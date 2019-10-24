using System;

namespace homeWork_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу калькулятор.");
            Console.WriteLine("Поддерживаемые операции: +, -, *, /.");
            Console.WriteLine("Формат ввода : <число1> <операция> <число2> ");
            Console.WriteLine("Для выхода из программы введите exit ");
            Console.WriteLine();

            //bool pr_end = false; ;
            String str;
            while (true)
            {
                Console.Write("введите пример либо exit для выхода:   ");
                str = Console.ReadLine();
                if (str == "exit") break;
                Calc2(str);                
            }
        }




        static void Calc2(string str)
        {
            double result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '+':
                        result = Convert.ToDouble(str.Substring(0, i)) + Convert.ToDouble(str.Substring(i + 1, str.Length - i - 1));
                        Console.WriteLine($"{str} = {result}"); Console.WriteLine();
                        i = str.Length;
                        break;
                    case '-':
                        result = Convert.ToDouble(str.Substring(0, i)) - Convert.ToDouble(str.Substring(i + 1, str.Length - i - 1));
                        Console.WriteLine($"{str} = {result}"); Console.WriteLine();
                        i = str.Length;
                        break;
                    case '*':
                        result = Convert.ToDouble(str.Substring(0, i)) * Convert.ToDouble(str.Substring(i + 1, str.Length - i - 1));
                        Console.WriteLine($"{str} = {result}"); Console.WriteLine();
                        i = str.Length;
                        break;
                    case '/':
                        result = Convert.ToDouble(str.Substring(0, i)) / Convert.ToDouble(str.Substring(i + 1, str.Length - i - 1));
                        Console.WriteLine($"{str} = {result}"); Console.WriteLine();
                        i = str.Length;
                        break;
                }
            }
        }

    }
}   
