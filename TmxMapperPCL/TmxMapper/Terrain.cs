using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TmxMapper
{
    public class Terrain
    {
        [XmlAttribute(DataType="string", AttributeName="name")]
        public string Name { get; set; }

        [XmlAttribute(DataType = "string", AttributeName = "tile")]
        public string TileId { get; set; }

        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<Property> Properties { get; set; }    
    }
}
