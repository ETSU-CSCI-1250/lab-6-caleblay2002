using System;
namespace Lab6;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a word to index: ");
         string Str = Console.ReadLine();
         Console.WriteLine("Enter the index number: ");
         int Num = Convert.ToInt32(Console.ReadLine());
         ShowCharacter(Str, Num);
        

         Console.WriteLine("Enter item's wholesale cost: ");
         double WholesaleCost = Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter markup percentage: ");
         int MarkupPercentage = Convert.ToInt32(Console.ReadLine());
         double FinalCost = CalculateRetail(WholesaleCost, MarkupPercentage);
         Console.Write("Final cost is " + FinalCost);


         for (int f = 80; f <= 100; f++)
         {
            int C = Celsius(f);
            Console.Write("Farenheight: " + f + "= Celsious: " + C);
         }


        Console.Write("Enter Number: ");
        int prime = Convert.ToInt32(Console.ReadLine());
        bool PrimeCheck = IsPrime(prime);
        if(PrimeCheck = true)
        {
            Console.Write("Number is prime");
        }
        else
        {
            Console.Write("Number is not prime");
        }

    }

    static void ShowCharacter(string Str, int Num)
    {
        Char c = Str[(Num - 1)];
        Console.Write("The value is: " + c );
    }

    static double CalculateRetail(double cost, int percent)
    {
        double percentage = percent / 100;
        double answer = (percentage + 1) * cost;
        return answer;
    }

    static int Celsius(int temp)
    {
        int x = 5/9;
        int c = (temp - 32);
        return (x / c);
    }

    static bool IsPrime(int argument)
    {
        bool IsPrime = false;
        int prime, i, m = 0, flag = 0;

        Console.Write("Enter the Number to check Prime: ");
        prime = int.Parse(Console.ReadLine());
        m = prime / 2;

        for (i = 2; i <= m; i++)
        {
            if (prime % i == 0)
            {
                flag = 1;
                break;
            }
        }
        if (flag == 0)
        {
            IsPrime = true;
        }
        else
        {
            IsPrime = false;
        }
            
        return IsPrime;
    }

}

