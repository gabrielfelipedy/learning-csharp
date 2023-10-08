// See https://aka.ms/new-console-template for more information
static void printNum(int num) {
  Console.WriteLine($"Num param: {num}");
}

printNum(10);
Console.WriteLine(Math.Sqrt(256));

Random r = new Random();

Console.WriteLine(r.Next(1, 7));

var stream = new StreamWriter("test.txt");
stream.WriteLine("first line");

stream.Close();
