using NUnit.Framework;
using ExesandOhs.main;

namespace Tests
{
    public class Tests
    {
        public XOCounter XandO = new XOCounter();

        [Test, Description("Input should return true only if the amounto 'x's matches the amount 'o's")]
        public void QuantitativeTest()
        {
            Assert.IsFalse(XandO.XO("xoxp"), "Diferent amounts of 'x' and 'o' should return false");
            Assert.IsFalse(XandO.XO("fxpt"), "Diferent amounts of 'x' and 'o' should return false");
            Assert.IsFalse(XandO.XO("xoxoxoro"), "Diferent amounts of 'x' and 'o' should return false");
            Assert.IsFalse(XandO.XO("xororo"), "Diferent amounts of 'x' and 'o' should return false");
            Assert.IsFalse(XandO.XO("x.ro-o"), "Diferent amounts of 'x' and 'o' should return false");
        }

        [Test, Description("If quantities match, should return true regardless of character casing")]
        public void CaseSentivenessTest()
        {
            Assert.IsTrue(XandO.XO("XoXo"), "Should be true regardless of casing");
            Assert.IsTrue(XandO.XO("xOxO"), "Should be true regardless of casing");
            Assert.IsTrue(XandO.XO("XOxo"), "Should be true regardless of casing");
            Assert.IsTrue(XandO.XO("XoXoxO"), "Should be true regardless of casing");
            Assert.IsTrue(XandO.XO("XOxoXO"), "Should be true regardless of casing");
            Assert.IsTrue(XandO.XO("xOxXOO"), "Should be true regardless of casing");
        }
    }
}