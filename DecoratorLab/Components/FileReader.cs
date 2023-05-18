using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DecoratorLab.Components
{
    class FileReader : TextReader
    {
        private TextReader reader;

        public FileReader(TextReader reader)
        {
            this.reader = reader;
        }

        public override string ReadLine()
        {
            return reader.ReadLine();
        }

        public override void Close()
        {
            reader.Close();
        }
    }
}
