Console.Write("Введите числа через запятую: ");
string? input = Console.ReadLine();
char splitSymbol = ',';

WriteArray(ParseArray(input, splitSymbol));

int[] ParseArray(string inputNumbers, char split)
{
int numbersCount = 1;
for (int i = 0; i < inputNumbers.Length; i++)
{
    if (inputNumbers[i] == split)
    numbersCount++;
}
int[] numbers = new int[numbersCount];
int numberIndex = 0;
string subString = "";
for (int i = 0; i < inputNumbers.Length; i++)
{
   if(inputNumbers[i] == split)
   {
    numbers[numberIndex++] = Convert.ToInt32(subString);
    subString = "";
   }
   else
   {
    subString += input[i];
   }
}
numbers[numberIndex] =  Convert.ToInt32(subString);
return numbers;
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + " " ); 
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}


 void PrintArray2D (int [,] array)
    {
      
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
       Console.Write(array[i,j] + " " ); 
    }
    Console.WriteLine();

    }

    Console.WriteLine();
   }   

   void FillIntArray2DRandomNumbers(int[,] array, Random randomizer)
   {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          array[i, j] = randomizer.Next(0,10); 
        }
    }
   }