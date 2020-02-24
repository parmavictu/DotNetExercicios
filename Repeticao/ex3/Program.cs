using System;
//Faça um programa que leia e valide as seguintes informações:
//Nome: maior que 3 caracteres;
//Idade: entre 0 e 150;
//Salário: maior que zero;
//Sexo: 'f' ou 'm';
//Estado Civil: 's', 'c', 'v', 'd';
namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine();
            while(!Validators.ValidateName(name)){
                Console.Write("Nome tem que ter no mínimo 3 caracteres. Digite novamente: ");
                name = Console.ReadLine();
            }

            Console.Write("Digite sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());
            while(!Validators.ValidateAge(age)){
                Console.Write("Idade tem que ser entre 0 e 150. Digite novamente: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite seu salário: ");
            double wage = Convert.ToDouble(Console.ReadLine());
            while(!Validators.ValidateWage(wage)){
                Console.Write("Salário tem que ser maior que 0. Digite novamente: ");
                wage = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Digite seu sexo: ");
            char gender = Console.ReadLine()[0];
            while(!Validators.ValidateGender(gender)){
                Console.Write("O sexo tem que ser M ou F. Digite novamente: ");
                gender = Console.ReadLine()[0];
            }


            Console.Write("Digite seu estado civil(S | C | V | D): ");
            char status = Console.ReadLine()[0];
            while(!Validators.ValidateStatus(status)){
                Console.Write("O estado civil tem que ser (S | C | V | D). Digite novamente: ");
                status = Console.ReadLine()[0];
            }
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Idade: {age}");
            Console.WriteLine($"Salário: {wage}");
            Console.WriteLine($"Sexo: {gender}");
            Console.WriteLine($"Estado civil: {status}");
            Console.ReadKey();

        }
    }
}
