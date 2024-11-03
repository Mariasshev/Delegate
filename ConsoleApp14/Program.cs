using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {

        delegate void MyDelegate();

        //class myArr
        //{
        //    private static int[] arr;
        //    public myArr(int len)
        //    {
        //        arr = new int[len];
        //        Random rnd = new Random();
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            arr[i] = rnd.Next(1,20);
        //        }
        //    }
        //    public static int[] GetArr()
        //    {
        //        return arr;
        //    }

        //    public static void Show()
        //    {
        //        Console.WriteLine("Array: ");
        //        for (int i = 0;i < arr.Length;i++)
        //        {
        //            Console.Write(arr[i]+" ");
        //        }
        //        Console.WriteLine(" ");
        //        Console.WriteLine("---------");
        //    }
        //    public static void ShowEven()
        //    {
        //        Console.WriteLine("Even elements: ");
        //        for(int i = 0;i < arr.Length; i++)
        //        {
        //            if (arr[i] % 2 == 0)
        //            {
        //                Console.Write(arr[i] + " ");
        //            }
        //        }
        //        Console.WriteLine(" ");
        //        Console.WriteLine("---------");
        //    }

        //    public static void ShowOdd()
        //    {
        //        Console.WriteLine("Odd elements: ");
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] % 2 != 0)
        //            {
        //                Console.Write(arr[i] + " ");
        //            }
        //        }
        //        Console.WriteLine(" ");
        //        Console.WriteLine("---------");
        //    }

        //    public static void ShowSimple()
        //    {
        //        Console.WriteLine("Sipmle elements: ");
        //        Console.WriteLine(" ");
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for(int j =  2; j < 10; j++)
        //            {
        //                if (arr[i] > 1 && arr[i] % j == 0 && arr[i] != j)
        //                {
        //                    break;
        //                }
        //                if(j == 10 - 1)
        //                {
        //                    Console.Write(arr[i] + " ");
        //                }
        //            }
        //        }
        //        Console.WriteLine(" ");
        //        Console.WriteLine("---------");
        //    }

        //    public static void Fib()
        //    {
        //        int[] fib = new int[arr.Length];
        //        Console.WriteLine("Fibonachi elements: ");
        //        Console.WriteLine(" ");
        //        int f1 = 0;
        //        int f2 = 1;
        //        fib[0] = f1;
        //        fib[1] = f2;
        //        int n = arr.Length;

        //        int count = 2;
        //        while (n > 2)
        //        {
        //            int f3 = f1 + f2;
        //            f1 = f2;
        //            f2 = f3;
        //            fib[count] = f2;
        //            count++;
        //            n-= 1;
        //        }

        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for(int j= 0; j < fib.Length; j++)
        //            {
        //                if (fib[j] == arr[i])
        //                {
        //                    Console.Write(arr[i] + " ");
        //                }
        //            }
        //        }
        //        Console.WriteLine(" ");
        //        Console.WriteLine("---------");

        //    }

        //    public static void Main(string[] args)
        //    {
        //        #region 1 Task 
        //        myArr myArr = new myArr(5);
        //        MyDelegate[] delegates = { Show, ShowEven, ShowOdd, ShowSimple, Fib };

        //        foreach (var del in delegates)
        //        {
        //            del();
        //        }
        //        Console.WriteLine();
        //        #endregion
        //    }
        //}


        delegate void MyDelegate2();
        delegate void TriangleSquareDel(int a, int b, int c);

        static Func<int, int, int> rectangleSquare = (height, width) => height * width;

        //class myClass
        //{
        //    public static void CurrentTime()
        //    {
        //        Console.WriteLine("Current time: ");
        //        DateTime dateTime = DateTime.Now;
        //        string time = dateTime.ToString("HH:mm:ss");
        //        Console.Write(time);
        //        Console.WriteLine(" ");
        //        Console.WriteLine("---------");
        //    }

        //    public static void CurrentDate()
        //    {
        //        Console.WriteLine("Current date: ");
        //        DateTime dateTime = DateTime.Now;
        //        string date = dateTime.ToString("d");
        //        Console.Write(date);
        //        Console.WriteLine(" ");
        //        Console.WriteLine("---------");
        //    }

        //    public static void CurrentDay()
        //    {
        //        Console.WriteLine("Current day of week: ");
        //        DateTime dateTime = DateTime.Now;
        //        DayOfWeek dayOfWeek = dateTime.DayOfWeek;
        //        Console.Write(dayOfWeek);
        //        Console.WriteLine(" ");
        //        Console.WriteLine("---------");
        //    }

        //    public static void TriangleSquare(int a, int b, int c)
        //    {
        //        Console.WriteLine("Triangle Square: ");
        //        if (a + b <= c || a + c <= b || b + c <= a)
        //        {
        //            Console.WriteLine("Не существует треугольника с данными сторонами.");
        //            Console.WriteLine("---------");
        //            return;
        //        }
        //        int p = (a + b + c) / 2;
        //        double square = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        //        if (double.IsNaN(square))
        //        {
        //            Console.WriteLine("Ошибка вычисления площади: результат не является числом.");
        //        }
        //        else
        //        {
        //            Console.WriteLine(square);
        //        }
        //        Console.WriteLine(" ");
        //        Console.WriteLine("---------");
        //    }

        //    public static void Main(string[] args)
        //    {
        //        myClass myClass = new myClass();
        //        MyDelegate2[] myDelegate2 = { CurrentTime , CurrentDate, CurrentDay };
        //        foreach(var del in myDelegate2)
        //        {
        //            del();
        //        }

        //        int height = 5;
        //        int width = 5;
        //        int area = rectangleSquare(height, width);
        //        Console.WriteLine("Rectangle Square: " + area);
        //        Console.WriteLine("---------");

        //        TriangleSquareDel dg = new TriangleSquareDel(TriangleSquare);
        //        dg(3, 4, 5);

        //    }
        //}

        delegate void MyDelegate3();

        class CreditCard
        {
            public static string Number { get; set; } 
            public static string FIO { get; set; }
            public static string PIN { get; set; } 
            public static int CreditLimit { get; set; }
            public static double Sum { get; set; }

            public CreditCard()
            {
                Number = null;
                FIO = null;
                PIN = null;
                CreditLimit = 1000;
                Sum = 0;
            }

            public CreditCard(string number, string fio, string pin, int creditLimit, double sum)
            {
                Number = number;
                FIO = fio;
                PIN = pin;
                CreditLimit = creditLimit;
                Sum = sum;
            }

            public static void Expense()
            {
                //снятие со счета
                Console.WriteLine("Какую сумму снять со счета? : ");
                double sum = double.Parse(Console.ReadLine());
                if (sum > 0 && sum < Sum)
                {
                    Sum -= sum;
                    Console.WriteLine("Сумма снята!");
                    Console.WriteLine("Остаток на счету: " + Sum);
                }
                else
                    Console.WriteLine("Error");
            }

            public static void ExpenseFromLimit()
            {
                //снятие с лимитного счета
                Console.WriteLine("Напишите сумму,которую снять с лимитного счета: ");
                double sum = double.Parse(Console.ReadLine());
                if (sum > 0 && sum < CreditLimit)
                {
                    Sum += sum;
                    Console.WriteLine("Операция успешна!");
                    Console.WriteLine("Остаток на лимитном счету: " + CreditLimit);
                }
                else
                    Console.WriteLine("Лимитный счет исчерпан!");
            }


            public static void TopUpAccount()
            {
                //пополнение счета
                Console.WriteLine("На какую сумму пополнить счет? : ");
                double sum = double.Parse(Console.ReadLine());
                if (sum > 0)
                {
                    Sum += sum;
                    Console.WriteLine("Счет пополнен!");
                    Console.WriteLine("Остаток на счету: " + Sum);
                }
                else
                    Console.WriteLine("Error");
            }

            public static void ChangePIN()
            {
                Console.WriteLine("Введите новый пинкод: ");
                string newPin = Console.ReadLine();
                if (PIN == newPin)
                {
                    Console.WriteLine("PIN must be different!");
                }
                else
                {
                    PIN = newPin;
                    Console.WriteLine("Pin changed!!!");
                }
                
            }

            public static void Main(string[] args)
            {
                CreditCard creditCard = new CreditCard("123356154", "Maria Shevchenko", "53623526", 500, 1000);
                MyDelegate3[] myDelegate3 = { Expense, ExpenseFromLimit, TopUpAccount, ChangePIN };
                foreach (var del in myDelegate3)
                {
                    del();
                }
            }
        }

    }
}
