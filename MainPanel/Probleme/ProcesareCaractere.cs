using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MainPanel.Probleme
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
        private string n,m;
        protected void ReadInput()
        {
            Console.Write("Scrieti calea completa fisierului: ");//ex: C:\...\...\...\...\OOP_Tema\MainPanel\Probleme\test.txt
            n = Console.ReadLine();
            Console.Write("Doriti sa vedeti si continutul fisierului?(d/n): ");
            m = Console.ReadLine();
            Console.WriteLine("-------");
        }
        private int car, c, v, l;
        protected void Compute()
        {
            TextReader txtReader = new StreamReader(n);
            string buffer;
            if(m == "d")
                while ((buffer = txtReader.ReadLine()) != null) { Console.WriteLine(buffer); }

            txtReader.Close(); txtReader = new StreamReader(n);
            while ((buffer = txtReader.ReadLine()) != null)
            {
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
                    else if (buffer[i] >= 'a' && buffer[i] >= 'z' || buffer[i] >= 'A' && buffer[i] >= 'Z')
                        c++;
                }
            }
        }
        protected void WriteOutput()
        {
            Console.WriteLine("-------");
            Console.WriteLine($"Numar de linii: {l}, carctere: {car}, vocale: {v}, consoane: {c}.");
        }
    }
}
