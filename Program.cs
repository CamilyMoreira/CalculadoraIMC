using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua altura em metros. Ex: 1,65");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com seu peso em Kg. Ex: 67,7");
            float peso = Convert.ToSingle(Console.ReadLine());

            Pessoa p1 = new Pessoa(nome, altura, peso);

            double imc = peso / (altura * altura);

            Console.WriteLine("{0} sua altura é {1} e seu peso {2}", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);
            
            double pcc = (24.9 * peso) / imc;
            double pc = peso - pcc;

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso!");
                Console.WriteLine("Você tem que engordar {0}kg para ter um peso saudável", pc);
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso saudável!");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso!");
                Console.WriteLine("Você tem que imagrecer {0}kg para ter um peso saudável", pc);
            }
            else if (imc > 30 && imc < 40)
            {
                Console.WriteLine("Obesidade!");
                Console.WriteLine("Você tem que imagrecer {0}kg para ter um peso saudável", pc);
            }
            else
            {
                Console.WriteLine("Obesidade grave!");
                Console.WriteLine("Você tem que imagrecer {0}kg para ter um peso saudável", pc);
            }
        }
    }
}
