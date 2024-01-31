namespace eserciziow1d3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            ContoCorrente utente = new ContoCorrente();

            while (continua)
            {
                Console.WriteLine("Menu ATM");
                Console.WriteLine("1. Crea Conto");
                Console.WriteLine("2. Visualizza Saldo");
                Console.WriteLine("3. Prelevamento");
                Console.WriteLine("4. Deposita");
                Console.WriteLine("5. Esci");

                Console.WriteLine("Scegli una opzione (1-5)");

                string scelta = Console.ReadLine();
                Console.Clear();

                switch (scelta)
                {
                    case "1":
                        Console.Write("Apertura conto:\n- Nome: ");
                        string name = Console.ReadLine();
                        Console.Write("- Cognome: ");
                        string cognome = Console.ReadLine();

                        utente.Name = name;
                        utente.Surname = cognome;
                        utente.Account();

                        Console.WriteLine(utente.IsOpen ? "Il conto è stato creato con successo!" : "Il conto è già aperto.");
                        break;

                    case "2":
                        Console.WriteLine(utente.CheckBalance());
                        break;

                    case "3":
                        Console.Write("Quanto desideri prelevare? ");
                        if (int.TryParse(Console.ReadLine(), out int withdrawAmount))
                        {
                            Console.WriteLine(utente.Withdraw(withdrawAmount));
                        }
                        else
                        {
                            Console.WriteLine("Inserisci un importo valido.");
                        }
                        break;

                    case "4":
                        Console.Write("Quanto desideri depositare? ");
                        if (int.TryParse(Console.ReadLine(), out int depositAmount))
                        {
                            Console.WriteLine(utente.Deposit(depositAmount));
                        }
                        else
                        {
                            Console.WriteLine("Inserisci un importo valido.");
                        }
                        break;

                    case "5":
                        continua = false;
                        Console.WriteLine("Grazie per aver utilizzato il nostro servizio.");
                        break;

                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;
                }
            }
        }
    }

    class ContoCorrente
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int Balance { get; set; }
        public bool IsOpen { get; private set; }

        public string CheckBalance()
        {
            return IsOpen ? $"Il tuo saldo attuale è {Balance}" : "Non esiste nessun conto.";
        }

        public void Account()
        {
            if (!IsOpen)
            {
                IsOpen = true;
            }
        }

        public string Withdraw(int amount)
        {
            if (IsOpen)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    return $"Il tuo prelievo di {amount} è andato a buon fine.";
                }
                else
                {
                    return "Non hai abbastanza fondi sul conto.";
                }
            }
            else
            {
                return "Non esiste nessun conto.";
            }
        }

        public string Deposit(int amount)
        {
            if (IsOpen)
            {
                if (amount >= 1000)
                {
                    Balance += amount;
                    return "Il deposito è andato a buon fine!";
                }
                else
                {
                    return "Devi depositare almeno 1000.";
                }
            }
            else
            {
                return "Non esiste nessun conto.";
            }
        }
    }
}