using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ex, dia; 
        
        Console.WriteLine("========Menu========")
        Console.WriteLine("Exercício 1");
        Console.WriteLine("Exercício 2");
        Console.WriteLine("Exercício 3");
        Console.WriteLine("Exercício 4");
        Console.WriteLine("Exercício 5");
        Console.WriteLine("Exercício 6");

        Ex = int.Parse(Console.ReadLine());

        switch(Ex);

        case 1;
            Console.WriteLine("Exercicio dias da semana");
            Console.WriteLine("Digite um numero de de 1 a 7 correspondente a um dia da semana");
            dia = int.Parse(Console.ReadLine ());
            
            switch (dia)
            {
                case 1: Console.WriteLine("numero digitado é domingo");
                break;

                case 2: Console.WriteLine("numero digitado é a segunda-feira");
                break;

                case 3: Console.WriteLine("numero digitado é a quarta-feira");
                break;
                
                case 4: Console.WriteLine("numero digitado é a quarta-feira");
                break;

                case 5: Console.WriteLine("numero digitado é a quinta-feira");
                break;
                
                case 6: Console.WriteLine("numero digitado é a sexta-feira");
                break;
                
                case 7: Console.WriteLine("numero digitado é a sabado");
                break;
                
                

                


            }
                
        }
    }
}
