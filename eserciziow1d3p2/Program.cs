
    //internal class program
    //{
    //    static void main(string[] args)
    //    {
    //        string[] myarr = new string[3];

    //        string nome1 = console.readline();
    //        string nome2 = console.readline();
    //        string nome3 = console.readline();

    //        myarr[0] = nome1;
    //        myarr[1] = nome2;
    //        myarr[2] = nome3;

    //        console.writeline(myarr[0]);
    //        console.writeline(myarr[1]);
    //        console.writeline(myarr[2]);



    //        console.writeline("inserisci un nome da cercare:");
    //        string nomedacercare = console.readline();

    //        bool nometrovato = cercacerca(myarr, nomedacercare);

    //        if (nometrovato)
    //        {
    //            console.writeline($"il nome '{nomedacercare}' è presente nell'array.");
    //        }
    //        else
    //        {
    //            console.writeline($"il nome '{nomedacercare}' non è presente nell'array.");
    //        }

    //    }

    //    public static bool cercacerca(string[] myarr, string nomedacercare)
    //    {
    //        foreach (string nome in myarr)
    //        {
    //            if (nome == nomedacercare)
    //            {
    //                return true;
    //            }
    //        }
    //        return false;
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scegli la dimenzione dell'array");
            int lunghezzaArray =int.Parse( Console.ReadLine());
            int[] myArr = new int[ lunghezzaArray ];

            for(int i = 0; i < lunghezzaArray; i++)
            {
                Console.WriteLine("Scrivi un numero");
                myArr[i] = int.Parse(Console.ReadLine());  
            }

            int somma = 0;

            for(int i = 0;i < lunghezzaArray;i++)
            {
                somma += myArr[i];
            }

            Console.WriteLine($"la somma è {somma}");

            Console.WriteLine($"la media aritmetica è {somma / lunghezzaArray}");
        }
    }

