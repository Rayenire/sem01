int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB){
    Console.Write("max = ");
    Console.WriteLine(numberA);
    Console.Write("min = ");
    Console.Write(numberB);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(numberB);
    Console.Write("min = ");
    Console.Write(numberA);
}