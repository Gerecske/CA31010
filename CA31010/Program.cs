using System.Drawing;

namespace CA31010
{
    class Allat
    {

    }
    public class Macska: Allat, ILogable, ITzdKöszönni
    {
        public ConsoleColor Szin { get; set; }
        public string Nev { get; set; }
        public Point pozition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Koszon(string nev)
        {
            throw new NotImplementedException();
        }

        public void Nyavog()
        {
            Console.ForegroundColor = this.Szin;
            Console.WriteLine("Miau-Miau");
            Console.ResetColor();
        }
    }

    public class Kocsog : ILogable
    {
        public bool Torott { get; set; } = false;
        public string Anyag { get; set; }

        private int _y;
        private int _x;

    }

    public interface ILogable
    {
        public Point pozition { get; set; }

    }
    public interface ITzdKöszönni
    {
        public void Koszon(string nev);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}