using System;

namespace sonmarket.Models
{
    public class Saida
    {
        public int Id {get; set;}
        public Produto Produto {get; set;}
        public float ValorDaVenda {get; set;}
        public DateTime Data {get; set;} 
    }
}