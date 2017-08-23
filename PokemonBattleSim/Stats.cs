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
        /// The name of the stat
        /// </summary>
        string name;

        /// <summary>
        /// The shorthand name of the stat
        /// </summary>
        string shortName;
        #endregion

        #region Stat Constructor
        public Stat(string name, string sName)
        {
            this.name = name;
            shortName = sName;
        }
        #endregion
    }
    #endregion

    public class PkmnStat
    {
        #region Members
        /// <summary>
        /// The numerical value of the stat at it's base for the specific pkmn
        /// </summary>
        double baseValue;

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
        /// The stage the stat is currently at
        /// </summary>
        int stage;

        /// <summary>
        /// The stat being represented
        /// </summary>
        Stat stat;

        /// <summary>
        /// The numerical value of the stat after level, IV, and EV application
        /// </summary>
        int value;
        #endregion

        #region Constructor
        public PkmnStat(double bV, Stat st)
        {
            baseValue = bV;
            stat = st;
        }
        #endregion

        #region Functions
        bool CalcValue(TeamMember pkmn, PkmnStat stat)
        {
            return true;
        }
        #endregion
    }

    public class IV
    {
        Stat stat;
        int value;

        public IV(Stat s, int val)
        {
            stat = s;
            value = val;
        }
    }

    public class EV
    {
        Stat stat;
        int value;

        public EV(Stat s, int val)
        {
            stat = s;
            value = val;
        }
    }

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
        /// <summary>
        /// The Pokemon's weight
        /// </summary>
        public static Stat Weight;
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
            Weight = new Stat("Weight", "Wgt");
        }
        #endregion
    }
    #endregion
}
