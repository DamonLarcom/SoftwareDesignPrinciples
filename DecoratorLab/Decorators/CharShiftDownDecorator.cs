using DecoratorLab.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DecoratorLab.Decorators
{
    class CharShiftDownDecorator : FileReader
    {
        public CharShiftDownDecorator(TextReader reader)
            : base(reader) { }

        public override string ReadLine()
        {
            char[] linechars = base.ReadLine().ToCharArray();
            for(int i = 0; i < linechars.Length; i++)
            {
                linechars[i] = (char)(linechars[i] - 1);
            }

            return string.Join("", linechars);
        }
    }
}
