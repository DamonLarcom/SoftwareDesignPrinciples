using DecoratorLab.Components;
using DecoratorLab.Decorators;
using System;
using System.IO;

namespace DecoratorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //test char shift up
            FileWriter writer = new CharShiftUpDecorator(new StreamWriter("C:\\Users\\Damon Larcom\\Desktop\\testfiles\\testCharShiftRead.txt"));
            writer.WriteLine("This is a test file.\r\nSecond line of test file.\r\n3rd line of test file.");
            writer.Close();

            //test signature
            writer = new SignatureDecorator(new StreamWriter("C:\\Users\\Damon Larcom\\Desktop\\testfiles\\testSig.txt"));
            writer.WriteLine("Testing Signature.");
            writer.Close();

            //make file for line endings test
            StreamWriter writer2 = new StreamWriter("C:\\Users\\Damon Larcom\\Desktop\\testfiles\\testLineEndings.txt");
            writer2.WriteLine("Line 1\r\nLine2\r\nLine3\r\n");
            writer2.Close();


            //test reading with char shift down
            FileReader reader = new CharShiftDownDecorator(new StreamReader("C:\\Users\\Damon Larcom\\Desktop\\testfiles\\testCharShiftRead.txt"));
            Console.WriteLine(reader.ReadLine());
            reader.Close();

            //test line ending converter
            reader = new LineEndingConverterDecorator(new StreamReader("C:\\Users\\Damon Larcom\\Desktop\\testfiles\\testLineEndings.txt"));
            Console.WriteLine(reader.ReadLine());
            reader.Close();
        }
    }
}
