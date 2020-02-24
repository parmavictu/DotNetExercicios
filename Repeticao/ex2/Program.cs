using System;



//Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário,
// mostrando uma mensagem de erro e voltando a pedir as informações.


namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Senha: ");
            string password = Console.ReadLine();


            while(name.Equals(password))
            {
                Console.Write("Senha igual o nome, digite novamente: ");
                password = Console.ReadLine();
            }

            Console.ReadKey();


        }
    }
}
