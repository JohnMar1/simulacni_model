namespace banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eight = 0.04;
            double nine = 0.10;
            double ten = 0.15;
            double eleven = 0.08;
            double twelve = 0.10;
            double thirteen = 0.06;
            double fourteen = 0.09;
            double fifteen = 0.14;
            double sixteen = 0.10;
            double seventeen = 0.12;
            double eighteen = 0.02;
            List<double> zakazniciCetnost = new List<double> { eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen };
            int customers = 250;
            List<int> zakaznici = new List<int>();
            foreach (var item in zakazniciCetnost)
            {
                zakaznici.Add((int)Math.Ceiling(item * customers));
            }
            
            foreach (var item in zakaznici)
            {
                Console.WriteLine(item);
            }
            Random random = new Random();
            foreach(var hodina in zakaznici)
            {
                for (int i = 0; i < hodina; i++)
                {
                    int wait = random.Next(5, 15);
                    
                }
            }
        }
    }
}
