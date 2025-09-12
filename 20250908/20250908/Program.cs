using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250908
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Feladat:");
            Console.Write("Add meg a négyzet oldalát");
            double oldal = double.Parse(Console.ReadLine());
            Console.WriteLine($"A négyzet kerülete: {4*oldal}, területe: {oldal*oldal}"); // de pow-al is lehet (math.pow)

            Console.WriteLine("2. Feladat:");
            Console.Write("Add meg a trapéz felső alapjának hosszát ");
            double t1 = double.Parse(Console.ReadLine());
            Console.Write("Add meg a trapéz alsó alapjának hosszát ");
            double t2 = double.Parse(Console.ReadLine());
            Console.Write("Add meg a trapéz magasságát ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine($"Területe: {((t1+t2)*m)/2}");

            Console.WriteLine("3. Feladat:");
            Console.Write("Add meg a téglalap hosszát ");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Add meg a téglalap szélességét ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine($"Terület: {l*w}, Kerület: {2* (l+w)}");

            Console.WriteLine("4. Feladat:");
            Console.Write("Add a háromszög alapjának hosszát ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Add meg a háromszög magasságát ");
            double m4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Terület = {(a*m4)/2}");

            Console.WriteLine("5. Feladat:");
            Console.Write("kör sugara ");
            double r5 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Kerület = {2*r5}, Terület = {(r5*r5)*Math.PI}");

            Console.WriteLine("6. Feladat:");
            int f6 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Négyzetgyöke: {Math.Pow(f6,2)}");

            Console.WriteLine("7. Feladat:");
            Console.Write("Kérem a háromszög a oldalát");
            double f7a = double.Parse(Console.ReadLine());
            Console.Write("Kérem a háromszög b oldalát");
            double f7b = double.Parse(Console.ReadLine());
            Console.Write("Kérem a háromszög c oldalát");
            double f7c = double.Parse(Console.ReadLine());
            double s = (f7a + f7b + f7c) / 2;
            Console.WriteLine($"Terület = {Math.Sqrt(s*(s-f7a)*(s-f7b)*(s-f7c))}");

            Console.WriteLine("8. Feladat:");
            Console.Write("Kérem a kocka élhosszát ");
            double f8e = double.Parse(Console.ReadLine());
            Console.WriteLine($"Térfogat = {Math.Pow(f8e,3)}, felszín = {6*(f8e*f8e)}");

            Console.WriteLine("9. Feladat:");
            Console.Write("Kérem a téglatest hosszát ");
            double f9h = double.Parse(Console.ReadLine());
            Console.Write("Kérem a téglatest szélességét ");
            double f9s = double.Parse(Console.ReadLine());
            Console.Write("Kérem a téglatest magasságát ");
            double f9he = double.Parse(Console.ReadLine());
            Console.WriteLine($"Térfogat = {f9h*f9s*f9he}");

            Console.WriteLine("10. Feladat:");
            Console.Write("Kérem a gömb sugarát ");
            double r10 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Térfogat {(4*Math.PI)/3 * Math.Pow(r10,3)} Felszín: {4*Math.PI*Math.Pow(r10,2)}");

            Console.WriteLine("11. Feladat:");
            Console.Write("Kérem a henger sugarát ");
            double r11 = double.Parse(Console.ReadLine());
            Console.Write("Kérem a henger magasságát ");
            double m11 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Térfogat = {Math.Pow(r11,2)*Math.PI*m11} Felszín: {2*r11*Math.PI*(r11+m11)}");

            Console.WriteLine("12. Feladat:");
            Console.Write("Kérem a kúp sugarát ");
            double r12 = double.Parse(Console.ReadLine());
            Console.Write("Kérem a kúp magasságát ");
            double m12 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Térfogata = {(Math.Pow(r12,2)*Math.PI*m12)/3} Felszín = {Math.PI*r12*(r12+Math.Sqrt(Math.Pow(r12,2)+Math.Pow(m12,2)))}");

            Console.WriteLine("13. Feladat:");
            Console.Write("Kérem a gúla alapjának területét ");
            double a13 = double.Parse(Console.ReadLine());
            Console.Write("Kérem a gúla magasságát ");
            double m13 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Térfogat = {(a13*m13)/3}");

            Console.WriteLine("14. Feladat:");
            Console.Write("Kérem a paralelogramma a oldalát");
            double a14 = double.Parse(Console.ReadLine());
            Console.Write("Kérem a paralelogramma b oldalát");
            double b14 = double.Parse(Console.ReadLine());
            Console.Write("Kérem a paralelogramma A b oldala által közbezárt szöget ");
            double y14 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Terület = {a14*b14*Math.Sin(y14)}");

            Console.WriteLine("15. Feladat:");
            Console.Write("Kérem a háromszög a oldalát");
            double a15 = double.Parse(Console.ReadLine());
            Console.Write("Kérem a háromszög b oldalát");
            double b15 = double.Parse(Console.ReadLine());
            Console.Write("Kérem a háromszög A b oldala által közbezárt szöget ");
            double y15 = double.Parse(Console.ReadLine());
            Console.WriteLine($"C = {Math.Sqrt(Math.Pow(a15,2)+Math.Pow(b15,2)-2*a15*b15*Math.Cos(y15))} T = {(a15*b15*Math.Sin(y15)/2)}");

            Console.WriteLine("16. Feladat:");
            Console.Write("Kérem a vízszintes hajítás kezdősebességét v0 = ");
            double v00 = double.Parse(Console.ReadLine());
            Console.Write("Kérek egy időt másodpercben s = ");
            int s0 = int.Parse(Console.ReadLine());
            double g = 9.81;
            Console.WriteLine($"X = {v00*s0} y = {(g/2)*Math.Pow(s0,2)}");

            Console.WriteLine("17. Feladat:");
            Console.Write("Kérem a ferde hajítás kezdősebességét a = ");
            double al = double.Parse(Console.ReadLine());
            Console.Write("Kérem a kezdősebességet v0 =");
            double v0 = double.Parse(Console.ReadLine());
            Console.Write("Kérem az időt másodpercben+ s =");
            int t = int.Parse(Console.ReadLine());
            double radian = al * (Math.PI / 180);
            Console.WriteLine($"Pillanatnyi helyzete koordináta = X = {v0*t*Math.Cos(radian)} y = {v0*t*Math.Sin(radian)-(g/2)*Math.Pow(t,2)}");
            Console.WriteLine($"Pillanatnyi sebesség koordináta = Vx = {v0*Math.Cos(radian)} vy = {v0*Math.Sin(radian)-g*t}");
            Console.WriteLine($"Emelkedés ideje: Tem = {(v0*Math.Sin(radian))/g}");
            Console.WriteLine($"Hajítás távolsága: Xmax = {(v0*Math.Sin(2*radian))/g}");
            Console.WriteLine($"Ymax = {(Math.Pow(v0,2)*Math.Pow(Math.Sin(radian),2))/2*g}");

            Console.WriteLine("NYOMD MEG AZ ENTERT!");
            Console.ReadKey();
        }
       

    }
}
