using System;

namespace AppProvaLogicProg_Exerc_06
{
    class Program
    {
        public static Boolean ValidarSenha(int senha) 
        {
            bool flag;
            try
            {
                if (senha==2002)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                return flag;
            }
            catch (Exception)
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            int senha;
            bool senhaValida = false;
            Console.WriteLine("Digite a sua senha: ");
            senha =int.Parse(Console.ReadLine());
            senhaValida = ValidarSenha(senha);

            while (!senhaValida)
            {
                Console.WriteLine("Senha Invalida");
                senha = 0;
                senha = int.Parse(Console.ReadLine());
                senhaValida = ValidarSenha(senha);
            }

            Console.WriteLine("Acesso Permitido");
            Console.ReadLine();
        }
    }
}
