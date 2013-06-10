using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpriteEditor
{
    /// <summary>
    /// A class that encapsulates sprite updating logic.
    /// </summary>
    public class SpriteLogic {
	    /// <summary>
        /// Data to act on.
        /// </summary>
	    public SpriteData SpriteData { get; set; }
	    /// <summary>
        /// Currently active pose.
        /// </summary>
	    public Pose CurrentPose { get; private set; }
	    /// <summary>
        /// Source rectangle of the current frame.
        /// </summary>
        public Rectangle srcRect { get; set; }
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
        /// Is the pose finished?
        /// </summary>
        public bool IsFinished { get; set; }
	    /// <summary>
        /// Is the animation in a tween frame?
        /// </summary>
	    private bool tweening;

	    public SpriteLogic() {
		    srcRect = new Rectangle(-1, -1, -1, -1);
	    }

	    public SpriteLogic(SpriteData spriteData) : this() {
		    SpriteData = spriteData;
	    }

	    /// <summary>
        /// Reset values to their defaults.
        /// </summary>
	    public void Reset(int currentTime) {
		    frameIndex = 0;
		    oldTime = currentTime;
		    repeatNumber = 0;
		    frameCount = CurrentPose.Frames.Count;
		    IsFinished = false;
            tweening = false;
	    }

	    /// <summary>
	    /// Set the current pose.  
	    /// </summary>
        /// <param name="poseName">
        /// Name of the new pose.
        /// </param>
	    public void SetPose(String poseName, int currentTime) {
		    var poses = SpriteData.Poses;
		    if (CurrentPose == null || 
                !poseName.Equals(CurrentPose.NameWithTags(), StringComparison.InvariantCultureIgnoreCase)) {
			    int poseCount = poses.Count;
                var pose =
                    poses.FirstOrDefault(p => p.NameWithTags().Equals(poseName,
                        StringComparison.InvariantCultureIgnoreCase));
                if (pose != null)
                    CurrentPose = pose;
		    }
		    Reset(currentTime);
	    }

	    /// <summary>
	    /// Update the current pose.
	    /// </summary>
	    public void Update(int currentTime) {
		    if (CurrentPose == null)
			    return;
		    if (frameCount == 0)
			    return;
		    // If we number of repeats is reached then animation is finished
		    if (CurrentPose.Repeats != -1 && repeatNumber >= CurrentPose.Repeats)
            {
                IsFinished = true;
		    }
            if (IsFinished)
			    return;

		    // If animation is still not finished...
		    if (CurrentPose.Repeats == -1 || repeatNumber < CurrentPose.Repeats) {
			    int frameDuration = CurrentFrame.Duration;
			    int frameTime = frameDuration == -1 ? 
                    CurrentPose.DefaultDuration : frameDuration;
                if (currentTime - oldTime >= frameTime)
                {
                    oldTime = currentTime;
                    if (tweening)
                        tweening = false;
                    frameIndex++;
                    if (frameIndex >= frameCount - 1)
                    {
                        repeatNumber++;
                    }
                    frameIndex %= frameCount;
                }
                if (!tweening && CurrentFrame.IsTweenFrame)
                {
				    Frame prevFrame = CurrentPose.Frames[frameIndex - 1];
                    CurrentFrame.Rectangle = prevFrame.Rectangle;
				    oldTime = currentTime;
				    tweening = true;
			    }
			    if (tweening)
                {
				    Frame prevFrame = CurrentPose.Frames[frameIndex - 1];
				    Frame nextFrame = CurrentPose.Frames[frameIndex + 1];
                    float alpha = (float)(currentTime - oldTime) / CurrentFrame.Duration;
				    alpha = Math.Min(Math.Max(alpha, 0.0f), 1.0f);
                    CurrentFrame.XMagnification = lerp(prevFrame.XMagnification, nextFrame.XMagnification, alpha);
                    CurrentFrame.YMagnification = lerp(prevFrame.YMagnification, nextFrame.YMagnification, alpha);
                    CurrentFrame.Angle = (int)lerp(prevFrame.Angle, nextFrame.Angle, alpha);
			    }
			    
		    }
	    }

	    /// <summary>
	    /// Linear interpolation between two floats.
	    /// @param start Starting value.
	    /// @param end Ending value.
	    /// @param alpha Current time.
	    /// @return Linearly interpolated value at time alpha.
	    /// </summary>
	    private float lerp(float start, float end, float alpha) {
		    return (1.0f - alpha) * start + alpha * end;
	    }

	    /// <summary>
	    /// Current frame in the current pose.
	    /// </summary>
	    public Frame CurrentFrame {
            get
            {
                if (frameCount == 0)
                    return null;
		        return CurrentPose.Frames[frameIndex];
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
	    public void Stop() {
            IsFinished = true;
	    }

    }
}
