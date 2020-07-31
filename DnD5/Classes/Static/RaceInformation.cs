using DnD5.UserStrings;

/// <summary>
/// Dungeons and Dragons 5th Edition Namespace.
/// </summary>
namespace DnD5
{
    /// <summary>
    /// Provides a means to getting string resource values for Race Type enum.
    /// </summary>
    public static class RaceInformation
    {
        /// <summary>
        /// Get the string description associated with RaceType enum.
        /// </summary>
        /// <param name="which">Which type of race do we want the string of?</param>
        /// <returns>Null, or the appropriate resource value.</returns>
        public static string GetDescription(RaceTypes which)
        {
            switch (which)
            {
                case RaceTypes.Dragonborn: return RaceStrings.Dragonborn;
                case RaceTypes.Dwarf: return RaceStrings.Dwarf;
                case RaceTypes.Elf: return RaceStrings.Elf;
                case RaceTypes.Gnome: return RaceStrings.Gnome;
                case RaceTypes.HalfElf: return RaceStrings.HalfElf;
                case RaceTypes.Halfling: return RaceStrings.Halfling;
                case RaceTypes.HalfOrc: return RaceStrings.HalfOrc;
                case RaceTypes.Human: return RaceStrings.Human;
                case RaceTypes.Tiefling: return RaceStrings.Tiefling;
                default: return null;
            }
        }
    }
}
