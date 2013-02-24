using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;

namespace SpriteEditor
{
    /// <summary>
    /// A single pose in a sprite. 
    /// </summary>
    [Serializable()]
    public class Pose {
	    /// <summary>
        /// Name of the pose (e.g. 'attacking). 
        /// </summary>
        public String Name { get; set; }
	    /// <summary>
        /// Collision bounding box. 
        /// </summary>
        [XmlElement(ElementName = "Bounding-Box")]
	    public Rect BoundingBox { get; set; }
        [XmlIgnoreAttribute()]
        public bool BoundingBoxSpecified { get; set; }
	    /// <summary>
        /// Total duration of one pose cycle in milliseconds. 
        /// </summary>
        [XmlElement(ElementName = "Duration")]
        public int DefaultDuration { get; set; }
        [XmlIgnoreAttribute()]
        public bool DefaultDurationSpecified { get; set; }
	    /// <summary>
        /// Number of times pose is repeated (-1 = forever). 
        /// </summary>
        public int Repeats { get; set; }
        [XmlIgnoreAttribute()]
        public bool RepeatsSpecified { get; set; }
	    /// <summary>
        /// Maximum number of frames in a pose. 
        /// </summary>
	    public static readonly int MAX_POSE_FRAMES = 8;
	    /// <summary>
        /// List of frames. 
        /// </summary>
        [XmlElement(ElementName="Frame")]
        public List<Frame> Frames { get; set; }

	    /// <summary>
        /// Default constructor. 
        /// </summary>
	    public Pose() {
		    BoundingBox = new Rect(-1, -1, -1, -1);
		    DefaultDuration = 100;
            Repeats = -1;
		    Frames = new List<Frame>(MAX_POSE_FRAMES);
	    }

    }
}
