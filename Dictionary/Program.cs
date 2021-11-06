using System;
using System.Threading;

namespace EngDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            TranslateDictionary cc = new TranslateDictionary();
            DBContext DB = new DBContext();
            Menu m = new Menu();
            m.Cover();
            System.Console.Clear();
            m.SwitchCommand(ref cc, m, DB);
        }
    }
}
