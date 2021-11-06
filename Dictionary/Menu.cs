using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDictionary
{

   
    public class Menu
    {  
        public void Cover()
        {
           System.Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t-----------------------------------------");
           System.Console.WriteLine("\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\tРусско-Английский словарь\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|\n\t\t\t\t\t\t|\t\t\t\t\t|");
           System.Console.WriteLine("\t\t\t\t\t\t-----------------------------------------");
        }


        public static ConsoleKey ShowMenu()
       {

            System.Console.WriteLine("Выберите действие: W - Показать словарь, E - Добавить перевод, R - Обновить значение, T - Удалить, Y - Поиск, U - Сохранить, I - Считать с файла, Q - Выход ");
            ConsoleKey Ret = Console.ReadKey().Key;
            Console.WriteLine("\n ------------ \n");
            return Ret;
       }


        public void SwitchCommand(ref TranslateDictionary cc, Menu m, DBContext DB)
        {
            while (true)
            {

                switch (ShowMenu())
                {
                    case ConsoleKey.W:
                        cc.Print(m, ref cc, DB);
                             break;
                    case ConsoleKey.E:
                        cc.Add( ref cc, m, DB);
                        break;
                    case ConsoleKey.R:
                        cc.Update(ref cc, m, DB);
                        break;
                    case ConsoleKey.T:
                        cc.Remove(ref cc, m, DB);
                        break;
                    case ConsoleKey.Y:
                        cc.Search(ref cc, m, DB);
                        break;
                    case ConsoleKey.U:
                        DB.Save(ref cc, m, DB);
                        break;
                    case ConsoleKey.I:
                        DB.Read(ref cc, m, DB);
                        break;
                    case ConsoleKey.Q:
                        return;
                }
            }
        }
    }
}