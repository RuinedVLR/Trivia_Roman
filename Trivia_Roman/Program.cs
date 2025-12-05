using System;
using System.Threading;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Trivia_Roman
{
    internal class Program
    {
        static int[] qNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static List<string> questions = new List<string>();
        static List<string> qAnswer1 = new List<string>();
        static List<string> qAnswer2 = new List<string>();
        static List<string> qAnswer3 = new List<string>();
        static List<string> qAnswer4 = new List<string>();
        static List<int> correctAnswers = new List<int>();

        static int score;
        static int numAnswer;
        static string name = "";

        static void Main(string[] args)
        {
            while (name.Length <= 0 || name.Length > 15)
            {
                Console.Clear();
                Console.Write("Enter your name: ");
                Console.SetCursorPosition(17, 0);
                name = Console.ReadLine();
            }

            AddQuestions();
            do
            {
                score = 0;
                PlayGame();
            }
            while (AskPlayAgain());
        }

        static void PlayGame()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                Console.Clear();

                Console.CursorVisible = true;

                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(0, 0);
                Console.Write($"«««««");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("»»»»»                     ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Score: {score}/10");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Question {qNumber[i]} : ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(questions[i]);
                Console.WriteLine(qAnswer1[i]);
                Console.WriteLine(qAnswer2[i]);
                Console.WriteLine(qAnswer3[i]);
                Console.WriteLine(qAnswer4[i]);

                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------");

                Console.SetCursorPosition(0, 11);
                string answer = Console.ReadLine();

                if (answer == "Michael Tweedale")
                {
                    Console.Clear();
                    Console.WriteLine("Easter Egg Found! +5 Points!");
                    Console.WriteLine();
                    Console.ReadKey(true);

                    Console.WriteLine("What??? No, I didn't proggram that in...");
                    Console.ReadKey(true);
                    Console.WriteLine("You don't deserve those points anyway.");
                    Console.ReadKey(true);
                    Console.WriteLine("Get the hell out of here!");
                    Console.ReadKey(true);

                    Environment.Exit(0);
                }

                while (!int.TryParse(answer, out numAnswer) || answer.Length > 1 || numAnswer < 1 || numAnswer > 4)
                {
                    Console.WriteLine("Wrong input, try again");
                    Console.SetCursorPosition(0, 11);
                    Console.Write("                                                                          ");
                    Console.SetCursorPosition(0, 11);
                    answer = Console.ReadLine();
                }


                if (correctAnswers[i].Equals(numAnswer))
                {
                    Console.CursorVisible = false;
                    score++;
                    Console.SetCursorPosition(0, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(numAnswer);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, 13);
                    Console.WriteLine("Press any button for next question");
                    Console.ReadKey();

                }
                else
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(0, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(numAnswer);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, 13);
                    Console.WriteLine("Press any button for next question");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            if(score == 10)
            {
                Console.WriteLine($"Your score is {score}/10");
                Console.WriteLine("Perfect score! Congratulations!");
            }
            else if(score >= 7)
            {
                Console.WriteLine($"Your score is {score}/10");
                Console.WriteLine("Well done!");
            }
            else if(score >= 4)
            {
                Console.WriteLine($"Your score is {score}/10");
                Console.WriteLine("Not bad, but you can do better!");
            }
            else
            {
                Console.WriteLine($"Your score is {score}/10");
                Console.WriteLine("Better luck next time!");
            }
        }

        static bool AskPlayAgain()
        {
            while (true)
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine();
                Console.WriteLine("Do you want to play again? Y/N");
                string answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine("Wrong input, try again");
                    continue;
                }

                answer = answer.Trim().ToUpperInvariant();

                if (answer == "Y") return true;

                if (answer == "N") return false;

                Console.WriteLine("Wrong input, try again");
            }
        }

        static void AddQuestions()
        {
            questions.Add("What is our Game Programming teacher name?");
            qAnswer1.Add("1: Sam");
            qAnswer2.Add("2: Bob");
            qAnswer3.Add("3: Simon");
            qAnswer4.Add("4: Wolfeschlegelsteinhausenbergerdorff");
            correctAnswers.Add(3);

            questions.Add("Which programming language do we learn?");
            qAnswer1.Add("1: C++");
            qAnswer2.Add("2: C#");
            qAnswer3.Add("3: Python");
            qAnswer4.Add("4: Java");
            correctAnswers.Add(2);

            questions.Add("What operator is making any condition NOT?");
            qAnswer1.Add("1: !");
            qAnswer2.Add("2: &&");
            qAnswer3.Add("3: ||");
            qAnswer4.Add("4: $");
            correctAnswers.Add(1);

            questions.Add("How do you take notes in code?");
            qAnswer1.Add("1: ++");
            qAnswer2.Add("2: %");
            qAnswer3.Add("3: ()");
            qAnswer4.Add("4: //");
            correctAnswers.Add(4);

            questions.Add("What variable is this (,)?");
            qAnswer1.Add("1: int");
            qAnswer2.Add("2: touple");
            qAnswer3.Add("3: string");
            qAnswer4.Add("4: array");
            correctAnswers.Add(2);

            questions.Add("What does ? operator represents?");
            qAnswer1.Add("1: nothing");
            qAnswer2.Add("2: if statement");
            qAnswer3.Add("3: while loop");
            qAnswer4.Add("4: error sign");
            correctAnswers.Add(2);

            questions.Add("What digit system we use in programming?");
            qAnswer1.Add("1: regular");
            qAnswer2.Add("2: hue system");
            qAnswer3.Add("3: romanian counting system");
            qAnswer4.Add("4: binary system");
            correctAnswers.Add(4);

            questions.Add(@"What does \n stands for?");
            qAnswer1.Add("1: I don't know");
            qAnswer2.Add("2: another shortcut for comments");
            qAnswer3.Add("3: new line");
            qAnswer4.Add("4: variable class");
            correctAnswers.Add(3);

            questions.Add("Which one is the right way to print out text in C#?");
            qAnswer1.Add("1: Console.Print(...);");
            qAnswer2.Add("2: print(...);");
            qAnswer3.Add("3: <a> ... </a>");
            qAnswer4.Add("4: Console.Write(...)");
            correctAnswers.Add(4);

            questions.Add("Which one is odd?");
            qAnswer1.Add("1: hor hor hor hor");
            qAnswer2.Add("2: 67");
            qAnswer3.Add("3: frody fuzber");
            qAnswer4.Add("4: WAS THAT THE BITE OF 87");
            correctAnswers.Add(2);


        }

    }
}
