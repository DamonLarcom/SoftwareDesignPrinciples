using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DecoratorLab.Components
{
    abstract class FileWriter : TextWriter
    {
        private TextWriter writer;
        public override Encoding Encoding => throw new NotImplementedException();

        public FileWriter(TextWriter writer)
        {
            this.writer = writer;
        }

        public override void WriteLine(String s) 
        {
            writer.WriteLine(s);
        }

        public override void Close()
        {
            writer.Close();
        }
    }
}
