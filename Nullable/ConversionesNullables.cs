using System;
using static System.Console;

namespace Nullable
{
    class ConversionesNullables
    {
        public static void Run()
        {
            // T a Nullable<T>
            int n = 17;
            WriteLine("--------------------------------------");
            WriteLine("T a Nullable<T>");
            WriteLine("int a Nullable<int>");
            WriteIntNulo(n);

            // Nullable<T> a T
            int? nint = 15;
            WriteLine("--------------------------------------");
            WriteLine("Nullable<T> a T");
            WriteLine("Nullable<int> a int");
            WriteInt((int)nint);

            // Nullable<S> a Nullable<T>
            WriteLine("--------------------------------------");
            WriteLine("Nullable<S> a Nullable<T>");
            WriteLine("Nullable<int> a Nullable<decimal>");
            WriteDecNulo(nint);
            decimal? ndec = 67;
            WriteLine("Nullable<decimal> a Nullable<int>");
            WriteIntNulo((int)ndec);

            // S a Nullable<T>
            WriteLine("--------------------------------------");
            WriteLine("S a Nullable<T>");
            WriteLine("int a Nullable<decimal>");
            WriteDecNulo(n);
            WriteLine("decimal a Nullable<int>");
            WriteIntNulo((int)ndec);

            // Nullable<S> a T
            WriteLine("--------------------------------------");
            WriteLine("Nullable<S> a T");
            WriteLine("Nullable<int> a decimal");
            WriteDecimal((decimal)nint);
        }

        static void WriteDecimal(decimal d) => WriteLine($"decimal = {d}");
        static void WriteDecNulo(decimal? d) => WriteLine($"decimal? = {d}");
        static void WriteInt(int n) => WriteLine($"int = {n}");
        static void WriteIntNulo(int? n) => WriteLine($"int? = {n}");
    }
}
