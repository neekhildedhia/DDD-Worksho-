

using Sample_Code_1.Domain;

Cart cart = new Cart();
Product product = new Product("Apple Pencil");
cart.add(product);

Console.WriteLine("Cart = " + cart);
List<Product> products = cart.getProducts();

Console.WriteLine("----------------------------------------");
Console.WriteLine("products = " + products.ToString());
Console.WriteLine("----------------------------------------");

Console.ReadLine();