using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MainPanel
{
    internal class ProcesareCaractere
    {
        internal ProcesareCaractere() { }
        internal void Initiate()
        {
            ReadInput();
            Compute();
            WriteOutput();
        }
        private string n;
        protected void ReadInput()
        {
            Console.Write("Scrieti calea fisierului: ");
            n = Console.ReadLine();
            Console.WriteLine();
            //if (n[check - 3] == 't' && n[check - 2] == 'x' && n[check - 1] == 't')
        }
        private int car, c, v, l;
        protected void Compute()
        {
            TextReader txtReader = new StreamReader(n);//26 caractere
            string buffer;
            while ((buffer = txtReader.ReadLine()) != null)
            {
                Console.WriteLine(buffer);
                l++;
                int len = buffer.Length;
                for (int i = 0; i < len; i++)
                {
                    car++;
                    if (buffer[i] == 'a' || buffer[i] == 'e' ||
                        buffer[i] == 'i' || buffer[i] == 'o' ||
                        buffer[i] == 'u' || buffer[i] == 'A' ||
                        buffer[i] == 'E' || buffer[i] == 'I' ||
                        buffer[i] == 'O' || buffer[i] == 'U')
                    {
                        v++;
                    }

                    else if ((buffer[i] >= 'a' && buffer[i] >= 'z') || (buffer[i] >= 'A' && buffer[i] >= 'Z'))
                        c++;
                }                               
            }
        }
        protected void WriteOutput()
        {
            Console.WriteLine();
            Console.WriteLine($"Numar de linii:{l}, carctere:{car}, vocale:{v}, consoane:{c}.");
        }
    }
}
