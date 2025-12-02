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
        static string input;

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
            PlayGame();

        }

        static void PlayGame()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                Console.Clear();

                Console.CursorVisible = true;

                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(0, 0);
                Console.WriteLine(name);

                Console.SetCursorPosition(0, 2);
                Console.WriteLine($"Question {qNumber[i]} : ");
                Console.WriteLine(questions[i]);
                Console.WriteLine(qAnswer1[i]);
                Console.WriteLine(qAnswer2[i]);
                Console.WriteLine(qAnswer3[i]);
                Console.WriteLine(qAnswer4[i]);

                Console.SetCursorPosition(0, 9);
                string answer = Console.ReadLine();
                while (!int.TryParse(answer, out numAnswer) || answer.Length > 1 || numAnswer < 1 || numAnswer > 4)
                {
                    Console.WriteLine("Wrong input, try again");
                    Console.SetCursorPosition(0, 9);
                    Console.Write("          ");
                    Console.SetCursorPosition(0, 9);
                    answer = Console.ReadLine();
                }


                if (correctAnswers[i].Equals(numAnswer))
                {
                    Console.CursorVisible = false;
                    score++;
                    Console.SetCursorPosition(0, 9);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(numAnswer);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Press any button for next question");
                    Console.ReadKey();

                }
                else
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(0, 9);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(numAnswer);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Press any button for next question");
                    Console.ReadKey();
                }


            }

            Console.Clear();
            Console.Write($"Your score is {score}/10");

            while (input != "Y" || input != "N")
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("Do you want to play again? Y/N");
                input = Console.ReadLine();

                if (input == "Y")
                {
                    score = 0;
                    PlayGame();
                }
                else if (input == "N")
                {
                    Environment.Exit(0);
                }
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
