using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1040_Media
{
    class Program
    {
        static void Main(string[] args)
        {

            float n1, n2, n3, n4, n5, media;

            string[] vet = Console.ReadLine().Split(' ');
            n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            if (media >= 7.0)
            {

                Console.WriteLine("Média: " + media);
                Console.WriteLine("Aluno aprovado.");

            }
            else if (media <= 6.9 && media >= 5.0)
            {

                Console.WriteLine("Aluno em exame.");

                n5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Nota do Exame:" + n5);
                media = (media + n5) / 2;

                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Média Final: " + media);
                    
                } else
                {
                    Console.WriteLine("Média: " + media);
                    Console.WriteLine("Aluno reprovado");
                }

            }
            else
            {
                Console.WriteLine("Média: " + media);
                Console.WriteLine("Aluno reprovado");
            }
            Console.ReadLine();

        }
    }
}