using BusinessLogic.Dtos;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IAdvertService
    {
         IEnumerable<ProductDto> GetAll();
        ProductDto? GetById(int id);
        void Create(ProductDto productDto);
        void Edit(ProductDto productDto);
        void Delete(int id);
    }
}
