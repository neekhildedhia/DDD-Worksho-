

using Sample_Code_1.Domain;

Cart cart = new Cart();
Product product = new Product("Apple Pencil", 2);
cart.add(product);

product = new Product("Sony Wireless Headphone");
cart.add(product);

Console.WriteLine("Cart = " + cart);
List<Product> products = cart.getProducts();

Console.WriteLine("----------------------------------------");
Console.WriteLine("products = " + string.Join(", ", products));
Console.WriteLine("----------------------------------------");

Console.ReadLine();