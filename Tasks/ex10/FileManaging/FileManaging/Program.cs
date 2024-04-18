using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManaging
{
    class Program
    {
        static void Main(string[] args)
        {

            Contact[] contacts = new Contact[]
                {
                    new Contact("Jan",50,"jan@seznam.cz",97.2,true),
                    new Contact("Jana",22,"jana@seznam.cz",45.81,true),
                    new Contact("Honza",88,"Honza@seznam.cz",72,true),
                    new Contact("Jarka",50,"jarka@seznam.cz",65,false)



                };


            FileStream fs = new FileStream("./contactlist.csv",FileMode.Create);

            StreamWriter sw = new StreamWriter(fs,Encoding.Default,2048,true);

            for (int i = 0; i < contacts.Length; i++)
            {
                sw.WriteLine("{0};{1};{2};{3};{4};", 
                    contacts[i].Name, contacts[i].Age, contacts[i].Email, contacts[i].Weight, contacts[i].IsAlive);

            }

            sw.Close();

            fs.Seek(0, SeekOrigin.Begin);

            StreamReader sr = new StreamReader(fs,Encoding.Default);

            List<Contact> newcontacts = new List<Contact>();
            string[] line;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine().Split(';');
                newcontacts.Add(new Contact(line[0], Convert.ToByte(line[1]), line[2], Convert.ToDouble(line[3]), Convert.ToBoolean(line[4])));
            }
            sr.Close();
            for (int i = 0; i < newcontacts.Count(); i++)
            {
                Console.WriteLine("{0};{1};{2};{3};{4};",
                    contacts[i].Name, contacts[i].Age, contacts[i].Email, contacts[i].Weight, contacts[i].IsAlive);
            }
            

            FileStream fb = new FileStream("./contactlist.bin", FileMode.Create);

            BinaryWriter bw = new BinaryWriter(fb,Encoding.Default,true);

            bw.Write(contacts.Length);
            for (int i = 0; i < contacts.Length; i++)
            {
                bw.Write(String.Format("{0};{1};{2};{3};{4};",
                    contacts[i].Name, contacts[i].Age, contacts[i].Email, contacts[i].Weight, contacts[i].IsAlive));

            }
            bw.Close();
            fb.Seek(0, SeekOrigin.Begin);

            BinaryReader br = new BinaryReader(fb);
            int count = br.ReadInt32();
            List<Contact> newbincontacts = new List<Contact>();
            
            for (int i = 0; i < count; i++)
            {
                newbincontacts.Add(new Contact(br.ReadString(), br.ReadByte(), br.ReadString(), br.ReadDouble(), br.ReadBoolean() ));

            }
            br.Close();

        }
    }
}
