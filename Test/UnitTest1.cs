using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSave()
        {
            EngDictionary.TranslateDictionary cc = new EngDictionary.TranslateDictionary();
            EngDictionary.Menu m = new EngDictionary.Menu();
            EngDictionary.DBContext DB = new EngDictionary.DBContext();
            for (int i = 0; i < 10000; i++)
            {
              DB.Save(ref cc, m, DB);
            }
        }
    }
}
