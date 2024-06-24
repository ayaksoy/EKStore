using System;
using Store.Models;
using Store.Models.Abstract;

namespace EKStore.Models
{
    public class Category : CommonProp
    {
        public List<Product>? Products { get; set; }
    }
}

