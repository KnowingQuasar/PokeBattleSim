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
            Bug = new BasicType("Bug", new BasicType[] { Fire, Flying, Rock }, new BasicType[] { Fighting, Grass, Ground }, new BasicType[] { Psychic, Grass, Dark }, new BasicType[] { Fighting, Fire, Flying, Ghost, Poison, Steel, Fairy }, new BasicType[] { }, new BasicType[] { });
            Dark = new BasicType("Dark", new BasicType[] { Bug, Fairy, Fighting }, new BasicType[] { Dark, Ghost }, new BasicType[] { Ghost, Psychic }, new BasicType[] { Dark, Fairy, Fighting }, new BasicType[] { }, new BasicType[] { Psychic });
            Dragon = new BasicType("Dragon", new BasicType[] { Dragon, Ice, Fairy }, new BasicType[] { Electric, Fire, Grass, Water }, new BasicType[] { Dragon }, new BasicType[] { Steel }, new BasicType[] { Fairy }, new BasicType[] { });
            Electric = new BasicType("Electric", new BasicType[] { Ground }, new BasicType[] { Electric, Flying, Steel }, new BasicType[] { Flying, Water }, new BasicType[] { Dragon, Electric, Grass }, new BasicType[] { Ground }, new BasicType[] { });
            Fairy = new BasicType("Fairy", new BasicType[] { Poison, Steel }, new BasicType[] { Bug, Dark, Fighting }, new BasicType[] { Dark, Dragon, Fighting }, new BasicType[] { Fire, Poison, Steel }, new BasicType[] { }, new BasicType[] { Dragon });
            Fighting = new BasicType("Fighting", new BasicType[] { Fairy, Flying, Psychic }, new BasicType[] { Bug, Dark, Rock }, new BasicType[] { Dark, Ice, Normal, Rock, Steel }, new BasicType[] { Bug, Flying, Fairy, Poison, Psychic }, new BasicType[] { Ghost }, new BasicType[] { });
            Fire = new BasicType("Fire", new BasicType[] { Ground, Rock, Water }, new BasicType[] { Bug, Fairy, Fire, Grass, Ice, Steel }, new BasicType[] { Bug, Grass, Ice, Steel }, new BasicType[] { Dragon, Fire, Rock, Water }, new BasicType[] { }, new BasicType[] { });
            Flying = new BasicType("Flying", new BasicType[] { Electric, Ice, Rock }, new BasicType[] { Bug, Fighting, Grass }, new BasicType[] { Bug, Fighting, Grass }, new BasicType[] { Electric, Rock, Steel }, new BasicType[] { }, new BasicType[] { Ground });
            Ghost = new BasicType("Ghost", new BasicType[] { Ghost, Dark }, new BasicType[] { Bug, Poison }, new BasicType[] { Ghost, Psychic }, new BasicType[] { Dark }, new BasicType[] { Normal }, new BasicType[] { Normal, Fighting });
            Grass = new BasicType("Grass", new BasicType[] { Bug, Fire, Flying, Ice, Poison }, new BasicType[] { Electric, Grass, Ground, Water }, new BasicType[] { Ground, Rock, Water }, new BasicType[] { Bug, Dragon, Fire, Flying, Grass, Poison, Steel }, new BasicType[] { }, new BasicType[] { });
            Ground = new BasicType("Ground", new BasicType[] { Grass, Ice, Water }, new BasicType[] { Poison, Rock }, new BasicType[] { Electric, Fire, Poison, Rock, Steel }, new BasicType[] { Bug, Grass }, new BasicType[] { Flying }, new BasicType[] { Electric });
            Ice = new BasicType("Ice", new BasicType[] { Fire, Fighting, Steel, Rock }, new BasicType[] { Ice }, new BasicType[] { Dragon, Flying, Grass, Ground }, new BasicType[] { Fire, Ice, Steel, Water }, new BasicType[] { }, new BasicType[] { });
            Normal = new BasicType("Normal", new BasicType[] { Fighting }, new BasicType[] { }, new BasicType[] { }, new BasicType[] { Rock, Steel }, new BasicType[] { Ghost }, new BasicType[] { Ghost });
            Poison = new BasicType("Poison", new BasicType[] { Ground, Psychic }, new BasicType[] { Bug, Fairy, Fighting, Grass, Poison }, new BasicType[] { Fairy, Grass }, new BasicType[] { Ghost, Ground, Poison, Rock }, new BasicType[] { Steel }, new BasicType[] { });
            Psychic = new BasicType("Psychic", new BasicType[] { Dark, Ghost, Bug }, new BasicType[] { Fighting, Psychic }, new BasicType[] { Fighting, Poison }, new BasicType[] { Psychic, Steel }, new BasicType[] { Dark }, new BasicType[] { });
            Rock = new BasicType("Rock", new BasicType[] { Fighting, Grass, Rock, Steel, Water }, new BasicType[] { Fire, Flying, Normal, Poison }, new BasicType[] { Bug, Fire, Flying, Ice }, new BasicType[] { Fighting, Ground, Steel }, new BasicType[] { }, new BasicType[] { });
            Steel = new BasicType("Steel", new BasicType[] { Fighting, Fire, Ground }, new BasicType[] { Bug, Dragon, Fairy, Flying, Grass, Ice, Normal, Psychic, Rock, Steel }, new BasicType[] { Fairy, Ice, Rock }, new BasicType[] { Electric, Fire, Steel, Water }, new BasicType[] { }, new BasicType[] { Poison });
            Water = new BasicType("Water", new BasicType[] { Electric, Grass }, new BasicType[] { Water, Ice, Fire, Steel }, new BasicType[] { Fire, Ground, Rock }, new BasicType[] { Dragon, Grass, Water }, new BasicType[] { }, new BasicType[] { });
        }
        #endregion
    }
}
