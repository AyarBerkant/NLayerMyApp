using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NLayerMyApp.Core.DTOs.Category;
using NLayerMyApp.Core.DTOs.Product;
using NLayerMyApp.Core.DTOs.ProductFeature;
using NLayerMyApp.Core.Entities;

namespace NLayerMyApp.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
        }


    }
}
