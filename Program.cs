using System;

namespace Elefante
{
    class Program
    {
        static void Main(string[] args)
        {
            int  qtIncomoda = 2;

            Console.Write ("Informe o número de elefantes (par maior que 2):");
            int  elefantes  = Int32.Parse (Console.ReadLine ());

            if(elefantes < 4)
            {
                throw new Exception("O número de elefantes é menor que o mínimo informado");
            }
            
            for (int i = 1; i <= elefantes; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"\n{i} elefante incomoda muita gente");
                }
                else if (i % 2 == 0)
                {
                    Console.Write($"{i} elefantes ");

                    for (int x = 0; x < qtIncomoda; x++)
                    {
                        Console.Write("incomodam ");
                    }
                    qtIncomoda += 2;

                    Console.WriteLine("muito mais\n");
                }
                else
                {
                    Console.WriteLine($"{i} elefantes incomodam muita gente");
                }
            }
        }
    }
}

