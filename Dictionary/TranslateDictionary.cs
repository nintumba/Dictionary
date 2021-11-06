using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDictionary
{
    public class TranslateDictionary
    {
        public Dictionary<string, string> dict = new Dictionary<string, string>();

        public void Add(ref TranslateDictionary cc,Menu m, DBContext DB)
        {
            System.Console.WriteLine("Введите cлово которое будет переводиться");
            string rus = System.Console.ReadLine();
            string rus1 = rus;
            if (dict.TryGetValue(rus, out rus) == true)
            {
                System.Console.WriteLine("Введите ещё один перевод");
                string eng1 = System.Console.ReadLine();

                dict[rus1] += ",";
                dict[rus1] += eng1;
                System.Console.Clear();
            }
            else
            {
        
                System.Console.WriteLine("Введите перевод");
                string eng = System.Console.ReadLine();

                dict.Add(rus1, eng);
                
                System.Console.Clear();
            }
            DB.Save(ref cc, m, DB);
        }

        public void Print(Menu m, ref TranslateDictionary cc, DBContext DB)
        {
            DB.Read(ref cc, m, DB);
        }

        public void Update(ref TranslateDictionary cc,Menu m, DBContext DB)
        {
            System.Console.WriteLine("Введите cлово которого хотите заменить");
            string word = System.Console.ReadLine();
            string wordru = word;
            if (dict.TryGetValue(word, out word) == false)
            {
                System.Console.WriteLine("Слова нет в словаре");
                System.Console.Clear();
            }
            else
            {
                dict.Remove(wordru);
                System.Console.WriteLine("Изменяем:");
                System.Console.Clear();
                cc.Add(ref cc, m,DB);
                DB.Save(ref cc, m, DB);
            }
        }

       
        public void Remove(ref TranslateDictionary cc,Menu m, DBContext DB)
        {

                System.Console.WriteLine("1 - Удалить слово");
                string Sel = System.Console.ReadLine();
                switch (Sel)
                {
                    case "1":
                    System.Console.WriteLine("Введите cлово которого хотите удалить");
                    string word = System.Console.ReadLine();
                    string WordDel = word;
                  if (dict.TryGetValue(word, out word) == false)
                  {   
                      System.Console.WriteLine("Слова нет в словаре");
                  }
                  else
                  {
                        cc.dict.Remove(WordDel);
                        DB.Save(ref cc, m, DB);
                  }
                    break;
                }
            System.Console.Clear();
        }

        public void Search(ref TranslateDictionary cc, Menu m, DBContext DB)
        {
            System.Console.WriteLine("Введите cлово перевод которого хотите найти");
            string word = System.Console.ReadLine();
            if (dict.TryGetValue(word, out word )==false)
            {
                System.Console.WriteLine("Слова нет в словаре");
            }
            else
            {
                System.Console.Write("Перевод: "); System.Console.WriteLine(word);
            }
        }

    }
}
