using System;
using static System.Console;

namespace Nullable
{
    static class LiftedOperadores
    {
        public static void Run()
        {
            int? nullInt = new int?();
            int? nullInt2 = null;
            int? four = 4;
            int? five = 5;
            int? cinco = 5;

            WriteLine("Lifted Operadores");
            WriteLine("----------------------------------");
            WriteLine($"-nullInt == null: {-nullInt == null}");
            WriteLine($"-five: {-five}");
            WriteLine($"five + five: {five + five}");
            WriteLine($"nullInt == nullInt: {nullInt == nullInt2}");
            WriteLine($"five == five: {five == cinco}");
            WriteLine($"five == nullInt: {five == nullInt}");
            WriteLine($"five == four: {five == four}");
            WriteLine($"four < five: {four < five}");
            WriteLine($"nullInt < five: {nullInt < five}");
            WriteLine($"five < nullInt: {five < nullInt}");
            WriteLine($"nullInt < nullInt: {nullInt < nullInt2}");
            WriteLine($"nullInt <= nullInt: {nullInt <= nullInt2}");
        }
    }
}
