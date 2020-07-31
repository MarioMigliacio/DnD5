using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

/// <summary>
/// Dungeons and Dragons 5th Edition Namespace.
/// </summary>
namespace DnD5
{
    /// <summary>
    /// The various types of Races for playable character Types available.
    /// (Is convertable to strings for simplistic Json serialization)
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RaceTypes
    {
        /// <summary>
        /// Defaulting purposes.
        /// </summary>
        None,

        /// <summary>
        /// Represents the Dragonborn Race Type.
        /// </summary>
        Dragonborn,

        /// <summary>
        /// Represents the Dwarf Race Type.
        /// </summary>
        Dwarf,

        /// <summary>
        /// Represents the Elf Race Type.
        /// </summary>
        Elf,

        /// <summary>
        /// Represents the Gnome Race Type.
        /// </summary>
        Gnome,

        /// <summary>
        /// Represents the HalfElf Race Type.
        /// </summary>
        HalfElf,

        /// <summary>
        /// Represents the HalfOrc Race Type.
        /// </summary>
        HalfOrc,

        /// <summary>
        /// Represents the Halfling Race Type.
        /// </summary>
        Halfling,

        /// <summary>
        /// Represents the Human Race Type.
        /// </summary>
        Human,

        /// <summary>
        /// Represents the Tiefling Race Type.
        /// </summary>
        Tiefling
    }
}