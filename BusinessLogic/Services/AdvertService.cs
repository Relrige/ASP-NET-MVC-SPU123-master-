using AutoMapper;
using BusinessLogic.Dtos;
using BusinessLogic.Interfaces;
using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class AdvertService : IAdvertService

    {
        private readonly ShopDbContext context;
        private readonly IMapper mapper;

        public AdvertService(ShopDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async void Create(ProductDto productDto)
        {
            await context.Products.AddAsync(mapper.Map<Product>(productDto));
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productDto = GetById(id);
           context.Products.Remove (mapper.Map<Product>(productDto));
            context.SaveChanges();
        }

        public void Edit(ProductDto productDto)
        {
            context.Products.Update(mapper.Map<Product>(productDto));
            context.SaveChanges();
        }
        
        public IEnumerable<ProductDto> GetAll()
        {
            var products =  context.Products.Include(x=>x.Category).ToList();
            return  mapper.Map<IEnumerable<ProductDto>> (products);
        }
        
        public ProductDto? GetById(int id)
        {
            if (id < 0) return null; 
            var product = context.Products.Find(id);

            if (product == null) return null;
            return mapper.Map<ProductDto>(product);
        }

  
    }
}
