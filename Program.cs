namespace Helloworld
{
    internal class Program

    {
    
        static void Main(string[] args)

        {
            int[] values = new int [20];
            values [3] = 5;
            int[] values2 = new int[25];
            Console.WriteLine(values2[3]);
            for (int i = 0; i < values.Length; i++)
            {
                values2[i] = values[i];
            }

            Console.WriteLine(values2[3]);
            Person p2 = new Person();
            Person[] persList = new Person[20];
            return;
        }
        
        }
    }
        public class Person{
        // public string Name  // Attribut 
        public string Name { get; set; } //Property
        public int Age { get; set; }
    }


