using IteratorCompositeLab.Components;
using IteratorCompositeLab.Interfaces;
using System;

namespace IteratorCompositeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite();

            //create categories
            IComponent sports = new Composite();
            IComponent programming = new Composite();
            IComponent movies = new Composite();
            IComponent history = new Composite();

            //add categories to root
            root.Add(sports);
            root.Add(programming);
            root.Add(movies);
            root.Add(history);

            sports.Add(new Leaf(new Question("Who won the 2021 World Series?", "Chicago Cubs", "Atlanta Braves", "New York Yankees", 2)));
            sports.Add(new Leaf(new Question("Which NFL QB has the most superbowl wins?", "Tom Brady", "Brett Favre", "Joe Montana", 1)));
            sports.Add(new Leaf(new Question("Which NHL team started play in 2021?", "Chicago Blackhawks", "Las Vegas Golden Knights", "Seattle Kraken", 3)));
            sports.Add(new Leaf(new Question(" What’s the diameter of a basketball hoop in inches?", "15","18","16",2)));

            programming.Add(new Leaf(new Question("Which of these is a Python control flow statement type?", "elif", "else if", "case",1)));
            programming.Add(new Leaf(new Question("What HTML tag is used to add CSS styling to a page?","div","nav","style",3)));
            programming.Add(new Leaf(new Question("Which of these is a reserved Java keyword?", "code","goto","biginteger",2)));
            programming.Add(new Leaf(new Question("Which of these languages was created by Google?", "Go","C++","Java", 1)));

            movies.Add(new Leaf(new Question("For what movie did Tom Hanks score his first Academy Award nomination?", "BIG", "Castaway","Forrest Gump", 1)));
            movies.Add(new Leaf(new Question("Where were The Lord of the Rings movies filmed?", "Iceland", "Ireland", "New Zealand", 3)));
            movies.Add(new Leaf(new Question("Freddy Krueger wears a striped sweater that is which colors?", "Red and green", "Orange and green", "Red and blue", 1)));
            movies.Add(new Leaf(new Question("What item is in every Fight Club scene?", "A Dunkin’ donut", "A Coca-Cola can", "A Starbucks cup", 3)));

            history.Add(new Leaf(new Question("What year did the United States gain independence?","1950","1776","1778", 2)));
            history.Add(new Leaf(new Question("Who was the first man on the moon?","Neil Armstrong","Tom Hanks","Barack Obama", 1)));
            history.Add(new Leaf(new Question("How many original colonies were there?","11","12","13", 3)));
            history.Add(new Leaf(new Question("Who invented the lightbulb?","George Washington", "Thomas Edison", "Nikola Tesla", 2)));

            IIterator iterator = root.GetIterator();
            int questionNum = 1;
            int correctNum = 0;
            while(iterator.HasNext())
            {
                Console.WriteLine($"Question {questionNum} of 16");
                Console.WriteLine($"Number Correct: {correctNum}\n");
                IComponent comp = iterator.Next();

                Console.Write("Enter number of answer: ");
                string input = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------");
                if (comp.GetQuestion().isCorrect(input.Trim()))
                {
                    correctNum++;
                    Console.WriteLine("--Correct!--");
                } else
                {
                    Console.WriteLine("--Incorrect!--");
                }
                questionNum++;
                Console.WriteLine("---------------------------------------------------------------");
            }
            Console.WriteLine($"Total number correct: {correctNum} of 16");
            Console.ReadLine();
        }
    }
}
