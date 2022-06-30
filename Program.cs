using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provaex1
{
    internal class Program
    {
        static void Main(string[] args) {
            double n1, n2, m;
            string nome  ;

            Console.WriteLine(" Qual o nome do aluno");
            Console.ReadLine();

            Console.WriteLine("qual a nota 1");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("qual a nota 2");
            n2 = double.Parse(Console.ReadLine());

            m = (n1 + n2) / 2;

            if (m == 0) 
            {
                Console.WriteLine(m + "o conceito é E");
            } 
            else if (m >= 0 & m <= 5.9) 
            {
                Console.WriteLine(m + " o conceito é D");
            }
            else if(m>= 6 & m <= 6.9) 
            {
                Console.WriteLine(m + " o conceito é C");
            }
            else if (m >=7 & m <= 8.4) 
            {
                Console.WriteLine(m + " o conceito é B");
            }
            else if (m>= 8.5) 
            {
                Console.WriteLine(m + " o conceito é A");
            }
            Console.ReadKey();  

        }
    }   
}
