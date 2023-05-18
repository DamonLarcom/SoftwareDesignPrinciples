using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DecoratorLab.Decorators
{
    class SignatureDecorator : Components.FileWriter
    {
        public SignatureDecorator(TextWriter writer)
            : base(writer){}

        public override void WriteLine(string s)
        {
            String signature = " ~ Damon Larcom " + DateTime.Now;
            base.WriteLine(s + signature);
        }
    }
}
