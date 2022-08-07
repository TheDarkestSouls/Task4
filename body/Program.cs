int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    if(a > c) Console.Write(a);
    else Console.Write(c);
         
}
else
{
    if(b > c) Console.Write(b);
    else Console.Write(c);
         
}