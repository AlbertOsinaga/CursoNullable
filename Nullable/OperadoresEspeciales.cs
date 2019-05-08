using System;
using static System.Console;

namespace Nullable
{
    class OperadoresEspeciales
    {
        public static void Run()
        {
            string first = "primero";
            string second = "segundo";
            var s = first ?? second;
            WriteLine($"s = {s}");

            first = null;
            s = first ?? second;
            WriteLine($"s = {s}");

            second = null;
            s = first ?? second;
            WriteLine($"s = {s == null}");

            int? nint = null;
            int n = nint ?? 10;
            WriteLine($"n = {n}");

            int? nonull = 20;
            var num = nint ?? nonull;
            WriteLine($"num = {num.Value}");

            decimal? ndec = null;

            WriteLine($"nint??ndec??30 = {nint??ndec??30}");
        }
    }
}
