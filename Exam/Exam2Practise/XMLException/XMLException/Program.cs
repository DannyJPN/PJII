using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLException
{
    class Program
    {
        static void Main(string[] args)
        {
            String PersonalFolder =
   new DirectoryInfo( Environment.GetFolderPath(Environment.SpecialFolder.Personal)).Parent.FullName;
            Console.WriteLine(PersonalFolder);
            XmlTextReader xmlread = new XmlTextReader(Path.Combine(@"F:\Dropbox\UNI\VSB\VSBTUO\FEI\BC\Informační a komunikační technologie-Informatika a výpočetní technika\S4\Povinně volitelný\Programovací jazyky II\Exam\Exam2Practise\XMLException", "xmlexercise.xml"));
            Console.WriteLine(xmlread.AttributeCount);
            Console.WriteLine(xmlread.Depth);
            Console.WriteLine(xmlread.MoveToContent());
            Console.WriteLine(xmlread.MoveToFirstAttribute());
            Console.ReadLine();




        }
    }
}
