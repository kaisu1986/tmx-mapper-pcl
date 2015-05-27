﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TmxMapperPCL
{
    // <image width="128" height="128" source="TilesPack/7.png"/>
    public class Image
    {
        // source
        [XmlAttribute(DataType = "string", AttributeName = "source")]
        public string Source { get; set; }

        // width
        [XmlAttribute(DataType="int", AttributeName="width")]
        public int Width { get; set; }
               
        // height
        [XmlAttribute(DataType="int", AttributeName="height")]
        public int Height { get; set; }

        // format
        [XmlAttribute(DataType="string", AttributeName="format")]
        public string Format { get; set; }

        // trans
        [XmlAttribute(DataType="string", AttributeName="trans")]
        public string Trans { get; set; }
       
        // Can contain: data (since 0.9.0)
        [XmlElement(ElementName = "data")]
        public Data Data { get; set; }
    }
}
