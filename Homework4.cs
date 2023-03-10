// Homework 4.
/*
    // Task 25: Write a cycle that takes two numbers (A and B) as input and raises A to the power of B.
  int Prompt(string message)
    {
      Console.Write(message);
      string readInput = Console.ReadLine();
      int result = int.Parse(readInput);
      return result;
    }
    
  int Power(int baseNumber, int exponent)
    {
      int power = 1;
      for(int i = 0; i < exponent; i++)
      {
        power *= baseNumber;
      }
      return power;
    }

    bool ValidateExponent(int exponent)
    {
      if(exponent < 0)
      {
        Console.WriteLine("Should be more than 0");
        return false;
      }
      return true;
    }

  int baseNumber = Prompt("Input base: ");
  int exponent = Prompt("Input exponent: ");
  if(ValidateExponent(exponent))
    {
      Console.WriteLine($"Number {baseNumber} in exponent {exponent} equals to {Power(baseNumber, exponent)}");
    }
*/

/*    
// Task 27: Write a program that takes a number as input and returns the sum of the digits in the number.
  int Prompt(string message)
    {
      Console.Write(message);
      string readInput = Console.ReadLine();
      int result = int.Parse(readInput);
      return result;
    }

    int SumNumbers(int number)
    {
      int result = 0;
      while(number > 0)
      {
        result += number % 10;
        number = number / 10;
      }
      return result;
    }

    int number = Prompt("Input number: ");
    Console.WriteLine($"Summary of all numbers in {number} = {SumNumbers(number)}");
    */

/*
// Task 29: Write a program that takes an array of 8 elements and prints them to the screen.
    int Prompt(string message)
    {
      Console.Write(message);
      string ReadInput = Console.ReadLine();
      int result = int.Parse(ReadInput);
      return result;
    }

    //Receive random numbers in an array.
    int[] GenerateArray(int Length, int minValue, int maxValue)
    {
      int[] array = new int[Length];
      Random random = new Random();
      for(int i = 0; i < Length; i++)
      {
        array[i] = random.Next(minValue, maxValue + 1);
      }
      return array;
    }

      void PrintArray(int[] array)
    {
        Console.Write("[");
        for(int i = 0; i < array.Length - 1; i++)
        {
          Console.Write($"{array[i]}, "); //Print Array
        }
        Console.Write($"{array[array.Length - 1]}");
        Console.WriteLine("]");
    }

      int length = Prompt("Array length is ");
      int min = Prompt("Start value is ");
      int max = Prompt("End number is ");
      int[] arrayMain = GenerateArray(length, min, max);
      PrintArray(arrayMain);
    */
    
