using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morseovka
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, String> morse = new Dictionary<char, String>();
            morse.Add('A', ".-");
            morse.Add('B', "-...");
            morse.Add('C', "-.-.");
            morse.Add('D', "-..");
            morse.Add('E', ".");
            morse.Add('F', "..-.");
            morse.Add('G', "--.");
            morse.Add('H', "....");
            morse.Add('I', "..");
            morse.Add('J', ".---");
            morse.Add('K', "-.-");
            morse.Add('L', ".-..");
            morse.Add('M', "--");
            morse.Add('N', "-.");
            morse.Add('O', "---");
            morse.Add('P', ".--.");
            morse.Add('Q', "--.-");
            morse.Add('R', ".-.");
            morse.Add('S', "...");
            morse.Add('T', "-");
            morse.Add('U', "..-");
            morse.Add('V', "...-");
            morse.Add('W', ".--");
            morse.Add('X', "-..-");
            morse.Add('Y', "-.--");
            morse.Add('Z', "--..");
            morse.Add('1', ".----");
            morse.Add('2', "..---");
            morse.Add('3', "...--");
            morse.Add('4', "....-");
            morse.Add('5', ".....");
            morse.Add('6', "-....");
            morse.Add('7', "--...");
            morse.Add('8', "---..");
            morse.Add('9', "----.");
            morse.Add('0', "-----");

            Console.WriteLine("Napište co chcete přeložit:");
            string input;

            input = Console.ReadLine();
            input = input.ToUpper();

            string slovo = "";
            bool naopak = false;

            for (int i = 0; i < input.Length; i++)
            {
                int eol = input.Length;
                char current = input[i];

                if (current == '.' || current == '-')
                {
                    naopak = true;
                    slovo += current;
                }

                if (current == '|' || (current == ' ' && slovo.Length > 0) || ((i + 1 == eol) && slovo.Length > 0))
                {
                    Console.Write(morse.Where(x => x.Value.Equals(slovo)).First().Key.ToString().ToLower());
                    slovo = "";
                }

                if (naopak && current == ' ')
                {
                    Console.Write(' ');
                }

                if (!naopak)
                {
                    if (i > 0)
                    {
                        if (input[i - 1] != ' ' && current != ' ')
                        {
                            Console.Write('|');
                        }

                        if (current == ' ')
                        {
                            Console.Write(' ');
                        }
                    }

                    if (morse.ContainsKey(current))
                    {
                        Console.Write(morse[current]);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}