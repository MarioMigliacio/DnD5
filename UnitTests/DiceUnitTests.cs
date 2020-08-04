using Microsoft.VisualStudio.TestTools.UnitTesting;
using DnD5.Dice;

/// <summary>
/// Dungeons and Dragons 5th Edition Unit Tests Namespace.
/// </summary>
namespace UnitTests
{
    /// <summary>
    /// Unit tests specific to Dice object.
    /// </summary>
    [TestClass]
    public class DiceUnitTests
    {
        /// <summary>
        /// Ensure that range of dice rolls never exceed threshold, or fall below minimum.
        /// </summary>
        [TestMethod]
        public void TestDiceBoundaries()
        {
            int d2 = 0, d4 = 0, d6 = 0, d8 = 0, d10 = 0, d12 = 0, d20 = 0, d100 = 0;
            bool fail = false;

            // rolling one hundred thousand times is sufficient.
            for (int i = 0; i < 100000; i++)
            {
                d2 = Dice.D2;
                d4 = Dice.D4;
                d6 = Dice.D6;
                d8 = Dice.D8;
                d10 = Dice.D10;
                d12 = Dice.D12;
                d20 = Dice.D20;
                d100 = Dice.D100;

                if (d2 > 2 || d2 < 1 ||
                    d4 > 4 || d4 < 1 ||
                    d6 > 6 || d6 < 1 ||
                    d8 > 8 || d8 < 1 ||
                    d10 > 10 || d10 < 1 ||
                    d12 > 12 || d12 < 1 ||
                    d20 > 20 || d20 < 1 ||
                    d100 > 100 || d100 < 1)
                {
                    fail = true;
                }
            }

            Assert.AreEqual(fail, false);
        }
    }
}
