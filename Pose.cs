using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.Xml.Linq;

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
	    /// <summary>
        /// Total duration of one pose cycle in milliseconds. 
        /// </summary>
        [XmlElement(ElementName = "Duration")]
        public int DefaultDuration { get; set; }
	    /// <summary>
        /// Number of times pose is repeated (-1 = forever). 
        /// </summary>
        public int Repeats { get; set; }
	    /// <summary>
        /// List of frames. 
        /// </summary>
        [XmlElement(ElementName = "Frame")]
        public List<Frame> Frames { get; set; }

	    /// <summary>
        /// Default constructor. 
        /// </summary>
	    public Pose() {
		    BoundingBox = new Rect(-1, -1, -1, -1);
		    DefaultDuration = 100;
            Repeats = -1;
		    Frames = new List<Frame>();
	    }

        public XElement ToXml()
        {
            var children = new List<object>();
            children.Add(new XAttribute("Name", Name));
            if (!BoundingBox.equals(-1, -1, -1, -1))
                children.Add(BoundingBox.ToXml("Bounding-Box"));
            if (DefaultDuration != 100)
                children.Add(new XAttribute("Duration", DefaultDuration));
            if (Repeats != -1)
                children.Add(new XAttribute("Repeats", Repeats));

            foreach (var frame in Frames)
            {
                children.Add(frame.ToXml());
            }

            return new XElement("Pose", children.ToArray());
        }

    }
}
