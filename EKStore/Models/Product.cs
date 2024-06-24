using EKStore.Models.Abstracts;

namespace EKStore.Models
{
    public class Product:CommonProp
    {
        public int Stock { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
