using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DnD5;

namespace UnitTests
{
    [TestClass]
    public class RaceTypeUnitTests
    {
        /// <summary>
        /// Test to see that we get the correct amount of RaceTypes from foreach enumeration.
        /// (excluding the None field)
        /// </summary>
        [TestMethod]
        public void EnumerateRaceTypes()
        {
            int total = 0;

            foreach (RaceTypes rt in Enum.GetValues(typeof(RaceTypes)))
            {
                if (rt != RaceTypes.None)
                {
                    total++;
                }
            }

            // for the time being, the last enumeration in the RaceTypes list is Tiefling, check the count verifies this.
            Assert.AreEqual(total, (int)RaceTypes.Tiefling);
        }

        /// <summary>
        /// Test to see that conversions to strings are predictable.
        /// </summary>
        [TestMethod]
        public void RaceTypeToString()
        {
            string testEnumStringValue = RaceTypes.Dwarf.ToString();
            Assert.AreEqual("Dwarf", testEnumStringValue);
        }

        /// <summary>
        /// Test the UserStrings value for sanity.
        /// </summary>
        [TestMethod]
        public void RaceTypeDescription()
        {
            string testRaceUserString = RaceInformation.GetDescription(RaceTypes.Dwarf);
            Assert.IsNotNull(testRaceUserString);
        }
    }
}
