using System;

namespace calculaIMC
{
    class Program
    {
        static void Main(string[] args)
        {
             float peso, altura = 0;
            double imc = 0;

            string nome, sobrenome = "";

            Console.Write("Digite seu nome:");
            nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome:");
            sobrenome =Console.ReadLine();
            Console.WriteLine("Caro Sr(a). : ", nome, " ", sobrenome);
            Console.Write("Digite seu peso em kilos:");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine(peso);
            Console.Write("Digite sua altura em metros");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine(altura);

            imc = peso / (altura * altura);

            if(imc < 17)
            {
                Console.WriteLine("Voce esta: MUITO ABAIXO DO PESO");
            }
            else if(imc >= 17 && imc < 18.5)
            {
                Console.WriteLine("Voce esta: ABAIXO DO PESO");
            }
            else if(imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Voce esta: PESO IDEAL");
            }
            else if(imc >= 25 & imc < 30)
            {
                Console.WriteLine("Voce esta: SOBREPESO");
            }
            else if(imc >= 30 & imc < 35)
            {
                Console.WriteLine("Voce esta: OBESIDADE MODERADA");
            }
            else if(imc >= 35 & imc < 40)
            {
                
                Console.WriteLine("Voce esta: OBESIDADE SEVERA");
            }
            else
            {
                Console.WriteLine("Voce esta: OBESIDADE MORBIDA");
            }

            float x = 0;

        x = imc - 10;
        Console.WriteLine("Seu peso ideal deveria ser: ", x);

        
        Console.ReadLine();


        }
    }
}
