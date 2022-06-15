Console.WriteLine("Guess the Number");

var r = new Random();

var favNumber = r.Next(1, 1000);

var userInput = int.Parse(Console.ReadLine());

if (userInput == favNumber)
{
    Console.WriteLine("Correct!");
}

if (userInput > favNumber)
{
    Console.WriteLine("High");
}


else
{
    Console.WriteLine("Low");
}