Console.Write("Enter integer a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter integer b: ");
int b = Convert.ToInt32(Console.ReadLine());

a = a + b;
b = a - b;
a = a - b;

Console.WriteLine("After swap: a = " + a + ", b = " + b);
