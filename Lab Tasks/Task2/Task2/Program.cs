float ItemPrice = 250.00f;
float Discount = 15.00f / 100.00f;

float PriceAfterDiscount = ItemPrice - (ItemPrice * Discount);

Console.WriteLine("Item Price: $250");
Console.WriteLine("Discount: 15%");
Console.WriteLine("The Price After Discount is: $" + PriceAfterDiscount);