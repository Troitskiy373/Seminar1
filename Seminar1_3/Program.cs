int n;
int current;

Console.Write("Input a number: ");
n = Convert.ToInt32(Console.ReadLine());
if(n<0)
{
    n = n * (-1);
}

current = n * (-1);

while(current <= n)
{
    Console.Write(current + "");
    current++;
}
