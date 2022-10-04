// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Input first number: ");
int a =  Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b =  Convert.ToInt32(Console.ReadLine());

var max = a > b;

if (a == b)
{
Console.WriteLine($"max number = {a} min number = {b}");
}
else
{
    Console.WriteLine($"max number = {b} min number = {a}");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Input first number: ");
int a =  Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b =  Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int c =  Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
    Console.WriteLine($"{max}");
    */


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

/*Console.Write("Input number: ");
int digit =  Convert.ToInt32(Console.ReadLine());

if(digit % 2 == 0 )
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("False");
}
*/

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;
while(current<=num)
{
    if(num%2==0)
    {
    Console.Write(" " + num);
    }
}
num--;
Console.Write("Input N");

*/