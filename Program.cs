// first assignment
string clientName;
string productName;
double priceProduct;
string addressDelivery;
// order 1
Console.WriteLine();
Console.WriteLine("Enter details for order №1");

Console.WriteLine();
Console.Write("Client Name: ");
clientName = Console.ReadLine();

Console.Write("Product Name: ");
productName = Console.ReadLine();

Console.Write("Price of the product (EUR): ");
priceProduct = double.Parse(Console.ReadLine());

Console.Write("Delivery address: ");
addressDelivery = Console.ReadLine();

string result1 = $"Order No 1\nClient: {clientName}.\nProduct: {productName}, price {priceProduct} EUR.\nAddress: {addressDelivery}.\n";
Console.WriteLine();
// order 2

Console.WriteLine("Enter details for order №2");
Console.WriteLine();

Console.Write("Client Name: ");
clientName = Console.ReadLine();

Console.Write("Product Name: ");
productName = Console.ReadLine();

Console.Write("Price of the product (EUR): ");
priceProduct = double.Parse(Console.ReadLine());

Console.Write("Delivery address: ");
addressDelivery = Console.ReadLine();

string result2 = $"Order No 2\nClient: {clientName}.\nProduct: {productName}, price {priceProduct} EUR.\nAddress: {addressDelivery}.\n";
Console.WriteLine();

// order 3

Console.WriteLine("Enter details for order №3");
Console.WriteLine();

Console.Write("Client Name: ");
clientName = Console.ReadLine(); 

Console.Write("Product Name: ");
productName = Console.ReadLine();

Console.Write("Price of the product (EUR): ");
priceProduct = double.Parse(Console.ReadLine());

Console.Write("Delivery address: ");
addressDelivery = Console.ReadLine();

string result3 = $"Order No 3\nClient: {clientName}.\nProduct: {productName}, price {priceProduct} EUR.\nAddress: {addressDelivery}.\n";
Console.WriteLine();
// Returning Results
Console.WriteLine(result1);
/*
Console.WriteLine(result2);
Console.WriteLine(result3);
*/