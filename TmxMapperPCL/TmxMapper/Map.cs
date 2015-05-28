﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace TmxMapper
{
    [XmlRoot(DataType="string", ElementName="map")]
    public class Map
    {        
        // Tmx format
        // https://github.com/bjorn/tiled/wiki/TMX-Map-Format

        // Sample:
        // <map version="1.0" orientation="orthogonal" renderorder="right-down" width="11" height="6" tilewidth="128" tileheight="128">
       
        [XmlAttribute(DataType = "string", AttributeName = "version")]
        public string Version { get; set; }
       
        //orientation - enum       
        // What is the proper data type?
        [XmlAttribute(AttributeName="orientation")]
        public Orientation Orientation { get; set; }

        // renderorder - enum       
        [XmlAttribute(AttributeName = "renderorder")]
        public RenderOrder RenderOrder { get; set; }
                
        [XmlAttribute(DataType = "string", AttributeName = "backgroundcolor")]
        public string BackgroundColor { get; set; }
        
        [XmlAttribute(DataType = "int", AttributeName = "width")]
        public int Width { get; set; }

        [XmlAttribute(DataType = "int", AttributeName = "height")]
        public int Height { get; set; }


        [XmlAttribute(DataType = "int", AttributeName = "tilewidth")]
        public int TileWidth { get; set; }


        [XmlAttribute(DataType = "int", AttributeName = "tileheight")]
        public int TileHeight { get; set; }


        // Can contain: properties, tileset, layer, objectgroup, imagelayer

      
        [XmlElement(ElementName = "tileset")]
        public TileSet TileSet { get; set; }

        // Layer
        [XmlElement(ElementName = "layer")]
        public List<Layer> Layers { get; set; }                        

        // ObjectGroup
        [XmlElement(ElementName= "objectgroup")]
        public List<ObjectGroup> ObjectGroups { get; set; }     


        // ImageLayer
        [XmlElement(ElementName = "imagelayer")]
        public ImageLayer ImageLayer { get; set; }

              
        public static Map Load(Stream stream)
        {     
            var serializer = new XmlSerializer(typeof(Map));
            return (Map)serializer.Deserialize(stream);                                  
        }
    }

    public enum Orientation
    {
        [XmlEnum(Name = "orthogonal")]
        Orthogonal = 1,
        [XmlEnum(Name = "isometric")]
        Isometric = 2,
        [XmlEnum(Name = "staggered")]
        Staggered = 3
    }

    public enum RenderOrder
    {
        [XmlEnum(Name = "right-down")]
        RightDown = 1,
        [XmlEnum(Name = "right-up")]
        RightUp = 2,
        [XmlEnum(Name = "left-down")]
        LeftDown = 3,
        [XmlEnum(Name = "left-up")]
        LeftUp = 4
    }
        
}