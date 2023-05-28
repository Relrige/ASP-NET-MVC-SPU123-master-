using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string ImageUrl { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }
    }
}
