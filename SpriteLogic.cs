using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;

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
        /// For playing sound effects
        /// </summary>
        private SoundPlayer player = new SoundPlayer();

        /// <summary>
        /// Last frame where sound was played
        /// </summary>
        private int lastSoundFrame;

        public SpriteLogic()
        {
            SrcRect = new Rectangle(-1, -1, -1, -1);
            lastSoundFrame = -1;
        }

        public SpriteLogic(SpriteData spriteData, string path) : this()
        {
            SpriteData = spriteData;
            OpenedFileName = path;
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
            repeatNumber = 0;
            frameCount = CurrentPose.Frames.Count;
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

        /// <summary>
        /// Update the current pose.
        /// </summary>
        public void Update(int currentTime)
        {
            if (CurrentPose == null || frameCount == 0)
            {
                return;
            }

            // If we number of repeats is reached then animation is finished
            if (CurrentPose.Repeats != -1 && repeatNumber >= CurrentPose.Repeats)
            {
                IsFinished = true;
            }

            if (IsFinished)
            {
                return;
            }

            // If animation is still not finished...
            if (CurrentPose.Repeats == -1 || repeatNumber < CurrentPose.Repeats)
            {
                if (!string.IsNullOrEmpty(CurrentFrame.Sound) && lastSoundFrame != frameIndex)
                {
                    player.SoundLocation = ResolvePath(CurrentFrame.Sound);
                    player.Play();
                    lastSoundFrame = frameIndex;
                }

                int frameDuration = CurrentFrame.Duration;
                int frameTime = frameDuration == -1 ?
                    CurrentPose.DefaultDuration : frameDuration;
                if (currentTime - oldTime >= frameTime)
                {
                    oldTime = currentTime;
                    if (tweening)
                    {
                        tweening = false;
                    }

                    frameIndex++;
                    if (frameIndex >= frameCount - 1)
                    {
                        repeatNumber++;
                        lastSoundFrame = -1;
                    }

                    frameIndex %= frameCount;
                }

                if (!tweening && CurrentFrame.IsTweenFrame)
                {
                    var prevFrame = CurrentPose.Frames[frameIndex - 1];
                    CurrentFrame.Rectangle = prevFrame.Rectangle;
                    oldTime = currentTime;
                    tweening = true;
                }

                if (tweening)
                {
                    var prevFrame = CurrentPose.Frames[frameIndex - 1];
                    var nextFrame = CurrentPose.Frames[frameIndex + 1];
                    float alpha = (float)(currentTime - oldTime) / (frameTime == 0 ? 1 : frameTime);
                    alpha = Math.Min(Math.Max(alpha, 0.0f), 1.0f);
                    CurrentFrame.Magnification.X = lerp(prevFrame.Magnification.X, nextFrame.Magnification.X, alpha);
                    CurrentFrame.Magnification.Y = lerp(prevFrame.Magnification.Y, nextFrame.Magnification.Y, alpha);
                    CurrentFrame.Angle = (int)lerp(prevFrame.Angle, nextFrame.Angle, alpha);
                    CurrentFrame.Opacity = lerp(prevFrame.Opacity, nextFrame.Opacity, alpha);
                }
            }
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
        /// Stop updating the pose.
        /// </summary>
        public void Stop()
        {
            IsFinished = true;
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || player == null) return;
            player.Dispose();
            player = null;
        }

        /// <summary>
        /// Linear interpolation between two floats.
        /// @param start Starting value.
        /// @param end Ending value.
        /// @param alpha Current time.
        /// @return Linearly interpolated value at time alpha.
        /// </summary>
        private float lerp(float start, float end, float alpha)
        {
            return (1.0f - alpha) * start + alpha * end;
        }
    }
}
