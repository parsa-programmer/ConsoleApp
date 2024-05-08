//Mohammad Ashrafi
//Reza Faizy

var firstNumber = 0;
var secondNumber = 0;

Console.Write("Enter first number : ");
var a = Console.ReadLine();
Console.Write("Enter second number : ");
var b = Console.ReadLine();

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