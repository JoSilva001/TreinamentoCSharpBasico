using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.InterfaceConsole
{//inicio do name espace
    internal class Program
    {//início do método
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            //início do métoodo
            /*
            *Main - principal
            *O método inicia-se com a letra maiuscula
            *Váriavél
            * É um espaço reservado na memória
            *
            */
            string pergunta;
            string resposta="git init";
            Console.WriteLine("Qual o comando para iniciar o git?");
            pergunta = Console.ReadLine();
            if (pergunta.Equals(resposta))
            {
                Console.WriteLine("acertou");
            }
            else
            {
                Console.WriteLine("errou");
            }
            resposta = Console.ReadLine();
            Console.WriteLine($"{resposta} \n {pergunta}");
            Console.WriteLine("Alô Mundo!");
            Console.ReadKey();
        }// fim do método
    }//fim do método
}// fim do name espace
