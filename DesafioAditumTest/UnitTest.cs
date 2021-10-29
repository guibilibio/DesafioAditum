using System;
using Xunit;
using Desafio_Aditum.Util;

namespace Desafio_Aditum.Util
{
    public class UnitTest
    {
        [Fact]
        public void TestAppUtil_readDate()
        {
            String DtStr = "10:51";
            DateTime dt = AppUtil.readDate(DtStr);
            Assert.Contains(DtStr, dt.ToString());
        }

        [Fact]
        public void TestAppUtil_readInt()
        {
            string opStr = "11";
            int op = AppUtil.readint(opStr);
            Assert.Contains(opStr, op.ToString());
        }
    }
}
