using System;

namespace ConsoleAppCalculator
{
    //class Program
    //{ 
    //    static void Main(string[] args)
    //    {
    //        double firstKey, secondKey, result;
    //        char operation;

    //        Console.WriteLine("Введите 1-ое число ");
    //        firstKey = Convert.ToDouble(Console.ReadLine());

    //        Console.WriteLine("Введите 2-ое число ");
    //        secondKey = Convert.ToDouble(Console.ReadLine());

    //        Console.WriteLine("Введите операцию для чисел ");
    //        operation = Convert.ToChar(Console.ReadLine());

    //        if (operation == '-') {
    //            result = firstKey - secondKey;
    //            Console.WriteLine("Ответ: " + firstKey + operation + secondKey + " = " + result);
    //        } else if (operation == '+') {
    //            result = firstKey + secondKey;
    //            Console.WriteLine("Ответ: " + firstKey + operation + secondKey + " = " + result);
    //        } else if (operation == '*') {
    //            result = firstKey * secondKey;
    //            Console.WriteLine("Ответ: " + firstKey + operation + secondKey + " = " + result);
    //        } else if (operation == '/') {
    //            result = firstKey / secondKey;
    //            Console.WriteLine("Ответ: " + firstKey + operation + secondKey + " = " + result);
    //        } else {
    //            Console.WriteLine("Input operation is invalid");
    //        }
    //        Console.ReadLine();
    //    }
    //}

    class Calculate {
        public void Main() {
            Console.WriteLine("Введите число");
            var a = Console.ReadLine();
            Console.WriteLine("Введдённое число");
            Console.WriteLine(a);
        }
    }

    class checkCalculate : ICalculator, ICalcObject {

    }

    interface ICalculator {
        ICalcObject[] Parse(string[] args);
        ICalcObject Calculate(ICalcObject obj1, ICalcObject oper, ICalcObject obj2);
    }

    interface ICalcObject {
        bool IsOperator { get; }
    }
}
