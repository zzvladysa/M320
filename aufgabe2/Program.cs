namespace aufgabe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = MyMath.ReadInt();
            int b = MyMath.ReadInt();

            int ggt = MyMath.Calc_ggT(a, b);
            int kgv = MyMath.Calc_kgV(a, b);

            MyMath.ShowResult("ggT", a, b, ggt);
            MyMath.ShowResult("kgV", a, b, kgv);
        }
    }

    public class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z;

            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }

            return a;
        }

        public static int Calc_kgV(int a, int b)
        {
            return (a * b) / Calc_ggT(a, b);
        }

        public static int ReadInt()
        {
            int zahl;

            do
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
                String s = Console.ReadLine();
                zahl = int.Parse(s);

            } while (zahl <= 0);

            return zahl;
        }

        public static void ShowResult(string name, int a, int b, int result)
        {
            Console.WriteLine(name + " von " + a + " und " + b + " ist " + result);
        }
    }
}