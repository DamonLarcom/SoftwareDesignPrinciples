using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorCompositeLab.Components
{
    public class Question
    {
        public string prompt;
        public string option1;
        public string option2;
        public string option3;
        public int correct;

        public Question(string prompt, string option1, string option2, string option3, int correct)
        {
            this.prompt = prompt;
            this.option1 = option1;
            this.option2 = option2;
            this.option3 = option3;
            this.correct = correct;
        }

        public bool isCorrect(string selected)
        {
            return int.Parse(selected.Trim()) == correct;
        }

        
        public override string ToString()
        {
            return String.Format("--{0}--\n 1.{1}\n 2.{2}\n 3.{3}", prompt, option1, option2, option3);
        }
    }
}
