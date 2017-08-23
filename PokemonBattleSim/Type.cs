namespace PokemonBattleSim
{
    /// <summary>
    /// Container for all current Pokemon types
    /// </summary>
    public static class Type
    {
        #region Type Declarations
        /// <summary>
        /// Represents the Bug-type
        /// </summary>
        public static BasicType Bug;

        /// <summary>
        /// Represents the Dark-type
        /// </summary>
        public static BasicType Dark;

        /// <summary>
        /// Represents the Dragon-type
        /// </summary>
        public static BasicType Dragon;

        /// <summary>
        /// Represents the Electric-type
        /// </summary>
        public static BasicType Electric;

        /// <summary>
        /// Represents the Fairy-type
        /// </summary>
        public static BasicType Fairy;

        /// <summary>
        /// Represents the Fighting-type
        /// </summary>
        public static BasicType Fighting;

        /// <summary>
        /// Represents the Fire-type
        /// </summary>
        public static BasicType Fire;

        /// <summary>
        /// Represents the Flying-type
        /// </summary>
        public static BasicType Flying;

        /// <summary>
        /// Represents the Ghost-type
        /// </summary>
        public static BasicType Ghost;

        /// <summary>
        /// Represents the Grass-type
        /// </summary>
        public static BasicType Grass;

        /// <summary>
        /// Represents the Ground-type
        /// </summary>
        public static BasicType Ground;

        /// <summary>
        /// Represents the Ice-type
        /// </summary>
        public static BasicType Ice;

        /// <summary>
        /// Represents the Normal-type
        /// </summary>
        public static BasicType Normal;

        /// <summary>
        /// Represents the Poison-type
        /// </summary>
        public static BasicType Poison;

        /// <summary>
        /// Represents the Psychic-type
        /// </summary>
        public static BasicType Psychic;

        /// <summary>
        /// Represents the Rock-type
        /// </summary>
        public static BasicType Rock;

        /// <summary>
        /// Represents the Steel-type
        /// </summary>
        public static BasicType Steel;

        /// <summary>
        /// Represents the Typeless-type (no weaknesses/resistances)
        /// </summary>
        public static BasicType Typeless;

        /// <summary>
        /// Represents the Water-type
        /// </summary>
        public static BasicType Water;
        #endregion

        #region Types Constructor
        static Type()
        {
            Normal = new BasicType("Normal", new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -42, 0, 0, 0, 0 });
            Fire = new BasicType("Fire", new int[] { 0, -1, 1, 0, -1, -1, 0, 0, 1, 0, 0, -1, 1, 0, 0, 0, -1, -1 });
            Water = new BasicType("Water", new int[] { 0, -1, -1, 1, 1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0 });
            Electric = new BasicType("Electric", new int[] { 0, 0, 0, -1, 0, 0, 0, 0, 1, -1, 0, 0, 0, 0, 0, 0, -1, 0 });
            Grass = new BasicType("Grass", new int[] { 0, 1, -1, -1, -1, 1, 0, 1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 0 });
            Ice = new BasicType("Ice", new int[] { 0, 1, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 });
            Fighting = new BasicType("Fighting", new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, -1, -1, 0, 0, -1, 0, 1 });
            Poison = new BasicType("Poison", new int[] { 0, 0, 0, 0, -1, 0, -1, -1, 1, 0, 1, -1, 0, 0, 0, 0, 0, -1 });
            Ground = new BasicType("Ground", new int[] { 0, 0, 1, -42, 1, 1, 0, -1, 0, 0, 0, 0, -1, 0, 0, 0, 0, 0 });
            Flying = new BasicType("Flying", new int[] { 0, 0, 0, 1, -1, 1, -1, 0, -42, 0, 0, -1, 1, 0, 0, 0, 0, 0 });
            Psychic = new BasicType("Psychic", new int[] { 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, -1, 1, 0, 1, 0, 1, 0, 0 });
            Bug = new BasicType("Bug", new int[] { 0, 1, 0, 0, -1, 0, -1, 0, -1, 1, 0, 0, 1, 0, 0, 0, 0, 0 });
            Rock = new BasicType("Rock", new int[] { -1, -1, 1, 0, 1, 0, 1, -1, 1, -1, 0, 0, 0, 0, 0, 0, 1, 0 });
            Ghost = new BasicType("Ghost", new int[] { -42, 0, 0, 0, 0, 0, -42, -1, 0, 0, 0, -1, 0, 1, 0, 1, 0, 0 });
            Dragon = new BasicType("Dragon", new int[] { 0, -1, -1, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1 });
            Dark = new BasicType("Dark", new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, -42, 1, 0, -1, 0, -1, 0, 1 });
            Steel = new BasicType("Steel", new int[] { -1, 1, 0, 0, -1, -1, 1, -42, 1, -1, -1, -1, -1, 0, -1, 0, -1, -1 });
            Fairy = new BasicType("Fairy", new int[] { 0, 0, 0, 0, 0, 0, -1, 1, 0, 0, 0, -1, 0, 0, -42, -1, 1, 0 });
        }
        #endregion
    }
}
