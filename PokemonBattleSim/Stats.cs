namespace PokemonBattleSim
{
    #region Stat
    /// <summary>
    /// Basic container for a stat
    /// </summary>
    public class Stat
    {
        #region Members
        /// <summary>
        /// Default stage a stat rests at
        /// </summary>
        const int default_stage = 0;

        /// <summary>
        /// The maximum stage a stat can reach
        /// </summary>
        static int max_stage = 6;

        /// <summary>
        /// The minimum stage a stat can reach
        /// </summary>
        static int min_stage = -6;
        
        /// <summary>
        /// The name of the stat
        /// </summary>
        string name;

        /// <summary>
        /// The shorthand name of the stat
        /// </summary>
        string shortName;

        /// <summary>
        /// The stage the stat is currently at
        /// </summary>
        int stage;
        #endregion

        #region Stat Constructor
        public Stat(string name, string sName)
        {
            this.name = name;
            shortName = sName;
            stage = default_stage;
        }
        #endregion
    }
    #endregion

    #region Stats
    /// <summary>
    /// All stats used to calculate damage, defense, HP, Happiness values, etc
    /// </summary>
    static class Stats
    {
        #region Declarations
        public static Stat Accuracy;
        public static Stat Atk;
        public static Stat Crit;
        public static Stat Def;
        public static Stat Evasion;
        /// <summary>
        /// DO NOTE! 0 is min 255 is max! And there are no "stages".
        /// </summary>
        public static Stat Happiness;
        /// <summary>
        /// DO NOTE! HP does not have "stages"!
        /// </summary>
        public static Stat HP;
        public static Stat SpAtk;
        public static Stat Spd;
        public static Stat SpDef;
        #endregion

        #region Definitions
        static Stats()
        {
            Accuracy = new Stat("Accuracy", "Accuracy");
            Atk = new Stat("Attack", "Atk");
            Crit = new Stat("Critical Ratio", "Crit");
            Def = new Stat("Defense", "Def");
            Evasion = new Stat("Evasion", "Evasion");
            Happiness = new Stat("Happiness", "Happiness");
            HP = new Stat("HP", "HP");
            SpAtk = new Stat("Special Attack", "Sp. Atk");
            Spd = new Stat("Speed", "Spd");
            SpDef = new Stat("Special Defense", "Sp. Def");
        }
        #endregion
    }
    #endregion
}
