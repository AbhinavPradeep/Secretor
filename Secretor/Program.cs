using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int StringLength =0;
            string EncryptedSentence = "";

            Console.WriteLine("Reading file...");
            //string Msg = Console.ReadLine();
            string Msg = File.ReadAllText(@"C:\Users\Abhin\source\repos\Secretor\MySecret.txt");

            StringLength = Msg.Length;



            for (int control = 0; control < StringLength; control = control + 1)
            {
                if (Msg[control] == ' ' )
                {
                    EncryptedSentence = EncryptedSentence + "~";
                    
                }
                if (Msg[control] == 'A' || Msg[control] == 'a')
                {
                    EncryptedSentence = EncryptedSentence +"%";
                }
                else if (Msg[control] == 'B' || Msg[control] == 'b')
                {
                    EncryptedSentence = EncryptedSentence +"@";
                }
                else if (Msg[control] == 'C' || Msg[control] == 'c')
                {
                    EncryptedSentence = EncryptedSentence +"&";
                }
                else if (Msg[control] == 'D' || Msg[control] == 'd')
                {
                    EncryptedSentence = EncryptedSentence +"*";
                }
                else if (Msg[control] == 'E' || Msg[control] == 'e')
                {
                    EncryptedSentence = EncryptedSentence +"`";
                }
                else if (Msg[control] == 'F' || Msg[control] == 'f')
                {
                    EncryptedSentence = EncryptedSentence +"=";
                }
                else if (Msg[control] == 'G' || Msg[control] == 'g')
                {
                    EncryptedSentence = EncryptedSentence +"+";
                }
                else if (Msg[control] == 'H' || Msg[control] == 'h')
                {
                    EncryptedSentence = EncryptedSentence +"-";
                }
                else if (Msg[control] == 'I' || Msg[control] == 'i')
                {
                    EncryptedSentence = EncryptedSentence +"/";
                }
                else if (Msg[control] == 'J' || Msg[control] == 'j')
                {
                    EncryptedSentence = EncryptedSentence +"1";
                }
                else if (Msg[control] == 'K' || Msg[control] == 'k')
                {
                    EncryptedSentence = EncryptedSentence +"3";
                }
                else if (Msg[control] == 'L' || Msg[control] == 'l')
                {
                    EncryptedSentence = EncryptedSentence +"5";
                }
                else if (Msg[control] == 'M' || Msg[control] == 'm')
                {
                    EncryptedSentence = EncryptedSentence +">";
                }
                else if (Msg[control] == 'N' || Msg[control] == 'n')
                {
                    EncryptedSentence = EncryptedSentence +"7";
                }
                else if (Msg[control] == 'O' || Msg[control] == 'o')
                {
                    EncryptedSentence = EncryptedSentence +",";
                }
                else if (Msg[control] == 'P' || Msg[control] == 'p')
                {
                    EncryptedSentence = EncryptedSentence +"<";
                }
                else if (Msg[control] == 'Q' || Msg[control] == 'q')
                {
                    EncryptedSentence = EncryptedSentence +"^";
                }
                else if (Msg[control] == 'R' || Msg[control] == 'r')
                {
                    EncryptedSentence = EncryptedSentence +"9";
                }
                else if (Msg[control] == 'S' || Msg[control] == 's')
                {
                    EncryptedSentence = EncryptedSentence +"a";
                }
                else if (Msg[control] == 'T' || Msg[control] == 't')
                {
                    EncryptedSentence = EncryptedSentence +"b";
                }
                else if (Msg[control] == 'U' || Msg[control] == 'u')
                {
                    EncryptedSentence = EncryptedSentence +"c";
                }
                else if (Msg[control] == 'V' || Msg[control] == 'v')
                {
                    EncryptedSentence = EncryptedSentence +"d";
                }
                else if (Msg[control] == 'W' || Msg[control] == 'w')
                {
                    EncryptedSentence = EncryptedSentence +"e";
                }
                else if (Msg[control] == 'X' || Msg[control] == 'x')
                {
                    EncryptedSentence = EncryptedSentence +"f";
                }
                else if (Msg[control] == 'Y' || Msg[control] == 'y')
                {
                    EncryptedSentence = EncryptedSentence +"g";
                }
                else if (Msg[control] == 'Z' || Msg[control] == 'z')
                {
                    EncryptedSentence = EncryptedSentence +"h";
                }
            }

            StreamWriter writer =   File.CreateText(@"C:\Users\Abhin\source\repos\Secretor\secretfile.txt");
           
            writer.WriteLine(EncryptedSentence);
            writer.Close();
            //Console.WriteLine("Encryped sentence is " + EncryptedSentence);
            Console.Read();
        }
    }
}
