using System;

namespace CSharp_Shell
{
    class Program 
    {
        /* Перевернуть текст */
        static void ReverseText(string text)
        {
            /* Перевëрнутый текст */
            string invertedText = "";
            
            for (int i = text.Length - 1; i >= 0; i--)
            {
                invertedText += text[i];
            }
            
            Console.WriteLine($"\nРезультат переворачивания текста: {invertedText}\n");
        }
        
        static void Main()
        {
            /* Введëнный текст */
            string text;
            
            Console.Title = "Перевернуть текст";
            
            Console.Write("Введите текст для переворачивания: ");
            text = Convert.ToString(Console.ReadLine());
            
            ReverseText(text);
        }
    }
}