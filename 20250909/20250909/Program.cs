using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250909
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematika");
            Console.WriteLine("\t1. Feladat - törtek");
            Console.WriteLine("\t1. Mit szeretne?: \n\t1. összeadás  2. kivonás \n\t3. szorzás  4. osztás");
            int opcio = int.Parse(Console.ReadLine());
            if (opcio == 1) {
                Console.WriteLine("\tKéplete: a/b + c/d = (ad+bc)/bd");
                Console.Write("\tKérem az a adatot a=");
                double a1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az a adatot b=");
                double b1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az a adatot c=");
                double c1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az a adatot d=");
                double d1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"a/b + c/d = {(a1 * d1 + b1 * c1) / b1 * d1}");
                Console.WriteLine("Tovább lépéshez ENTER");
                Console.ReadKey();
            }
            if (opcio == 2) {
                Console.WriteLine("\tKéplete: a/b - c/d = (ad-bc)/bd");
                Console.Write("\tKérem az a adatot a=");
                double a1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az a adatot b=");
                double b1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az a adatot c=");
                double c1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az a adatot d=");
                double d1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"a/b - c/d = {(a1 * d1 - b1 * c1) / b1 * d1}");
                Console.WriteLine("Tovább lépéshez ENTER");
                Console.ReadKey();
            }
            if (opcio == 3) {
                Console.WriteLine("\tKéplete: a/b * c/d = (a*c)/b*d");
                Console.Write("\tKérem az a adatot a=");
                double a1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az a adatot b=");
                double b1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az a adatot c=");
                double c1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az a adatot d=");
                double d1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"a/b * c/d = {(a1*c1)/b1*d1}");
                Console.WriteLine("Tovább lépéshez ENTER");
                Console.ReadKey();
            }
            if (opcio == 4) {
                Console.WriteLine("\tKéplete: a/b : c/d = ad/bc");
                Console.Write("\tKérem az a adatot a=");
                double a1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az b adatot b=");
                double b1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az c adatot c=");
                double c1 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az d adatot d=");
                double d1 = double.Parse(Console.ReadLine());
                Console.WriteLine($"a/b + c/d = {(a1*d1)/b1*c1}");
                Console.WriteLine("Tovább lépéshez ENTER");
                Console.ReadKey();
            }

            Console.WriteLine("\t2. Feladat - Nevezetes azonosságok");
            Console.WriteLine("\tVálassza ki, hogyan néz ki az egyenlete");
            Console.WriteLine("\t1. (a+b)^2  2. (a-b)^2  3. (a-b)(a+b)  4. (a+b+c)^2\n\t5. (a+b)^3  6.(a-b)^3  7. a^3+b^3  8. a^3-b^3");
            int opcio2 = int.Parse(Console.ReadLine());

            
            if (opcio2 == 1)
            {
                Console.Write("\tKérem az a adatot a=");
                double a2 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az b adatot b=");
                double b2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t({a2}+{b2})^2 = {Math.Pow(a2,2)+2*(a2*b2)+Math.Pow(b2,2)}");
            }
            if(opcio2 == 2)
            {
                Console.Write("\tKérem az a adatot a=");
                double a2 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az b adatot b=");
                double b2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t({a2}-{b2})^2 = {Math.Pow(a2, 2) - 2 * (a2 * b2) + Math.Pow(b2, 2)}");
            }
            if (opcio2 == 3)
            {
                Console.Write("\tKérem az a adatot a=");
                double a2 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az b adatot b=");
                double b2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t({a2}-{b2})({a2}+{b2}) = {Math.Pow(a2,2)-Math.Pow(b2,2)}");
            }
            if (opcio2 == 4)
            {
                Console.Write("\tKérem az a adatot a=");
                double a2 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az b adatot b=");
                double b2 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az c adatot c=");
                double c2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"\t({a2}+{b2}+{c2})^2 = {Math.Pow(a2,2)+Math.Pow(b2,2)+Math.Pow(c2,2)+ 2*(a2*b2)+2*(a2+c2)+2*(b2+c2)}");

            }
            if (opcio2 == 5)
            {
                Console.Write("\tKérem az a adatot a=");
                double a2 = double.Parse(Console.ReadLine());
                Console.Write("\tKérem az b adatot b=");
                double b2 = double.Parse(Console.ReadLine());
                //Console.WriteLine($"({a2}+{b2})^3 = {Math.Pow(a2,3)+3*Math.Pow(a2,2)*b2 +Math.Pow(3*(a2+b2),2))}");
            }
            Console.WriteLine("Tovább lépéshez ENTER");
            Console.ReadKey();
        }
    }
}
