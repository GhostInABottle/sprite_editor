﻿using FmodAudio;
using SpriteEditor.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpriteEditor
{
    /// <summary>
    /// A class that encapsulates sprite updating logic.
    /// </summary>
    public class SpriteLogic : IDisposable
    {
        /// <summary>
        /// Current frame index.
        /// </summary>
        private int frameIndex;

        /// <summary>
        /// Used to check if enough time passed since last frame.
        /// </summary>
        private long oldTime;

        /// <summary>
        /// The duration of the current frame
        /// </summary>
        private int? currentFrameTime;

        /// <summary>
        /// Number of times animation repeated so far.
        /// </summary>
        private int repeatNumber;

        /// <summary>
        /// Total number of frames.
        /// </summary>
        private int frameCount;

        /// <summary>
        /// Is the animation in a tween frame?
        /// </summary>
        private bool tweening;

        /// <summary>
        /// Last frame where sound was played
        /// </summary>
        private int lastSoundFrame;
        /// <summary>
        /// FMOD system
        /// </summary>
        private readonly FmodSystem? fmodSystem;
        /// <summary>
        /// Resource disposal status
        /// </summary>
        private bool isDisposed;

        public SpriteLogic(bool soundPlayback)
        {
            SrcRect = new Rectangle(-1, -1, -1, -1);
            lastSoundFrame = -1;
            if (!soundPlayback) return;

            try
            {
                fmodSystem = Fmod.CreateSystem();
                fmodSystem.Value.Init(10);
            }
            catch (Exception ex)
            {
                fmodSystem = null;
                if (OperatingSystem.IsWindowsVersionAtLeast(6, 1))
                {
                    MessageBox.Show("Failed to load FMOD sound system - make sure the correct DLL is in the executable folder - " + ex.Message);
                }
            }
        }

        public SpriteLogic(SpriteData spriteData, string path, bool soundPlayback) : this(soundPlayback)
        {
            SpriteData = spriteData;
            OpenedFileName = path;
        }

        ~SpriteLogic()
        {
            Dispose(false);
        }

        /// <summary>
        /// Is the pose finished?
        /// </summary>
        public bool IsFinished { get; set; }

        /// <summary>
        /// Data to act on.
        /// </summary>
        public SpriteData SpriteData { get; set; }

        /// <summary>
        /// Name of currently opened sprite file
        /// </summary>
        public string OpenedFileName { get; set; }

        /// <summary>
        /// Currently active pose.
        /// </summary>
        public Pose CurrentPose { get; private set; }

        /// <summary>
        /// Source rectangle of the current frame.
        /// </summary>
        public Rectangle SrcRect { get; set; }

        /// <summary>
        /// Get currently active image.
        /// </summary>
        public string Image
        {
            get
            {
                if (!string.IsNullOrEmpty(CurrentFrame?.Image))
                {
                    return CurrentFrame.Image;
                }
                if (!string.IsNullOrEmpty(CurrentPose?.Image))
                {
                    return CurrentPose.Image;
                }
                if (!string.IsNullOrEmpty(SpriteData.Image))
                {
                    return SpriteData.Image;
                }
                return null;
            }
        }

        public string TransparentColorHex => CurrentFrame?.TransparentColor
                ?? CurrentPose?.TransparentColor
                ?? SpriteData.TransparentColor;

        /// <summary>
        /// Current frame in the current pose.
        /// </summary>
        public Frame CurrentFrame => frameCount == 0 ? null : CurrentPose.Frames[frameIndex];

        /// <summary>
        /// Reset values to their defaults.
        /// </summary>
        public void Reset(int currentTime)
        {
            frameIndex = 0;
            oldTime = currentTime;
            currentFrameTime = null;
            repeatNumber = 0;
            frameCount = CurrentPose?.Frames.Count ?? 0;
            IsFinished = false;
            tweening = false;
            lastSoundFrame = -1;
        }

        /// <summary>
        /// Set the current pose.
        /// </summary>
        /// <param name="poseName">
        /// Name of the new pose.
        /// </param>
        /// <param name="currentTime">
        /// Update time.
        /// </param>
        public void SetPose(string poseName, int currentTime)
        {
            var poses = SpriteData.Poses;
            if (CurrentPose == null ||
                !poseName.Equals(CurrentPose.NameWithTags(), StringComparison.InvariantCultureIgnoreCase))
            {
                var pose =
                    poses.FirstOrDefault(p => p.NameWithTags()
                            .Equals(poseName, StringComparison.InvariantCultureIgnoreCase));
                if (pose != null)
                {
                    CurrentPose = pose;
                }
            }

            Reset(currentTime);
        }

        private int GetFrameTime()
        {
            int frameDuration = CurrentFrame.Duration;
            var frameTime = frameDuration == -1 ?
                CurrentPose.DefaultDuration : frameDuration;
            if (CurrentFrame.MaxDuration.HasValue)
            {
                frameTime = new Random()
                    .Next(frameTime, CurrentFrame.MaxDuration.Value);
            }

            return frameTime;
        }

        /// <summary>
        /// Update the current pose.
        /// </summary>
        public void Update(int currentTime)
        {
            fmodSystem?.Update();

            if (CurrentPose == null || frameCount == 0)
            {
                return;
            }

            // If we number of repeats is reached then animation is finished
            if (FinishedRepeating())
            {
                IsFinished = true;
            }

            if (IsFinished)
            {
                return;
            }

            // If animation is still not finished...
            var soundData = CurrentFrame.Sound;
            if (fmodSystem != null && !string.IsNullOrEmpty(soundData?.Filename) && lastSoundFrame != frameIndex)
            {
                try
                {
                    PlaySound(soundData);
                }
                catch (Exception)
                {
                    // Ignore playback errors (e.g. ogg files aren't supported)
                }
                lastSoundFrame = frameIndex;
            }

            if (!currentFrameTime.HasValue)
            {
                currentFrameTime = GetFrameTime();
            }

            if (currentTime - oldTime >= currentFrameTime)
            {
                oldTime = currentTime;
                tweening = false;

                frameIndex++;
                if (frameIndex >= frameCount)
                {
                    repeatNumber++;
                    lastSoundFrame = -1;
                    if (FinishedRepeating())
                    {
                        frameIndex--;
                        return;
                    }
                }

                frameIndex %= frameCount;
                currentFrameTime = null;
            }

            if (!tweening && CurrentFrame.IsTweenFrame)
            {
                var prevFrame = CurrentPose.Frames[frameIndex - 1];
                CurrentFrame.Rectangle = prevFrame.Rectangle;
                oldTime = currentTime;
                currentFrameTime = GetFrameTime();
                tweening = true;
            }

            if (tweening)
            {
                var prevFrame = CurrentPose.Frames[frameIndex - 1];
                var nextFrame = CurrentPose.Frames[frameIndex + 1];
                var frameTime = currentFrameTime.Value;
                float alpha = (float)(currentTime - oldTime) / (frameTime == 0 ? 1 : frameTime);
                alpha = Math.Min(Math.Max(alpha, 0.0f), 1.0f);
                CurrentFrame.Magnification.X = Lerp(prevFrame.Magnification.X, nextFrame.Magnification.X, alpha);
                CurrentFrame.Magnification.Y = Lerp(prevFrame.Magnification.Y, nextFrame.Magnification.Y, alpha);
                CurrentFrame.Angle = (int)Lerp(prevFrame.Angle, nextFrame.Angle, alpha);
                CurrentFrame.Opacity = Lerp(prevFrame.Opacity, nextFrame.Opacity, alpha);
            }
        }

        public void PlaySound(Models.Sound soundData)
        {
            if (string.IsNullOrEmpty(soundData.Filename)) return;

            var sound = soundData.LoadFmodSound(fmodSystem.Value, ResolvePath(soundData.Filename));
            Channel channel = fmodSystem.Value.PlaySound(sound.Value, paused: true);
            if (soundData.Pitch.HasValue)
            {
                channel.Pitch = soundData.Pitch.Value;
            }
            if (soundData.Volume.HasValue)
            {
                channel.Volume = soundData.Volume.Value;
            }
            channel.Paused = false;
        }

        /// <summary>
        /// Set current frame
        /// </summary>
        /// <param name="index">Frame index</param>
        public void SetFrame(int index)
        {
            frameIndex = index;
        }

        /// <summary>
        /// Resolve a relative base directory to a full path
        /// </summary>
        public string ResolveBaseDir()
        {
            var baseDir = SpriteData.BaseDirectory;
            if (OpenedFileName != null && !Path.IsPathRooted(baseDir))
            {
                baseDir = Utilities.ResolveRelativePath(
                    Path.GetDirectoryName(OpenedFileName), baseDir);
            }

            return baseDir;
        }

        /// <summary>
        /// Resolve a relative path into a full one
        /// </summary>
        public string ResolvePath(string filename)
        {
            var baseDir = SpriteData.BaseDirectory;
            if (baseDir == "." || Path.IsPathRooted(filename)) return filename;
            try
            {
                baseDir = ResolveBaseDir();
                return Utilities.ResolveRelativePath(baseDir, filename);
            }
            catch (Exception)
            {
                return filename;
            }
        }

        /// <summary>
        /// Linear interpolation between two floats.
        /// @param start Starting value.
        /// @param end Ending value.
        /// @param alpha Current time.
        /// @return Linearly interpolated value at time alpha.
        /// </summary>
        private static float Lerp(float start, float end, float alpha)
        {
            return (1.0f - alpha) * start + alpha * end;
        }

        private bool FinishedRepeating()
        {
            return CurrentPose.Repeats != -1 && repeatNumber >= CurrentPose.Repeats;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if (disposing)
            {
                SpriteData?.Dispose();
            }

            fmodSystem?.Dispose();
            isDisposed = true;
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
