﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP.Model
{
    public class Image
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] Data { get; set; }
    }
}
