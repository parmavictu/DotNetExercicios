using System;
using LoremNET;
namespace Training.Business
{
    public class Class1
    {
        //static string text = "sdf";

        public static string GetMessage()
        {

            string message = Lorem.Words(5);
            return message; 
        }
    }
    
}
