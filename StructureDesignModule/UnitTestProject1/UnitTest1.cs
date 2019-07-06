using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureDesignModule;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t1 = new Technical_Demand();
            t1.Write_Info2TXT();
            var t2 = new CrossSection();
            t2.calculate_girder_parament(ref t1);
            t2.Write_Info2TXT();
            var t3 = new longitudinal_lateral_connection();
            t3.get_parameters(ref t1, ref t3, ref t2);
            t3.Write_Info2TXT();
        }
    }
}
