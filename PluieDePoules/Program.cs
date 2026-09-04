class Program
{
    public static List<Poule> poules = new List<Poule>();
    static void Main()
    {
        Random random = new Random();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        while (true)
        {
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            poules.Add(new Poule(random.Next(width)));

            Console.Clear();

            for (int i = poules.Count - 1; i >= 0; i--)
            {
                Poule p = poules[i];

                if (p.Y >= height - 2)
                {
                    poules.RemoveAt(i);
                    continue;
                }
                try
                {
                    Console.SetCursorPosition(p.X, p.Y);
                    Console.Write("🐔");
                }
                catch (ArgumentOutOfRangeException){}
                p.Tomber();
            }
        }
    }
}
public class Poule
{   
    public int X { get; set; }
    public int Y { get; set; }

    public Poule(int x, int y = 0)
    {
        X = x;
        Y = y;
    }
    public void Tomber() => Y++;
}