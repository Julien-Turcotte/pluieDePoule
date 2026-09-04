class Program
{
    public static List<Poule> poules = new List<Poule>();
    static void Main()
    {
        Random random = new Random();Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        while (true)
        {
            poules.Add(new Poule(random.Next(1, Console.WindowWidth)));
            
            foreach (Poule p in poules.ToList())
            {
                if (p.X >= Console.WindowWidth || p.Y >= Console.WindowHeight - 2)
                {
                    poules.Remove(p);
                }
                else
                {
                    try
                    {
                        Console.SetCursorPosition(p.X, p.Y); Console.Write("🐔");
                    }
                    catch { }
                }
                p.Tomber();
            }
            Thread.Sleep(3);Console.Clear();
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