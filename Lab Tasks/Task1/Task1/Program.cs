Console.Write("Enter the Score of Student1: ");
double St1score = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Score of Student2: ");
double St2score = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Score of Student3: ");
double St3score = Convert.ToDouble(Console.ReadLine());

double average = (St1score + St2score + St3score) / 3.0;
Console.WriteLine("Average score: " + average.ToString("F2"));
