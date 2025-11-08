Console.Write("Enter temperature in Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;
Console.WriteLine(celsius + " °C = " + fahrenheit.ToString("F2") + " °F");
