using System;

class Program
{

    public static void Main(string[] args)
    {
        int numTartaruga = 3;

        while (numTartaruga > 0)
        {
            var qtdVelocidade = Int32.Parse(Console.ReadLine());


            if (numTartaruga >= 1 && qtdVelocidade <= 500)
            {
                var s = Console.ReadLine();
                string[] tartarugas = s.Split(' ');
                var maxVelocidade = Int32.Parse(tartarugas[0]);

                for (int i = 1; i < numTartaruga; i++)
                {
                    var tartaruga = Int32.Parse(tartarugas[i]);

                    if (tartaruga > maxVelocidade)
                    {
                        maxVelocidade = tartaruga;
                    }
                }
                if (maxVelocidade < 10)
                {
                    Console.WriteLine(1);
                }
                else if (maxVelocidade >= 10 && maxVelocidade < 20)
                {
                    Console.WriteLine(2);
                }
                else if (maxVelocidade >= 20)
                {
                    Console.WriteLine(3);
                }
                numTartaruga--;
            }
            else
            {
                Console.WriteLine("Insira um número entre 1 e 500");
            }
        }



    }


}
// IMPLEMENTE A SOLUÇÃO


