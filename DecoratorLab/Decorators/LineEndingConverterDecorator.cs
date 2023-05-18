using DecoratorLab.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DecoratorLab.Decorators
{
    class LineEndingConverterDecorator : FileReader
    {
        public LineEndingConverterDecorator(TextReader reader)
            : base(reader) { }

        public override string ReadLine()
        {
            List<char> linechars = base.ReadLine().ToList();
            foreach(char c in linechars)
            {
                if((int)c == 13)
                {
                    linechars.Remove(c);
                }
            }
            return String.Join("", linechars);
        }
    }
}
