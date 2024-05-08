//Mohammad Ashrafi - Reza Faizy
Console.WriteLine("Enter first number : ");
var a = Console.ReadLine();
var firstNumber = 0;
Console.WriteLine("Enter second number : ");
var b = Console.ReadLine();
var secondNumber = 0;

int.TryParse(a,out firstNumber);
int.TryParse(b,out secondNumber);
Sum(firstNumber, secondNumber);
Zarb(firstNumber, secondNumber);




void Sum(int one,int two){
    Console.Write("Jam Adad : ");
    Console.WriteLine(one + two);
}
void Zarb(int one, int two)
{
    Console.Write("Zarbe Adad : ");
    Console.WriteLine(one * two);
}