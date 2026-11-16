using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForPractice
{
    class Piont
    {
        private int x {set; get;}
        private int y {set; get;}

        public Piont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Piont operator +(Piont p1, Piont p2)
        {
            return new Piont(p1.x + p2.x, p2.y + p2.y);
        }

        public static Piont operator -(Piont p1, Piont p2)
        {
            return new Piont(p1.x - p2.x, p2.y - p2.y);
        }

        public static bool operator ==(Piont p1, Piont p2)
        {
            return (p1.x == p2.x) && (p2.y == p2.y);
        }

        public static bool operator !=(Piont p1, Piont p2)
        {
            return (p1.x != p2.x) || (p2.y != p2.y);
        }

        public override string ToString()
        {

            return "( "+ x +" , " + y + " )";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Piont P1 = new Piont(7, 9);
            Piont P2 = new Piont(3, 4);

            Piont p3 = P1 + P2;
            Piont p4 = P1 - P2;

            Console.WriteLine("Piont1 : " + P1.ToString());
            Console.WriteLine("Piont2 : " + P2.ToString());
            Console.WriteLine("The result of sum to Piont3 : " + p3.ToString());
            Console.WriteLine("The result of Sub to Piont4 : " + p4.ToString());

            if (P1 == P2)
                Console.WriteLine("== : Yes");
            else
                Console.WriteLine("== : No");

            if (P1 != P2)
                Console.WriteLine("!= : Yes");
            else
                Console.WriteLine("!= : Nos");

            Console.ReadKey();
        }
    }
}
