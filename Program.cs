using System;
using System.Collections;

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
            Console.WriteLine("Для вызова истории вычислений введите hisory");

            Console.WriteLine();

            String str;
            String res;
            ArrayList historyList = new ArrayList();
            while (true)
            {
                Console.Write("введите пример либо команду :   ");
                str = Console.ReadLine();
                
                if (str == "exit") break;                                           //обработка команды 'exit' - выход из программы
                
                if (str == "history")                                               //обработка команды 'history' - вывод на экран успешно решенных примеров
                {
                    foreach (String s in historyList) Console.WriteLine(s);
                    continue;
                }
                
                res = Calc2(str);
                if (res == "error")                                                 //вывод сообщения об ошибки ввода примера, при ее наличии
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }
                str = str + " = "+ res;                                             
                historyList.Add(str);                                               //сохранение успешо решенного примера в истории
                Console.WriteLine(str);                                             //вывод результата
            }
        }


        static String Calc2(string str)
        {
            double op1 = 0;
            double op2 = 0;
            bool err = false;                       // флаг наличия ошибки формата ввода
            double result = 0;
            int i;
            for (i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '+':
                        if (Double.TryParse(str.Substring(0, i), out op1) && Double.TryParse(str.Substring(i + 1, str.Length - i - 1),out op2))
                            result = op1 + op2;
                        else
                            err = true;  
                        i = str.Length+1;
                        break;
                    case '-':
                        if (Double.TryParse(str.Substring(0, i), out op1) && Double.TryParse(str.Substring(i + 1, str.Length - i - 1), out op2))
                            result = op1 - op2;
                        else
                            err = true;
                        i = str.Length+1;
                        break;
                    case '*':
                        if (Double.TryParse(str.Substring(0, i), out op1) && Double.TryParse(str.Substring(i + 1, str.Length - i - 1), out op2))
                            result = op1 * op2;
                        else
                            err = true;
                        i = str.Length+1;
                        break;
                    case '/':
                        if (Double.TryParse(str.Substring(0, i), out op1) && Double.TryParse(str.Substring(i + 1, str.Length - i - 1), out op2))
                            result = op1 / op2;
                        else
                            err = true;
                        i = str.Length+1;
                        break;
                }
            }
            if (i == str.Length) if (!Double.TryParse(str, out result)) err = true;      // в случае, если введено просто одно число, результатом является само число
            if (err) return "error"; else return result.ToString();
        }

    }
}   
