namespace DiGi.CityGML.Enums
{
    /// <summary>
    /// Specifies the Level of Detail (LOD) for CityGML representations.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1712:Do not prefix enum values with type name", Justification = "LOD1 and LOD2 are the CityGML level names and the stored values.")]
    public enum LOD
    {
        /// <summary>
        /// Level of Detail 1: A simplified representation, typically consisting of a block or footprint.
        /// </summary>
        LOD1,

        /// <summary>
        /// Level of Detail 2: A more detailed representation, typically including roof structures and basic architectural features.
        /// </summary>
        LOD2,
    }
}