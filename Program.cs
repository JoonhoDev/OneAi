using System;
using System.Collections.Generic;
using System.IO;

namespace OneAI
{
    class Program
    {

    
        
        static void Main(string[] args)
        {

            Console.Beep(392, 300);
            Console.Beep(415, 500);
            Console.Title = "OneAI - Deveolped by JoonhoDev";

            Console.WriteLine("Welcome to OneAI Version 2020.2 - Foundation Update");
            Console.WriteLine("NO CAPS");
            
            Console.WriteLine("Type 'l' to visit learning section");
            Console.WriteLine("Type 'c' to visit chatting section");
            Console.WriteLine("Type 'Q//' to quit");

            string w = Console.ReadLine();
            if(w == "l")
            {
                Learning();
            }
            if(w == "c")
            {
                Chat();
            }
            if(w == "Q//")
            {
                Environment.Exit(0);
            }

        }
        static void Chat()
        {
            bool isChatting = true;
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("<Chat Loading>");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("<OneAI Chat Loaded>");
            Console.WriteLine("");
            Console.WriteLine("Welcome to OneAI Chat ask me anything *Remember I am still learning through our learning software*");
            Console.WriteLine("Type Q// at any time to quit " +
                "Type 'l' to visit the learning section'");
            int showAd = 0;
            while(isChatting == true)
            {
                showAd++;
                string q = Console.ReadLine();
          
                   
                if (File.Exists(q))
                {
                    string[] allLines = File.ReadAllLines(q);
                    Random rnd1 = new Random();
                    Console.WriteLine(allLines[rnd1.Next(allLines.Length)]);



                }
                if (!File.Exists(q))
                {
                    Console.WriteLine("Sorry I don't know that yet");
                }
                
                if (q == "Q//")
                {
                    Console.WriteLine("Shutting Down :)");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                if(q == "l")
                {
                    Learning();
                }
                if(showAd == 36)
                {
                   
                    Console.WriteLine("You have reached the end of your free trial");
                    Console.WriteLine("Please purchase the full version for $3.99");
                    break;
                }
               
            }
           

        }
        static void Learning()
        {
            string one;
            string two;
            string three;
            string four;
            string five;
            string six;
            string seven;
            string eight;
            string nine;
           
          
            string Q;
           
            List<string> answerList = new List<string>();
            List<string> wordList = new List<string>();


            Console.WriteLine("OneAI is in its learning phase");
            Console.WriteLine("Please type in common 10 words");
            Console.WriteLine("Do Not Use Caps");
            one = Console.ReadLine();
            wordList.Add(one);
            two = Console.ReadLine();
            wordList.Add(two);
            three = Console.ReadLine();
            wordList.Add(three);
            four = Console.ReadLine();
            wordList.Add(four);
            five = Console.ReadLine();
            wordList.Add(five);
            six = Console.ReadLine();
            wordList.Add(six);
            seven = Console.ReadLine();
            wordList.Add(seven);
            eight = Console.ReadLine();
            wordList.Add(eight);
            nine = Console.ReadLine();
            wordList.Add(nine);

            if (!File.Exists("words"))
            {
                TextWriter TW = new StreamWriter("words");

                foreach (String s in wordList)
                    TW.WriteLine(s);

                TW.Close();

            }


            using (StreamWriter w = File.AppendText("words"))
            {
                foreach (String s in wordList)
                    w.WriteLine(s);
            }



            Console.WriteLine("Ask OneAi a simple question. " +
                "OneAI will give possible answers if the answer answers the question type 'y', if it does not type 'n'");
            Console.WriteLine("Before starting please type your question");
            Console.WriteLine("Do Not Use Caps");
            Q = Console.ReadLine();
            int times = 0;
            bool shouldGo = true;
            while(shouldGo == true)
            {
                shouldGo = false;
                times++;
                Console.WriteLine("In the context of the question is this answer true and grammatically correct y/n?");
                string[] allLines = File.ReadAllLines("words");
                Random rnd1 = new Random();
                string a = allLines[rnd1.Next(allLines.Length)];

                Console.WriteLine(a);
                
                Console.WriteLine("y/n");
                string A =  Console.ReadLine();
                if(A == "y")
                {
                    shouldGo = true;
                    if (!File.Exists(Q))
                    {
                        TextWriter TW = new StreamWriter(Q);

                      
                            TW.WriteLine(a);

                        TW.Close();

                    }

                    if (File.Exists(Q))
                    {
                        using (StreamWriter w = File.AppendText(Q))
                        {

                            w.WriteLine(a);
                        }
                    }
                   

                }
                if(A == "n")
                {
                    shouldGo = true;
                }
               if(A == "Q//")
                {
                    Environment.Exit(0);
                }
              if(times == 10)
                {
                    break;
                }
                
            }

            Console.WriteLine("Thank you for you input (processing data).");
          
           
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Processing complete");
            Console.WriteLine("Type 'c' to load chat | Type 'Q//' to quit | Type 'l' to restart the learning section");
            string cmd = Console.ReadLine();
            if (cmd == "c")
            {
                Chat();
            };
            if (cmd == "Q//")
            {
                Environment.Exit(0);
            }
           








        }

    }
}
