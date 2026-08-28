using PluieDePoules;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        List<Poule> poules = new List<Poule>();

        while (true)
        {
            Poule? nouvellePoule = CreerPoule(random.Next(1, Console.WindowWidth), random.Next(0, 100));
            if (nouvellePoule != null)
            {
                poules.Add(nouvellePoule);
            }

            foreach (Poule p in poules.ToList())
            {
                if (CheckSol(p))
                {
                    poules.Remove(p);
                }
            }
            UpdateStatus(poules);
            Thread.Sleep(100);
        }
    }

    /// <summary>
    /// A 20% de chance de créer une poule
    /// </summary>
    /// <param name="x">la position horizontale de la poule</param>
    /// <param name="random">un nombre qui determine si la poule va apparaite</param>
    /// <returns>La poule si créer</returns>
    private static Poule? CreerPoule(int x, int random)
    {
        if (random < 20)
        {
            Poule p = new Poule(x);
            return p;
        }
        return null;
    }

    /// <summary>
    /// reaffiche les poules une case plus bas
    /// </summary>
    /// <param name="poules">La liste de poules sur l'écran</param>
    private static void UpdateStatus(List<Poule> poules)
    {
        Console.Clear();
        foreach(Poule p in poules)
        {
            p.Tomber();
            Console.SetCursorPosition(p.x, p.y);
            Console.Write("🐔");
        }

    }
    private static bool CheckSol(Poule poule)
    {
        return poule.y >= Console.WindowHeight - 2;
    }

}