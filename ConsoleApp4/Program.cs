using System;

class Progrem()
{
    //Display menu functio
    static void MainMenu()
    {
        Console.WriteLine("Please choose a menu key:");
        Console.WriteLine("0: Exit");
        Console.WriteLine("1: Return a position from a sorted Int array - linear method");
        Console.WriteLine("2: Return a position from a sorted Int array - advanced method");
        Console.WriteLine("3: Return the 'N' th Fibonacii number");
        Console.WriteLine();
    }

    // This is a function to sort an Int array
    static void SortF(int[] arr)
    {
        int temp = 0;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            for (int j = 1; j <= arr.Length - i; j++)
            {
                if (arr[j - 1] > arr[j])
                {
                    temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
    //Recurssion function returning a Fibonacci number
    static int Fibonacci(int f)
    {
        if ((f == 1) || (f == 2))
            return 1;
        else
            return Fibonacci(f - 1) + Fibonacci(f - 2);
    }

    static void Main()
    {

        int[] s = new int[10];
        Random r = new Random();
        MainMenu();
        int menu = Convert.ToInt32(Console.ReadLine());

        while (menu != 0)
        {
            if (menu == 1)
            {
                Console.WriteLine("This is the randomly generated array: ");
                for (int i = 0; i < s.Length; i++)
                {
                    s[i] = r.Next(1, 100);
                    Console.Write(s[i] + "  ");
                }
                SortF(s);
                Console.WriteLine();
                Console.WriteLine("The array is sorted: ");
                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write(s[i] + "  ");
                }
                Console.WriteLine();
                //practice 1: Return a number position from a sorted Int array - linear method 
                Console.WriteLine("Input a member number for its position:");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == n)
                    {
                        Console.Write("The first position is found at: " + i);
                        Console.WriteLine(System.Environment.NewLine);
                        break;
                    }
                    if (i == s.Length-1)
                        Console.WriteLine("There is no such number in the array!" + System.Environment.NewLine);
                }
                Console.ReadKey();
                MainMenu();
                Console.WriteLine("Please choose the function to test(0-3):");
                menu = Convert.ToInt32(Console.ReadLine());
            }

            if (menu == 2)
            {
                Console.WriteLine("This is the randomly generated array: ");
                for (int i = 0; i < s.Length; i++)
                {
                    s[i] = r.Next(1, 100);
                    Console.Write(s[i] + "  ");
                }
                SortF(s);
                Console.WriteLine();
                Console.WriteLine("This is the sorted array: ");
                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write(s[i] + "  ");
                }
                Console.WriteLine();

                int mid = 0;
                int left = 0;
                int right = s.Length - 1;
                Console.WriteLine("Input a member number for its position:");
                int n = Convert.ToInt32(Console.ReadLine());
                while (left <= right)
                {
                    mid = left + (right - left) / 2;
                    if (s[mid] == n)
                    {
                        Console.Write("The first position is found at: " + mid);
                        Console.WriteLine(System.Environment.NewLine);
                    }
                        if (s[mid] < n)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                Console.ReadKey();
                MainMenu();
                Console.WriteLine("Please choose the function to test(0-3):");
                menu = Convert.ToInt32(Console.ReadLine());
            }
            if (menu == 3)
            {
                Console.WriteLine("Please inpute a number:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The "+ n.ToString() + "th Fibonacci number is: "+ Fibonacci(n));
                Console.ReadKey();
                MainMenu();
                Console.WriteLine("Please choose the function to test(0-3):");
                menu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}


