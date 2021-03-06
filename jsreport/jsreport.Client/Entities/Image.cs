﻿using System;

namespace jsreport.Client.Entities
{
    /// <summary>
    /// Image entity used in images extension
    /// </summary>
    public class Image
    {
        public string _id { get; set; }
        public string shortid { get; set; }
        public string name { get; set; }
        public string contentType { get; set; }
        public DateTimeOffset? creationDate { get; set; }
        public DateTimeOffset? modificationDate { get; set; }
        public byte[] content { get; set; } 
    }
}