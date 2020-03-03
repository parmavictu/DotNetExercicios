using System;
using System.IO;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {


            var path = @"C:\Users\victorfp\Desktop\Estudos\DotNetExercicios\exceptions\idk\WriteLine.txt";
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }


            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s;

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }



            string[] lines = { "First line", "Second line", "Third line" };

            //Obs.: Com esse método não é necessário, fechar liberar ou fechar o arquivo criado.
            System.IO.File.WriteAllLines(@"C:\Users\victorfp\Desktop\Estudos\DotNetExercicios\exceptions\idk\Writeline2.txt", lines);

            // ########################################################################
            // Example #2: Utilizando uma string para gerar o conteúdo de um arquivo
            // ########################################################################
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";

            //Obs.: Com esse método não é necessário, fechar liberar ou fechar o arquivo criado.
            System.IO.File.WriteAllText(@"C:\Users\victorfp\Desktop\Estudos\DotNetExercicios\exceptions\idk\Writeline3.txt", text);

            // ########################################################################
            // Example #3: Escrevendo linha a linha no arquivo.
            // ########################################################################
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\victorfp\Desktop\Estudos\DotNetExercicios\exceptions\idk\Writeline4.txt"))
            {
                foreach (string line in lines)
                {
                    // Lógica
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\victorfp\Desktop\Estudos\DotNetExercicios\exceptions\idk\WriteLine.txt", true))
            {
                file.WriteLine("Fourth line");
            }

            string text2 = System.IO.File.ReadAllText(@"C:\Users\victorfp\Desktop\Estudos\DotNetExercicios\exceptions\idk\WriteLine.txt");
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text2);

            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\victorfp\Desktop\Estudos\DotNetExercicios\exceptions\idk\WriteLine.txt");

            foreach (string line in lines2)
            {
                Console.WriteLine("\t" + line);
            }



        }
    }
}
