﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TmxMapperPCL
{
    [XmlRoot(ElementName = "tileset")]  
    public class TileSet
    {

        // SAMPLE: <tileset firstgid="1" name="BaseTileSet" tilewidth="129" tileheight="129">

        // firstgid
        [XmlAttribute(DataType="int", AttributeName="firstgid")]
        public int FirstGID { get; set; }

        // TODO: source - optional

        
        // name
        [XmlAttribute(DataType="string", AttributeName="name")]
        public string Name { get; set; }
        
        // tilewidth
        [XmlAttribute(DataType = "int", AttributeName = "tilewidth")]
        public int TileWidth { get; set; }
        
        // tileheight
        [XmlAttribute(DataType = "int", AttributeName = "tileheight")]
        public int TileHeight { get; set; }
        
        // spacing - optional, used when tileset image
        [XmlAttribute(DataType = "int", AttributeName = "spacing")]
        public int Spacing { get; set; }

        // margin - optional, used when tileset image
        [XmlAttribute(DataType = "int", AttributeName = "margin")]
        public int Margin { get; set; }

        [XmlElement(ElementName = "tileoffset")]
        public TileOffset TileOffset { get; set; }

        [XmlElement("tile")]
        public List<Tile> Tiles { get; set; }

        // TODO: Properties
        // TODO: Image
        // TODO: TerrainTypes
              
        // Can contain: tileoffset (since 0.8.0), properties (since 0.8.0), image, terraintypes (since 0.9.0), tile
    }
}
