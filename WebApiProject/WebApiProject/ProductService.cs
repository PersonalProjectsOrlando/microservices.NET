﻿namespace WebAPIProject
{
    public class Product
    {
        /*public Product(int id, string name, decimal price, string description) {
            Id = id;
            Name = name;    
            Price = price;
            Description = description;
        }*/
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
       
    }
}
