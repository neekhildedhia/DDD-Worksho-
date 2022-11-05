

using Sample_Code_1.Domain;

Cart cart = new Cart();
Item item = new Item(new Product("Apple Pencil"), 2);
cart.add(item);

item = new Item(new Product("Sony Wireless Headphone"), 1);
cart.add(item);

item = new Item(new Product("Macbook"), 3);
cart.add(item);

Console.WriteLine("Cart = " + cart);
List<Item> products = cart.getItems();

Console.WriteLine("----------------------------------------");
Console.WriteLine("products = " + string.Join(", ", products));
Console.WriteLine("----------------------------------------");

Product applePencilProduct1 = new Product("Apple Pencil");
//Item applePencilItem1 = new Item(applePencilProduct1, 2);

//cart.remove(applePencilItem1);
cart.remove(applePencilProduct1);

Product macbookProduct = new Product("Macbook");
cart.remove(macbookProduct);

Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("After Removing Apple Pencil with 2 quantity");
Console.WriteLine("Cart = " + cart);
Console.WriteLine("--------------------------------------------------------");
List<Item> items1 = cart.getItems();
Console.WriteLine("items = " + string.Join(", ", items1));
Console.WriteLine("--------------------------------------------------------");

List<string> removedItems = cart.getRemovedItems();
Console.WriteLine("Removed Items = " + string.Join(", ", removedItems));
Console.WriteLine("--------------------------------------------------------");

Console.ReadLine();