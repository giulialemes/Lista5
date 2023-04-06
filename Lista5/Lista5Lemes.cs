using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numere;
            Console.WriteLine("Escolha um exercicio");
            Console.WriteLine("====== MENU ======");
            Console.WriteLine("1 - exercicio 1 ");
            Console.WriteLine("2 - exercicio 2 ");
            Console.WriteLine("3 - exercicio 3 ");
            Console.WriteLine("4 - exercicio 4 ");
            Console.WriteLine("5 - exercicio 5 ");
            Console.WriteLine("6 - exercicio 6 ");
            Console.WriteLine("7 - exercicio 7 ");
            Console.WriteLine("================");

            numere = int.Parse(Console.ReadLine());
            switch (numere)
            {
                case 1: 


                    int num;
                    Console.WriteLine("Digite um numero qualquer: ");
                    num = int.Parse(Console.ReadLine());

                    for (int i = 1; i < num; i++)
                        Console.WriteLine("valor de i" + i);

                    Console.ReadKey();
                    break;  

                case 2:


                    int numero;
                    Console.WriteLine("Digite um numero qualquer: ");
                    numero = int.Parse(Console.ReadLine());

                    for (int i = 2; i <= numero; i += 2)
                        Console.WriteLine("valor de i" + i);


                    Console.ReadKey();
                    break;

                case 3:


                    int Num;
                    Console.WriteLine("Digite um numero inteiro: ");
                    Num = int.Parse(Console.ReadLine());    

                    for (int i = 1000; i > Num; i-= 2)
                        Console.WriteLine("valor de i" + i );

                    Console.ReadKey ();
                    break;


                case 4:


                    int NUMERO, soma; 
                    
                    for ( soma = 0; soma <= 200;)
                    {
                        Console.WriteLine("Digite um numero: ");
                        NUMERO = int.Parse(Console.ReadLine());

                        if (NUMERO > 0)
                            soma = soma + NUMERO;

                    Console.ReadKey();
                    
                    }
                    break;


                case 5:


                    int number;
                    Console.WriteLine("Digite um numero inteiro: ");
                    number = int.Parse(Console.ReadLine());


                    for (int i = 1; i<= number; i++)    
                        if (number % i == 0)
                        {
                            Console.WriteLine("valor de i" + i);

                            Console.ReadKey();
                        }

                    break;


                case 6:


                    int Numeros;
                    Console.WriteLine("Digite 10 numeros");
                    Numeros = int.Parse(Console.ReadLine());

                    for (int i = 0; Numeros < )











                    break;


                


                  










                



















            }

              

           



            

        }
    }
}
