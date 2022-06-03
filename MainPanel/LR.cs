using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPanel
{
    internal class LR
    {
        internal LR() { }
        internal void Initiate()
        {
            ReadInput();
            Compute();
            WriteOutput();
        }
        int n,c;
        int[] v, L, R;
        string[] data;
        protected void ReadInput()
        {
            Console.WriteLine("-LR-");
            Console.WriteLine();
            Console.WriteLine("Introduceti datele necesare(cate numere contine sirul; dupa sirul de nr despartite de un spatiu):");
            n = int.Parse(Console.ReadLine());
            data = new string[n];
            data = Console.ReadLine().Split(' ');
            v = new int[n];
            L = new int[n];
            R = new int[n];
            c = 0;
        }
        protected void Compute()
        {
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (v[i] >= a)
                {
                    a = v[i];
                    L[i] = a;
                }
                else
                    L[i] = a;
            }
            int b = v[n - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                if (b > v[i])
                {
                    b = v[i];
                    R[i] = b;
                }
                else
                    R[i] = b;
            }
            for (int i = 0; i < n; i++)
                if (R[i] == L[i])
                    c++;                 
        }
        protected void WriteOutput()
        {
            for (int i = 0; i < n; i++)
                Console.Write(L[i] + " ");
            Console.Write(":L");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.Write(R[i] + " ");
            Console.Write(":R");
            Console.WriteLine();
            Console.WriteLine($"Nr. de elemente LR: {c}");
        }
    }
}
