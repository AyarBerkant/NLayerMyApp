﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerMyApp.Core.DTOs.ProductFeature
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int ProductId { get; set; }

    }
}
