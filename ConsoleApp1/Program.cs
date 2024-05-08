//Ashrafi - Faizy
Console.WriteLine("Enter first number : ");
var a = Console.ReadLine();
var firstNumber = 0;
Console.WriteLine("Enter second number : ");
var b = Console.ReadLine();
var secondNumber = 0;

int.TryParse(a,out firstNumber);
int.TryParse(b,out secondNumber);
Sum(firstNumber, secondNumber);




void Sum(int one,int two){
    Console.WriteLine(one + two);
}