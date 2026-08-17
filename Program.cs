namespace Helloworld
{
    internal class Program

    {
        static void Printnumber(int k)
        {
            k = k + 3;
            Console.WriteLine($"Zahl {k}");
        }
        static void PrintMessege(string s)
        {
            Console.WriteLine($"Message {s}");
        }
        static void Main(string[] args)
        {
            // var a = 5;
            //Printnumber(a);
            //var res = Add(5, 7);
            //Console.WriteLine($"Main {a}");
           // var message = "Hello ";
            //PrintMessege(message);
            //Console.WriteLine($"Main {message}");

            var p = new Person();
            p.Name = "Max";
            p.Age = 25;



        }
    }
        public class Person{
        // public string Name  // Attribut 
        public string Name { get; set; } //Property
        public int Age { get; set; }
    }
}

