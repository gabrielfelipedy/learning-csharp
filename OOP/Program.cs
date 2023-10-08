// See https://aka.ms/new-console-template for more information
using System;

class Program {
  static void Main(string[] args) {
    Product p = new Product();
    p.name = "gabriel";

    Console.WriteLine(p.name);

    var products = new List<Product>();
    products.Add(new Product(){name="soap", price=1.0f});

    products.ForEach(product => Console.WriteLine($"{product.name}\n{product.price}\n"));
  }
}
