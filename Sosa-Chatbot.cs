using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Microsoft.Win32;
using System.Xml.Linq;

namespace chatBot
{
    
    class Program
    {

        static void graphic()
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" ________                            ");
            Console.WriteLine("|        |                         ");
            Console.WriteLine("|    ____|                          ");
            Console.WriteLine("|   |_____  ___^___^___  _________  ___________                                                       ");
            Console.WriteLine("|         | |         | |   ______||    ___    |     _____  __     __  ________  ________  _________  ______  ________ ");
            Console.WriteLine("|____     | | [0] [0] | |  |______ |   |___|   |    |     ||  |   |  ||   __   ||__    __||    _    ||      ||__    __|");
            Console.WriteLine("     |    |[|         |]|____     ||    ___    |    |   __||  |___|  ||  |__|  |   |  |   |   |_|  _|[0]  [0]   |  |");
            Console.WriteLine(" ____|    | |    <    |      |    ||   |   |   |    |  |__ |   ___   ||        |   |  |   |    _  |_ |  <   |   |  |");
            Console.WriteLine("|         | |  [---]  |  ____|    ||   |   |   |    |     ||  |   |  ||   __   |   |  |   |   |_|   ||  U   |   |  |");
            Console.WriteLine("|_________| |_________| |_________||___|   |___|    |_____||__|   |__||__|  |__|   |__|   |_________||______|   |__|");
            Console.WriteLine("WELCOME TO SOSA CHATBOT CYBERSECURITY");
            Console.ResetColor();

        }
        static string getAnswer(string Question)
        {

            string Answer;
            if ( Question.Contains("password") )
            {
                Answer = "A strong and unique password prevents attackers from easily guessing or reusing compromised credentials to gain access to multiple accounts.";
            }
            else if (Question.Contains("hacking"))
            {
                Answer = "Hacking is the process of exploiting vulnerabilities in a computer system, network, or software to gain unauthorized access, steal data, or disrupt operations.";
            }
            else if (Question.Contains("phishing"))
            {
                Answer = "Phishing is a cyber-attack where attackers trick users into revealing sensitive information, such as passwords or financial details, through fake emails, messages, or websites.";
            }
            else
            {
                Answer = "No information on this yet";
            }

            return Answer;
            
        }

        static void voiceIntro()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Admin\Desktop\schoolProjects\practice\chatBot\chatBot\bin\Debug\lwazi.wav");
            simpleSound.Play();
        }
        static void Main(string[] args)
        {
            voiceIntro();

            graphic();


            Console.WriteLine("Hello; how can I help you today?");
            Thread.Sleep(5000);
            Console.Write("Before we start I'd like to know your name: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"What would you like to know about security {Name} ?");
            string Question = Console.ReadLine();

            Console.WriteLine( getAnswer(Question) );
            Console.WriteLine($"Anymore security {Name} ? please type no to stop chatbot");
            Question = Console.ReadLine();

            while (Question != "no")
            {
                Console.WriteLine(getAnswer(Question));
                Console.WriteLine($"Anymore security questions {Name} ? please type no to stop chatbot");
                Question = Console.ReadLine();
            }
            Console.WriteLine("Thank you");

        }
    }
}
