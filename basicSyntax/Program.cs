// See https://aka.ms/new-console-template for more information

int tam = 20;
float euler = 2.78f;
bool married = false;
decimal fraction = 2.5m;

Console.WriteLine($"Testing vars: {tam}\n{euler}\n{married}\n{fraction}");

const decimal pi = 3.14m;
Console.WriteLine($"{pi} is immutable");

var text = "Hello, mom!";
Console.WriteLine(text);

//@ is equivalent to ''' in python
//$ is equivalent to f in python

Console.WriteLine(@"
    Formatting a string

    like this
    ");
