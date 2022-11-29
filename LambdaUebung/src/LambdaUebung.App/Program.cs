using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaUebung.App {
    public class Program {

        static void Main(string[] args) {
            Console.WriteLine("Beispiel 1: Converter");
            //decimal[] converted = LambdaTest.Converter(new decimal[] { -10, 0, 10, 20, 30 }, CelsiusToKelvin);
            decimal[] converted = LambdaTest.Converter(new decimal[] { -10, 0, 10, 20, 30 }, x => x + 273.15M);

            //LambdaTest.ForEach(converted, PrintValue);
            LambdaTest.ForEach(converted, x => Console.WriteLine(x));


            Console.WriteLine("Beispiel 2: Filter");
            //decimal[] freezed = LambdaTest.Filter(converted, WasserGefriert);
            decimal[] freezed = LambdaTest.Filter(converted, x => x < 273.15M);
            LambdaTest.ForEach(freezed, x => Console.WriteLine(x));

            Console.WriteLine("Beispiel 3: Division");
            //decimal result = LambdaTest.ArithmeticOperation(2, 0, DivideSafe);
            decimal result = LambdaTest.ArithmeticOperation(2, 0, (x, y) => y != 0 ? x / y : 0);
            Console.WriteLine(result);
            result = LambdaTest.ArithmeticOperation(2, 0, (x, y) => x / y, x => Console.Error.WriteLine(x));
            Console.WriteLine(result);

            Console.WriteLine("Beispiel 4: Callback Funktion");
            LambdaTest.RunCommand(() => {
                Console.WriteLine("Hello World.");
                Console.WriteLine("Hello World again.");
            });

            Console.ReadLine();
        }

        public static decimal CelsiusToKelvin(decimal value) {
            return value + 273.15M;
        }
        //public static Func<decimal, decimal> CelsiusToKelvin = x => x + 273.15M;
        public static void PrintValue(decimal value) {
            Console.WriteLine(value);
        }
        //public static Action<decimal> PrintValue = x => Console.WriteLine(x);

        public static decimal Divide(decimal x, decimal y) {
            return x / y;
        }
        //public static Func<decimal, decimal, decimal> Divide = (x, y) => x / y;

        public static decimal DivideSafe(decimal x, decimal y) {
            if (y == 0) { return 0; }
            return x / y;
        }
        //public static Func<decimal, decimal, decimal> DivideSafe = (x, y) => y != 0 ? x / y : 0;

        public static void PrintError(string message) {
            Console.Error.WriteLine(message);
        }
        //public static Action<string> PrintError = x => Console.Error.WriteLine(x);

        public static void SayHello() {
            Console.WriteLine("Hello World.");
            Console.WriteLine("Hello World again.");
        }
        //public static Action SayHello = () => {
        //    Console.WriteLine("Hello World.");
        //    Console.WriteLine("Hello World again.");
        //};

        public static bool WasserGefriert(decimal val) {
            return val < 273.15M;
        }
        //public static Func<decimal, bool> WasserGefriert = x => x < 273.15M;
    }
}

