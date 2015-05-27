using System;
using System.IO;
using TmxMapperPCL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileStream fstream = new FileStream("../../map1.tmx", FileMode.Open, FileAccess.Read);
            Map map = Map.Load(fstream);

            int height = map.Height;
        }
    }
}
