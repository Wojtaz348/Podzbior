using System;

class Program
{
    static void Main()
    {
      
        int[,] matrix = new int[20, 20];
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                matrix[i, j] = random.Next(-99, 100); 
            }
        }

        
        int maxSum = int.MinValue;
        int startRow = 0, endRow = 0;

        for (int i = 0; i < 20; i++) 
        {
            int currentSum = 0;
            for (int j = i; j < 20; j++) 
            {
                currentSum += matrix[i, j]; 
                if (currentSum > maxSum) 
                {
                    maxSum = currentSum; 
                    startRow = i;
                    endRow = j; 
                }
            }
        }

        Console.WriteLine($"Największa suma podciągu: {maxSum}");
        Console.WriteLine($"Pozycja podciągu: Rozpoczyna się na wierszu {startRow} i kończy na wierszu {endRow}");
    }
}
