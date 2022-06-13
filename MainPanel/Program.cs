using MainPanel.Probleme;

namespace MainPanel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista probleme:");
            listaProb();
            Console.Write("Introduceti nr. problemei: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    LR prob1 = new LR(); prob1.Initiate();
                    break;
                case 2:
                    ProcesareCaractere prob2 = new ProcesareCaractere(); prob2.Initiate();
                    break;
            }
            Console.ReadKey();
        }
        protected static void listaProb()
        {
            Console.WriteLine("---");
            Console.WriteLine("1.LR");
            Console.WriteLine("2.Procesare caractere dintr-un fisier text.");
            Console.WriteLine("---");
        }
    }
}