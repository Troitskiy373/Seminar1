int n1, n2;

Console.Write("Imput a first number:");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Imput a second number:");
n2 = Convert.ToInt32(Console.ReadLine());

int kuad = n2*n2;

if(n1 == kuad)
{
    Console.WriteLine("First number is a quad of second number");
}
else
{
     Console.WriteLine("First number is not a quad of second number");
}
