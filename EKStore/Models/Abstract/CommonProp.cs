using System;
namespace Store.Models.Abstract
{
    abstract public class CommonProp
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool IsDelete { get; set; }
        public bool IsStatus { get; set; }


    }
}

