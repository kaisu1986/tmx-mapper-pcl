using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TmxMapper
{
    [XmlRoot(ElementName="tileoffset")]
    public class TileOffset
    {
        [XmlAttribute(DataType="int", AttributeName="x")]
        public int X { get; set; }

        [XmlAttribute(DataType = "int", AttributeName = "y")]
        public int Y { get; set; }
    }
}
