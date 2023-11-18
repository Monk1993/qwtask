Random randomizer = new Random();
int minRandomNumber = 5;
int maxRandomNumber = 10;
string result = string.Empty;
int number = randomizer.Next(minRandomNumber, maxRandomNumber +1);
int[] numbers = new int[6];
Console.WriteLine(number);
while (number >= 1)
{
    result = number % 2 + result;
   number = number / 2;
}
   Console.WriteLine(result);
