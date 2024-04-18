using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class DynamicArray
    {
        int?[] content;
        public DynamicArray(int size)
        {
            content = new int?[size];
        }
        public DynamicArray() : this(25)
        {

        }
        public int? this[int index]
        {
            get {
                if (index < content.Length)
                    {
                        return content[index];
                    }
                else
                    {
                    return null;
                    }
                }
            set {
                if (index < content.Length)
                    {
                       content[index] = value;
                    }
                else
                    {
                        int?[] temp = (int?[])(content.Clone());
                    //Array.Copy();
                        content = new int?[index+1];
                        for (int i = 0; i < temp.Length; i++)
                        {
                            content[i] = temp[i];
                        }
                        content[index] = value;
                    }



            }

        }


        public int Length
        {
            get { return content.Length; }
            set
            {
                if (value > content.Length)
                {
                    int?[] temp = (int?[])(content.Clone());
                    //Array.Copy();
                    content = new int?[value];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        content[i] = temp[i];
                    }
                }
                else if (value < content.Length)
                {
                    throw new InvalidOperationException("Array cannot be shrunken");

                }

            }


        }

        public override string ToString()
        {
            StringBuilder serial = new StringBuilder("");
            for (int i = 0; i < content.Length; i++)
            {
                serial.Append(content[i]==null?"NULL":content[i].ToString());
                serial.Append(",");

            }
            return serial.ToString();
        }

        public void Sum(out int result)
        {
            result = 0;
            for (int i = 0; i < content.Length; i++)
            {
                result += content[i]==null?0:content[i].Value;
            }

        }

        public void Add(ref int? res, int index)
        {
            res += content[index];


        }


        public string State
        {
            
            get
            {
                uint indicator = 0;
                for (int i = 0;i<content.Length;i++)
                {
                    if (content[i] != null)
                    {
                        indicator++;
                    }

                }
                if (indicator == 0)
                {
                    return "Empty";
                }
                else if (indicator == content.Length)
                {

                    return "Full";
                }
                else return "Partially filled";

            }


        }


    }
}
