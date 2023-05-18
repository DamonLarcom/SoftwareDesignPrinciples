using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DecoratorLab.Decorators
{
    class CharShiftUpDecorator : Components.FileWriter
    {
        public CharShiftUpDecorator(TextWriter writer)
            : base(writer) { }

        public override void WriteLine(string s)
        {
            char[] chars = s.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] + 1);
            }
            string word = string.Join("", chars);
            base.WriteLine(word);
        }
    }
}
