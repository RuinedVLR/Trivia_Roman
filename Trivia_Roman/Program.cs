using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static string name;

        static void Main(string[] args)
        {

            name = Console.ReadLine();

            AddQuestions();
            PlayGame();

        }

        static void PlayGame()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"Question {qNumber[i]} : ");
                Console.Write(questions[i]);
                Console.WriteLine(qAnswer1[i]);
                Console.WriteLine(qAnswer2[i]);
                Console.WriteLine(qAnswer3[i]);
                Console.WriteLine(qAnswer4[i]);
                string answer = Console.ReadLine();
            }
        }

        static void AddQuestions()
        {
            questions.Add("What is our Game Programming teacher name?");
            qAnswer1.Add("1: Sam");
            qAnswer2.Add("2: Bob");
            qAnswer3.Add("3: Simon");
            qAnswer4.Add("4: Wolfeschlegelsteinhausenbergerdorff");

            questions.Add("Which programming language do we learn?");
            qAnswer1.Add("1: C++");
            qAnswer2.Add("2: C#");
            qAnswer3.Add("3: Python");
            qAnswer4.Add("4: Java");

            questions.Add("What operator is making any condition NOT?");
            qAnswer1.Add("1: !");
            qAnswer2.Add("2: &&");
            qAnswer3.Add("3: ||");
            qAnswer4.Add("4: $");

            questions.Add("How do you take notes in code?");
            qAnswer1.Add("1: ++");
            qAnswer2.Add("2: %");
            qAnswer3.Add("3: ()");
            qAnswer4.Add("4: //");

            questions.Add("What variable is this (,)?");
            qAnswer1.Add("1: int");
            qAnswer2.Add("2: touple");
            qAnswer3.Add("3: string");
            qAnswer4.Add("4: array");

            questions.Add("What does ? operator represents?");
            qAnswer1.Add("1: nothing");
            qAnswer2.Add("2: if statement");
            qAnswer3.Add("3: while loop");
            qAnswer4.Add("4: error sign");

            questions.Add("What digit system we use in programming?");
            qAnswer1.Add("1: regular");
            qAnswer2.Add("2: hue system");
            qAnswer3.Add("3: romanian counting system");
            qAnswer4.Add("4: binary system");

            questions.Add(@"What does \n stands for?");
            qAnswer1.Add("1: I don't know");
            qAnswer2.Add("2: another shortcut for comments");
            qAnswer3.Add("3: new line");
            qAnswer4.Add("4: ");

            questions.Add("How do you take notes in code?");
            qAnswer1.Add("1: ++");
            qAnswer2.Add("2: %");
            qAnswer3.Add("3: ()");
            qAnswer4.Add("4: //");

            questions.Add("How do you take notes in code?");
            qAnswer1.Add("1: ++");
            qAnswer2.Add("2: %");
            qAnswer3.Add("3: ()");
            qAnswer4.Add("4: //");

            
        }

    }
}
