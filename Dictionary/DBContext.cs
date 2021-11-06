using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace EngDictionary
{
    public class DBContext
    {
       public void Save(ref TranslateDictionary cc, Menu m, DBContext DB)
       {
            var points = cc.dict;

            string json = JsonConvert.SerializeObject(points, Formatting.Indented);
            File.WriteAllText("dictionary.json", json);
       }
            
        public void Read(ref TranslateDictionary cc, Menu m, DBContext DB)
        {
            var points = cc.dict;
            string json = File.ReadAllText("dictionary.json");
            cc.dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            foreach (var item in cc.dict)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
