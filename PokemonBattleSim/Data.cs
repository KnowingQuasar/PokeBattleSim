using System.Collections.Generic;

namespace PokemonBattleSim
{
    #region Data Classes
    #region Effect Class
    /// <summary>
    /// A basic effect
    /// </summary>
    public class Effect
    {
        #region Members
        /// <summary>
        /// The name of the effect
        /// </summary>
        public string name;
        /// <summary>
        /// Description of the effect
        /// </summary>
        public string description;
        #endregion

        #region Efect Constructor
        /// <summary>
        /// Represents an in-game effect
        /// </summary>
        /// <param name="n">Name of the effect</param>
        /// <param name="d">Description of the effect</param>
        public Effect(string n, string d)
        {
            name = n;
            description = d;
        }
        #endregion
    }
    #endregion

    #region Move Class
    /// <summary>
    /// Class describing a Pokemon move
    /// </summary>
    public class Move
    {
        #region Members
        /// <summary>
        /// The accuracy of the move in decimal
        /// </summary>
        double accuracy;

        /// <summary>
        /// The attack type of the move, represented by a char:
        /// 'P' - Physical
        /// 'S' - Status
        /// 'M' - Special
        /// </summary>
        char atkType;

        /// <summary>
        /// The total damage of the move
        /// </summary>
        int damage;

        /// <summary>
        /// The effects of the move
        /// </summary>
        List<Effect> effects;

        /// <summary>
        /// The name of the move
        /// </summary>
        string name;

        /// <summary>
        /// Determines whether "effects" are proc'd on the self or target
        /// </summary>
        List<bool> onSelf;

        /// <summary>
        /// The PP of the move
        /// </summary>
        int pp;

        /// <summary>
        /// The move's priority
        /// </summary>
        int priority;

        /// <summary>
        /// The chance 
        /// </summary>
        List<double> proc;

        /// <summary>
        /// The type of the move
        /// </summary>
        BasicType type;

        /// <summary>
        /// The move's z-form
        /// </summary>
        ZMove zmove;
        #endregion

        #region Move Constructor
        /// <summary>
        /// Constructor for a move
        /// </summary>
        /// <param name="name">Name of the move</param>
        /// <param name="type">The type of the move</param>
        /// <param name="dmg">The damage of the move</param>
        /// <param name="acc">Accuracy of the move</param>
        /// <param name="pp">PP of the move</param>
        /// <param name="atktype">The move's type (attack, special, etc)</param>
        /// <param name="proc">The chance that the move's effects will proc in decimal (90% is 0.9, etc) corresponds to the effects list</param>
        /// <param name="effects">List of effects of the move</param>
        /// <param name="zmove">The move's z-form</param>
        /// <param name="priorityChange">Priority level</param>
        public Move(string name, BasicType type, int dmg, double acc, int pp, char atktype, double[] proc, Effect[] effects, bool[] onself, ZMove zmove, int priorityChange)
        {
            this.name = name;
            this.type = type;
            damage = dmg;
            accuracy = acc;
            this.pp = pp;
            atkType = atktype;
            if (proc != null)
                this.proc = new List<double>(proc);
            else
                this.proc = new List<double>();

            if (effects != null)
                this.effects = new List<Effect>(effects);
            else
                this.effects = new List<Effect>();

            if (onself != null)
                onSelf = new List<bool>(onself);
            else
                onSelf = new List<bool>();
            this.zmove = zmove;
            priority = priorityChange;
        }
        #endregion
    }
    #endregion

    #region ZMove Class
    /// <summary>
    /// Class representing a move's z-form
    /// </summary>
    public class ZMove
    {
        #region Members
        /// <summary>
        /// Boolean list representing whether the effects of the z-move are enacted on self
        /// </summary>
        List<bool> onSelf;

        /// <summary>
        /// The damage of the z-move
        /// </summary>
        int zdmg;

        /// <summary>
        /// A list of effects of the z-move
        /// </summary>
        List<Effect> zeffects;

        /// <summary>
        /// The name of the z-move
        /// </summary>
        string zname;
        #endregion

        #region Z-Move Constructors
        /// <summary>
        /// Constructor for a move's z-form
        /// </summary>
        /// <param name="zname">Name of the z-move</param>
        /// <param name="zdmg">The damage of the z-move (if applicable)</param>
        /// <param name="zeffects">The effects of the z-move (if applicable, null otherwise)</param>
        public ZMove(string zname, int zdmg, Effect[] zeffects, bool[] onself)
        {
            this.zname = zname;
            this.zdmg = zdmg;
            if (zeffects != null)
                this.zeffects = new List<Effect>(zeffects);
            else
                this.zeffects = new List<Effect>();
            if (onself != null)
                onSelf = new List<bool>(onself);
            else
                onSelf = new List<bool>();
        }

        /// <summary>
        /// Copies the zmove, but with new damage numbers
        /// </summary>
        /// <param name="zmove"></param>
        /// <param name="newdmg"></param>
        public ZMove(ZMove zmove, int newdmg)
        {
            zname = zmove.zname;
            zdmg = newdmg;
            if (zmove.zeffects != null)
                zeffects = new List<Effect>(zmove.zeffects);
            else
                zeffects = new List<Effect>();
        }
        #endregion
    }
    #endregion

    #region Ability Class
    /// <summary>
    /// Represents the effects of all abilities
    /// </summary>
    public class Ability
    {
        public readonly string name;
        public readonly string desc;
        public readonly int id;

        public Ability(string n, string d, int id)
        {
            name = n;
            desc = d;
            this.id = id;
        }
    }
    #endregion

    #region Basic Type Class
    public class BasicType
    {
        #region Member Declarations
        /// <summary>
        /// Name of the type
        /// </summary>
        public string name;

        /// <summary>
        /// The type chart of the move.
        /// Order of the types: Normal, Fire, Water, Ele, Grass, Ice, Fight, Poison, Ground, Fly, Psy, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy
        /// </summary>
        public int[] typeChart;
        #endregion

        #region Basic Type Constructor
        /// <summary>
        /// Basic Constructor for a type
        /// </summary>
        /// <param name="name">Name of the type</param>
        /// <param name="tC">The type chart of the type</param>
        public BasicType(string name, int[] tC)
        {
            this.name = name;
            typeChart = tC;
        }
        #endregion
    }
    #endregion

    #region Stat Change Class
    /// <summary>
    /// Repesents a change in stats in either user or target
    /// </summary>
    public class StatChange : Effect
    {
        /// <summary>
        /// The number to change the stat by
        /// </summary>
        public int change;
        /// <summary>
        /// The stat to be changed
        /// </summary>
        public Stat stat;

        public StatChange(string n, string d, Stat stat, int change) : base(n, d)
        {
            this.stat = stat;
            this.change = change;
        }
    }
    #endregion

    #region Stat Class
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

    #region PkmnStat Class
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
    #endregion

    #region Pokemon Class
    public class Pokemon
    {
        #region Members
        /// <summary>
        /// The number of the Pokemon in the Pokedex, if negative means alt form
        /// </summary>
        public double dexNum;
        /// <summary>
        /// The name of the Pokemon
        /// </summary>
        public string name;
        /// <summary>
        /// Primary type of the Pokemon
        /// </summary>
        public BasicType type1;
        /// <summary>
        /// Secondary type of the Pokemon
        /// </summary>
        public BasicType type2;
        /// <summary>
        /// List of possible abilities, the final one being the HA
        /// </summary>
        public List<Ability> possAbilities;
        /// <summary>
        /// Enumerates the base stats of the pkmn.
        /// Stat order: HP, Atk, Def, SpAtk, SpDef, Spd, Weight, Happiness, Acc, Evas
        /// </summary>
        public List<double> baseStats;
        /// <summary>
        /// List of possible moves
        /// </summary>
        public HashSet<Move> possMoves;
        #endregion

        #region Constructor
        /// <param name="s">The species of the pkmn</param>
        /// <param name="sd">The Pokedex description from Sun version</param>
        /// <param name="md">The Pokedex description from Moon version</param>

        /// <summary>
        /// Constructs a basic Pokemon
        /// </summary>
        /// <param name="dexnum">The national dex number of the pkmn</param>
        /// <param name="n">The name of the pkmn</param>
        /// <param name="typeA">The "primary" type of the pkmn</param>
        /// <param name="typeB">The "secondary" type of the pkmn</param>
        /// <param name="abilities">The list of possible abilites of the pkmn</param>
        /// <param name="stats">The base stats of the pkmn</param>
        /// <param name="moves">The list of possible moves the pkmn can learn</param>
        public Pokemon(double dexnum, string n, BasicType typeA, BasicType typeB, Ability[] abilities, double[] stats, Move[] moves)
        {
            dexNum = dexnum;
            name = n;
            type1 = typeA;
            type2 = typeB;
            possAbilities = new List<Ability>(abilities);
            possMoves = new HashSet<Move>(moves);

            baseStats = new List<double>(stats);
            baseStats.Add(70);
            baseStats.Add(1);
            baseStats.Add(1);
        }
        #endregion
    }
    #endregion

    #region IV Class
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
    #endregion

    #region EV Class
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
    #endregion
    #endregion

    public static class Data
    {
        #region Abilities
        #region A-H
        public static readonly Ability Adaptabililty = new Ability("Adaptability", "Powers up moves of the same type as the Pokémon.", 91);
        public static readonly Ability Aerilate = new Ability("Aerilate", "Contact with the Pokémon lowers the attacker's Speed stat.", 184);
        public static readonly Ability Aftermath = new Ability("Aftermath", "Damages the attacker if it contacts the Pokémon with a finishing hit.", 106);
        public static readonly Ability AirLock = new Ability("Air Lock", "Eliminates the effects of weather.", 76);
        public static readonly Ability Analytic = new Ability("Analytic", "Boosts move power when the Pokémon moves last.", 148);
        public static readonly Ability AngerPoint = new Ability("Anger Point", "The Pokémon is angered when it takes a critical hit, and that maxes its Attack stat.", 83);
        public static readonly Ability Anticipation = new Ability("Anticipation", "The Pokémon can sense an opposing Pokémon's dangerous moves.", 107);
        public static readonly Ability ArenaTrap = new Ability("Arena Trap", "Prevents opposing Pokémon from fleeing.", 71);
        public static readonly Ability AromaVeil = new Ability("Aroma Veil", "Protects itself and its allies from attacks that limit their move choices.", 165);
        public static readonly Ability AuraBreak = new Ability("Aura Break", "The effects of \"Aura\" Abilities are reversed to lower the power of affected moves.", 188);
        public static readonly Ability BadDreams = new Ability("Bad Dreams", "Reduces the HP of sleeping opposing Pokémon.", 123);
        public static readonly Ability Battery = new Ability("Battery", "Powers up ally Pokémon's special moves.", 217);
        public static readonly Ability BattleArmor = new Ability("Battle Armor", "Hard armor protects the Pokémon from critical hits.", 4);
        public static readonly Ability BattleBond = new Ability("Battle Bond", "Defeating an opposing Pokémon strengthens the Pokémon's bond with its Trainer, and it becomes Ash-Greninja. Water Shuriken gets more powerful.", 210);
        public static readonly Ability BeastBoost = new Ability("Beast Boost", "The Pokémon boosts its most proficient stat each time it knocks out a Pokémon.", 224);
        public static readonly Ability Beserk = new Ability("Beserk", "Boosts the Pokémon's Sp. Atk stat when it takes a hit that causes its HP to become half or less.", 201);
        public static readonly Ability BigPecks = new Ability("Big Pecks", "Protects the Pokémon from Defense-lowering effects.", 145);
        public static readonly Ability Blaze = new Ability("Blaze", "Powers up Fire-type moves when the Pokémon's HP is low.", 66);
        public static readonly Ability Bulletproof = new Ability("Bulletproof", "Protects the Pokémon from some ball and bomb moves.", 171);
        public static readonly Ability CheekPouch = new Ability("Cheek Pouch", "Restores HP as well when the Pokémon eats a Berry.", 167);
        public static readonly Ability Chlorophyll = new Ability("Chlorophyll", "Boosts the Pokémon's Speed stat in sunshine.", 34);
        public static readonly Ability ClearBody = new Ability("Clear Body", "Prevents other Pokémon's moves or Abilities from lowering the Pokémon's ", 29);
        public static readonly Ability CloudNine = new Ability("Cloud Nine", "Eliminates the effects of weather.", 13);
        public static readonly Ability ColorChange = new Ability("Color Change", "The Pokémon's type becomes the type of the move used on it.", 16);
        public static readonly Ability Comatose = new Ability("Comatose", "It's always drowsing and will never wake up. It can attack without waking up.", 213);
        public static readonly Ability Competitive = new Ability("Competitive", "Boosts the Sp. Atk stat sharply when a stat is lowered.", 172);
        public static readonly Ability CompoundEyes = new Ability("Compound Eyes", "The Pokémon's compound eyes boost its accuracy.", 14);
        public static readonly Ability Contrary = new Ability("Contrary", "Makes stat changes have an opposite effect.", 126);
        public static readonly Ability Corrosion = new Ability("Corrosion", "The Pokémon can poison the target even if it's a Steel or Poison ", 212);
        public static readonly Ability CursedBody = new Ability("Cursed Body", "May disable a move used on the Pokémon.", 130);
        public static readonly Ability CuteCharm = new Ability("Cute Charm", "Contact with the Pokémon may cause infatuation.", 56);
        public static readonly Ability Damp = new Ability("Damp", "Prevents the use of explosive moves such as Self-Destruct by dampening its surroundings.", 6);
        public static readonly Ability Dancer = new Ability("Dancer", "When another Pokémon uses a dance move, it can use a dance move following it regardless of its Speed.", 216);
        public static readonly Ability DarkAura = new Ability("Dark Aura", "Powers up each Pokémon's Dark-type moves.", 186);
        public static readonly Ability Dazzling = new Ability("Dazzling", "Surprises the opposing Pokémon, making it unable to attack using priority moves.", 219);
        public static readonly Ability Defeatist = new Ability("Defeatist", "Halves the Pokémon's Attack and Sp. Atk stats when its HP becomes half or less.", 129);
        public static readonly Ability Defiant = new Ability("Defiant", "Boosts the Pokémon's Attack stat sharply when its stats are lowered.", 128);
        public static readonly Ability DeltaStream = new Ability("Delta Stream", "The Pokémon changes the weather to eliminate all of the Flying type's weaknesses.", 191);
        public static readonly Ability DesolateLand = new Ability("Desolate Land", "The Pokémon changes the weather to nullify Water-type attacks.", 190);
        public static readonly Ability Disguise = new Ability("Disguise", "Once per battle, the shroud that covers the Pokémon can protect it from an attack.", 209);
        public static readonly Ability Download = new Ability("Download", "Compares an opposing Pokémon's Defense and Sp. Def stats before raising its own Attack or Sp. Atk stat—whichever will be more effective.", 88);
        public static readonly Ability Drizzle = new Ability("Drizzle", "The Pokémon makes it rain when it enters a battle.", 2);
        public static readonly Ability Drought = new Ability("Drought", "Turns the sunlight harsh when the Pokémon enters a battle.", 70);
        public static readonly Ability DrySkin = new Ability("Dry Skin", "Restores HP in rain or when hit by Water-type moves. Reduces HP in sunshine, and increases the damage received from Fire-type moves.", 87);
        public static readonly Ability EarlyBird = new Ability("Early Bird", "The Pokémon awakens twice as fast as other Pokémon from sleep.", 48);
        public static readonly Ability EffectSpore = new Ability("Effect Spore", "Contact with the Pokémon may inflict poison, sleep, or paralysis on its attacker.", 27);
        public static readonly Ability ElectricSurge = new Ability("Electric Surge", "Turns the ground into Electric Terrain when the Pokémon enters a battle.", 226);
        public static readonly Ability EmergencyExit = new Ability("Emergency Exit", "The Pokémon, sensing danger, switches out when its HP becomes half or less.", 194);
        public static readonly Ability FairyAura = new Ability("Fairy Aura", "Powers up each Pokémon's Fairy-type moves.", 187);
        public static readonly Ability Filter = new Ability("Filter", "Reduces the power of supereffective attacks taken.", 111);
        public static readonly Ability FlameBody = new Ability("Flame Body", "Contact with the Pokémon may burn the attacker.", 49);
        public static readonly Ability FlareBoost = new Ability("Flare Boost", "Powers up special attacks when the Pokémon is burned.", 138);
        public static readonly Ability FlashFire = new Ability("Flash Fire", "Powers up the Pokémon's Fire-type moves if it's hit by one.", 18);
        public static readonly Ability FlowerGift = new Ability("Flower Gift", "Boosts the Attack and Sp. Def stats of itself and allies when it is sunny.", 122);
        public static readonly Ability FlowerVeil = new Ability("Flower Veil", "Ally Grass-type Pokémon are protected from status conditions and the lowering of their ", 166);
        public static readonly Ability Fluffy = new Ability("Fluffy", "Halves the damage taken from moves that make direct contact, but doubles that of Fire-type moves.", 218);
        public static readonly Ability Forecast = new Ability("Forecast", "The Pokémon transforms with the weather to change its type to Water, Fire, or Ice.", 59);
        public static readonly Ability Forewarn = new Ability("Forewarn", "When it enters a battle, the Pokémon can tell one of the moves an opposing Pokémon has.", 108);
        public static readonly Ability FriendGuard = new Ability("Friend Guard", "Reduces damage done to allies.", 132);
        public static readonly Ability Frisk = new Ability("Frisk", "When it enters a battle, the Pokémon can check an opposing Pokémon's held item.", 119);
        public static readonly Ability FullMetalBody = new Ability("Full Metal Body", "Prevents other Pokémon's moves or Abilities from lowering the Pokémon's ", 230);
        public static readonly Ability FurCoat = new Ability("Fur Coat", "Halves the damage from physical moves.", 169);
        public static readonly Ability GaleWings = new Ability("Gale Wings", "Gives priority to Flying-type moves when the Pokémon's HP is full.", 177);
        public static readonly Ability Galvanize = new Ability("Galvanize", "	Normal-type moves become Electric-type moves. The power of those moves is boosted a little.", 206);
        public static readonly Ability Gluttony = new Ability("Gluttony", "Makes the Pokémon eat a held Berry when its HP drops to half or less, which is sooner than usual.", 82);
        public static readonly Ability Gooey = new Ability("Gooey", "Contact with the Pokémon lowers the attacker's Speed stat.", 183);
        public static readonly Ability GrassPelt = new Ability("Grass Pelt", "Boosts the Pokémon's Defense stat in Grassy Terrain.", 179);
        public static readonly Ability GrassySurge = new Ability("Grassy Surge", "Turns the ground into Grassy Terrain when the Pokémon enters a battle.", 229);
        public static readonly Ability Guts = new Ability("Guts", "It's so gutsy that having a status condition boosts the Pokémon's Attack stat.", 62);
        public static readonly Ability Harvest = new Ability("Harvest", "May create another Berry after one is used.", 139);
        public static readonly Ability Healer = new Ability("Healer", "Sometimes heals an ally's status condition.", 131);
        public static readonly Ability Heatproof = new Ability("Heatproof", "The heatproof body of the Pokémon halves the damage from Fire-type moves that hit it.", 85);
        public static readonly Ability HeavyMetal = new Ability("Heavy Metal", "Doubles the Pokémon's weight.", 134);
        public static readonly Ability HoneyGather = new Ability("Honey Gather", "The Pokémon may gather Honey after a battle.", 118);
        public static readonly Ability HugePower = new Ability("Huge Power", "Doubles the Pokémon's Attack stat.", 37);
        public static readonly Ability Hustle = new Ability("Hustle", "Boosts the Attack stat, but lowers accuracy.", 55);
        public static readonly Ability Hydration = new Ability("Hydration", "Heals status conditions if it's raining.", 93);
        public static readonly Ability HyperCutter = new Ability("Hyper Cutter", "The Pokémon's proud of its powerful pincers. They prevent other Pokémon from lowering its Attack stat.", 52);
        #endregion
        #region I-R
        public static readonly Ability IceBody = new Ability("Ice Body", "The Pokémon gradually regains HP in a hailstorm.", 115);
        public static readonly Ability Illuminate = new Ability("Illuminate", "Raises the likelihood of meeting wild Pokémon by illuminating the surroundings.", 35);
        public static readonly Ability Illusion = new Ability("Illusion", "Comes out disguised as the Pokémon in the party's last spot.", 149);
        public static readonly Ability Immunity = new Ability("Immunity", "The immune system of the Pokémon prevents it from getting poisoned.", 17);
        public static readonly Ability Imposter = new Ability("Imposter", "The Pokémon transforms itself into the Pokémon it's facing.", 150);
        public static readonly Ability Infiltrator = new Ability("Infiltrator", "Passes through the opposing Pokémon's barrier, substitute, and the like and strikes.", 151);
        public static readonly Ability InnardsOut = new Ability("Innards Out", "Damages the attacker landing the finishing hit by the amount equal to its last HP.", 215);
        public static readonly Ability InnerFocus = new Ability("Inner Focus", "The Pokémon's intensely focused, and that protects the Pokémon from flinching.", 39);
        public static readonly Ability Insomnia = new Ability("Insomnia", "The Pokémon is suffering from insomnia and cannot fall asleep.", 15);
        public static readonly Ability Intimidate = new Ability("Intimidate", "The Pokémon intimidates opposing Pokémon upon entering battle, lowering their Attack stat.", 22);
        public static readonly Ability IronBarbs = new Ability("Iron Barbs", "Inflicts damage to the attacker on contact with iron barbs.", 160);
        public static readonly Ability IronFist = new Ability("Iron Fist", "Powers up punching moves.", 89);
        public static readonly Ability Justified = new Ability("Justified", "Being hit by a Dark-type move boosts the Attack stat of the Pokémon, for justice.", 154);
        public static readonly Ability KeenEye = new Ability("Keen Eye", "Keen eyes prevent other Pokémon from lowering this Pokémon's accuracy.", 51);
        public static readonly Ability Klutz = new Ability("Klutz", "The Pokémon can't use any held items.", 103);
        public static readonly Ability LeafGuard = new Ability("Leaf Guard", "Prevents status conditions in sunny weather.", 102);
        public static readonly Ability Levitate = new Ability("Levitate", "By floating in the air, the Pokémon receives full immunity to all Ground-type moves.", 26);
        public static readonly Ability LightMetal = new Ability("Light Metal", "Halves the Pokémon's weight.", 135);
        public static readonly Ability LightningRod = new Ability("Lightning Rod", "The Pokémon draws in all Electric-type moves. Instead of being hit by Electric-type moves, it boosts its Sp. Atk.", 31);
        public static readonly Ability Limber = new Ability("Limber", "Its limber body protects the Pokémon from paralysis.", 7);
        public static readonly Ability LiquidOoze = new Ability("Liquid Ooze", "Oozed liquid has strong stench, which damages attackers using any draining move.", 64);
        public static readonly Ability LiquidVoice = new Ability("Liquid Voice", "All sound-based moves become Water-type moves.", 204);
        public static readonly Ability LongReach = new Ability("Long Reach", "The Pokémon uses its moves without making contact with the target.", 203);
        public static readonly Ability MagicBounce = new Ability("Magic Bounce", "Reflects status moves, instead of getting hit by them.", 156);
        public static readonly Ability MagicGuard = new Ability("Magic Guard", "The Pokémon only takes damage from attacks.", 98);
        public static readonly Ability Magician = new Ability("Magician", "The Pokémon steals the held item of a Pokémon it hits with a move.", 170);
        public static readonly Ability MagmaArmor = new Ability("Magma Armor", "The Pokémon is covered with hot magma, which prevents the Pokémon from becoming frozen.", 40);
        public static readonly Ability MagnetPull = new Ability("Magnet Pull", "Prevents Steel-type Pokémon from escaping using its magnetic force.", 42);
        public static readonly Ability MarvelScale = new Ability("Marvel Scale", "The Pokémon's marvelous scales boost the Defense stat if it has a status condition.", 63);
        public static readonly Ability MegaLauncher = new Ability("Mega Launcher", "Powers up aura and pulse moves.", 178);
        public static readonly Ability Merciless = new Ability("Merciless", "The Pokémon's attacks become critical hits if the target is poisoned.", 196);
        public static readonly Ability Minus = new Ability("Minus", "Boosts the Sp. Atk stat of the Pokémon if an ally with the Plus or Minus Ability is also in battle.", 58);
        public static readonly Ability MistySurge = new Ability("Misty Surge", "Turns the ground into Misty Terrain when the Pokémon enters a battle.", 228);
        public static readonly Ability MoldBreaker = new Ability("Mold Breaker", "Moves can be used on the target regardless of its Abilities.", 104);
        public static readonly Ability Moody = new Ability("Moody", "Raises one stat sharply and lowers another every turn.", 141);
        public static readonly Ability MotorDrive = new Ability("Motor Drive", "Boosts its Speed stat if hit by an Electric-type move, instead of taking damage.", 78);
        public static readonly Ability Moxie = new Ability("Moxie", "The Pokémon shows moxie, and that boosts the Attack stat after knocking out any Pokémon.", 153);
        public static readonly Ability Multiscale = new Ability("Multiscale", "Reduces the amount of damage the Pokémon takes when its HP is full.", 136);
        public static readonly Ability Multitype = new Ability("Multitype", "Changes the Pokémon's type to match the Plate or Z-Crystal it holds.", 121);
        public static readonly Ability Mummy = new Ability("Mummy", "Contact with the Pokémon changes the attacker's Ability to Mummy.", 152);
        public static readonly Ability NaturalCure = new Ability("Natural Cure", "All status conditions heal when the Pokémon switches out.", 30);
        public static readonly Ability NoGuard = new Ability("No Guard", "The Pokémon employs no-guard tactics to ensure incoming and outgoing attacks always land.", 99);
        public static readonly Ability Normalize = new Ability("Normalize", "All the Pokémon's moves become Normal  The power of those moves is boosted a little.", 96);
        public static readonly Ability Oblivious = new Ability("Oblivious", "The Pokémon is oblivious, and that keeps it from being infatuated or falling for taunts.", 12);
        public static readonly Ability Overcoat = new Ability("Overcoat", "Protects the Pokémon from things like sand, hail, and powder.", 142);
        public static readonly Ability Overgrow = new Ability("Overgrow", "Powers up Grass-type moves when the Pokémon's HP is low.", 65);
        public static readonly Ability OwnTempo = new Ability("Own Tempo", "This Pokémon has its own tempo, and that prevents it from becoming confused", 20);
        public static readonly Ability ParentalBond = new Ability("Parental Bond", "Parent and child each attacks.", 185);
        public static readonly Ability Pickpocket = new Ability("Pickpocket", "Steals an item from an attacker that made direct contact.", 124);
        public static readonly Ability Pickup = new Ability("Pickup", "The Pokémon may pick up the item an opposing Pokémon used during a battle. It may pick up items outside of battle, too.", 53);
        public static readonly Ability Pixilate = new Ability("Pixilate", "Normal-type moves become Fairy-type moves. The power of those moves is boosted a little.", 182);
        public static readonly Ability Plus = new Ability("Plus", "Boosts the Sp. Atk stat of the Pokémon if an ally with the Plus or Minus Ability is also in battle.", 57);
        public static readonly Ability PoisonHeal = new Ability("Poison Heal", "Restores HP if the Pokémon is poisoned, instead of losing HP.", 90);
        public static readonly Ability PoisonPoint = new Ability("Poison Point", "Contact with the Pokémon may poison the attacker.", 38);
        public static readonly Ability PoisonTouch = new Ability("Poison Touch", "May poison a target when the Pokémon makes contact.", 143);
        public static readonly Ability PowerConstruct = new Ability("Power Construct", "Other Cells gather to aid when its HP becomes half or less. Then the Pokémon changes its form to Complete Forme.", 211);
        public static readonly Ability PowerOfAlchemy = new Ability("Power of Alchemy", "The Pokémon copies the Ability of a defeated ally.", 223);
        public static readonly Ability Prankster = new Ability("Prankster", "Gives priority to a status move.", 158);
        public static readonly Ability Pressure = new Ability("Pressure", "By putting pressure on the opposing Pokémon, it raises their PP usage.", 46);
        public static readonly Ability PrimordialSea = new Ability("Primordial Sea", "The Pokémon changes the weather to nullify Fire-type attacks.", 189);
        public static readonly Ability PrismArmor = new Ability("Prism Armor", "Reduces the power of supereffective attacks taken.", 232);
        public static readonly Ability Protean = new Ability("Protean", "Changes the Pokémon's type to the type of the move it's about to use.", 168);
        public static readonly Ability PsychicSurge = new Ability("Psychic Surge", "Turns the ground into Psychic Terrain when the Pokémon enters a battle.", 227);
        public static readonly Ability PurePower = new Ability("Pure Power", "Using its pure power, the Pokémon doubles its Attack stat.", 74);
        public static readonly Ability QueenlyMajesty = new Ability("Queenly Majesty", "Its majesty pressures the opposing Pokémon, making it unable to attack using priority moves.", 214);
        public static readonly Ability QuickFeet = new Ability("Quick Feet", "Boosts the Speed stat if the Pokémon has a status condition.", 95);
        public static readonly Ability RainDish = new Ability("Rain Dish", "The Pokémon gradually regains HP in rain.", 44);
        public static readonly Ability Rattled = new Ability("Rattled", "Dark-, Ghost-, and Bug-type moves scare the Pokémon and boost its Speed stat.", 155);
        public static readonly Ability Receiver = new Ability("Receiver", "The Pokémon copies the Ability of a defeated ally.", 222);
        public static readonly Ability Reckless = new Ability("Reckless", "Powers up moves that have recoil damage.", 120);
        public static readonly Ability Refrigerate = new Ability("Refrigerate", "Normal-type moves become Ice-type moves. The power of those moves is boosted a little.", 174);
        public static readonly Ability Regenerator = new Ability("Regenerator", "Restores a little HP when withdrawn from battle.", 144);
        public static readonly Ability Rivalry = new Ability("Rivalry", "Becomes competitive and deals more damage to Pokémon of the same gender, but deals less to Pokémon of the opposite gender.", 79);
        public static readonly Ability RKSSystem = new Ability("RKS System", "Changes the Pokémon's type to match the memory disc it holds.", 225);
        public static readonly Ability RockHead = new Ability("Rock Head", "Protects the Pokémon from recoil damage.", 69);
        public static readonly Ability RoughSkin = new Ability("Rough Skin", "This Pokémon inflicts damage with its rough skin to the attacker on contact.", 24);
        public static readonly Ability RunAway = new Ability("Run Away", "Enables a sure getaway from wild Pokémon.", 50);
        #endregion
        #region S-Z
        public static readonly Ability SandForce = new Ability("Sand Force", "Boosts the power of Rock-, Ground-, and Steel-type moves in a sandstorm.", 159);
        public static readonly Ability SandRush = new Ability("Sand Rush", "Boosts the Pokémon's Speed stat in a sandstorm.", 146);
        public static readonly Ability SandStream = new Ability("Sand Stream", "The Pokémon summons a sandstorm when it enters a battle.", 45);
        public static readonly Ability SandVeil = new Ability("Sand Veil", "Boosts the Pokémon's evasion in a sandstorm.", 8);
        public static readonly Ability SapSipper = new Ability("Sap Sipper", "Boosts the Attack stat if hit by a Grass-type move, instead of taking damage.", 157);
        public static readonly Ability Schooling = new Ability("Schooling", "When it has a lot of HP, the Pokémon forms a powerful school. It stops schooling when its HP is low.", 208);
        public static readonly Ability Scrappy = new Ability("Scrappy", "The Pokémon can hit Ghost-type Pokémon with Normal- and Fighting-type moves.", 113);
        public static readonly Ability SereneGrace = new Ability("Serene Grace", "Boosts the likelihood of additional effects occurring when attacking.", 32);
        public static readonly Ability ShadowShield = new Ability("Shadow Shield", "Reduces the amount of damage the Pokémon takes while its HP is full.", 231);
        public static readonly Ability ShadowTag = new Ability("Shadow Tag", "This Pokémon steps on the opposing Pokémon's shadow to prevent it from escaping.", 23);
        public static readonly Ability ShedSkin = new Ability("Shed Skin", "The Pokémon may heal its own status conditions by shedding its skin.", 61);
        public static readonly Ability SheerForce = new Ability("Sheer Force", "Removes additional effects to increase the power of moves when attacking.", 125);
        public static readonly Ability ShellArmor = new Ability("Shell Armor", "A hard shell protects the Pokémon from critical hits.", 75);
        public static readonly Ability ShieldDust = new Ability("Shield Dust", "This Pokémon's dust blocks the additional effects of attacks taken.", 19);
        public static readonly Ability ShieldsDown = new Ability("Shields Down", "When its HP becomes half or less, the Pokémon's shell breaks and it becomes aggressive.", 197);
        public static readonly Ability Simple = new Ability("Simple", "The stat changes the Pokémon receives are doubled.", 86);
        public static readonly Ability SkillLink = new Ability("Skill Link", "Maximizes the number of times multi-strike moves hit.", 92);
        public static readonly Ability SlowStart = new Ability("Slow Start", "For five turns, the Pokémon's Attack and Speed stats are halved.", 112);
        public static readonly Ability SlushRush = new Ability("Slush Rush", "Boosts the Pokémon's Speed stat in a hailstorm.", 202);
        public static readonly Ability Sniper = new Ability("Sniper", "Powers up moves if they become critical hits when attacking.", 97);
        public static readonly Ability SnowCloak = new Ability("Snow Cloak", "Boosts evasion in a hailstorm.", 81);
        public static readonly Ability SnowWarning = new Ability("Snow Warning", "The Pokémon summons a hailstorm when it enters a battle.", 117);
        public static readonly Ability SolarPower = new Ability("Solar Power", "Boosts the Sp. Atk stat in sunny weather, but HP decreases every turn.", 94);
        public static readonly Ability SolidRock = new Ability("Solid Rock", "Reduces the power of supereffective attacks taken.", 116);
        public static readonly Ability SoulHeart = new Ability("Soul-Heart", "Boosts its Sp. Atk stat every time a Pokémon faints.", 220);
        public static readonly Ability Soundproof = new Ability("Soundproof", "Soundproofing of the Pokémon itself gives full immunity to all sound-based moves.", 43);
        public static readonly Ability SpeedBoost = new Ability("Speed Boost", "Its Speed stat is boosted every turn.", 3);
        public static readonly Ability Stakeout = new Ability("Stakeout", "Doubles the damage dealt to the target's replacement if the target switches out.", 198);
        public static readonly Ability Stall = new Ability("Stall", "The Pokémon moves after all other Pokémon do.", 100);
        public static readonly Ability Stamina = new Ability("Stamina", "Boosts the Defense stat when hit by an attack.", 192);
        public static readonly Ability StanceChange = new Ability("Stance Change", "The Pokémon changes its form to Blade Forme when it uses an attack move, and changes to Shield Forme when it uses King's Shield.", 176);
        public static readonly Ability Static = new Ability("Static", "The Pokémon is charged with static electricity, so contact with it may cause paralysis.", 9);
        public static readonly Ability Steadfast = new Ability("Steadfast", "The Pokémon's determination boosts the Speed stat each time the Pokémon flinches.", 80);
        public static readonly Ability Steelworker = new Ability("Steelworker", "Powers up Steel-type moves.", 200);
        public static readonly Ability Stench = new Ability("Stench", "By releasing stench when attacking, this Pokémon may cause the target to flinch.", 1);
        public static readonly Ability StickyHold = new Ability("Sticky Hold", "Items held by the Pokémon are stuck fast and cannot be removed by other Pokémon.", 60);
        public static readonly Ability StormDrain = new Ability("Storm Drain", "Draws in all Water-type moves. Instead of being hit by Water-type moves, it boosts its Sp. Atk.", 114);
        public static readonly Ability StrongJaw = new Ability("Strong Jaw", "The Pokémon's strong jaw boosts the power of its biting moves.", 173);
        public static readonly Ability Sturdy = new Ability("Sturdy", "It cannot be knocked out with one hit. One-hit KO moves cannot knock it out, either.", 5);
        public static readonly Ability SuctionCups = new Ability("Suction Cups", "This Pokémon uses suction cups to stay in one spot to negate all moves and items that force switching out.", 21);
        public static readonly Ability SuperLuck = new Ability("Super Luck", "The Pokémon is so lucky that the critical-hit ratios of its moves are boosted.", 105);
        public static readonly Ability SurgeSurfer = new Ability("Surge Surfer", "Doubles the Pokémon's Speed stat on Electric Terrain.", 207);
        public static readonly Ability Swarm = new Ability("Swarm", "Powers up Bug-type moves when the Pokémon's HP is low.", 68);
        public static readonly Ability SweetVeil = new Ability("Sweet Veil", "Prevents itself and ally Pokémon from falling asleep.", 175);
        public static readonly Ability SwiftSwim = new Ability("Swift Swim", "Boosts the Pokémon's Speed stat in rain.", 33);
        public static readonly Ability Symbiosis = new Ability("Symbiosis", "The Pokémon passes its item to an ally that has used up an item.", 180);
        public static readonly Ability Synchronize = new Ability("Synchronize", "The attacker will receive the same status condition if it inflicts a burn, poison, or paralysis to the Pokémon.", 28);
        public static readonly Ability TangledFeet = new Ability("Tangled Feet", "Raises evasion if the Pokémon is confused.", 77);
        public static readonly Ability TanglingHair = new Ability("Tangling Hair", "Contact with the Pokémon lowers the attacker's Speed stat.", 221);
        public static readonly Ability Technician = new Ability("Technician", "Powers up the Pokémon's weaker moves.", 101);
        public static readonly Ability Telepathy = new Ability("Telepathy", "Anticipates an ally's attack and dodges it.", 140);
        public static readonly Ability Teravolt = new Ability("Teravolt", "Moves can be used on the target regardless of its Abilities.", 164);
        public static readonly Ability ThickFat = new Ability("Thick Fat", "The Pokémon is protected by a layer of thick fat, which halves the damage taken from Fire- and Ice-type moves.", 47);
        public static readonly Ability TintedLens = new Ability("Tinted Lens", "The Pokémon can use \"not very effective\" moves to deal regular damage.", 110);
        public static readonly Ability Torrent = new Ability("Torrent", "Powers up Water-type moves when the Pokémon's HP is low.", 67);
        public static readonly Ability ToughClaws = new Ability("Tough Claws", "Powers up moves that make direct contact.", 181);
        public static readonly Ability ToxicBoost = new Ability("Toxic Boost", "Powers up physical attacks when the Pokémon is poisoned.", 137);
        public static readonly Ability Trace = new Ability("Trace", "When it enters a battle, the Pokémon copies an opposing Pokémon's Ability.", 36);
        public static readonly Ability Triage = new Ability("Triage", "Gives priority to a healing move.", 205);
        public static readonly Ability Truant = new Ability("Truant", "The Pokémon can't use a move the following turn if it uses one.", 54);
        public static readonly Ability Turboblaze = new Ability("Turboblaze", "Moves can be used on the target regardless of its Abilities.", 163);
        public static readonly Ability Unaware = new Ability("Unaware", "When attacking, the Pokémon ignores the target Pokémon's stat changes.", 109);
        public static readonly Ability Unburden = new Ability("Unburden", "Boosts the Speed stat if the Pokémon's held item is used or lost.", 84);
        public static readonly Ability Unnerve = new Ability("Unnerve", "Unnerves opposing Pokémon and makes them unable to eat Berries.", 127);
        public static readonly Ability VictoryStar = new Ability("Victory Star", "Boosts the accuracy of its allies and itself.", 162);
        public static readonly Ability VitalSpirit = new Ability("Vital Spirit", "The Pokémon is full of vitality, and that prevents it from falling asleep.", 72);
        public static readonly Ability VoltAbsorb = new Ability("Volt Absorb", "Restores HP if hit by an Electric-type move, instead of taking damage.", 10);
        public static readonly Ability WaterAbsorb = new Ability("Water Absorb", "Restores HP if hit by a Water-type move, instead of taking damage.", 11);
        public static readonly Ability WaterBubble = new Ability("Water Bubble", "Lowers the power of Fire-type moves done to the Pokémon and prevents the Pokémon from getting a burn.", 199);
        public static readonly Ability WaterCompaction = new Ability("Water Compaction", "Boosts the Pokémon's Defense stat sharply when hit by a Water-type move.", 195);
        public static readonly Ability WaterVeil = new Ability("Water Veil", "The Pokémon is covered with a water veil, which prevents the Pokémon from getting a burn.", 41);
        public static readonly Ability WeakArmor = new Ability("Weak Armor", "Physical attacks to the Pokémon lower its Defense stat but sharply raise its Speed stat.", 133);
        public static readonly Ability WhiteSmoke = new Ability("White Smoke", "The Pokémon is protected by its white smoke, which prevents other Pokémon from lowering its ", 73);
        public static readonly Ability WimpOut = new Ability("Wimp Out", "The Pokémon cowardly switches out when its HP becomes half or less.", 193);
        public static readonly Ability WonderGuard = new Ability("Wonder Guard", "Its mysterious power only lets supereffective moves hit the Pokémon.", 25);
        public static readonly Ability WonderSkin = new Ability("Wonder Skin", "Makes status moves more likely to miss.", 147);
        public static readonly Ability ZenMode = new Ability("Zen Mode", "Changes the Pokémon's shape when HP is half or less.", 161);
        #endregion
        #endregion

        #region Effects
        #region General Effects
        public static readonly Effect AllCrit = new Effect("100% Crit Rate", "The attack is guaranteed to be a critical hit.");
        public static readonly Effect AttackScreen = new Effect("Attack Screen", "Halves damage from physical moves.");
        public static readonly Effect BreakScreens = new Effect("Break Screens", "Clears the effects of Reflect and Light Screen");
        public static readonly Effect Charge1Turn = new Effect("Charge 1 turn", "The attack will take 1 turn to charge before activation.");
        public static readonly Effect ClearTraps = new Effect("Clears traps from the user's side of the field", "Removes effects of any binding moves, leech seeds, and entry hazards from the field");
        public static readonly Effect ConfuseAll = new Effect("Confuses all pokemon on the battlefield", "Confuses all pokemon on the battlefield, including the user");
        public static readonly Effect ConsumeItem = new Effect("ConsumeItem", "Consumes the target or user's item if possible");
        public static readonly Effect CopyAbility = new Effect("Copies the ability of the target", "Copies the ability of the target pokemon");
        public static readonly Effect CopyLastMove = new Effect("Copy the opponent's last move", "Copies the opponent's last used move");
        public static readonly Effect CopyNextMove = new Effect("CopyNextMove", "Copy the target's next move");
        public static readonly Effect CopyStatChanges = new Effect("Copy the target's stat changes", "Copies the target's stat changes, both positive and negative");
        public static readonly Effect DealsDmgEqualToLvl = new Effect("DmgEqToLvl", "Deals damage equal to the level of the user");
        public static readonly Effect DealsDmg = new Effect("DealsDmg", "Allows the move to deal damage this turn");
        public static readonly Effect DealsNoDmg = new Effect("doNoDmg", "Damage will be prevented if this flag is not ignored");
        public static readonly Effect DecreaseAcc50Pcnt = new Effect("Decreases the accuracy of the move to 50%", "Decreases the accuracy of the move to 50%");
        public static readonly Effect DestroyHeldBerry = new Effect("DestroyHeldBerry", "Destroy the target's held berry");
        public static readonly Effect DmgBasedOnOppositeStat = new Effect("DmgOppStat", "Deals damage based on the opposite stat. Physical moves operate on Sp. Defense and Special moves operate on Defense");
        public static readonly Effect DoBPInDmg = new Effect("Do exactly the power of the move in HP to the target", "Do exactly the BP number in damage to the target. For example, 20BP would translate to 20 raw damage, 40BP would translate to 40 damage, etc");
        public static readonly Effect DoesHalfTargetHPDmg = new Effect("Move halves target's current HP", "Move does damage equal to half of the target's current HP");
        public static readonly Effect DoublePower = new Effect("Doubles the power of the move", "A move with this effect will do double its normal damage");
        public static readonly Effect EruptionSpout = new Effect("User does more damage the more HP the user has", "The move does more damage the more HP they have at time of execution");
        public static readonly Effect ForceAttackFirstNextTurn = new Effect("Target attacks first next turn", "Forces the target to attack first next turn");
        public static readonly Effect GuaranteedCritNextTurn = new Effect("Guarantees the next move will crit", "The next move used will result in a critical hit");
        public static readonly Effect HalveWeight = new Effect("HalveWgt", "Halves the weight of the target");
        public static readonly Effect HeavierMoreDmg = new Effect("HeavierMoreDmg", "The heavier the user is compared to the target, the more damage the move does on execution");
        public static readonly Effect HeavierOppMoreDmg = new Effect("HeavierOppMoreDmg", "The heavier the opponent is, the more damage th emove does one execution");
        public static readonly Effect HighCrit = new Effect("Raises critical ratio", "Raises crit ratio from 1/16 to 1/8");
        public static readonly Effect HitAllAdjacent = new Effect("Hits all adjacent pokemon", "The move will hit all adjacent pokemon including allies");
        public static readonly Effect HitAllAllies = new Effect("HitAllAllies", "The move will target all allies on the battlefield at time of execution");
        public static readonly Effect HitAllFoes = new Effect("HitAllFoes", "Hits all foes on the battlefield at time of execution");
        public static readonly Effect HitsMultipleTimes = new Effect("Hits Multiple Times", "The attack hits 2-5 times.");
        public static readonly Effect HitTwiceOneTurn = new Effect("Hits twice in one turn", "The move will strike twice in one turn");
        public static readonly Effect IgnoreStatChanges = new Effect("Ignore opponent's stat changes", "The move will ignore all of the opponent's stat changes");
        public static readonly Effect IncrementalDamageMux = new Effect("Incremental Damage Multiplier", "The attack's damage is multiplied by 2 for 1-5 turns");
        public static readonly Effect LessHPMoreDmg = new Effect("LessHPMoreDmg", "The lower the user's HP on execution, the more damage the move does");
        public static readonly Effect MoreHPMoreDmg = new Effect("More powerful when opponent has higher HP", "The higher the opponent's HP, the more damage the move does. Formula: 120 x (Target Curr HP / Target Max HP");
        public static readonly Effect MoveUsedByAllyThisTurn = new Effect("Extra effects if the same move has been used by an ally this turn", "Doubles power and is used right after an ally uses the same move");
        public static readonly Effect PreventAllSleep = new Effect("Prevents pokemon from sleeping", "Prevents all pokemon on the battlefield from sleeping while the move is being used");
        public static readonly Effect ReduceHPToUsers = new Effect("Reduces HP of the target to the user's", "The move will reduce the HP of the target to your current HP");
        public static readonly Effect ReduceLastMoveBy4PP = new Effect("Redux4PPTgtLstMv", "Reduces the PP of the opponent's last used move by 4");
        public static readonly Effect RemoveEntryHazards = new Effect("RmvEntryHzrd", "Removes all entry hazards");
        public static readonly Effect Repeat3Times = new Effect("Repeats move 3 times", "Repeats the move 3 times");
        public static readonly Effect SelfDestruction = new Effect("User faints", "Move causes the user to faint");
        public static readonly Effect SpecialScreen = new Effect("Special Screen", "Halves damage from special moves.");
        public static readonly Effect SplashDmg = new Effect("Deals 1/16 maximum health to all adjacent pokemon", "Deals 1/16 max HP to all adjacent pokemon in typeless splash damage. Can affect user if move targets an adjacent ally");
        public static readonly Effect Switchout = new Effect("Switches pokemon out", "Pokemon gets switched out for anothe in party");
        public static readonly Effect TransferItem = new Effect("Transfer item to target", "Transfers the user's held item to the target pokemon");
        public static readonly Effect TransferStatBoosts = new Effect("TransferStatBosts", "Transfers all stat boosts from the target to the user");
        public static readonly Effect TransferStatsToSwitchout = new Effect("Passes stat changes to switched in pokemon", "Passes any and all stat changes to switched in pokemon");
        public static readonly Effect TransferStatus = new Effect("TransferStatus", "Transfers status conditions to the target");
        public static readonly Effect TypeMatchesUser = new Effect("Type of the move matches the user", "The type of the move matches the user");
        public static readonly Effect UseLastMove = new Effect("UseLastMv", "Uses the last move of the targt");
        public static readonly Effect UseRandomMove = new Effect("Use a random move of the user", "Uses a random move of the use in addition to any other effects of the move itself");

        public static class Ignore
        {
            /// <summary>
            /// Ignore the semi-invuln state of fly
            /// </summary>
            public static readonly Effect Fly = new Effect("IgnoreFly", "Ignores the semi-invulunerable state given by fly");
            /// <summary>
            /// Ignore the semi-invuln state of dig
            /// </summary>
            public static readonly Effect Dig = new Effect("IgnoreDig", "Ignores the semi-invulnerable state given by Dig");
            /// <summary>
            /// Ignore the semi-invuln state of dive
            /// </summary>
            public static readonly Effect Dive = new Effect("IgnoreDive", "Ignores the semi-invulnerable state given by Dive");
            /// <summary>
            /// Ignore the effects of Protect, Detect, Endure, Wonder Guard, etc
            /// </summary>
            public static readonly Effect AllProtection = new Effect("IgnoreAllProtect", "Ignores all protection moves (including Endure)");
            /// <summary>
            /// Ignore the effects of Protect and Detect
            /// </summary>
            public static readonly Effect Protection = new Effect("IgnoreProtect", "Ignores Protect and Detect");
            /// <summary>
            /// Ignore the target's ability
            /// </summary>
            public static readonly Effect Ability = new Effect("IgnoreAbility", "Ignore the target's ability's effects");
        }
        public static class SetEntryHazards
        {
            /// <summary>
            /// Damages incoming opponents. Additional uses of this move will do more damage. Only affects GROUNDED pkmn.
            /// </summary>
            public static readonly Effect Spikes = new Effect("SetSpikes", "Damages incoming opponents. Additional uses of this move will do more damage. Only affects grounded Pokémon.");

            /// <summary>
            /// Damages incoming opponents. Affected by type matchups.
            /// </summary>
            public static readonly Effect StealthRock = new Effect("SetStealthRock", "Damages incoming opponents. Affected by type matchups.");

            /// <summary>
            /// Reduces Speed of incoming opponents by 1 stage. Only affects grounded pkmn
            /// </summary>
            public static readonly Effect StickyWeb = new Effect("SetStickyWeb", "Reduces Speed of incoming opponents by one stage. Only affects grounded Pokémon.");

            /// <summary>
            /// Poisons incoming opponents. A second use of this move causes the pkmn to be badly poisoned. Only affects grounded pkmn. Poison and Steel type pkmn are immune.
            /// </summary>
            public static readonly Effect ToxicSpikes = new Effect("SetToxicSpikes", "Poisons incoming opponents. A second use of this move causes the Pokémon to be badly poisoned. Only affects grounded Pokémon. Poison-type and Steel-type Pokémon are immune.");
        }
        public static class Split
        {
            /// <summary>
            /// Averages opponents and user's HPs
            /// </summary>
            public static readonly Effect HP = new Effect("SplitHP", "The user and target's HP become the average of both");
            /// <summary>
            /// Averages the defensive stats
            /// </summary>
            public static readonly Effect Guard = new Effect("SplitGuard", "The user and target's Defense and Sp. Defense become the average of both");
            /// <summary>
            /// Averages the offensive stats
            /// </summary>
            public static readonly Effect Power = new Effect("SplitPwr", "The user and target's Attack and Sp. Attack become the average of both");
        }
        public static class Swap
        {
            /// <summary>
            /// Swaps attack and defense (used on self)
            /// </summary>
            public static readonly Effect AtkDef = new Effect("SwapAtkDef", "Swaps the users Attack and Defense");
            /// <summary>
            /// Swaps the user and opponent's defensive boosts (NOT base stats)
            /// </summary>
            public static readonly Effect DefSpDefBoosts = new Effect("SwapDefBoosts", "Swaps defensive boosts with the target");
            /// <summary>
            /// Swaps the user and opponent's abilities
            /// </summary>
            public static readonly Effect Ability = new Effect("SwapAbility", "Swaps abilities with the target");
            /// <summary>
            /// Swaps the user and opponent's speed
            /// </summary>
            public static readonly Effect Speed = new Effect("SwapSpeed", "Swaps Speed with the target");
            /// <summary>
            /// Swaps the user and opponent's stat changes
            /// </summary>
            public static readonly Effect StatChanges = new Effect("SwapStatChanges", "Swaps stat changes with the target");
            /// <summary>
            /// Swaps the user and opponent's items
            /// </summary>
            public static readonly Effect Item = new Effect("SwapItem", "Swaps items with the target");
        }
        public static class Recoil
        {
            /// <summary>
            /// User (or target) takes 1/8 of its max HP as recoil
            /// </summary>
            public static readonly Effect EighthMaxHP = new Effect("EighthMaxHP", "User (or target), takes 1/8 of max HP as recoil damage");

            /// <summary>
            /// User takes 1/2 of its current HP as recoil
            /// </summary>
            public static readonly Effect HalfCurrHP = new Effect("HalfCurrHP", "User takes 1/2 of its current HP as recoil dmg");

            /// <summary>
            /// User takes 1/2 of its max HP as recoil
            /// </summary>
            public static readonly Effect HalfMaxHP = new Effect("HalfMaxHP", "User takes 1/2 of its maximum HP as recoil dmg");

            /// <summary>
            /// User takes 1/2 of the dmg dealt as recoil
            /// </summary>
            public static readonly Effect HalfDmgDealt = new Effect("HalfDmgDealt", "User takes 1/2 of the dmg dealt by its move as recoil");

            /// <summary>
            /// User takes 1/4 of the dmg dealt as recoil
            /// </summary>
            public static readonly Effect QuarterDmgDealt = new Effect("QuarterDmgDealt", "User takes 1/4 of the dmg dealt by its move as recoil");

            /// <summary>
            /// User takes 1/4 of its maximum HP as recoil
            /// </summary>
            public static readonly Effect QuarterMaxHP = new Effect("QuarterMaxHP", "User takes 1/4 of its max HP as recoil dmg");

            /// <summary>
            /// User takes 1/3 of the dmg dealt as recoil
            /// </summary>
            public static readonly Effect ThirdDmgDealt = new Effect("ThirdDmgDealt", "User takes 1/3 of the dmg dealt by its move as recoil");
        }
        public static class Strengthen
        {
            /// <summary>
            /// Strengthens water type moves by 50%
            /// </summary>
            public static readonly Effect Water = new Effect("PlusWater", "Strengthens Water type moves by 50%");
            /// <summary>
            /// Strengthens ground type moves by 50%
            /// </summary>
            public static readonly Effect Ground = new Effect("PlusGround", "Strengthens Ground type moves by 50%");
        }
        public static class Wait
        {
            /// <summary>
            /// Wait 1 turn before execution
            /// </summary>
            public static readonly Effect OneTurn = new Effect("Move executes after the passing of 1 turn", "The move will execute after 1 turn in addition to the effects of the used move");
            /// <summary>
            /// Wait 2 turns before execution
            /// </summary>
            public static readonly Effect TwoTurns = new Effect("Move executes after the passing of 2 turns", "The move will execute after 2 turns in addition to the effects of the used move");
        }
        public static class ChangeTargetType
        {
            /// <summary>
            /// Changes target's type to Water
            /// </summary>
            public static readonly Effect Water = new Effect("ChangeWater", "Changes the target's type to Water");
        }
        public static class AddTypeToTarget
        {
            public static readonly Effect Grass = new Effect("AddGrass", "Adds the Grass type to the target in addition to its other types");

            public static readonly Effect Ghost = new Effect("AddGhost", "Adds the Ghost type to the target in addition to its other types");
        }
        public static class Weaken
        {
            /// <summary>
            /// Weakens Fire type moves' power by 50%
            /// </summary>
            public static readonly Effect Fire = new Effect("WeakenFire", "Weakens Fire type moves' power by 50%");
            /// <summary>
            /// Weakens Electric type moves' power by 50%
            /// </summary>
            public static readonly Effect Electric = new Effect("WeakenEle", "Weakens Electric type moves' power by 50%");
        }
        #endregion

        #region Double Battle Effects
        public static readonly Effect IncreaseTargetDmg50Pcnt = new Effect("Increase the damage of target ally's next move by 50%", "Increases the damage of the target ally's next move by 50% or 1.5x the damage");
        public static readonly Effect UseRandomPartnerMove = new Effect("Use one of partner's moves", "Uses a random move of the partner pokemon. Only works in double battles.");
        #endregion

        #region Healing Effects
        #region HP Restore
        public static readonly Effect FloralHealingEffect = new Effect("FloralHealing", "Heals up to 1/2 of the target's max HP. If Grassy Terrain is in effect, 2/3 of the target's max HP is healed instead");
        public static readonly Effect FullHPRestore = new Effect("FullHPRestore", "Restores HP to full");
        public static readonly Effect HalfHPRestore = new Effect("HalfHPRestore", "Restores half of the user's HP");
        public static readonly Effect HealHalfDmgInflicted = new Effect("HealHalfDmgDone", "Restores an amount of HP equal to half the damage inflicted by the move");
        public static readonly Effect HealTargetAtkStat = new Effect("HealTgtAtkStat", "Heals for an amount equal to the target's attack stat, including any and all stat changes to the target");
        public static readonly Effect SixthHPRestore = new Effect("SixthHPRestore", "Heals one sixth of the user's HP");
        public static readonly Effect SwitchInFullHeal = new Effect("SwitchFull", "Heals a switched in pkmn fully");
        public static readonly Effect ThreeQuarterDmgInflicted = new Effect("ThreeQtrDmgInf", "Heals for 75% of the damage done");
        public static readonly Effect WeatherBasedHPRestore = new Effect("WthrHPRestore", "Heals for varying amounts based on the weather");
        #endregion

        #region Stat Alterations
        public static readonly Effect PreventStatChanges = new Effect("PreventStatChanges", "Prevents stat changes for 5 turns on the user");
        public static readonly Effect RandomStatBuffBy2 = new Effect("RandoStatBuffBy2", "Increases a random stat (incl Evasion and Accuracy) by 2 stages");
        public static readonly Effect ResetAllStatChanges = new Effect("ResetAllStatChanges", "Resets all Pokemon on the battlefield's stat changes.");
        public static readonly Effect ResetStatDrops = new Effect("ResetStatDrops", "Resets any and all stat drops");
        #endregion

        #region Status Cures
        public static readonly Effect CureBurn = new Effect("CureBurn", "Cures the burn status effect");
        public static readonly Effect CureNonVolatile = new Effect("CureNonVolatile", "Cures all non-volatile statuses from the target");
        public static readonly Effect CureParalysis = new Effect("CureParalysis", "Cures the paralysis status effect");
        public static readonly Effect CurePoison = new Effect("CurePoison", "Cures the poison and bad poison status effects");
        public static readonly Effect CureSleep = new Effect("CureSleep", "Cures the sleep status effect");
        public static readonly Effect HealUserPartyStatus = new Effect("HealPartyStatus", "Heal the status conditions of the user's party (both in battle and out), allies, and the user itself.");
        #endregion
        #endregion

        #region Rare Effects
        public static readonly Effect BeatUpEffect = new Effect("BeatUp", "Hits based off the attack of the uesr, but hits as many times as there are able Pokemon in your team at time of execution");
        public static readonly Effect BellyDrumEffect = new Effect("BellyDrum", "Removes half of the target's max HP and maxes the Attack stat.");
        public static readonly Effect BideEffect = new Effect("Bide", "User takes damage for two turns then strikes back with double the amount of damage received.");
        public static readonly Effect BurnUpEffect = new Effect("BurnUp", "User's type changes to typeless after use. Cannot be used if the user is not a fire type");
        public static readonly Effect Camo = new Effect("Camo", "Changes user's type according to location");
        public static readonly Effect ChangeTargetAbilityToInsomnia = new Effect("WorrySeed", "Changes target's ability to Insomnia");
        public static readonly Effect ChangeTargetWater = new Effect("ChgTgtWater", "Changes the target's main type to water");
        public static readonly Effect ChangeTypeToDrive = new Effect("TypeToDrive", "Changes the move's type to the type of the user's held Drive");
        public static readonly Effect ChangeTypeToWeather = new Effect("TypeToWeather", "Changes the move's type based on the weather");
        public static readonly Effect ChargeEffect = new Effect("Charge", "Doubles the power of the next move if it's an Electric type move");
        public static readonly Effect Conv = new Effect("Conv", "Changes user's type to that of it's first listed move");
        public static readonly Effect Conv2 = new Effect("Conv2", "User changes type to become resistant to opponent's last used move");
        public static readonly Effect CraftyShieldEffect = new Effect("CraftyShield", "Protect's user's team from any Status moves used by any opponent.");
        public static readonly Effect CutCurrHPBy75Pcnt = new Effect("CutMajHP", "Removes 75% of the target's remaining HP");
        public static readonly Effect DealRemainingHP = new Effect("DealRemainHP", "Deals damage equal to the remaining HP of the user");
        public static readonly Effect DoublePartySpeed4turns = new Effect("DblPtySpd4Turns", "Doubles the user's party's speed for 4 turns");
        public static readonly Effect DisableEffect = new Effect("Disable", "Opponent can't use it's last attack for 1-8 turns");
        public static readonly Effect ElectrifyEffect = new Effect("Electrify", "Changes the type of the target's move to electric if it has not already attacked this turn");
        public static readonly Effect ElectroBallEffect = new Effect("ElecBall", "Deals more damage the faster the user is compared to the target");
        public static readonly Effect EleTerrain = new Effect("EleTerrain", "Creates terrain that envelops the field and replaces the bg environ and all other terrain for 5 tursn");
        public static readonly Effect FairyLockEffect = new Effect("FairyLock", "Prevents all Pokemon the field from switching out during their next turn.");
        public static readonly Effect FairyTerrainEffect = new Effect("FairyTerrain", "Creates terrain that envelops the field and replaces the background environment and any other terrain that is already in effect. The terrain fades after five turns.");
        public static readonly Effect FalseSwipeEffect = new Effect("FalseSwipe", "Can only deal enough damage to reduce target HP to 1 and cannot K.O.");
        public static readonly Effect FlailEffect = new Effect("Flail", "Deals more damage the lower the user's HP");
        public static readonly Effect FlingEffect = new Effect("Fling", "Deals damage based on the item held by the user");
        public static readonly Effect FlyingPressEffect = new Effect("FlyingPress", "Deals damage as both a Fighting and Flying type move");
        public static readonly Effect FocusPunchEffect = new Effect("FocusPunch", "Charges punch at beginning of turn, if the user is hit by a damaging move before a -3 priority move would execute, the move fails.");
        public static readonly Effect FuryCutterEffect = new Effect("FuryCutter", "If used successively, its power will double");
        public static readonly Effect FreezeDryEffect = new Effect("FreezeDry", "This move is super-effective on water types in addition to its normal type-matchups.");
        public static readonly Effect FriendlyMoreDmg = new Effect("MoreFriendMoreDmg", "The friendlier the pokemon is towards the user, the more damage the move does");
        public static readonly Effect GrassTerrain = new Effect("GrassTerrain", "Creates terrain that envelops the field and replaces the background environment and any other terrain that is already in effect. The terrain fades after five turns.");
        public static readonly Effect GravityEffect = new Effect("Gravity", "Prevents flying moves and the \"raised\" status");
        public static readonly Effect GyroBallEffect = new Effect("GyroBall", "The move inflicts more damage the slower the user is compared to the target.");
        public static readonly Effect HiddenPowerEffect = new Effect("HiddenPwr", "The move's type depends on the IVs of the user");
        public static readonly Effect ImprisonEffect = new Effect("Imprison", "Target cannot use moves the user also knows");
        public static readonly Effect InstructEffect = new Effect("Instruct", "Ally uses a move instead");
        public static readonly Effect IonDelugeEffect = new Effect("Ion Deluge", "Changes Normal type moves to Electric type");
        public static readonly Effect JudgementEffect = new Effect("Judgement", "Arceus' exclusive move. Type changes to the the equipped plate's type");
        public static readonly Effect KingsShieldEffect = new Effect("KingsShield", "Protects the user from damaging moves. Additionally sharply lowers the attacker's Attack stat if hit by a contact move");
        public static readonly Effect KnockOffEffect = new Effect("KnockOff", "Knocks the target's item out of its hands, dealing more damage and consuming the item if successful");
        public static readonly Effect LastResortEffect = new Effect("LastResort", "Move can only be used after all others have been exhausted");
        public static readonly Effect MagicRoomEffect = new Effect("MagicRoom", "Suppresses the effects of held items for 5 turns");
        public static readonly Effect MagnitudeEffect = new Effect("Magnitude", "The base power of Magnitude is one of 7 random values with differing probabilities");
        public static readonly Effect MeFirstEffect = new Effect("MeFirst", "Copies target's move to use the following turn with 1.5 the damage");
        public static readonly Effect MetalBurstEffect = new Effect("MetalBurst", "Returns 1.5 times the damage deal by the foe's last attack");
        public static readonly Effect MetronomeEffect = new Effect("Metronome", "Use any move in the game at random");
        public static readonly Effect MiracleEyeEffect = new Effect("MiracleEye", "Causes accuracy checks against the target to ignore changes to the target's evasion stat stages, also removes Dark type's immunity to Psychic");
        public static readonly Effect MorningSunEffect = new Effect("MorningSun", "Restores the user's HP based on the weather in the battle");
        public static readonly Effect NatGiftEffect = new Effect("Natural Gift", "Damage and type vary with the held berry");
        public static readonly Effect NaturePowerEffect = new Effect("NaturePwr", "Move transforms into different move based on terrain");
        public static readonly Effect NoCrits5Turns = new Effect("NoCrits", "The target's moves cannot crit for 5 turns");
        public static readonly Effect OHKO = new Effect("OHKO", "It's a one-hit KO!");
        public static readonly Effect OricorioForme = new Effect("OricorioForme", "The type of the move is determined by the Oricorio's forme");
        public static readonly Effect PainSplitEffect = new Effect("PainSplit", "User's and opponent's HP becomes the average of both");
        public static readonly Effect PledgesEffect = new Effect("Pledges", "The move does more damage and has other effects if Water or Grass Pledge are used in the same turn");
        public static readonly Effect PwrSwap = new Effect("PwrSwap", "Switch the user's Atk and SpAtk stages with the target's");
        public static readonly Effect PowerTripEffect = new Effect("PowerTrip", "The move does more damage the more positive stat boosts the user has accrued");
        public static readonly Effect PresentEffect = new Effect("Present", "Either damages or heals the target");
        public static readonly Effect PsyTerrainEffect = new Effect("PsyTerrain", "Creates terrain that envelops the field and replaces all bg effects for 5 turns");
        public static readonly Effect PsywaveEffect = new Effect("Psywave", "Deals a random damage equal to 0.5-1.5x the user's level");
        public static readonly Effect PunishmentEffect = new Effect("Punishment", "Deals more damage the more stat boosts the opponent has");
        public static readonly Effect PursuitEffect = new Effect("Pursuit", "Deals double damage if the opponent is switchint out the turn the move is used");
        public static readonly Effect QuickGuardEffect = new Effect("QuickGuard", "Blocks increased priority moves from doing damage to the user and its team");
        public static readonly Effect RecycleEffect = new Effect("Recycle", "User's used held item is restored");
        public static readonly Effect ReflectTypeEffect = new Effect("ReflectType", "User becomes the target's type");
        public static readonly Effect RemoveTargetAbilityEffects = new Effect("RmvTgtAbility", "Cancels out the effect of the opponent's Ability");
        public static readonly Effect RetainCopiedMove = new Effect("RetainCopied", "Replace the move that caused the copying");
        public static readonly Effect ReverseStatChanges = new Effect("RvsStatChanges", "Reverse the stat changes of the target");
        public static readonly Effect RoostEffect = new Effect("Roost", "User loses the Flying type until end of turn");
        public static readonly Effect RototillerEffect = new Effect("Rototiller", "Raises the Atk and SpAtk of Grass types by 1 stage");
        public static readonly Effect SecretPwr = new Effect("SecretPwr", "Deals dmg and has a chance to do a different effect based on location");
        public static readonly Effect ShellTrapEffect = new Effect("ShellTrap", "User sets a trap at the very beginning of a turn, then at thee time of a -3 priority move executing if the user has been hit by a physical move, then it will inflict damage. Otherwise, it will do 0 damage.");
        public static readonly Effect SimpleEffect = new Effect("Simple", "Changes the target's ability to Simple");
        public static readonly Effect SketchEffect = new Effect("Sketch", "Copies the target opponent's last move in totality");
        public static readonly Effect SkyDropEffect = new Effect("SkyDrop", "Represents the move Sky Drop");
        public static readonly Effect SpitUpEffect = new Effect("SpitUp", "Deals varying dmg based on stockpile level");
        public static readonly Effect StockpileEffect = new Effect("Stockpile", "Stores energy for the user to be used in conjunction with Spit Up. Also raises Def and Sp Def");
        public static readonly Effect StoredPwr = new Effect("StoredPwr", "Deals varying damage based on user's stat increases.");
        public static readonly Effect SwallowEffect = new Effect("Swallow", "Heals the user by varying percents of HP based on the stockpile level");
        public static readonly Effect SwitchPlacesAlly = new Effect("SwitchAlly", "User switches places with an adjacent ally");
        public static readonly Effect SynchronoiseEffect = new Effect("Synchronoise", "User hit's all adjacent pokemon that share a type with it");
        public static readonly Effect TgtMvLastThisTurn = new Effect("TgtLastTurn", "Forces the target to move last this turn");
        public static readonly Effect ThrashEffect = new Effect("Thrash", "User swings 2-3 times and becomes confused after completion");
        public static readonly Effect ThroatChopEffect = new Effect("ThroatChop", "Prevents the target from using sound moves for 2 turns");
        public static readonly Effect ThunderEffect = new Effect("Thunder", "Weather effects of the move thunder");
        public static readonly Effect TransformEffect = new Effect("Transform", "User becomes an exat copy of target pokemon, copying moves, stats, stat changes, species, type, cry, etc");
        public static readonly Effect TriAttackEffect = new Effect("TriAttack", "20% chance of proc'ing either burn, paralysis, or freeze");
        public static readonly Effect TrickRoomEffect = new Effect("TrickRoom", "Slower Pokemon go first in the turn for 5 turns");
        public static readonly Effect TripleKickEffect = new Effect("TripleKick", "Move deals damage and will stirke 3 times, with each kick's damage doing increasing damage. Starts at 10 then goes 20 then 30, for a total of 60");
        public static readonly Effect TrumpCardEffect = new Effect("TrumpCard", "Inflicts more damage when fewer PP is remaining. Damage is calc'd based on the PP remaining AFTER execution");
        public static readonly Effect UnfriendlyMoreDamage = new Effect("MoreUnfriendlyMoreDmg", "The more unfriendly the user is toward the player, the more damage the move does.");
        public static readonly Effect UseTgtAtk = new Effect("UseTgtAtk", "Use the target's attack stat to calculate damage");
        public static readonly Effect WideGuardEffect = new Effect("WideGuard", "Protects the user's team from multi-target attacks");
        public static readonly Effect WonderRoomEffect = new Effect("WonderRoom", "Swaps every Pokemon's Defense and Sp. Defense for 5 turns");
        #endregion

        #region Flags
        public static readonly Effect AllyDiedThisTurn = new Effect("AllyDied", "If the user has an ally that died the turn the move is used, it has additional/different effects");
        public static readonly Effect FusionBoltFlag = new Effect("FusionBolt", "If the move Fusion Bolt is used on the same turn by an ally, the move Fusion Flare will double in power");
        public static readonly Effect FusionFlareFlag = new Effect("FusionFlare", "If the move Fusion Flare is used on the same turn by an ally, the move Fusion Bolt will double in power");
        public static readonly Effect hasPlusMinus = new Effect("hasPlusMinus", "If the target has the ability \"Plus\" or \"Minus\", the move will have extra effects.");
        public static readonly Effect ifAfflicted = new Effect("ifAfflicted", "If the user is afflicted by a status condition, the effects of the move will trigger");
        public static readonly Effect ifFirstTurn = new Effect("if1stTurn", "If it is the first turn the pokemon has been rotated in (i.e. match starting, switched in, etc), the move's effects will trigger");
        public static readonly Effect ifGrassType = new Effect("ifGrassType", "If the target is a Grass type, the move will have extra effects");
        public static readonly Effect ifInAir = new Effect("ifInAir", "If the target is in air (from Bounce or Fly), the move has extra effects");
        public static readonly Effect ifMoveMisses = new Effect("ifMoveMisses", "If the move misses, it has extra effects");
        public static readonly Effect ifNoProtection = new Effect("ifNoProtect", "Used mostly for the move Feint, fires the effects of moves if the moves Detect or Protect have not been used this turn");
        public static readonly Effect ifOppositeGender = new Effect("ifOppGender", "If the target is the opposite gender, enact effects. Otherwise, move fails.");
        public static readonly Effect ifTakenDmgThisTurn = new Effect("ifDmgTurn", "If the user has taken damage this turn the move will have extra effects");
        public static readonly Effect ifTgtHoldBerry = new Effect("ifTgtBerry", "If the target is holding a berry, the move has extra effects");
        public static readonly Effect ifTgtFaints = new Effect("ifTgtFaints", "If the target faints as a result of the move's damage, extra effects will occur");
        public static readonly Effect ifUnderground = new Effect("ifDug", "If the target is underground (from the effects of Dig)");
        public static readonly Effect isActiveWeather = new Effect("IsWeather", "If sunlight, fog, hail, sandstorm, or other weather effect active, move has extra effects");
        public static readonly Effect isAsleep = new Effect("If the target is asleep move has extra effects", "The move will have extra effects if the user is asleep");
        public static readonly Effect isHarshSunlight = new Effect("isHarshSunlight", "If a move has extra effects/no recharge time when there is harsh sunlight, then the effects will go off iff there is harsh sunlight");
        public static readonly Effect isHitBeforeNextMove = new Effect("isHitBeforeNxtMove", "If the user is hit by a move before using another move");
        public static readonly Effect isHitByPhysMv = new Effect("isHitByPhysMv", "If the user is hit by a physical move, extra effects occur");
        public static readonly Effect isHitBySpMv = new Effect("isHitBySpMv", "If the user is hit by a special move, extra effects occur");
        public static readonly Effect isParalyzed = new Effect("isParalyzed", "The move will have extra effects if the user is paralyzed");
        public static readonly Effect isPoisoned = new Effect("isPoisoned", "The move will have extra effects if the user is poisoned");
        public static readonly Effect isRaining = new Effect("isRain", "The move will have extra effects if it is raining");
        public static readonly Effect isSandstorm = new Effect("isSandstorm", "The move will have extra effects if the battlefield is under a sandstorm");
        public static readonly Effect LastMoveFailed = new Effect("LastMoveFailed", "The move will have extra effects if the user's last move failed");
        public static readonly Effect NoHeldItem = new Effect("NoHeldItem", "The move will have extra effects if the target (or user) does not have a held item");
        public static readonly Effect NotEatenBerry = new Effect("NoEatBerry", "The move will have extra effects if the user has eaten a berry this match");
        public static readonly Effect OpponentLessThanHalf = new Effect("OppLessHalf", "If the opponent is at or less than 50% HP, then the move has extra effects");
        public static readonly Effect SameMoveLastTurn = new Effect("SameMvLastTurn", "If the move to be used was used the turn before, it has additional effects");
        public static readonly Effect tgtIsAlly = new Effect("tgtAlly", "If the target is an ally, other effects occur");
        public static readonly Effect tgtReadyingAttack = new Effect("tgtRdyAtk", "If the target is readying an attack, the move has extra effects");
        #endregion
        #endregion

        #region Stat Changes
        #region Positive Stat Changes
        public static readonly StatChange AtkUp1 = new StatChange("Attack raised by 1", "Raises Attack by 1 stage", Atk, 1);
        public static readonly StatChange AtkUp2 = new StatChange("Attack raised by 2", "Raises Attack by 2 stages", Atk, 2);
        public static readonly StatChange AtkUp3 = new StatChange("Attack raised by 3", "Raises Attack by 3 stages", Atk, 3);
        public static readonly StatChange AtkUp2IfKnockout = new StatChange("Attack raised by 2", "Raises Attack by 2 stages if the move causes a K.O.", Atk, 2);
        public static readonly StatChange AtkMaxIfCrit = new StatChange("Attack is maximized!", "Raises Attack to maximum stage if the move crits.", Atk, 6);

        public static readonly StatChange DefUp1 = new StatChange("Defense raised by 1", "Raises Defense by 1 stage", Def, 1);
        public static readonly StatChange DefUp2 = new StatChange("Defense raised by 2", "Raises Defense by 2 stages", Def, 2);
        public static readonly StatChange DefUp3 = new StatChange("Defense raised by 3", "Raises Defense by 3 stages", Def, 3);

        public static readonly StatChange SpAtkUp1 = new StatChange("Sp. Attack raised by 1", "Raises Special Attack by 1 stage", SpAtk, 1);
        public static readonly StatChange SpAtkUp2 = new StatChange("Sp. Attack raised by 2", "Raises Special Attack by 2 stages", SpAtk, 2);
        public static readonly StatChange SpAtkUp3 = new StatChange("Sp. Attack raised by 3", "Raises Special Attack by 3 stages", SpAtk, 3);

        public static readonly StatChange SpDefUp1 = new StatChange("Sp. Defense raised by 1", "Raises Special Defense by 1 stage", SpDef, 1);
        public static readonly StatChange SpDefUp2 = new StatChange("Sp. Defense raised by 2", "Raises Special Defense by 2 stages", SpDef, 2);

        public static readonly StatChange SpdUp1 = new StatChange("Speed raised by 1", "Raises Speed by 1 stage", Spd, 1);
        public static readonly StatChange SpdUp2 = new StatChange("Speed raised by 2", "Raises Speed by 2 stages", Spd, 2);

        public static readonly StatChange EvasUp1 = new StatChange("Evasion raised by 1", "Raises Evasion by 1 stage", Evasion, 1);
        public static readonly StatChange EvasUp2 = new StatChange("Evasion raised by 2", "Raises Evasion by 2 stages", Evasion, 2);

        public static readonly StatChange AccUp1 = new StatChange("Accuracy raised by 1", "Raises Accuracy by 1 stage", Accuracy, 1);
        public static readonly StatChange AccUp2 = new StatChange("Accuracy raised by 2", "Raises Accuracy by 2 stages", Accuracy, 2);

        public static readonly StatChange CritUp1 = new StatChange("Crit raised by 1", "Raises Critical Hit Ratio by 1 stage", Crit, 1);
        public static readonly StatChange CritUp2 = new StatChange("Crit raised by 2", "Raises Critical Hit Ratio by 2 stages", Crit, 2);
        #endregion

        #region Negative Stat Change
        public static readonly StatChange AtkDwn1 = new StatChange("Attack lowered by 1", "Lowers Attack by 1 stage", Atk, -1);
        public static readonly StatChange AtkDwn2 = new StatChange("Attack lowered by 2", "Lowers Attack by 2 stages", Atk, -2);

        public static readonly StatChange DefDwn1 = new StatChange("Defense lowered by 1", "Lowers Defense by 1 stage", Def, -1);
        public static readonly StatChange DefDwn2 = new StatChange("Defense lowered by 2", "Lowers Defense by 2 stages", Def, -2);

        public static readonly StatChange SpAtkDwn1 = new StatChange("Sp. Attack lowered by 1", "Lowers Special Attack by 1 stage", SpAtk, -1);
        public static readonly StatChange SpAtkDwn2 = new StatChange("Sp. Attack lowered by 2", "Lowers Special Attack by 2 stages", SpAtk, -2);

        public static readonly StatChange SpDefDwn1 = new StatChange("Sp. Defense lowered by 1", "Lowers Special Defense by 1 stage", SpDef, -1);
        public static readonly StatChange SpDefDwn2 = new StatChange("Sp. Defense lowered by 2", "Lowers Special Defense by 2 stages", SpDef, -2);

        public static readonly StatChange SpdDwn1 = new StatChange("Speed lowered by 1", "Lowers Speed by 1 stage", Spd, -1);
        public static readonly StatChange SpdDwn2 = new StatChange("Speed lowered by 2", "Lowers Speed by 2 stages", Spd, -2);

        public static readonly StatChange EvasDwn1 = new StatChange("Evasion lowered by 1", "Lowers Evasion by 1 stage", Evasion, -1);
        public static readonly StatChange EvasDwn2 = new StatChange("Evasion lowered by 2", "Lowers Evasion by 2 stages", Evasion, -2);

        public static readonly StatChange AccDwn1 = new StatChange("Accuracy lowered by 1", "Lowers Accuracy by 1 stage", Accuracy, -1);
        #endregion
        #endregion

        #region Statuses
        #region Base Statuses
        public static readonly Effect Freeze = new Effect("Freeze", "The Pokemon is frozen and cannot attack. There is a 20% chance that the pokemon will thaw.");
        public static readonly Effect Burn = new Effect("Burn", "The Pokemon is burned and loses 1/8 of its maximum health and deals 1/2 damage with physical attacks.");
        public static readonly Effect Paralysis = new Effect("Paralysis", "The Pokemon is paralyzed and has a 25% chance of not being able to attack.");
        public static readonly Effect Sleep = new Effect("Sleep", "The Pokemon is slept from 1 to 3 turns and cannot attack.");
        public static readonly Effect Poisoned = new Effect("Poisoned", "The Pokemon is poisoned and loses 1/8 of its maximum HP at the end of every turn.");
        public static readonly Effect BadPoison = new Effect("Badly Poisoned", "The Pokemon is badly poisoned and loses 1/16 of its maximum HP plus another 1/16 every turn thereafter (1/16 the first turn, 1/8 the second, etc).");
        #endregion

        #region Volatile Statuses
        public static readonly Effect AquaRingStatus = new Effect("Aqua Ring", "The Pokemon surrounds itself with a veil of water, restoring 1/16th of its maximum HP.");
        public static readonly Effect Bound = new Effect("Bound", "The Pokemon is bound and will lose 1/8 of its maximum HP at the end of each turn.");
        public static readonly Effect Bracing = new Effect("Bracing", "The Pokemon is bracing and cannot go below 1 HP");
        public static readonly Effect CenterofAttention = new Effect("Center of Attention", "The Pokemon becomes the Center of Attention, forcing opponents to target it.");
        public static readonly Effect Charging = new Effect("Charging", "The Pokemon is charging up a move to hit on the next turn");
        public static readonly Effect Confused = new Effect("Confused", "The Pokemon is confused and will hit itself rather than its opponent 33% of the time.");
        public static readonly Effect CurseStatus = new Effect("Curse", "The Pokemon is cursed and will lose 1/4 of its maximum HP at the end of each turn.");
        public static readonly Effect DefCurl = new Effect("Defense Curl", "The moves Rollout and Ice Ball deal double damage for this Pokemon.");
        public static readonly Effect Destiny = new Effect("Destiny", "If the user of the move causing this status dies, so does the opposing Pokemon affected by Destiny");
        public static readonly Effect EmbargoStatus = new Effect("Embargo", "The Pokemon is embargoed and is unable to use its held item.");
        public static readonly Effect EncoreStatus = new Effect("Encore", "The Pokemon is being encored for 3 turns and will repeat its last attack.");
        public static readonly Effect Flinch = new Effect("Flinch", "The Pokemon is flinching and cannot attack for the turn in which it is being flinched.");
        public static readonly Effect Glowing = new Effect("Glowing", "The Pokemon is cloaked in light for one-turn and cannot attack.");
        public static readonly Effect Grounded = new Effect("Grounded", "The Pokemon is now susceptible to Ground, Terrain, Areana Trap");
        public static readonly Effect GrudgeStatus = new Effect("Grudge", "If the applier of this status dies, its opponent's last move loses all PP");
        public static readonly Effect HealBlockStatus = new Effect("Heal Block", "The Pokemon is blocked from healing and cannot heal or be healed for 5 turns.");
        public static readonly Effect Identified = new Effect("Identified", "The Pokemon is identified and has all of its evasion modifiers ignored. Additionally, all no-effect type matchups will do normal damage.");
        public static readonly Effect Infatuated = new Effect("Infatuated", "The Pokemon is infatuated and cannot attack 50% of the time.");
        public static readonly Effect LeechSeedStatus = new Effect("Leech Seed", "The Pokemon is seeded and loses 1/8 of its maximum health at the end of every turn.");
        public static readonly Effect LegHold = new Effect("LegHold", "The Pokemon is held in place and cannot escape!");
        public static readonly Effect MagicCoatStatus = new Effect("Magic Coat", "The Pokemon shrouds itself in a coat that reflects most statuses inflicted upon it or its side of the field back to the user.");
        public static readonly Effect MagneticLevitation = new Effect("Magnetic Levitation", "The Pokemon levitates via Magnet Rise and becomes immune to ground-based attacks.");
        public static readonly Effect MinimizeStatus = new Effect("Minimize", "The Pokemon raises its evasion by 2 stages, but takes double damage from some moves.");
        public static readonly Effect NightmareStatus = new Effect("Nightmare", "The Pokemon is under the effects of a nightmare and loses 1/4 of its maximum HP at the end of every turn if asleep.");
        public static readonly Effect PerishSongStatus = new Effect("Perish Song", "The Pokemon has heard a perishing song and will wil faint in 3 turns if not switched out.");
        public static readonly Effect Powdered = new Effect("Powdered", "If a fire type move is used, the Pokemon takes 25% of their HP in self damage and the move will fail to execute.");
        public static readonly Effect Protection = new Effect("Protection", "The Pokemon is protected from most damaging and status moves.");
        public static readonly Effect Raised = new Effect("Raised", "The Pokemon is raised above the ground and is immune to Ground type moves and terrain moves");
        public static readonly Effect Recharging = new Effect("Recharging", "The Pokemon is recharging from using a powerful move and cannot attack for 1 turn");
        public static readonly Effect Rooting = new Effect("Rooting", "The Pokemon plants its roots, restoring 1/16th of its maximum HP and cannot switch-out");
        public static readonly Effect SafeguardStatus = new Effect("Safeguard", "The user's party is protected from status conditions");
        public static readonly Effect SemiInvulnerable = new Effect("Semi-Invulnerable", "The Pokemon is invulnerable to most attacks for 1 turn.");
        public static readonly Effect SubstituteStatus = new Effect("Substitute", "The Pokemon converts 1/4 of its total HP into a substitute that absorbs damage until it breaks and cannot be affected by status conditions.");
        public static readonly Effect TakingAim = new Effect("Taking Aim", "The Pokemon is taking aim. Its next attack will hit regardless of accuracy.");
        public static readonly Effect TakingInSunlight = new Effect("Taking in Sunlight", "The Pokemon is absorbing sunlight and cannot attck for 1 turn.");
        public static readonly Effect TauntStatus = new Effect("Taunt", "The Pokemon is taunted and cannot use status moves for 3 turns.");
        public static readonly Effect TeamProtection = new Effect("Team Protection", "The Pokemon protects both it and its allies from specific moves.");
        public static readonly Effect TelekinesisStatus = new Effect("Telekinesis", "The Pokemon is telekinetically elevated and becomes immune to Ground-type moves, Spikes, Toxic Spikes, and Arena Trap.");
        public static readonly Effect TormentStatus = new Effect("Torment", "The Pokemon is tormented and cannot use the same move twice in a row.");
        public static readonly Effect WhippingUpWhirlwind = new Effect("Whipping up a Whirlwind", "The Pokemon is readying a whirlwind. It cannot attack for 1 turn.");
        public static readonly Effect Withdrawing = new Effect("Withdrawing", "The Pokemon is readying a bash with its skull. It cannot attack for 1 turn.");
        #endregion
        #endregion

        #region Types
        // Type chart is Normal, Fire, Water, Ele, Grass, Ice, Fight, Poison, Ground, Fly, Psy, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy (18 total)

        public static readonly BasicType Normal = new BasicType("Normal", new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -42, 0, 0, 0, 0 });
        public static readonly BasicType Fire = new BasicType("Fire", new int[] { 0, -1, 1, 0, -1, -1, 0, 0, 1, 0, 0, -1, 1, 0, 0, 0, -1, -1 });
        public static readonly BasicType Water = new BasicType("Water", new int[] { 0, -1, -1, 1, 1, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0 });
        public static readonly BasicType Electric = new BasicType("Electric", new int[] { 0, 0, 0, -1, 0, 0, 0, 0, 1, -1, 0, 0, 0, 0, 0, 0, -1, 0 });
        public static readonly BasicType Grass = new BasicType("Grass", new int[] { 0, 1, -1, -1, -1, 1, 0, 1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 0 });
        public static readonly BasicType Ice = new BasicType("Ice", new int[] { 0, 1, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 });
        public static readonly BasicType Fighting = new BasicType("Fighting", new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, -1, -1, 0, 0, -1, 0, 1 });
        public static readonly BasicType Poison = new BasicType("Poison", new int[] { 0, 0, 0, 0, -1, 0, -1, -1, 1, 0, 1, -1, 0, 0, 0, 0, 0, -1 });
        public static readonly BasicType Ground = new BasicType("Ground", new int[] { 0, 0, 1, -42, 1, 1, 0, -1, 0, 0, 0, 0, -1, 0, 0, 0, 0, 0 });
        public static readonly BasicType Flying = new BasicType("Flying", new int[] { 0, 0, 0, 1, -1, 1, -1, 0, -42, 0, 0, -1, 1, 0, 0, 0, 0, 0 });
        public static readonly BasicType Psychic = new BasicType("Psychic", new int[] { 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, -1, 1, 0, 1, 0, 1, 0, 0 });
        public static readonly BasicType Bug = new BasicType("Bug", new int[] { 0, 1, 0, 0, -1, 0, -1, 0, -1, 1, 0, 0, 1, 0, 0, 0, 0, 0 });
        public static readonly BasicType Rock = new BasicType("Rock", new int[] { -1, -1, 1, 0, 1, 0, 1, -1, 1, -1, 0, 0, 0, 0, 0, 0, 1, 0 });
        public static readonly BasicType Ghost = new BasicType("Ghost", new int[] { -42, 0, 0, 0, 0, 0, -42, -1, 0, 0, 0, -1, 0, 1, 0, 1, 0, 0 });
        public static readonly BasicType Dragon = new BasicType("Dragon", new int[] { 0, -1, -1, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1 });
        public static readonly BasicType Dark = new BasicType("Dark", new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, -42, 1, 0, -1, 0, -1, 0, 1 });
        public static readonly BasicType Steel = new BasicType("Steel", new int[] { -1, 1, 0, 0, -1, -1, 1, -42, 1, -1, -1, -1, -1, 0, -1, 0, -1, -1 });
        public static readonly BasicType Fairy = new BasicType("Fairy", new int[] { 0, 0, 0, 0, 0, 0, -1, 1, 0, 0, 0, -1, 0, 0, -42, -1, 1, 0 });
        public static readonly BasicType Typeless = new BasicType("TYPELESS", new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        #endregion

        #region Z Moves
        #region Unique
        public static readonly ZMove Catastropika = new ZMove("Catastropika", 210, null, null);
        public static readonly ZMove ExtremeEvoboost = new ZMove("Extreme Evoboost", 0, new Effect[] { AtkUp2, DefUp2, SpAtkUp2, SpDefUp2, SpdUp2 }, new bool[] { true, true, true, true, true });
        public static readonly ZMove GenesisSupernova = new ZMove("Genesis Supernova", 185, null, null);
        public static readonly ZMove GuardianOfAlola = new ZMove("Guardian of Alola", 0, new Effect[] { CutCurrHPBy75Pcnt }, new bool[] { false });
        public static readonly ZMove MaliciousMoonsault = new ZMove("Malicious Moonsault", 180, null, null);
        public static readonly ZMove NO_EFFECT = new ZMove("EMPTY", 0, null, null);
        public static readonly ZMove OceanicOperetta = new ZMove("Oceanic Operetta", 195, null, null);
        public static readonly ZMove PulverizingPancake = new ZMove("Pulverizing Pancake", 210, null, null);
        public static readonly ZMove SinisterArrowRaid = new ZMove("Sinister Arrow Raid", 180, null, null);
        public static readonly ZMove StokedSparksurfer = new ZMove("Stoked Sparksurfer", 175, null, null);
        public static readonly ZMove VoltThunderbolt = new ZMove("10,000,000 Volt Thunderbolt", 195, new Effect[] { HighCrit }, new bool[] { true });
        #endregion

        #region Normal
        #region A-M
        public static readonly ZMove BreakneckBlitz = new ZMove("Breakneck Blitz", 100, null, null);
        public static readonly ZMove ZAcupressure = new ZMove("Z-Acupressure", 0, new Effect[] { CritUp1 }, new bool[] { true });
        public static readonly ZMove ZAfterYou = new ZMove("Z-After You", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZAttract = new ZMove("Z-Attract", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZBatonPass = new ZMove("Z-Baton Pass", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZBellyDrum = new ZMove("Z-Belly Drum", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZBestow = new ZMove("Z-Bestow", 0, new Effect[] { SpdUp2 }, new bool[] { true });
        public static readonly ZMove ZBlock = new ZMove("Z-Block", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZCamouflage = new ZMove("Z-Camouflage", 0, new Effect[] { EvasUp1 }, new bool[] { true });
        public static readonly ZMove ZCaptivate = new ZMove("Z-Captivate", 0, new Effect[] { SpDefUp2 }, new bool[] { true });
        public static readonly ZMove ZCelebrate = new ZMove("Z-Celebrate", 0, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true });
        public static readonly ZMove ZConfide = new ZMove("Z-Confide", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZConversion = new ZMove("Z-Conversion", 0, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true });
        public static readonly ZMove ZConversion2 = new ZMove("Z-Conversion2", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZCopycat = new ZMove("Z-Copycat", 0, new Effect[] { AccUp1 }, new bool[] { true });
        public static readonly ZMove ZDefenseCurl = new ZMove("Z-Defense Curl", 0, new Effect[] { AccUp1 }, new bool[] { true });
        public static readonly ZMove ZDisable = new ZMove("Z-Disable", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZDoubleTeam = new ZMove("Z-DoubleTeam", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZEncore = new ZMove("Z-Encore", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZEndure = new ZMove("Z-Endure", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZEntrainment = new ZMove("Z-Entrainment", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZFlash = new ZMove("Z-Flash", 0, new Effect[] { EvasUp1 }, new bool[] { true });
        public static readonly ZMove ZFocusEnergy = new ZMove("Z-Focus Energy", 0, new Effect[] { AccUp1 }, new bool[] { true });
        public static readonly ZMove ZFollowMe = new ZMove("Z-Follow Me", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZForesight = new ZMove("Z-Foresight", 0, new Effect[] { CritUp1 }, new bool[] { true });
        public static readonly ZMove ZGlare = new ZMove("Z-Glare", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZGrowl = new ZMove("Z-Growl", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZGrowth = new ZMove("Z-Growth", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZHappyHour = new ZMove("Z-Happy Hour", 0, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true });
        public static readonly ZMove ZHarden = new ZMove("Z-Harden", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZHealBell = new ZMove("Z-Heal Bell", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZHelpingHand = new ZMove("Z-Helping Hand", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZHoldHands = new ZMove("Z-Hold Hands", 0, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true });
        public static readonly ZMove ZHowl = new ZMove("Z-Howl", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZLaserFocus = new ZMove("Z-Laser Focus", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZLeer = new ZMove("Z-Leer", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZLockOn = new ZMove("Z-Lock-On", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZLovelyKiss = new ZMove("Z-Lovely Kiss", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZLuckyChant = new ZMove("Z-Lucky Chant", 0, new Effect[] { EvasUp1 }, new bool[] { true });
        public static readonly ZMove ZMeanLook = new ZMove("Z-Mean Look", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZMeFirst = new ZMove("Z-Me First", 0, new Effect[] { SpdUp2 }, new bool[] { true });
        public static readonly ZMove ZMilkDrink = new ZMove("Z-Milk Drink", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZMimic = new ZMove("Z-Mimic", 0, new Effect[] { AccUp1 }, new bool[] { true });
        public static readonly ZMove ZMindReader = new ZMove("Z-Mind Reader", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZMinimize = new ZMove("Z-Minimize", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZMorningSun = new ZMove("Z-Morning Sun", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        #endregion
        #region N-Z
        public static readonly ZMove ZNobleRoar = new ZMove("Z-Noble Roar", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZOdorSleuth = new ZMove("Z-Odor Sleuth", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZPainSplit = new ZMove("Z-Pain Split", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZPerishSong = new ZMove("Z-Perish Song", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZPlayNice = new ZMove("Z-Play Nice", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZProtect = new ZMove("Z-Protect", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZPsychUp = new ZMove("Z-PsychUp", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZRecover = new ZMove("Z-Recover", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZRecycle = new ZMove("Z-Recycle", 0, new Effect[] { SpdUp2 }, new bool[] { true });
        public static readonly ZMove ZReflectType = new ZMove("Z-Reflect Type", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZRefresh = new ZMove("Z-Refresh", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZRoar = new ZMove("Z-Roar", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZSafeguard = new ZMove("Z-Safeguard", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZScaryFace = new ZMove("Z-Scary Face", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZScreech = new ZMove("Z-Screech", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZSharpen = new ZMove("Z-Sharpen", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZShellSmash = new ZMove("Z-Shell Smash", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSimpleBeam = new ZMove("Z-Simple Beam", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZSing = new ZMove("Z-Sing", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZSketch = new ZMove("Z-Sketch", 0, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true });
        public static readonly ZMove ZSlackOff = new ZMove("Z-Slack Off", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSleepTalk = new ZMove("Z-Sleep Talk", 0, new Effect[] { CritUp1 }, new bool[] { true });
        public static readonly ZMove ZSmokescreen = new ZMove("Z-Smokescreen", 0, new Effect[] { EvasUp1 }, new bool[] { true });
        public static readonly ZMove ZSoftBoiled = new ZMove("Z-Soft-Boiled", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSplash = new ZMove("Z-Splash", 0, new Effect[] { AtkUp3 }, new bool[] { true });
        public static readonly ZMove ZSpotlight = new ZMove("Z-Spotlight", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZStockpile = new ZMove("Z-Stockpile", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZSubstitute = new ZMove("Z-Substitute", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSupersonic = new ZMove("Z-Supersonic", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZSwagger = new ZMove("Z-Swagger", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSwallow = new ZMove("Z-Swallow", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSweetScent = new ZMove("Z-Sweet Scent", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSwordsDance = new ZMove("Z-Swords Dance", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZTailWhip = new ZMove("Z-Tail Whip", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZTearfulLook = new ZMove("Z-Tearful Look", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZTeeterDance = new ZMove("Z-Teeter Dance", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZTickle = new ZMove("Z-Tickle", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZTransform = new ZMove("Z-Transform", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZWhirlwind = new ZMove("Z-Whirlwind", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZWish = new ZMove("Z-Wish", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZWorkUp = new ZMove("Z-Work Up", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZYawn = new ZMove("Z-Yawn", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        #endregion
        #endregion

        #region Fire
        public static readonly ZMove InfernoOverdrive = new ZMove("Inferno Overdrive", 100, null, null);
        public static readonly ZMove ZSunnyDay = new ZMove("Z-Sunny Day", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZWillOWisp = new ZMove("Z-Will-O-Wisp", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        #endregion

        #region Water
        public static readonly ZMove HydroVortex = new ZMove("Hydro Vortex", 100, null, null);
        public static readonly ZMove ZAquaRing = new ZMove("Z-Aqua Ring", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZRainDance = new ZMove("Z-Rain Dance", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZSoak = new ZMove("Z-Soak", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZWaterSport = new ZMove("Z-Water Sport", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZWithdraw = new ZMove("Z-Withdraw", 0, new Effect[] { DefUp1 }, new bool[] { true });
        #endregion

        #region Electric
        public static readonly ZMove GigavoltHavoc = new ZMove("Gigavolt Havoc", 100, null, null);
        public static readonly ZMove ZCharge = new ZMove("Z-Charge", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZEerieImpulse = new ZMove("Z-Eerie Impulse", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZElectricTerrain = new ZMove("Z-Electric Terrain", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZElectrify = new ZMove("Z-Electrify", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZIonDeluge = new ZMove("Z-Ion Deluge", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZMagnetRise = new ZMove("Z-Magnet Rise", 0, new Effect[] { EvasUp1 }, new bool[] { true });
        public static readonly ZMove ZMagneticFlux = new ZMove("Z-Magnetic Flux", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZThunderWave = new ZMove("Z-Thunder Wave", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        #endregion

        #region Grass
        public static readonly ZMove BloomDoom = new ZMove("Bloom Doom", 100, null, null);
        public static readonly ZMove ZAromatherapy = new ZMove("Z-Aromatherapy", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZCottonGuard = new ZMove("Z-Cotton Guard", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZCottonSpore = new ZMove("Z-Cotton Spore", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZForestsCurse = new ZMove("Z-Forest's Curse", 0, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true });
        public static readonly ZMove ZGrassWhistle = new ZMove("Z-Grass Whistle", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZGrassyTerrain = new ZMove("Z-Grassy Terrain", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZIngrain = new ZMove("Z-Ingrain", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZLeechSeed = new ZMove("Z-Leech Seed", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSleepPowder = new ZMove("Z-Sleep Powder", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZSpikyShield = new ZMove("Z-Spiky Shield", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZSpore = new ZMove("Z-Spore", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZStrengthSap = new ZMove("Z-Strengthh Sap", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZStunSpore = new ZMove("Z-Stun Spore", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZSynthesis = new ZMove("Z-Synthesis", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZWorrySeed = new ZMove("Z-Worry Seed", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        #endregion

        #region Ice
        public static readonly ZMove SubzeroSlammer = new ZMove("Subzero Slammer", 120, null, null);
        public static readonly ZMove ZAuroraVeil = new ZMove("Z-Aurora Veil", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZHail = new ZMove("Z-Hail", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZHaze = new ZMove("Z-Haze", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZMist = new ZMove("Z-Mist", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        #endregion

        #region Fighting
        public static readonly ZMove AllOutPummeling = new ZMove("All-Out Pummeling", 100, null, null);
        public static readonly ZMove ZBulkUp = new ZMove("Z-Bulk Up", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZDetect = new ZMove("Z-Detect", 0, new Effect[] { EvasUp1 }, new bool[] { true });
        public static readonly ZMove ZMatBlock = new ZMove("Z-Mat Block", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZQuickGuard = new ZMove("Z-Quick Guard", 0, new Effect[] { DefUp1 }, new bool[] { true });
        #endregion

        #region Poison
        public static readonly ZMove AcidDownpour = new ZMove("Acid Downpour", 100, null, null);
        public static readonly ZMove ZAcidArmor = new ZMove("Z-Acid Armor", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZBanefulBunker = new ZMove("Z-Baneful Bunker", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZCoil = new ZMove("Z-Coil", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZGastroAcid = new ZMove("Z-Gastro Acid", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZPoisonGas = new ZMove("Z-Poison Gas", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZPoisonPowder = new ZMove("Z-Poison Powder", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZPurify = new ZMove("Z-Purify", 0, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true });
        public static readonly ZMove ZToxic = new ZMove("Z-Toxic", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZToxicSpikes = new ZMove("Z-Toxic Spikes", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZToxicThread = new ZMove("Z-Toxic Thread", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZVenomDrench = new ZMove("Z-Venom Drench", 0, new Effect[] { DefUp1 }, new bool[] { true });
        #endregion

        #region Ground
        public static readonly ZMove TectonicRage = new ZMove("Tectonic Rage", 100, null, null);
        public static readonly ZMove ZMudSport = new ZMove("Z-Mud Sport", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZRototiller = new ZMove("Z-Rototiller", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZSandAttack = new ZMove("Z-Sand Attack", 0, new Effect[] { EvasUp1 }, new bool[] { true });
        public static readonly ZMove ZShoreUp = new ZMove("Z-Shore Up", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSpikes = new ZMove("Z-Spikes", 0, new Effect[] { DefUp1 }, new bool[] { true });
        #endregion

        #region Flying
        public static readonly ZMove SupersonicSkystrike = new ZMove("Supersonic Skystrike", 100, null, null);
        public static readonly ZMove ZDefog = new ZMove("Z-Defog", 0, new Effect[] { AccUp1 }, new bool[] { true });
        public static readonly ZMove ZFeatherDance = new ZMove("Z-Feather Dance", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZMirrorMove = new ZMove("Z-Mirror Move", 0, new Effect[] { AtkUp2 }, new bool[] { true });
        public static readonly ZMove ZRoost = new ZMove("Z-Roost", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZTailwind = new ZMove("Z-Tailwind", 0, new Effect[] { CritUp1 }, new bool[] { true });
        #endregion

        #region Psychic
        public static readonly ZMove ShatteredPsyche = new ZMove("Shattered Psyche", 100, null, null);
        public static readonly ZMove ZAgility = new ZMove("Z-Agility", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZAllySwitch = new ZMove("Z-Ally Switch", 0, new Effect[] { SpdUp2 }, new bool[] { true });
        public static readonly ZMove ZAmnesia = new ZMove("Z-Amnesia", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZBarrier = new ZMove("Z-Barrier", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZCalmMind = new ZMove("Z-Calm Mind", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZCosmicPower = new ZMove("Z-Cosmic Power", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZGravity = new ZMove("Z-Gravity", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZGuardSplit = new ZMove("Z-Guard Split", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZGuardSwap = new ZMove("Z-Guard Swap", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZHealBlock = new ZMove("Z-Heal Block", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZHealPulse = new ZMove("Z-Heal Pulse", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZHeartSwap = new ZMove("Z-Heart Swap", 0, new Effect[] { CritUp1 }, new bool[] { true });
        public static readonly ZMove ZHypnosis = new ZMove("Z-Hypnosis", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZImprison = new ZMove("Z-Imprison", 0, new Effect[] { SpDefUp2 }, new bool[] { true });
        public static readonly ZMove ZInstruct = new ZMove("Z-Instruct", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZKinesis = new ZMove("Z-Kinesis", 0, new Effect[] { EvasUp1 }, new bool[] { true });
        public static readonly ZMove ZLightScreen = new ZMove("Z-Light Screen", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZMagicCoat = new ZMove("Z-Magic Coat", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZMagicRoom = new ZMove("Z-Magic Room", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZMeditate = new ZMove("Z-Meditate", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZMiracleEye = new ZMove("Z-Miracle Eye", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZPowerSplit = new ZMove("Z-Power Split", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZPowerSwap = new ZMove("Z-Power Swap", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZPowerTrick = new ZMove("Z-Power Trick", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZPsychicTerrain = new ZMove("Z-Psychic Terrain", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZPsychoShift = new ZMove("Z-Psycho Shift", 0, new Effect[] { SpAtkUp2 }, new bool[] { true });
        public static readonly ZMove ZReflect = new ZMove("Z-Reflect", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZRest = new ZMove("Z-Rest", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZRolePlay = new ZMove("Z-Role Play", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZSkillSwap = new ZMove("Z-Skill Swap", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZSpeedSwap = new ZMove("Z-Speed Swap", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZTelekinesis = new ZMove("Z-Telekinesis", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZTeleport = new ZMove("Z-Teleport", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZTrick = new ZMove("Z-Trick", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZTrickRoom = new ZMove("Z-Trick Room", 0, new Effect[] { AccUp1 }, new bool[] { true });
        public static readonly ZMove ZWonderRoom = new ZMove("Z-Wonder Room", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        #endregion

        #region Rock
        public static readonly ZMove ContinentalCrush = new ZMove("Continental Crush", 100, null, null);
        public static readonly ZMove ZRockPolish = new ZMove("Z-Rock Polish", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSandstorm = new ZMove("Z-Sandstorm", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZStealthRock = new ZMove("Z-Stealth Rock", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZWideGuard = new ZMove("Z-Wide Guard", 0, new Effect[] { DefUp1 }, new bool[] { true });
        #endregion

        #region Bug
        public static readonly ZMove SavageSpinOut = new ZMove("Savage Spin-Out", 100, null, null);
        public static readonly ZMove ZDefendOrder = new ZMove("Z-Defend Order", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZHealOrder = new ZMove("Z-Heal Order", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZPowder = new ZMove("Z-Powder", 0, new Effect[] { SpDefUp2 }, new bool[] { true });
        public static readonly ZMove ZQuiverDance = new ZMove("Z-Quiver Dance", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZRagePowder = new ZMove("Z-Rage Powder", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSpiderWeb = new ZMove("Z-Spider Web", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZStickyWeb = new ZMove("Z-Sticky Web", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZStringShot = new ZMove("Z-String Shot", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZTailGlow = new ZMove("Z-Tail Glow", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        #endregion

        #region Dragon
        public static readonly ZMove DevastatingDrake = new ZMove("Devastating Drake", 100, null, null);
        public static readonly ZMove ZDragonDance = new ZMove("Z-Dragon Dance", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        #endregion

        #region Ghost
        public static readonly ZMove NeverEndingNightmare = new ZMove("Never-Ending Nightmare", 100, null, null);
        public static readonly ZMove ZConfuseRay = new ZMove("Z-Confuse Ray", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZDestinyBond = new ZMove("Z-Destiny Bond", 0, new Effect[] { CenterofAttention }, new bool[] { true });
        public static readonly ZMove ZGhostCurse = new ZMove("Z-Curse", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZGrudge = new ZMove("Z-Grudge", 0, new Effect[] { CenterofAttention }, new bool[] { true });
        public static readonly ZMove ZNightmare = new ZMove("Z-Nightmare", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZNonGhostCurse = new ZMove("Z-Curse", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZSpite = new ZMove("Z-Spite", 0, new Effect[] { FullHPRestore }, new bool[] { true });
        public static readonly ZMove ZTrickOrTreat = new ZMove("Z-Trick-or-Treat", 0, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true });
        #endregion

        #region Dark
        public static readonly ZMove BlackHoleEclipse = new ZMove("Black Hole Eclipse", 100, null, null);
        public static readonly ZMove ZDarkVoid = new ZMove("Z-Dark Void", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZEmbargo = new ZMove("Z-Embargo", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZFakeTears = new ZMove("Z-Fake Tears", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZFlatter = new ZMove("Z-Flatter", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZHoneClaws = new ZMove("Z-Hone Claws", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZMemento = new ZMove("Z-Memento", 0, new Effect[] { SwitchInFullHeal }, new bool[] { false });
        public static readonly ZMove ZNastyPlot = new ZMove("Z-Nasty Plot", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZPartingShot = new ZMove("Z-Parting Shot", 0, new Effect[] { SwitchInFullHeal }, new bool[] { false });
        public static readonly ZMove ZQuash = new ZMove("Z-Quash", 0, new Effect[] { SpdUp1 }, new bool[] { true });
        public static readonly ZMove ZSnatch = new ZMove("Z-Snatch", 0, new Effect[] { SpdUp2 }, new bool[] { true });
        public static readonly ZMove ZSwitcheroo = new ZMove("Z-Switcheroo", 0, new Effect[] { SpdUp2 }, new bool[] { true });
        public static readonly ZMove ZTaunt = new ZMove("Z-Taunt", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZTopsyTurvy = new ZMove("Z-Topsy-Turvy", 0, new Effect[] { AtkUp1 }, new bool[] { true });
        public static readonly ZMove ZTorment = new ZMove("Z-Torment", 0, new Effect[] { DefUp1 }, new bool[] { true });
        #endregion

        #region Steel
        public static readonly ZMove CorkscrewCrash = new ZMove("Corkscrew Crash", 100, null, null);
        public static readonly ZMove ZAutotomize = new ZMove("Z-Autotomize", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZGearUp = new ZMove("Z-Gear Up", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZIronDefense = new ZMove("Z-Iron Defense", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZKingsShield = new ZMove("Z-King's Shield", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZMetalSound = new ZMove("Z-Metal Sound", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        public static readonly ZMove ZShiftGear = new ZMove("Z-Shift Gear", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        #endregion

        #region Fairy
        public static readonly ZMove TwinkleTackle = new ZMove("Twinkle Tackle", 100, null, null);
        public static readonly ZMove ZAromaticMist = new ZMove("Z-Aromatic Mist", 0, new Effect[] { SpDefUp2 }, new bool[] { true });
        public static readonly ZMove ZBabyDollEyes = new ZMove("Z-Baby-Doll Eyes", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZCharm = new ZMove("Z-Charm", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZCraftyShield = new ZMove("Z-Crafty Shield", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZFairyLock = new ZMove("Z-Fairy Lock", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZFloralHealing = new ZMove("Z-Floral Healing", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZFlowerShield = new ZMove("Z-Flower Shield", 0, new Effect[] { DefUp1 }, new bool[] { true });
        public static readonly ZMove ZGeomancy = new ZMove("Z-Geomancy", 0, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true });
        public static readonly ZMove ZMistyTerrain = new ZMove("Z-Misty Terrain", 0, new Effect[] { SpDefUp1 }, new bool[] { true });
        public static readonly ZMove ZMoonlight = new ZMove("Z-Moonlight", 0, new Effect[] { ResetStatDrops }, new bool[] { true });
        public static readonly ZMove ZSweetKiss = new ZMove("Z-Sweet Kiss", 0, new Effect[] { SpAtkUp1 }, new bool[] { true });
        #endregion
        #endregion

        #region Moves
        #region Normal
        #region A-H
        public static readonly Move Acupressure = new Move("Acupressure", Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { RandomStatBuffBy2 }, new bool[] { true }, ZAcupressure, 0);
        public static readonly Move AfterYou = new Move("After You", Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { ForceAttackFirstNextTurn }, new bool[] { false }, ZAfterYou, 0);
        public static readonly Move Assist = new Move("Assist", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { UseRandomPartnerMove }, new bool[] { true }, NO_EFFECT, 0);
        public static readonly Move Attract = new Move("Attract", Normal, 0, 1, 15, 'S', new double[] { 1, 1 }, new Effect[] { ifOppositeGender, Infatuated }, new bool[] { false, false }, ZAttract, 0);
        public static readonly Move Barrage = new Move("Barrage", Normal, 15, 0.85, 20, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move BatonPass = new Move("Baton Pass", Normal, 0, -1, 40, 'S', new double[] { 1, 1 }, new Effect[] { Switchout, TransferStatsToSwitchout }, new bool[] { true, false }, ZBatonPass, 0);
        public static readonly Move BellyDrum = new Move("Belly Drum", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { BellyDrumEffect }, new bool[] { true }, ZBellyDrum, 0);
        public static readonly Move Bestow = new Move("Bestow", Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { TransferItem }, new bool[] { false }, ZBestow, 0);
        public static readonly Move Bide = new Move("Bide", Normal, 0, -1, 10, 'P', new double[] { 1 }, new Effect[] { BideEffect }, new bool[] { true }, BreakneckBlitz, 1);
        public static readonly Move Bind = new Move("Bind", Normal, 15, 85, 20, 'P', new double[] { 1 }, new Effect[] { Bound }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move Block = new Move("Block", Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { LegHold }, new bool[] { false }, ZBlock, 0);
        public static readonly Move BodySlam = new Move("Body Slam", Normal, 85, 1, 15, 'P', new double[] { 0.3 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move Boomburst = new Move("Boomburst", Normal, 140, 1, 10, 'M', new double[] { 1 }, new Effect[] { HitAllAdjacent }, new bool[] { false }, new ZMove(BreakneckBlitz, 200), 0);
        public static readonly Move Camouflage = new Move("Camouflage", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Camo }, new bool[] { true }, ZCamouflage, 0);
        public static readonly Move Captivate = new Move("Captivate", Normal, 0, 1, 20, 'S', new double[] { 1, 1 }, new Effect[] { ifOppositeGender, AtkDwn2 }, new bool[] { false, false }, ZCaptivate, 0);
        public static readonly Move Celebrate = new Move("Celebrate", Normal, 0, -1, 40, 'S', null, null, null, ZCelebrate, 0);
        public static readonly Move ChipAway = new Move("Chip Away", Normal, 70, 1, 20, 'P', new double[] { 1 }, new Effect[] { IgnoreStatChanges }, new bool[] { true }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move CometPunch = new Move("Comet Punch", Normal, 10, 0.85, 15, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { true }, BreakneckBlitz, 0);
        public static readonly Move Confide = new Move("Confide", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { SpAtkDwn1 }, new bool[] { false }, ZConfide, 0);
        public static readonly Move Constrict = new Move("Constrict", Normal, 10, 1, 35, 'P', new double[] { 0.1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move Conversion = new Move("Conversion", Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Conv }, new bool[] { true }, ZConversion, 0);
        public static readonly Move Conversion2 = new Move("Conversion2", Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { Conv2 }, new bool[] { true }, ZConversion2, 0);
        public static readonly Move Copycat = new Move("Copycat", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { CopyLastMove }, new bool[] { false }, ZCopycat, 0);
        public static readonly Move Covet = new Move("Covet", Normal, 60, 1, 25, 'P', new double[] { 1 }, new Effect[] { TransferItem }, new bool[] { true }, new ZMove(BreakneckBlitz, 120), 0);
        public static readonly Move CrushClaw = new Move("Crush Claw", Normal, 75, 0.95, 10, 'P', new double[] { 0.5 }, new Effect[] { DefDwn1 }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move CrushGrip = new Move("Crush Grip", Normal, 0, 100, 5, 'P', new double[] { 1 }, new Effect[] { MoreHPMoreDmg }, new bool[] { false }, new ZMove(BreakneckBlitz, 190), 0);
        public static readonly Move Cut = new Move("Cut", Normal, 50, 0.95, 30, 'P', null, null, null, BreakneckBlitz, 0);
        public static readonly Move DefenseCurl = new Move("Defense Curl", Normal, 0, -1, 40, 'S', new double[] { 1, 1 }, new Effect[] { DefUp1, DefCurl }, new bool[] { true, true }, ZDefenseCurl, 0);
        public static readonly Move Disable = new Move("Disable", Normal, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { DisableEffect }, new bool[] { false }, ZDisable, 0);
        public static readonly Move DizzyPunch = new Move("Dizzy Punch", Normal, 70, 1, 10, 'P', new double[] { 0.2 }, new Effect[] { Confused }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move DoubleHit = new Move("Double Hit", Normal, 35, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { HitTwiceOneTurn }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move DoubleSlap = new Move("Double Hit", Normal, 35, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { HitTwiceOneTurn }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move DoubleTeam = new Move("Double Team", Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { EvasUp1 }, new bool[] { true }, ZDoubleTeam, 0);
        public static readonly Move DoubleEdge = new Move("Double-Edge", Normal, 120, 1, 15, 'P', new double[] { 1 }, new Effect[] { Recoil.ThirdDmgDealt }, new bool[] { true }, new ZMove(BreakneckBlitz, 190), 0);
        public static readonly Move EchoedVoice = new Move("Echoed Voice", Normal, 40, 1, 15, 'M', new double[] { 1 }, new Effect[] { IncrementalDamageMux }, new bool[] { true }, BreakneckBlitz, 0);
        public static readonly Move EggBomb = new Move("Egg Bomb", Normal, 100, 0.75, 10, 'P', null, null, null, new ZMove(BreakneckBlitz, 180), 0);
        public static readonly Move Encore = new Move("Encore", Normal, 0, 1, 5, 'S', new double[] { 1 }, new Effect[] { EncoreStatus }, new bool[] { true }, ZEncore, 0);
        public static readonly Move Endeavor = new Move("Endeavor", Normal, 0, 1, 5, 'P', new double[] { 1 }, new Effect[] { ReduceHPToUsers }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move Endure = new Move("Endure", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Bracing }, new bool[] { true }, ZEndure, 4);
        public static readonly Move Entrainment = new Move("Entrainment", Normal, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { CopyAbility }, new bool[] { false }, ZEntrainment, 0);
        public static readonly Move Explosion = new Move("Explosion", Normal, 250, 1, 5, 'P', new double[] { 1 }, new Effect[] { SelfDestruction }, new bool[] { true }, new ZMove(BreakneckBlitz, 200), 0);
        public static readonly Move ExtremeSpeed = new Move("Extreme Speed", Normal, 80, 1, 5, 'P', null, null, null, new ZMove(BreakneckBlitz, 160), 2);
        public static readonly Move Facade = new Move("Facade", Normal, 70, 1, 20, 'P', new double[] { 1, 1 }, new Effect[] { ifAfflicted, DoublePower }, new bool[] { true, true }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move FakeOut = new Move("Fake Out", Normal, 40, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { ifFirstTurn, Flinch }, new bool[] { true, false }, BreakneckBlitz, 3);
        public static readonly Move FalseSwipe = new Move("False Swipe", Normal, 40, 1, 40, 'P', new double[] { 1 }, new Effect[] { FalseSwipeEffect }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move Feint = new Move("Feint", Normal, 30, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { ifNoProtection, DealsNoDmg }, new bool[] { false, true }, BreakneckBlitz, 2);
        public static readonly Move Flail = new Move("Flail", Normal, 0, 1, 15, 'P', new double[] { 1 }, new Effect[] { FlailEffect }, new bool[] { true }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move Flash = new Move("Flash", Normal, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { AccDwn1 }, new bool[] { false }, ZFlash, 0);
        public static readonly Move FocusEnergy = new Move("Focus Energy", Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { CritUp2 }, new bool[] { true }, ZFocusEnergy, 0);
        public static readonly Move FollowMe = new Move("Follow Me", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { CenterofAttention }, new bool[] { true }, ZFollowMe, 2);
        public static readonly Move Foresight = new Move("Foresight", Normal, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { Identified }, new bool[] { false }, ZForesight, 0);
        public static readonly Move Frustration = new Move("Frustration", Normal, 0, 1, 20, 'P', new double[] { 1 }, new Effect[] { UnfriendlyMoreDamage }, new bool[] { true }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move FuryAttack = new Move("Fury Attack", Normal, 15, 0.85, 20, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move FurySwipes = new Move("Fury Swipes", Normal, 18, 0.8, 15, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move GigaImpact = new Move("Giga Impact", Normal, 150, 0.9, 5, 'P', new double[] { 1 }, new Effect[] { Recharging }, new bool[] { true }, new ZMove(BreakneckBlitz, 200), 0);
        public static readonly Move Glare = new Move("Glare", Normal, 0, 1, 30, 'S', new double[] { 1 }, new Effect[] { Paralysis }, new bool[] { false }, ZGlare, 0);
        public static readonly Move Growl = new Move("Growl", Normal, 0, 1, 40, 'S', new double[] { 1 }, new Effect[] { AtkDwn1 }, new bool[] { false }, ZGrowl, 0);
        public static readonly Move Growth = new Move("Growth", Normal, 0, -1, 40, 'S', new double[] { 1, 1, 1, 1, 1 }, new Effect[] { AtkUp1, SpAtkUp1, isHarshSunlight, AtkUp1, SpAtkUp1 }, new bool[] { true, true, true, true, true }, ZGrowth, 0);
        public static readonly Move Guillotine = new Move("Guillotine", Normal, -1, -2, 5, 'P', new double[] { 1 }, new Effect[] { OHKO }, new bool[] { false }, new ZMove(BreakneckBlitz, 180), 0);
        public static readonly Move HappyHour = new Move("Happy Hour", Normal, 0, -1, 30, 'S', null, null, null, ZHappyHour, 0);
        public static readonly Move Harden = new Move("Harden", Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { DefUp1 }, new bool[] { true }, ZHarden, 0);
        public static readonly Move HeadCharge = new Move("Head Charge", Normal, 120, 1, 15, 'P', new double[] { 1 }, new Effect[] { Recoil.QuarterDmgDealt }, new bool[] { true }, new ZMove(BreakneckBlitz, 190), 0);
        public static readonly Move Headbutt = new Move("Headbutt", Normal, 70, 1, 15, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move HealBell = new Move("Heal Bell", Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { HealUserPartyStatus }, new bool[] { false }, ZHealBell, 0);
        public static readonly Move HelpingHand = new Move("Helping Hand", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { IncreaseTargetDmg50Pcnt }, new bool[] { false }, ZHelpingHand, 5);
        public static readonly Move HiddenPower = new Move("Hidden Power", Normal, 60, 1, 15, 'M', new double[] { 1 }, new Effect[] { HiddenPowerEffect }, new bool[] { true }, new ZMove(BreakneckBlitz, 120), 0);
        public static readonly Move HoldBack = new Move("Hold Back", Normal, 40, 1, 40, 'P', new double[] { 1 }, new Effect[] { FalseSwipeEffect }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move HoldHands = new Move("Hold Hands", Normal, 0, -1, 40, 'S', null, null, null, ZHoldHands, 0);
        public static readonly Move HornAttack = new Move("Horn Attack", Normal, 65, 1, 25, 'P', null, null, null, new ZMove(BreakneckBlitz, 120), 0);
        public static readonly Move HornDrill = new Move("Horn Drill", Normal, 0, 0, 5, 'P', new double[] { 1 }, new Effect[] { OHKO }, new bool[] { false }, new ZMove(BreakneckBlitz, 180), 0);
        public static readonly Move Howl = new Move("Howl", Normal, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { AtkUp1 }, new bool[] { true }, ZHowl, 0);
        public static readonly Move HyperBeam = new Move("Hyper Beam", Normal, 150, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { Recharging }, new bool[] { true }, new ZMove(BreakneckBlitz, 200), 0);
        public static readonly Move HyperFang = new Move("Hyper Fang", Normal, 80, 0.9, 15, 'P', new double[] { 0.1 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move HyperVoice = new Move("Hyper Voice", Normal, 90, 1, 10, 'M', null, null, null, new ZMove(BreakneckBlitz, 175), 0);
        #endregion
        #region I-R
        public static readonly Move Judgement = new Move("Judgement", Normal, 100, 1, 10, 'M', new double[] { 1 }, new Effect[] { JudgementEffect }, new bool[] { false }, new ZMove(BreakneckBlitz, 180), 0);
        public static readonly Move LaserFocus = new Move("Laser Focus", Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { GuaranteedCritNextTurn }, new bool[] { true }, ZLaserFocus, 0);
        public static readonly Move LastResort = new Move("Last Resort", Normal, 140, 100, 5, 'P', new double[] { 1 }, new Effect[] { LastResortEffect }, new bool[] { false }, new ZMove(BreakneckBlitz, 200), 0);
        public static readonly Move Leer = new Move("Leer", Normal, 0, 1, 30, 'S', new double[] { 1 }, new Effect[] { DefDwn1 }, new bool[] { false }, ZLeer, 0);
        public static readonly Move LockOn = new Move("Lock-On", Normal, 0, 1, 30, 'S', new double[] { 1 }, new Effect[] { TakingAim }, new bool[] { true }, ZLockOn, 0);
        public static readonly Move LovelyKiss = new Move("Lovely Kiss", Normal, 0, 0.75, 10, 'S', new double[] { 1 }, new Effect[] { Confused }, new bool[] { false }, ZLovelyKiss, 0);
        public static readonly Move LuckyChant = new Move("Lucky Chant", Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { NoCrits5Turns }, new bool[] { false }, ZLuckyChant, 0);
        public static readonly Move MeFirst = new Move("Me First", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { MeFirstEffect }, new bool[] { false }, ZMeFirst, 0);
        public static readonly Move MeanLook = new Move("Mean Look", Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { LegHold }, new bool[] { false }, ZMeanLook, 0);
        public static readonly Move MegaKick = new Move("Mega Kick", Normal, 120, 0.75, 5, 'P', null, null, null, new ZMove(BreakneckBlitz, 190), 0);
        public static readonly Move MegaPunch = new Move("Mega Punch", Normal, 80, 0.85, 20, 'P', null, null, null, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move Metronome = new Move("Metronome", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { MetronomeEffect }, new bool[] { true }, NO_EFFECT, 0);
        public static readonly Move MilkDrink = new Move("Milk Drink", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { HalfHPRestore }, new bool[] { true }, ZMilkDrink, 0);
        public static readonly Move Mimic = new Move("Mimic", Normal, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { CopyLastMove, RetainCopiedMove }, new bool[] { false, true }, ZMimic, 0);
        public static readonly Move MindReader = new Move("Mind Reader", Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { TakingAim }, new bool[] { true }, ZMindReader, 0);
        public static readonly Move Minimize = new Move("Minimize", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { EvasUp2 }, new bool[] { true }, ZMinimize, 0);
        public static readonly Move MorningSun = new Move("Morning Sun", Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { MorningSunEffect }, new bool[] { false }, ZMorningSun, 0);
        public static readonly Move MultiAttack = new Move("Multi-Attack", Normal, 90, 1, 10, 'P', new double[] { 1 }, new Effect[] { TypeMatchesUser }, new bool[] { false }, new ZMove(BreakneckBlitz, 185), 0);
        public static readonly Move NaturalGift = new Move("Natural Gift", Normal, 0, 1, 15, 'P', new double[] { 1 }, new Effect[] { NatGiftEffect }, new bool[] { true }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move NaturePower = new Move("Nature Power", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { NaturePowerEffect }, new bool[] { false }, NO_EFFECT, 0);
        public static readonly Move NobleRoar = new Move("Noble Roar", Normal, 0, 1, 30, 'S', new double[] { 1, 1 }, new Effect[] { AtkDwn1, SpAtkDwn1 }, new bool[] { false, false }, ZNobleRoar, 0);
        public static readonly Move OdorSleuth = new Move("Odor Sleuth", Normal, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { Identified }, new bool[] { false }, ZOdorSleuth, 0);
        public static readonly Move PainSplit = new Move("Pain Split", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Split.HP }, new bool[] { true }, ZPainSplit, 0);
        public static readonly Move PayDay = new Move("Pay Day", Normal, 40, 1, 20, 'P', null, null, null, BreakneckBlitz, 0);
        public static readonly Move PerishSong = new Move("Perish Song", Normal, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { PerishSongStatus }, new bool[] { false }, ZPerishSong, 0);
        public static readonly Move PlayNice = new Move("Play Nice", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { AtkDwn1 }, new bool[] { false }, ZPlayNice, 0);
        public static readonly Move Pound = new Move("Pound", Normal, 40, 1, 35, 'P', null, null, null, BreakneckBlitz, 0);
        public static readonly Move Present = new Move("Present", Normal, 0, 0.9, 15, 'P', new double[] { 1 }, new Effect[] { PresentEffect }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move Protect = new Move("Protect", Normal, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Protection, SameMoveLastTurn, DecreaseAcc50Pcnt }, new bool[] { true, true, true }, ZProtect, 4);
        public static readonly Move PsychUp = new Move("Psych Up", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { CopyStatChanges }, new bool[] { false }, ZPsychUp, 0);
        public static readonly Move QuickAttack = new Move("Quick Attack", Normal, 40, 1, 30, 'P', null, null, null, BreakneckBlitz, 1);
        public static readonly Move Rage = new Move("Rage", Normal, 20, 1, 20, 'P', new double[] { 1, 1 }, new Effect[] { isHitBeforeNextMove, AtkUp1 }, new bool[] { true, true }, BreakneckBlitz, 0);
        public static readonly Move RapidSpin = new Move("Rapid Spin", Normal, 20, 1, 40, 'P', new double[] { 1 }, new Effect[] { ClearTraps }, new bool[] { true }, BreakneckBlitz, 0);
        public static readonly Move RazorWind = new Move("Razor Wind", Normal, 80, 100, 10, 'M', new double[] { 1, 1 }, new Effect[] { WhippingUpWhirlwind, HighCrit }, new bool[] { true, true }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move Recover = new Move("Recover", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { HalfHPRestore }, new bool[] { true }, ZRecover, 0);
        public static readonly Move Recycle = new Move("Recycle", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { RecycleEffect }, new bool[] { true }, ZRecycle, 0);
        public static readonly Move ReflectType = new Move("Reflect Type", Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { ReflectTypeEffect }, new bool[] { true }, ZReflectType, 0);
        public static readonly Move Refresh = new Move("Refresh", Normal, 0, -1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { CureParalysis, CurePoison, CureBurn }, new bool[] { true, true, true }, ZRefresh, 0);
        public static readonly Move RelicSong = new Move("Relic Song", Normal, 75, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { Sleep }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move Retaliate = new Move("Retaliate", Normal, 70, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { AllyDiedThisTurn, DoublePower }, new bool[] { true, true }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move Return = new Move("Return", Normal, 0, 1, 20, 'P', new double[] { 1 }, new Effect[] { FriendlyMoreDmg }, new bool[] { true }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move RevelationDance = new Move("Revelation Dance", Normal, 90, 1, 15, 'M', new double[] { 1 }, new Effect[] { OricorioForme }, new bool[] { true }, new ZMove(BreakneckBlitz, 175), 0);
        public static readonly Move Roar = new Move("Roar", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Switchout }, new bool[] { false }, ZRoar, -6);
        public static readonly Move RockClimb = new Move("Rock Climb", Normal, 90, 0.85, 20, 'P', new double[] { 0.2 }, new Effect[] { Confused }, new bool[] { false }, new ZMove(BreakneckBlitz, 175), 0);
        public static readonly Move Round = new Move("Round", Normal, 60, 1, 15, 'M', new double[] { 1 }, new Effect[] { MoveUsedByAllyThisTurn }, new bool[] { true }, new ZMove(BreakneckBlitz, 120), 0);
        #endregion
        #region S-Z
        public static readonly Move Safeguard = new Move("Safeguard", Normal, 0, -1, 25, 'S', new double[] { 1 }, new Effect[] { SafeguardStatus }, new bool[] { true }, ZSafeguard, 0);
        public static readonly Move ScaryFace = new Move("Scary Face", Normal, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { SpdDwn2 }, new bool[] { false }, ZScaryFace, 0);
        public static readonly Move Scratch = new Move("Scratch", Normal, 40, 1, 35, 'P', null, null, null, BreakneckBlitz, 0);
        public static readonly Move Screech = new Move("Screech", Normal, 0, 0.85, 40, 'S', new double[] { 1 }, new Effect[] { DefDwn2 }, new bool[] { false }, ZScreech, 0);
        public static readonly Move SecretPower = new Move("Secret Power", Normal, 70, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { SecretPwr }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move SelfDestruct = new Move("Self-Destruct", Normal, 200, 1, 5, 'P', new double[] { 1 }, new Effect[] { SelfDestruction }, new bool[] { false }, new ZMove(BreakneckBlitz, 200), 0);
        public static readonly Move Sharpen = new Move("Sharpen", Normal, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { AtkUp1 }, new bool[] { true }, ZSharpen, 0);
        public static readonly Move ShellSmash = new Move("Shell Smash", Normal, 0, -1, 15, 'S', new double[] { 1, 1, 1, 1, 1 }, new Effect[] { AtkUp2, SpAtkUp2, SpdUp2, DefDwn1, SpDefDwn1 }, new bool[] { true, true, true, true, true }, ZShellSmash, 0);
        public static readonly Move SimpleBeam = new Move("Simple Beam", Normal, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { SimpleEffect }, new bool[] { false }, ZSimpleBeam, 0);
        public static readonly Move Sing = new Move("Sing", Normal, 0, 0.55, 15, 'S', new double[] { 1 }, new Effect[] { Sleep }, new bool[] { false }, ZSing, 0);
        public static readonly Move Sketch = new Move("Sketch", Normal, 0, -1, 1, 'S', new double[] { 1 }, new Effect[] { SketchEffect }, new bool[] { true }, ZSketch, 0);
        public static readonly Move SkullBash = new Move("Skull Bash", Normal, 130, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { DefUp1, Charging }, new bool[] { true, true }, new ZMove(BreakneckBlitz, 195), 0);
        public static readonly Move SlackOff = new Move("Slack Off", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { HalfHPRestore }, new bool[] { true }, ZSlackOff, 0);
        public static readonly Move Slam = new Move("Slam", Normal, 80, 0.75, 20, 'P', null, null, null, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move Slash = new Move("Slash", Normal, 70, 1, 20, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move SleepTalk = new Move("Sleep Talk", Normal, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { isAsleep, UseRandomMove }, new bool[] { true, true }, ZSleepTalk, 0);
        public static readonly Move SmellingSalts = new Move("Smelling Salts", Normal, 70, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { isParalyzed, DoublePower, CureParalysis }, new bool[] { false, true, false }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move Smokescreen = new Move("Smokescreen", Normal, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { AccDwn1 }, new bool[] { false }, ZSmokescreen, 0);
        public static readonly Move Snore = new Move("Snore", Normal, 50, 1, 15, 'M', new double[] { 1, 0.3 }, new Effect[] { isAsleep, Flinch }, new bool[] { true, false }, BreakneckBlitz, 0);
        public static readonly Move SoftBoiled = new Move("Soft-Boiled", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { HalfHPRestore }, new bool[] { true }, ZSoftBoiled, 0);
        public static readonly Move SonicBoom = new Move("Sonic Boom", Normal, 20, 0.9, 20, 'M', new double[] { 1 }, new Effect[] { DoBPInDmg }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move SpikeCannon = new Move("Spike Cannon", Normal, 20, 1, 15, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move SpitUp = new Move("Spit Up", Normal, 0, 1, 10, 'M', new double[] { 1 }, new Effect[] { SpitUpEffect }, new bool[] { true }, BreakneckBlitz, 0);
        public static readonly Move Splash = new Move("Splash", Normal, 0, -1, 40, 'S', null, null, null, ZSplash, 0);
        public static readonly Move Spotlight = new Move("Spotlight", Normal, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { CenterofAttention }, new bool[] { false }, ZSpotlight, 3);
        public static readonly Move Stockpile = new Move("Stockpile", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { StockpileEffect }, new bool[] { true }, ZStockpile, 0);
        public static readonly Move Stomp = new Move("Stomp", Normal, 65, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(BreakneckBlitz, 120), 0);
        public static readonly Move Strength = new Move("Strength", Normal, 80, 1, 15, 'P', null, null, null, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move Struggle = new Move("Struggle", Typeless, 50, -1, -1, 'P', new double[] { 1 }, new Effect[] { Recoil.QuarterMaxHP }, new bool[] { true }, NO_EFFECT, 0);
        public static readonly Move Substitute = new Move("Substitute", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { SubstituteStatus }, new bool[] { true }, ZSubstitute, 0);
        public static readonly Move SuperFang = new Move("Super Fang", Normal, 0, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { DoesHalfTargetHPDmg }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move Supersonic = new Move("Supersonic", Normal, 0, 0.55, 20, 'S', new double[] { 1 }, new Effect[] { Confused }, new bool[] { false }, ZSupersonic, 0);
        public static readonly Move Swagger = new Move("Swagger", Normal, 0, 0.85, 15, 'S', new double[] { 1, 1 }, new Effect[] { Confused, AtkUp2 }, new bool[] { false, false }, ZSwagger, 0);
        public static readonly Move Swallow = new Move("Swallow", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { SwallowEffect }, new bool[] { true }, ZSwallow, 0);
        public static readonly Move SweetScent = new Move("Sweet Scent", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { EvasDwn1 }, new bool[] { false }, ZSweetScent, 0);
        public static readonly Move Swift = new Move("Swift", Normal, 60, -1, 20, 'P', null, null, null, new ZMove(BreakneckBlitz, 120), 0);
        public static readonly Move SwordsDance = new Move("Swords Dance", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { AtkUp2 }, new bool[] { true }, ZSwordsDance, 0);
        public static readonly Move Tackle = new Move("Tackle", Normal, 40, 1, 35, 'P', null, null, null, BreakneckBlitz, 0);
        public static readonly Move TailSlap = new Move("Tail Slap", Normal, 25, 0.85, 10, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, new ZMove(BreakneckBlitz, 140), 0);
        public static readonly Move TailWhip = new Move("Tail Whip", Normal, 0, 1, 30, 'S', new double[] { 1 }, new Effect[] { DefDwn1 }, new bool[] { false }, ZTailWhip, 0);
        public static readonly Move TakeDown = new Move("Take Down", Normal, 90, 0.85, 20, 'P', new double[] { 1 }, new Effect[] { Recoil.QuarterDmgDealt }, new bool[] { true }, new ZMove(BreakneckBlitz, 175), 0);
        public static readonly Move TearfulLook = new Move("Tearful Look", Normal, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { AtkDwn1, SpAtkDwn1 }, new bool[] { false, false }, ZTearfulLook, 0);
        public static readonly Move TechnoBlast = new Move("Techno Blast", Normal, 120, 1, 5, 'M', new double[] { 1 }, new Effect[] { ChangeTypeToDrive }, new bool[] { true }, new ZMove(BreakneckBlitz, 190), 0);
        public static readonly Move TeeterDance = new Move("Teeter Dance", Normal, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { ConfuseAll }, new bool[] { true }, ZTeeterDance, 0);
        public static readonly Move Thrash = new Move("Thrash", Normal, 120, 1, 10, 'P', new double[] { 1 }, new Effect[] { ThrashEffect }, new bool[] { false }, new ZMove(BreakneckBlitz, 190), 0);
        public static readonly Move Tickle = new Move("Tickle", Normal, 0, 1, 20, 'S', new double[] { 1, 1 }, new Effect[] { AtkDwn1, DefDwn1 }, new bool[] { false, false }, ZTickle, 0);
        public static readonly Move Transform = new Move("Transform", Normal, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { TransformEffect }, new bool[] { true }, ZTransform, 0);
        public static readonly Move TriAttack = new Move("Tri Attack", Normal, 80, 1, 10, 'M', new double[] { 0.2 }, new Effect[] { TriAttackEffect }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move TrumpCard = new Move("Trump Card", Normal, 0, -1, 5, 'M', new double[] { 1 }, new Effect[] { TrumpCardEffect }, new bool[] { false }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move Uproar = new Move("Uproar", Normal, 90, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { Repeat3Times, PreventAllSleep }, new bool[] { false, false }, new ZMove(BreakneckBlitz, 175), 0);
        public static readonly Move ViceGrip = new Move("Vice Grip", Normal, 55, 1, 30, 'P', null, null, null, BreakneckBlitz, 0);
        public static readonly Move WeatherBall = new Move("Weather Ball", Normal, 50, 1, 10, 'M', new double[] { 1, 1, 1 }, new Effect[] { ChangeTypeToWeather, isActiveWeather, DoublePower }, new bool[] { true, true, true }, new ZMove(BreakneckBlitz, 160), 0);
        public static readonly Move Whirlwind = new Move("Whirlwind", Normal, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Switchout }, new bool[] { false }, ZWhirlwind, -6);
        public static readonly Move Wish = new Move("Wish", Normal, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Wait.OneTurn, HalfHPRestore }, new bool[] { true, true }, ZWish, 0);
        public static readonly Move WorkUp = new Move("Work Up", Normal, 0, -1, 30, 'S', new double[] { 1, 1 }, new Effect[] { AtkUp1, SpAtkUp1 }, new bool[] { true, true }, ZWorkUp, 0);
        public static readonly Move Wrap = new Move("Wrap", Normal, 15, 0.9, 20, 'P', new double[] { 1 }, new Effect[] { Bound }, new bool[] { false }, BreakneckBlitz, 0);
        public static readonly Move WringOut = new Move("Wring Out", Normal, 0, 1, 5, 'M', new double[] { 1 }, new Effect[] { MoreHPMoreDmg }, new bool[] { false }, new ZMove(BreakneckBlitz, 190), 0);
        public static readonly Move Yawn = new Move("Yawn", Normal, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Wait.OneTurn, Sleep }, new bool[] { true, false }, ZYawn, 0);
        #endregion
        #endregion

        #region Fire
        public static readonly Move BlastBurn = new Move("Blast Burn", Fire, 150, 0.9, 5, 'S', new double[] { 1 }, new Effect[] { Recharging }, new bool[] { true }, new ZMove(InfernoOverdrive, 200), 0);
        public static readonly Move BlazeKick = new Move("Blaze Kick", Fire, 85, 0.9, 10, 'P', new double[] { 1, 0.1 }, new Effect[] { HighCrit, Burn }, new bool[] { true, false }, new ZMove(InfernoOverdrive, 160), 0);
        public static readonly Move BlueFlare = new Move("Blue Flare", Fire, 130, 0.85, 5, 'M', new double[] { 0.2 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 195), 0);
        public static readonly Move BurnUp = new Move("Burn Up", Fire, 130, 1, 5, 'M', new double[] { 1 }, new Effect[] { BurnUpEffect }, new bool[] { true }, new ZMove(InfernoOverdrive, 195), 0);
        public static readonly Move Ember = new Move("Ember", Fire, 40, 1, 25, 'M', new double[] { 0.1 }, new Effect[] { Burn }, new bool[] { false }, InfernoOverdrive, 0);
        public static readonly Move Eruption = new Move("Eruption", Fire, 0, 1, 5, 'M', new double[] { 1 }, new Effect[] { EruptionSpout }, new bool[] { false }, new ZMove(InfernoOverdrive, 200), 0);
        public static readonly Move FieryDance = new Move("Fiery Dance", Fire, 80, 1, 10, 'M', new double[] { 0.5 }, new Effect[] { SpAtkUp1 }, new bool[] { true }, new ZMove(InfernoOverdrive, 160), 0);
        public static readonly Move FireBlast = new Move("Fire Blast", Fire, 110, 0.85, 5, 'M', new double[] { 0.1 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 185), 0);
        public static readonly Move FireFang = new Move("Fire Fang", Fire, 65, 0.95, 15, 'P', new double[] { 0.1, 0.1 }, new Effect[] { Burn, Flinch }, new bool[] { false, false }, new ZMove(InfernoOverdrive, 120), 0);
        public static readonly Move FireLash = new Move("Fire Lash", Fire, 80, 1, 15, 'P', new double[] { 1 }, new Effect[] { DefDwn1 }, new bool[] { false }, new ZMove(InfernoOverdrive, 160), 0);
        public static readonly Move FirePledge = new Move("Fire Pledge", Fire, 80, 1, 10, 'M', new double[] { 1 }, new Effect[] { PledgesEffect }, new bool[] { true }, new ZMove(InfernoOverdrive, 160), 0);
        public static readonly Move FirePunch = new Move("Fire Punch", Fire, 75, 1, 15, 'P', new double[] { 0.1 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 140), 0);
        public static readonly Move FireSpin = new Move("Fire Spin", Fire, 35, 0.85, 15, 'M', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, InfernoOverdrive, 0);
        public static readonly Move FlameBurst = new Move("Flame Burst", Fire, 70, 1, 15, 'M', new double[] { 1 }, new Effect[] { SplashDmg }, new bool[] { true }, new ZMove(InfernoOverdrive, 140), 0);
        public static readonly Move FlameCharge = new Move("Flame Charge", Fire, 50, 1, 20, 'P', new double[] { 1 }, new Effect[] { SpdUp1 }, new bool[] { true }, InfernoOverdrive, 0);
        public static readonly Move FlameWheel = new Move("Flame Wheel", Fire, 60, 1, 25, 'P', new double[] { 0.1 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 120), 0);
        public static readonly Move Flamethrower = new Move("Flamethrower", Fire, 90, 1, 15, 'M', new double[] { 0.1 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 175), 0);
        public static readonly Move FlareBlitz = new Move("Flare Blitz", Fire, 120, 1, 15, 'P', new double[] { 1, 0.1 }, new Effect[] { Recoil.ThirdDmgDealt, Burn }, new bool[] { true, false }, new ZMove(InfernoOverdrive, 190), 0);
        public static readonly Move FusionFlare = new Move("Fusion Flare", Fire, 100, 1, 5, 'M', new double[] { 1, 1 }, new Effect[] { FusionBoltFlag, DoublePower }, new bool[] { true, true }, new ZMove(InfernoOverdrive, 180), 0);
        public static readonly Move HeatCrash = new Move("Heat Crash", Fire, 0, 1, 10, 'P', new double[] { 1 }, new Effect[] { HeavierMoreDmg }, new bool[] { false }, new ZMove(InfernoOverdrive, 160), 0);
        public static readonly Move HeatWave = new Move("Heat Wave", Fire, 95, 0.9, 10, 'M', new double[] { 0.1 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 175), 0);
        public static readonly Move Incinerate = new Move("Incinerate", Fire, 60, 1, 15, 'M', new double[] { 1 }, new Effect[] { DestroyHeldBerry }, new bool[] { false }, new ZMove(InfernoOverdrive, 120), 0);
        public static readonly Move Inferno = new Move("Inferno", Fire, 100, 0.5, 5, 'M', new double[] { 1 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 180), 0);
        public static readonly Move LavaPlume = new Move("Lava Plume", Fire, 80, 1, 15, 'M', new double[] { 0.3 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 160), 0);
        public static readonly Move MagmaStorm = new Move("Magma Storm", Fire, 120, 0.75, 5, 'M', new double[] { 1 }, new Effect[] { Bound }, new bool[] { false }, new ZMove(InfernoOverdrive, 180), 0);
        public static readonly Move MysticalFire = new Move("Mystical Fire", Fire, 75, 1, 10, 'M', new double[] { 1 }, new Effect[] { SpAtkDwn1 }, new bool[] { false }, new ZMove(InfernoOverdrive, 140), 0);
        public static readonly Move Overheat = new Move("Overheat", Fire, 130, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { SpAtkDwn2 }, new bool[] { true }, new ZMove(InfernoOverdrive, 195), 0);
        public static readonly Move SacredFire = new Move("Sacred Fire", Fire, 100, 0.95, 5, 'P', new double[] { 0.5 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 180), 0);
        public static readonly Move SearingShot = new Move("Searing Shot", Fire, 100, 1, 5, 'M', new double[] { 0.3 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(InfernoOverdrive, 180), 0);
        public static readonly Move ShellTrap = new Move("Shell Trap", Fire, 150, 1, 5, 'M', new double[] { 1 }, new Effect[] { ShellTrapEffect }, new bool[] { false }, new ZMove(InfernoOverdrive, 200), -3);
        public static readonly Move SunnyDay = new Move("Sunny Day", Fire, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { HarshSunlight }, new bool[] { true }, ZSunnyDay, 0);
        public static readonly Move VCreate = new Move("V-create", Fire, 180, 0.95, 5, 'P', new double[] { 1, 1, 1 }, new Effect[] { DefDwn1, SpDefDwn1, SpdDwn1 }, new bool[] { true, true, true }, new ZMove(InfernoOverdrive, 220), 0);
        public static readonly Move WillOWisp = new Move("Will-O-Wisp", Fire, 0, 0.85, 15, 'S', new double[] { 1 }, new Effect[] { Burn }, new bool[] { false }, ZWillOWisp, 0);
        #endregion

        #region Water
        public static readonly Move AquaJet = new Move("Aqua Jet", Water, 40, 1, 20, 'P', null, null, null, HydroVortex, 1);
        public static readonly Move AquaRing = new Move("Aqua Ring", Water, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { AquaRingStatus }, new bool[] { true }, ZAquaRing, 0);
        public static readonly Move AquaTail = new Move("Aqua Tail", Water, 90, 0.9, 10, 'P', null, null, null, new ZMove(HydroVortex, 175), 0);
        public static readonly Move Brine = new Move("Brine", Water, 65, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { OpponentLessThanHalf, DoublePower }, new bool[] { false, true }, new ZMove(HydroVortex, 120), 0);
        public static readonly Move Bubble = new Move("Bubble", Water, 40, 1, 30, 'M', new double[] { 0.1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, HydroVortex, 0);
        public static readonly Move BubbleBeam = new Move("Bubble Beam", Water, 65, 1, 20, 'M', new double[] { 0.1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 120), 0);
        public static readonly Move Clamp = new Move("Clamp", Water, 35, 0.85, 10, 'P', new double[] { 1 }, new Effect[] { Bound }, new bool[] { false }, HydroVortex, 0);
        public static readonly Move Crabhammer = new Move("Crabhammer", Water, 100, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(HydroVortex, 180), 0);
        public static readonly Move Dive = new Move("Dive", Water, 80, 1, 10, 'P', new double[] { 1 }, new Effect[] { SemiInvulnerable }, new bool[] { true }, new ZMove(HydroVortex, 160), 0);
        public static readonly Move HydroCannon = new Move("Hydro Cannon", Water, 150, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { Recharging }, new bool[] { true }, new ZMove(HydroVortex, 200), 0);
        public static readonly Move HydroPump = new Move("Hydro Pump", Water, 110, 0.8, 5, 'M', null, null, null, new ZMove(HydroVortex, 185), 0);
        public static readonly Move Liquidation = new Move("Liquidation", Water, 85, 1, 10, 'P', new double[] { 0.2 }, new Effect[] { DefDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 160), 0);
        public static readonly Move MuddyWater = new Move("Muddy Water", Water, 90, 0.85, 10, 'M', new double[] { 0.3 }, new Effect[] { AccDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 175), 0);
        public static readonly Move Octazooka = new Move("Octazooka", Water, 65, 0.85, 10, 'M', new double[] { 0.5 }, new Effect[] { AccDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 120), 0);
        public static readonly Move RainDance = new Move("Rain Dance", Water, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Rain }, new bool[] { true }, ZRainDance, 0);
        public static readonly Move RazorShell = new Move("Razor Shell", Water, 75, 0.95, 10, 'P', new double[] { 0.5 }, new Effect[] { DefDwn1 }, new bool[] { false }, new ZMove(HydroVortex, 140), 0);
        public static readonly Move Scald = new Move("Scald", Water, 80, 1, 15, 'M', new double[] { 0.3 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(HydroVortex, 160), 0);
        public static readonly Move Soak = new Move("Soak", Water, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { ChangeTargetWater }, new bool[] { false }, ZSoak, 0);
        public static readonly Move SparklingAria = new Move("Sparkling Aria", Water, 90, 1, 10, 'M', new double[] { 1 }, new Effect[] { CureBurn }, new bool[] { false }, new ZMove(HydroVortex, 175), 0);
        public static readonly Move SteamEruption = new Move("Steam Eruption", Water, 110, 0.95, 5, 'M', new double[] { 0.3 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(HydroVortex, 185), 0);
        public static readonly Move Surf = new Move("Surf", Water, 90, 1, 15, 'M', new double[] { 1 }, new Effect[] { HitAllAdjacent }, new bool[] { true }, new ZMove(HydroVortex, 175), 0);
        public static readonly Move WaterGun = new Move("Water Gun", Water, 40, 1, 25, 'M', null, null, null, HydroVortex, 0);
        public static readonly Move WaterPledge = new Move("Water Pledge", Water, 80, 100, 10, 'M', new double[] { 1 }, new Effect[] { PledgesEffect }, new bool[] { false }, new ZMove(HydroVortex, 160), 0);
        public static readonly Move WaterPulse = new Move("Water Pulse", Water, 60, 1, 20, 'M', new double[] { 0.2 }, new Effect[] { Confused }, new bool[] { false }, new ZMove(HydroVortex, 120), 0);
        public static readonly Move WaterShruiken = new Move("Water Shruiken", Water, 15, 1, 20, 'M', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, HydroVortex, 1);
        public static readonly Move WaterSport = new Move("Water Sport", Water, 0, -1, 15, 'S', new double[] { 1, 1 }, new Effect[] { Strengthen.Water, Weaken.Fire }, new bool[] { false, false }, ZWaterSport, 0);
        public static readonly Move WaterSpout = new Move("Water Spout", Water, 0, 1, 5, 'M', new double[] { 1 }, new Effect[] { EruptionSpout }, new bool[] { false }, new ZMove(HydroVortex, 200), 0);
        public static readonly Move Waterfall = new Move("Waterfall", Water, 80, 1, 15, 'P', new double[] { 0.2 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(HydroVortex, 160), 0);
        public static readonly Move Whirlpool = new Move("Whirlpool", Water, 35, 0.85, 15, 'M', new double[] { 1 }, new Effect[] { Bound }, new bool[] { false }, HydroVortex, 0);
        public static readonly Move Withdraw = new Move("Withdraw", Water, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { DefUp1 }, new bool[] { true }, ZWithdraw, 0);
        #endregion

        #region Electric
        public static readonly Move BoltStrike = new Move("Bolt Strike", Electric, 130, 0.85, 5, 'P', new double[] { 0.2 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 195), 0);
        public static readonly Move Charge = new Move("Charge", Electric, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { SpDefUp1, ChargeEffect }, new bool[] { true, true }, ZCharge, 0);
        public static readonly Move ChargeBeam = new Move("Charge Beam", Electric, 50, 0.9, 10, 'M', new double[] { 0.7 }, new Effect[] { SpAtkUp1 }, new bool[] { true }, GigavoltHavoc, 0);
        public static readonly Move Discharge = new Move("Discharge", Electric, 80, 1, 15, 'M', new double[] { 0.3 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 160), 0);
        public static readonly Move EerieImpulse = new Move("Eerie Impulse", Electric, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { SpAtkDwn2 }, new bool[] { false }, ZEerieImpulse, 0);
        public static readonly Move ElectricTerrain = new Move("Electric Terrain", Electric, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { EleTerrain }, new bool[] { true }, ZElectricTerrain, 0);
        public static readonly Move Electrify = new Move("Electrify", Electric, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { ElectrifyEffect }, new bool[] { false }, ZElectrify, 0);
        public static readonly Move ElectroBall = new Move("Electro Ball", Electric, -1, 1, 10, 'M', new double[] { 1 }, new Effect[] { ElectroBallEffect }, new bool[] { false }, new ZMove(GigavoltHavoc, 160), 0);
        public static readonly Move Electroweb = new Move("Electroweb", Electric, 55, 0.95, 15, 'M', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, GigavoltHavoc, 0);
        public static readonly Move FusionBolt = new Move("Fusion Bolt", Electric, 100, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { FusionFlareFlag, DoublePower }, new bool[] { true, true }, new ZMove(GigavoltHavoc, 180), 0);
        public static readonly Move IonDeluge = new Move("Ion Deluge", Electric, 0, -1, 25, 'S', new double[] { 1 }, new Effect[] { IonDelugeEffect }, new bool[] { true }, ZIonDeluge, 1);
        public static readonly Move MagnetRise = new Move("Magnet Rise", Electric, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { MagneticLevitation }, new bool[] { true }, ZMagnetRise, 0);
        public static readonly Move MagneticFlux = new Move("Magnetic Flux", Electric, 0, -1, 20, 'S', new double[] { 1, 1, 1, 1 }, new Effect[] { HitAllAllies, hasPlusMinus, DefUp1, SpDefUp1 }, new bool[] { true, false, false, false }, ZMagneticFlux, 0);
        public static readonly Move Nuzzle = new Move("Nuzzle", Electric, 20, 1, 20, 'P', new double[] { 1 }, new Effect[] { Paralysis }, new bool[] { false }, GigavoltHavoc, 0);
        public static readonly Move ParabolicCharge = new Move("Parabolic Charge", Electric, 65, 1, 20, 'M', new double[] { 1 }, new Effect[] { HealHalfDmgInflicted }, new bool[] { true }, new ZMove(GigavoltHavoc, 120), 0);
        public static readonly Move ShockWave = new Move("Shock Wave", Electric, 60, -1, 20, 'M', null, null, null, new ZMove(GigavoltHavoc, 120), 0);
        public static readonly Move Spark = new Move("Spark", Electric, 65, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 120), 0);
        public static readonly Move Thunder = new Move("Thunder", Electric, 110, 0.7, 10, 'M', new double[] { 0.3, 1, 1 }, new Effect[] { Paralysis, Ignore.Fly, ThunderEffect }, new bool[] { false, true, true }, new ZMove(GigavoltHavoc, 185), 0);
        public static readonly Move ThunderFang = new Move("Thunder Fang", Electric, 65, 0.95, 15, 'P', new double[] { 0.1, 0.1 }, new Effect[] { Paralysis, Flinch }, new bool[] { false, false }, new ZMove(GigavoltHavoc, 120), 0);
        public static readonly Move ThunderPunch = new Move("Thunder Punch", Electric, 75, 1, 15, 'P', new double[] { 0.1 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 140), 0);
        public static readonly Move ThunderShock = new Move("Thunder Shock", Electric, 40, 1, 30, 'M', new double[] { 0.1 }, new Effect[] { Paralysis }, new bool[] { false }, GigavoltHavoc, 0);
        public static readonly Move ThunderWave = new Move("Thunder Wave", Electric, 0, 0.9, 20, 'S', new double[] { 1 }, new Effect[] { Paralysis }, new bool[] { false }, ZThunderWave, 0);
        public static readonly Move Thunderbolt = new Move("Thunderbolt", Electric, 90, 1, 15, 'M', new double[] { 0.1 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 175), 0);
        public static readonly Move VoltSwitch = new Move("Volt Switch", Electric, 70, 1, 20, 'M', new double[] { 1 }, new Effect[] { Switchout }, new bool[] { true }, new ZMove(GigavoltHavoc, 140), 0);
        public static readonly Move VoltTackle = new Move("Volt Tackle", Electric, 120, 1, 15, 'P', new double[] { 1, 0.1 }, new Effect[] { Recoil.ThirdDmgDealt, Paralysis }, new bool[] { true, false }, new ZMove(GigavoltHavoc, 190), 0);
        public static readonly Move WildCharge = new Move("Wild Charge", Electric, 90, 1, 15, 'P', new double[] { 1 }, new Effect[] { Recoil.QuarterDmgDealt }, new bool[] { true }, new ZMove(GigavoltHavoc, 175), 0);
        public static readonly Move ZapCannon = new Move("Zap Cannon", Electric, 120, 0.5, 5, 'M', new double[] { 1 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(GigavoltHavoc, 190), 0);
        public static readonly Move ZingZap = new Move("Zing Zap", Electric, 80, 1, 10, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(GigavoltHavoc, 160), 0);
        #endregion

        #region Grass
        public static readonly Move Absorb = new Move("Absorb", Grass, 20, 1, 25, 'M', new double[] { 1 }, new Effect[] { HealHalfDmgInflicted }, new bool[] { true }, BloomDoom, 0);
        public static readonly Move Aromatherapy = new Move("Aromatherapy", Grass, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { HealUserPartyStatus }, new bool[] { true }, ZAromatherapy, 0);
        public static readonly Move BulletSeed = new Move("Bullet Seed", Grass, 25, 1, 30, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, new ZMove(BloomDoom, 140), 0);
        public static readonly Move CottonGuard = new Move("Cotton Guard", Grass, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { DefUp3 }, new bool[] { true }, ZCottonGuard, 0);
        public static readonly Move CottonSpore = new Move("Cotton Spore", Grass, 0, 1, 40, 'S', new double[] { 1 }, new Effect[] { SpdDwn2 }, new bool[] { false }, ZCottonSpore, 0);
        public static readonly Move EnergyBall = new Move("Energy Ball", Grass, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, new ZMove(BloomDoom, 175), 0);
        public static readonly Move ForestsCurse = new Move("Forest's Curse", Grass, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { AddTypeToTarget.Grass }, new bool[] { false }, ZForestsCurse, 0);
        public static readonly Move FrenzyPlant = new Move("Frenzy Plant", Grass, 150, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { Recharging }, new bool[] { true }, new ZMove(BloomDoom, 200), 0);
        public static readonly Move GigaDrain = new Move("Giga Drain", Grass, 75, 1, 10, 'M', new double[] { 1 }, new Effect[] { HealHalfDmgInflicted }, new bool[] { true }, new ZMove(BloomDoom, 140), 0);
        public static readonly Move GrassKnot = new Move("Grass Knot", Grass, -1, 1, 20, 'M', new double[] { 1 }, new Effect[] { HeavierOppMoreDmg }, new bool[] { false }, new ZMove(BloomDoom, 160), 0);
        public static readonly Move GrassPledge = new Move("Grass Pledge", Grass, 80, 1, 10, 'M', new double[] { 1 }, new Effect[] { PledgesEffect }, new bool[] { false }, new ZMove(BloomDoom, 160), 0);
        public static readonly Move GrassWhistle = new Move("Grass Whistle", Grass, 0, 0.55, 15, 'S', new double[] { 1 }, new Effect[] { Sleep }, new bool[] { false }, ZGrassWhistle, 0);
        public static readonly Move GrassyTerrain = new Move("Grassy Terrain", Grass, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { GrassTerrain }, new bool[] { false }, ZGrassyTerrain, 0);
        public static readonly Move HornLeech = new Move("Horn Leech", Grass, 75, 1, 10, 'P', new double[] { 1 }, new Effect[] { HealHalfDmgInflicted }, new bool[] { true }, new ZMove(BloomDoom, 140), 0);
        public static readonly Move Ingrain = new Move("Ingrain", Grass, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Rooting }, new bool[] { true }, ZIngrain, 0);
        public static readonly Move LeafBlade = new Move("Leaf Blade", Grass, 90, 1, 15, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(BloomDoom, 175), 0);
        public static readonly Move LeafStorm = new Move("Leaf Storm", Grass, 130, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { SpAtkDwn2 }, new bool[] { true }, new ZMove(BloomDoom, 195), 0);
        public static readonly Move LeafTornado = new Move("Leaf Tornado", Grass, 65, 0.9, 10, 'M', new double[] { 0.3 }, new Effect[] { AccDwn1 }, new bool[] { false }, new ZMove(BloomDoom, 120), 0);
        public static readonly Move Leafage = new Move("Leafage", Grass, 40, 1, 40, 'P', null, null, null, BloomDoom, 0);
        public static readonly Move LeechSeed = new Move("Leech Seed", Grass, 0, 0.9, 10, 'S', new double[] { 1 }, new Effect[] { LeechSeedStatus }, new bool[] { false }, ZLeechSeed, 0);
        public static readonly Move MagicalLeaf = new Move("Magical Leaf", Grass, 60, -1, 20, 'M', null, null, null, new ZMove(BloomDoom, 120), 0);
        public static readonly Move MegaDrain = new Move("Mega Drain", Grass, 40, 1, 15, 'M', new double[] { 1 }, new Effect[] { HealHalfDmgInflicted }, new bool[] { true }, new ZMove(BloomDoom, 120), 0);
        public static readonly Move NeedleArm = new Move("Needle Arm", Grass, 60, 1, 15, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(BloomDoom, 120), 0);
        public static readonly Move PetalBlizzard = new Move("Petal Blizzard", Grass, 90, 1, 15, 'P', new double[] { 1 }, new Effect[] { HitAllAdjacent }, new bool[] { false }, new ZMove(BloomDoom, 175), 0);
        public static readonly Move PetalDance = new Move("Petal Dance", Grass, 120, 1, 10, 'M', new double[] { 1 }, new Effect[] { ThrashEffect }, new bool[] { true }, new ZMove(BloomDoom, 190), 0);
        public static readonly Move PowerWhip = new Move("Power Whip", Grass, 120, 0.85, 10, 'P', null, null, null, new ZMove(BloomDoom, 190), 0);
        public static readonly Move RazorLeaf = new Move("Razor Leaf", Grass, 55, 0.95, 25, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, BloomDoom, 0);
        public static readonly Move SeedBomb = new Move("Seed Bomb", Grass, 80, 1, 15, 'P', null, null, null, new ZMove(BloomDoom, 160), 0);
        public static readonly Move SeedFlare = new Move("Seed Flare", Grass, 120, 0.85, 5, 'M', new double[] { 0.4 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, new ZMove(BloomDoom, 190), 0);
        public static readonly Move SleepPowder = new Move("Sleep Powder", Grass, 0, 0.75, 15, 'S', new double[] { 1 }, new Effect[] { Sleep }, new bool[] { false }, ZSleepPowder, 0);
        public static readonly Move SolarBeam = new Move("Solar Beam", Grass, 120, 1, 10, 'M', new double[] { 1 }, new Effect[] { TakingInSunlight }, new bool[] { true }, new ZMove(BloomDoom, 190), 0);
        public static readonly Move SolarBlade = new Move("Solar Blade", Grass, 125, 1, 10, 'P', new double[] { 1 }, new Effect[] { TakingInSunlight }, new bool[] { true }, new ZMove(BloomDoom, 190), 0);
        public static readonly Move SpikyShield = new Move("Spiky Shield", Grass, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Protection, isHitByPhysMv, Recoil.EighthMaxHP }, new bool[] { true, true, false }, ZSpikyShield, 4);
        public static readonly Move Spore = new Move("Spore", Grass, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { Sleep }, new bool[] { false }, ZSpore, 0);
        public static readonly Move StrengthSap = new Move("Strength Sap", Grass, 0, 1, 10, 'S', new double[] { 1, 1 }, new Effect[] { HealTargetAtkStat, AtkDwn1 }, new bool[] { true, false }, ZStrengthSap, 0);
        public static readonly Move StunSpore = new Move("Stun Spore", Grass, 0, 0.75, 30, 'S', new double[] { 1 }, new Effect[] { Paralysis }, new bool[] { false }, ZStunSpore, 0);
        public static readonly Move Synthesis = new Move("Synthesis", Grass, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { WeatherBasedHPRestore }, new bool[] { true }, ZSynthesis, 0);
        public static readonly Move TropKick = new Move("Trop Kick", Grass, 70, 1, 15, 'P', new double[] { 1 }, new Effect[] { AtkDwn1 }, new bool[] { false }, new ZMove(BloomDoom, 140), 0);
        public static readonly Move VineWhip = new Move("Vine Whip", Grass, 45, 1, 25, 'P', null, null, null, BloomDoom, 0);
        public static readonly Move WoodHammer = new Move("Wood Hammer", Grass, 120, 1, 15, 'P', new double[] { 1 }, new Effect[] { Recoil.ThirdDmgDealt }, new bool[] { true }, new ZMove(BloomDoom, 190), 0);
        public static readonly Move WorrySeed = new Move("Worry Seed", Grass, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { ChangeTargetAbilityToInsomnia }, new bool[] { false }, ZWorrySeed, 0);
        #endregion

        #region Ice
        public static readonly Move AuroraBeam = new Move("Aurora Beam", Ice, 65, 1, 20, 'M', new double[] { 0.1 }, new Effect[] { AtkDwn1 }, new bool[] { false }, SubzeroSlammer, 0);
        public static readonly Move AuroraVeil = new Move("Aurora Veil", Ice, 0, 1, 20, 'S', new double[] { 1, 1 }, new Effect[] { AttackScreen, SpecialScreen }, new bool[] { true, true }, ZAuroraVeil, 0);
        public static readonly Move Avalanche = new Move("Avalanche", Ice, 60, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { ifTakenDmgThisTurn, DoublePower }, new bool[] { true }, SubzeroSlammer, -4);
        public static readonly Move Blizzard = new Move("Blizzard", Ice, 110, 0.7, 5, 'M', new double[] { 0.1 }, new Effect[] { Freeze }, new bool[] { false }, new ZMove(SubzeroSlammer, 185), 0);
        public static readonly Move FreezeShock = new Move("Freeze Shock", Ice, 140, 0.9, 5, 'P', new double[] { 0.3 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(SubzeroSlammer, 200), 0);
        public static readonly Move FreezeDry = new Move("Freeze-Dry", Ice, 70, 1, 20, 'M', new double[] { 0.1, 1 }, new Effect[] { Freeze, FreezeDryEffect }, new bool[] { false, true }, new ZMove(SubzeroSlammer, 140), 0);
        public static readonly Move FrostBreath = new Move("Frost Breath", Ice, 60, 0.9, 10, 'M', new double[] { 1 }, new Effect[] { AllCrit }, new bool[] { true }, SubzeroSlammer, 0);
        public static readonly Move Glaciate = new Move("Glaciate", Ice, 65, 0.95, 10, 'M', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, SubzeroSlammer, 0);
        public static readonly Move Hail = new Move("Hail", Ice, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { HailWeather }, new bool[] { false }, ZHail, 0);
        public static readonly Move Haze = new Move("Haze", Ice, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { ResetAllStatChanges }, new bool[] { true }, ZHaze, 0);
        public static readonly Move IceBall = new Move("Ice Ball", Ice, 30, 0.9, 20, 'P', new double[] { 1 }, new Effect[] { IncrementalDamageMux }, new bool[] { true }, new ZMove(SubzeroSlammer, 100), 0);
        public static readonly Move IceBeam = new Move("Ice Beam", Ice, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { Freeze }, new bool[] { false }, new ZMove(SubzeroSlammer, 175), 0);
        public static readonly Move IceBurn = new Move("Ice Burn", Ice, 140, 0.9, 5, 'M', new double[] { 0.3 }, new Effect[] { Burn }, new bool[] { false }, new ZMove(SubzeroSlammer, 200), 0);
        public static readonly Move IceFang = new Move("Ice Fang", Ice, 65, 0.95, 15, 'P', new double[] { 0.1 }, new Effect[] { Flinch }, new bool[] { false }, SubzeroSlammer, 0);
        public static readonly Move IceHammer = new Move("Ice Hammer", Ice, 100, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, new ZMove(SubzeroSlammer, 180), 0);
        public static readonly Move IcePunch = new Move("Ice Punch", Ice, 75, 1, 15, 'P', new double[] { 0.1 }, new Effect[] { Freeze }, new bool[] { false }, new ZMove(SubzeroSlammer, 140), 0);
        public static readonly Move IceShard = new Move("Ice Shard", Ice, 40, 1, 30, 'P', new double[] { }, new Effect[] { }, new bool[] { }, new ZMove(SubzeroSlammer, 100), 1);
        public static readonly Move IcicleCrash = new Move("Icicle Crash", Ice, 85, 0.9, 10, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(SubzeroSlammer, 160), 0);
        public static readonly Move IcicleSpear = new Move("Icicle Spear", Ice, 25, 1, 30, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { true }, new ZMove(SubzeroSlammer, 140), 0);
        public static readonly Move IcyWind = new Move("Icy Wind", Ice, 55, 0.95, 15, 'M', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, new ZMove(SubzeroSlammer, 100), 0);
        public static readonly Move Mist = new Move("Mist", Ice, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { PreventStatChanges }, new bool[] { true }, ZMist, 0);
        public static readonly Move PowderSnow = new Move("Powder Snow", Ice, 40, 1, 35, 'M', new double[] { 0.1 }, new Effect[] { Freeze }, new bool[] { false }, new ZMove(SubzeroSlammer, 100), 0);
        public static readonly Move SheerCold = new Move("Sheer Cold", Ice, -1, -2, 5, 'M', new double[] { 1 }, new Effect[] { OHKO }, new bool[] { false }, new ZMove(SubzeroSlammer, 180), 0);
        #endregion

        #region Fighting
        public static readonly Move ArmThrust = new Move("Arm Thrust", Fighting, 15, 1, 20, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, AllOutPummeling, 0);
        public static readonly Move AuraSphere = new Move("Aura Sphere", Fighting, 80, -1, 20, 'M', null, null, null, new ZMove(AllOutPummeling, 160), 0);
        public static readonly Move BrickBreak = new Move("Brick Break", Fighting, 75, 1, 15, 'P', new double[] { 1 }, new Effect[] { BreakScreens }, new bool[] { false }, new ZMove(AllOutPummeling, 140), 0);
        public static readonly Move BulkUp = new Move("Bulk Up", Fighting, 0, -1, 20, 'P', new double[] { 1, 1 }, new Effect[] { AtkUp1, DefUp1 }, new bool[] { true, true }, ZBulkUp, 0);
        public static readonly Move CircleThrow = new Move("Circle Throw", Fighting, 60, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Switchout }, new bool[] { false }, new ZMove(AllOutPummeling, 120), -6);
        public static readonly Move CloseCombat = new Move("Close Combat", Fighting, 120, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { DefDwn1, SpDefDwn1 }, new bool[] { true, true }, new ZMove(AllOutPummeling, 190), 0);
        public static readonly Move Counter = new Move("Counter", Fighting, -1, 1, 20, 'P', new double[] { 1, 1 }, new Effect[] { isHitByPhysMv, CopyLastMove, DoublePower }, new bool[] { true, false, true }, AllOutPummeling, -5);
        public static readonly Move CrossChop = new Move("Cross Chop", Fighting, 100, 0.8, 5, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(AllOutPummeling, 180), 0);
        public static readonly Move Detect = new Move("Detect", Fighting, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { Protection }, new bool[] { true }, ZDetect, 4);
        public static readonly Move DoubleKick = new Move("DoubleKick", Fighting, 30, 1, 30, 'P', new double[] { 1 }, new Effect[] { HitTwiceOneTurn }, new bool[] { false }, AllOutPummeling, 0);
        public static readonly Move DynamicPunch = new Move("Dynamic Punch", Fighting, 100, 0.5, 5, 'P', new double[] { 1 }, new Effect[] { Confused }, new bool[] { false }, new ZMove(AllOutPummeling, 180), 0);
        public static readonly Move FinalGambit = new Move("Final Gambit", Fighting, -1, 1, 5, 'M', new double[] { 1, 1 }, new Effect[] { DealRemainingHP, SelfDestruction }, new bool[] { false, true }, new ZMove(AllOutPummeling, 180), 0);
        public static readonly Move FlyingPress = new Move("Flying Press", Fighting, 100, 0.95, 10, 'P', new double[] { 1 }, new Effect[] { FlyingPressEffect }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
        public static readonly Move FocusBlast = new Move("Focus Blast", Fighting, 120, 0.7, 5, 'M', new double[] { 0.1 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, new ZMove(AllOutPummeling, 190), 0);
        public static readonly Move FocusPunch = new Move("Focus Punch", Fighting, 150, 1, 20, 'P', new double[] { 1 }, new Effect[] { FocusPunchEffect }, new bool[] { true }, new ZMove(AllOutPummeling, 200), -3);
        public static readonly Move ForcePalm = new Move("Force Palm", Fighting, 60, 1, 10, 'P', new double[] { 0.3 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
        public static readonly Move HammerArm = new Move("Hammer Arm", Fighting, 100, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { true }, new ZMove(AllOutPummeling, 180), 0);
        public static readonly Move HighJumpKick = new Move("High Jump Kick", Fighting, 130, 0.9, 10, 'P', new double[] { 1, 1 }, new Effect[] { ifMoveMisses, Recoil.HalfMaxHP }, new bool[] { true, true }, new ZMove(AllOutPummeling, 195), 0);
        public static readonly Move JumpKick = new Move("Jump Kick", Fighting, 100, 0.95, 10, 'P', new double[] { 1, 1 }, new Effect[] { ifMoveMisses, Recoil.HalfMaxHP }, new bool[] { true, true }, new ZMove(AllOutPummeling, 180), 0);
        public static readonly Move KarateChop = new Move("Karate Chop", Fighting, 50, 1, 25, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, AllOutPummeling, 0);
        public static readonly Move LowKick = new Move("Low Kick", Fighting, -1, 1, 20, 'P', new double[] { 1 }, new Effect[] { HeavierOppMoreDmg }, new bool[] { false }, new ZMove(AllOutPummeling, 160), 0);
        public static readonly Move LowSweep = new Move("Low Sweep", Fighting, 65, 1, 20, 'P', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
        public static readonly Move MachPunch = new Move("Mach Punch", Fighting, 40, 1, 30, 'P', null, null, null, AllOutPummeling, 1);
        public static readonly Move MatBlock = new Move("Mat Block", Fighting, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { TeamProtection }, new bool[] { false }, ZMatBlock, 0);
        public static readonly Move PowerUpPunch = new Move("Power-Up Punch", Fighting, 40, 1, 10, 'P', new double[] { 1 }, new Effect[] { AtkUp1 }, new bool[] { true }, AllOutPummeling, 0);
        public static readonly Move QuickGuard = new Move("Quick Guard", Fighting, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { QuickGuardEffect }, new bool[] { false }, ZQuickGuard, 3);
        public static readonly Move Revenge = new Move("Revenge", Fighting, 60, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { ifTakenDmgThisTurn, DoublePower }, new bool[] { true, true }, new ZMove(AllOutPummeling, 120), -4);
        public static readonly Move Reversal = new Move("Reversal", Fighting, -1, 1, 15, 'P', new double[] { 1 }, new Effect[] { LessHPMoreDmg }, new bool[] { true }, new ZMove(AllOutPummeling, 160), 0);
        public static readonly Move RockSmash = new Move("Rock Smash", Fighting, 40, 1, 15, 'P', new double[] { 0.5 }, new Effect[] { DefDwn1 }, new bool[] { false }, AllOutPummeling, 0);
        public static readonly Move RollingKick = new Move("Rolling Kick", Fighting, 60, 0.85, 15, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
        public static readonly Move SacredSword = new Move("Sacred Sword", Fighting, 90, 1, 20, 'P', new double[] { 1 }, new Effect[] { IgnoreStatChanges }, new bool[] { true }, new ZMove(AllOutPummeling, 175), 0);
        public static readonly Move SecretSword = new Move("Secret Sword", Fighting, 85, 1, 10, 'M', new double[] { 1 }, new Effect[] { DmgBasedOnOppositeStat }, new bool[] { false }, new ZMove(AllOutPummeling, 160), 0);
        public static readonly Move SeismicToss = new Move("Seismic Toss", Fighting, -1, 1, 20, 'P', new double[] { 1 }, new Effect[] { DealsDmgEqualToLvl }, new bool[] { false }, AllOutPummeling, 0);
        public static readonly Move SkyUppercut = new Move("Sky Uppercut", Fighting, 85, 0.9, 15, 'P', new double[] { 1 }, new Effect[] { Ignore.Fly }, new bool[] { false }, new ZMove(AllOutPummeling, 160), 0);
        public static readonly Move StormThrow = new Move("Storm Throw", Fighting, 60, 1, 10, 'P', new double[] { 1 }, new Effect[] { AllCrit }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
        public static readonly Move Submission = new Move("Submission", Fighting, 80, 0.8, 20, 'P', new double[] { 1 }, new Effect[] { Recoil.QuarterDmgDealt }, new bool[] { true }, new ZMove(AllOutPummeling, 160), 0);
        public static readonly Move Superpower = new Move("Superpower", Fighting, 120, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { AtkDwn1, DefDwn1 }, new bool[] { true, true }, new ZMove(AllOutPummeling, 190), 0);
        public static readonly Move TripleKick = new Move("Triple Kick", Fighting, -1, 0.9, 10, 'P', new double[] { 1, }, new Effect[] { TripleKickEffect }, new bool[] { false }, new ZMove(AllOutPummeling, 120), 0);
        public static readonly Move VacuumWave = new Move("Vacuum Wave", Fighting, 40, 1, 30, 'M', null, null, null, AllOutPummeling, 1);
        public static readonly Move VitalThrow = new Move("Vital Throw", Fighting, 70, -1, 10, 'P', null, null, null, new ZMove(AllOutPummeling, 140), -1);
        public static readonly Move WakeUpSlap = new Move("Wake-Up Slap", Fighting, 70, 1, 10, 'P', new double[] { 1, 1, 1 }, new Effect[] { isAsleep, DoublePower, CureSleep }, new bool[] { false, true, false }, new ZMove(AllOutPummeling, 140), 0);
        #endregion

        #region Poison
        public static readonly Move Acid = new Move("Acid", Poison, 40, 1, 30, 'M', new double[] { 0.1 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, AcidDownpour, 0);
        public static readonly Move AcidArmor = new Move("Acid Armor", Poison, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { DefUp2 }, new bool[] { true }, ZAcidArmor, 0);
        public static readonly Move AcidSpray = new Move("Acid Spray", Poison, 40, 1, 20, 'M', new double[] { 1 }, new Effect[] { SpDefDwn2 }, new bool[] { false }, AcidDownpour, 0);
        public static readonly Move BanefulBunker = new Move("Baneful Bunker", Poison, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { Protection, isHitByPhysMv, Poisoned }, new bool[] { true, true, false }, ZBanefulBunker, 4);
        public static readonly Move Belch = new Move("Belch", Poison, 120, 0.9, 10, 'M', new double[] { 1, 1 }, new Effect[] { NotEatenBerry, DealsNoDmg }, new bool[] { true, true }, new ZMove(AcidDownpour, 190), 0);
        public static readonly Move ClearSmog = new Move("Clear Smog", Poison, 50, -1, 15, 'M', new double[] { 1 }, new Effect[] { ResetAllStatChanges }, new bool[] { false }, AcidDownpour, 0);
        public static readonly Move Coil = new Move("Coil", Poison, 0, -1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { AtkUp1, DefUp1, AccUp1 }, new bool[] { true, true, true }, ZCoil, 0);
        public static readonly Move CrossPoison = new Move("Cross Poison", Poison, 70, 1, 20, 'P', new double[] { 1, 0.1 }, new Effect[] { HighCrit, Poisoned }, new bool[] { true, false }, new ZMove(AcidDownpour, 140), 0);
        public static readonly Move GastroAcid = new Move("Gastro Acid", Poison, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { RemoveTargetAbilityEffects }, new bool[] { false }, ZGastroAcid, 0);
        public static readonly Move GunkShot = new Move("Gunk Shot", Poison, 120, 0.8, 5, 'P', new double[] { 0.3 }, new Effect[] { Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 190), 0);
        public static readonly Move PoisonFang = new Move("Poison Fang", Poison, 50, 1, 15, 'P', new double[] { 0.5 }, new Effect[] { BadPoison }, new bool[] { false }, AcidDownpour, 0);
        public static readonly Move PoisonGas = new Move("Poison Gas", Poison, 0, 0.9, 40, 'S', new double[] { 1 }, new Effect[] { Poisoned }, new bool[] { false }, ZPoisonGas, 0);
        public static readonly Move PoisonJab = new Move("Poison Jab", Poison, 80, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 160), 0);
        public static readonly Move PoisonPowder = new Move("Poison Powder", Poison, 0, 0.75, 35, 'S', new double[] { 1 }, new Effect[] { Poisoned }, new bool[] { false }, ZPoisonPowder, 0);
        public static readonly Move PoisonSting = new Move("Poison Sting", Poison, 15, 1, 35, 'P', new double[] { 0.3 }, new Effect[] { Poisoned }, new bool[] { false }, AcidDownpour, 0);
        public static readonly Move PoisonTail = new Move("Poison Tail", Poison, 50, 1, 25, 'P', new double[] { 1, 0.1 }, new Effect[] { HighCrit, Poisoned }, new bool[] { true, false }, AcidDownpour, 0);
        public static readonly Move Purify = new Move("Purify", Poison, 0, -1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { ifAfflicted, CureNonVolatile, HalfHPRestore }, new bool[] { false, false, true }, ZPurify, 0);
        public static readonly Move Sludge = new Move("Sludge", Poison, 65, 1, 20, 'M', new double[] { 0.3 }, new Effect[] { Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 120), 0);
        public static readonly Move SludgeBomb = new Move("Sludge Bomb", Poison, 90, 1, 10, 'M', new double[] { 0.3 }, new Effect[] { Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 175), 0);
        public static readonly Move SludgeWave = new Move("Sludge Wave", Poison, 95, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { Poisoned }, new bool[] { false }, new ZMove(AcidDownpour, 175), 0);
        public static readonly Move Smog = new Move("Smog", Poison, 30, 0.7, 20, 'M', new double[] { 0.4 }, new Effect[] { Poisoned }, new bool[] { false }, AcidDownpour, 0);
        public static readonly Move Toxic = new Move("Toxic", Poison, 0, 0.9, 10, 'S', new double[] { 1 }, new Effect[] { BadPoison }, new bool[] { false }, ZToxic, 0);
        public static readonly Move ToxicSpikes = new Move("Toxic Spikes", Poison, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { SetEntryHazards.ToxicSpikes }, new bool[] { false }, ZToxicSpikes, 0);
        public static readonly Move ToxicThread = new Move("Toxic Thread", Poison, 0, 1, 20, 'S', new double[] { 1, 1 }, new Effect[] { Poisoned, SpdDwn1 }, new bool[] { false, false }, ZToxicThread, 0);
        public static readonly Move VenomDrench = new Move("Venom Drench", Poison, 0, 1, 20, 'S', new double[] { 1, 1, 1, 1 }, new Effect[] { isPoisoned, AtkDwn1, SpAtkDwn1, SpdDwn1 }, new bool[] { false, false, false, false }, ZVenomDrench, 0);
        public static readonly Move Venoshock = new Move("Venoshock", Poison, 65, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { isPoisoned, DoublePower }, new bool[] { false, true }, new ZMove(AcidDownpour, 120), 0);
        #endregion

        #region Ground
        public static readonly Move BoneClub = new Move("Bone Club", Ground, 65, 0.85, 20, 'P', new double[] { 0.1 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(TectonicRage, 120), 0);
        public static readonly Move BoneRush = new Move("Bone Rush", Ground, 25, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, new ZMove(TectonicRage, 140), 0);
        public static readonly Move Bonemerang = new Move("Bonemerang", Ground, 50, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { HitTwiceOneTurn }, new bool[] { false }, TectonicRage, 0);
        public static readonly Move Bulldoze = new Move("Bulldoze", Ground, 60, 1, 20, 'P', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, new ZMove(TectonicRage, 120), 0);
        public static readonly Move Dig = new Move("Dig", Ground, 80, 1, 10, 'P', new double[] { 1 }, new Effect[] { SemiInvulnerable }, new bool[] { true }, new ZMove(TectonicRage, 160), 0);
        public static readonly Move DrillRun = new Move("Drill Run", Ground, 80, 0.95, 10, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(TectonicRage, 160), 0);
        public static readonly Move EarthPower = new Move("Earth Power", Ground, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, new ZMove(TectonicRage, 175), 0);
        public static readonly Move Earthquake = new Move("Earthquake", Ground, 100, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { ifUnderground, DoublePower }, new bool[] { false, true }, new ZMove(TectonicRage, 180), 0);
        public static readonly Move Fissure = new Move("Fissure", Ground, -1, -2, 5, 'P', new double[] { 1 }, new Effect[] { OHKO }, new bool[] { false }, new ZMove(TectonicRage, 180), 0);
        public static readonly Move HighHorsepower = new Move("High Horsepower", Ground, 95, 0.95, 10, 'P', null, null, null, new ZMove(TectonicRage, 175), 0);
        public static readonly Move LandsWrath = new Move("Land's Wrath", Ground, 90, 1, 10, 'P', null, null, null, new ZMove(TectonicRage, 185), 0);
        public static readonly Move Magnitude = new Move("Magnitude", Ground, -1, 1, 30, 'P', new double[] { 1, 1, 1 }, new Effect[] { MagnitudeEffect, ifUnderground, DoublePower }, new bool[] { false, false, true }, new ZMove(TectonicRage, 140), 0);
        public static readonly Move MudBomb = new Move("Mud Bomb", Ground, 65, 0.85, 10, 'M', new double[] { 0.3 }, new Effect[] { AccDwn1 }, new bool[] { false }, new ZMove(TectonicRage, 120), 0);
        public static readonly Move MudShot = new Move("Mud Shot", Ground, 55, 0.95, 15, 'M', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, TectonicRage, 0);
        public static readonly Move MudSport = new Move("Mud Sport", Ground, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { Strengthen.Ground, Weaken.Electric }, new bool[] { false, false }, ZMudSport, 0);
        public static readonly Move MudSlap = new Move("Mud-Slap", Ground, 20, 1, 10, 'M', new double[] { 1 }, new Effect[] { AccDwn1 }, new bool[] { false }, TectonicRage, 0);
        public static readonly Move PrecipiceBlades = new Move("Precipice Blades", Ground, 120, 0.85, 10, 'P', new double[] { 1 }, new Effect[] { HitAllFoes }, new bool[] { false }, new ZMove(TectonicRage, 190), 0);
        public static readonly Move Rototiller = new Move("Rototiller", Ground, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { RototillerEffect }, new bool[] { false }, ZRototiller, 0);
        public static readonly Move SandAttack = new Move("Sand Attack", Ground, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { AccDwn1 }, new bool[] { false }, ZSandAttack, 0);
        public static readonly Move SandTomb = new Move("Sand Tomb", Ground, 35, 0.85, 15, 'P', new double[] { 1 }, new Effect[] { Bound }, new bool[] { false }, TectonicRage, 0);
        public static readonly Move ShoreUp = new Move("Shore Up", Ground, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { HalfHPRestore, isSandstorm, SixthHPRestore }, new bool[] { true, true, true }, ZShoreUp, 0);
        public static readonly Move Spikes = new Move("Spikes", Ground, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { SetEntryHazards.Spikes }, new bool[] { false }, ZSpikes, 0);
        public static readonly Move StompingTantrum = new Move("Stomping Tantrum", Ground, 75, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { LastMoveFailed, DoublePower }, new bool[] { true, true }, new ZMove(TectonicRage, 140), 0);
        public static readonly Move ThousandArrows = new Move("Thousand Arrows", Ground, 90, 1, 10, 'P', new double[] { 1 }, new Effect[] { Grounded }, new bool[] { false }, new ZMove(TectonicRage, 180), 0);
        public static readonly Move ThousandWaves = new Move("Thousand Waves", Ground, 90, 1, 10, 'P', new double[] { 1 }, new Effect[] { LegHold }, new bool[] { false }, new ZMove(TectonicRage, 175), 0);
        #endregion

        #region Flying
        public static readonly Move Acrobatics = new Move("Acrobatics", Flying, 55, 1, 15, 'P', new double[] { 1, 1 }, new Effect[] { NoHeldItem, DoublePower }, new bool[] { true, true }, SupersonicSkystrike, 0);
        public static readonly Move AerialAce = new Move("Aerial Ace", Flying, 60, -1, 20, 'P', null, null, null, new ZMove(SupersonicSkystrike, 120), 0);
        public static readonly Move Aeroblast = new Move("Aeroblast", Flying, 100, 0.95, 5, 'M', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(SupersonicSkystrike, 180), 0);
        public static readonly Move AirCutter = new Move("Air Cutter", Flying, 60, 0.95, 25, 'M', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(SupersonicSkystrike, 120), 0);
        public static readonly Move AirSlash = new Move("Air Slash", Flying, 75, 0.95, 20, 'M', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(SupersonicSkystrike, 150), 0);
        public static readonly Move BeakBlast = new Move("Beak Blast", Flying, 100, 1, 15, 'P', new double[] { 1, 1 }, new Effect[] { isHitByPhysMv, Burn }, new bool[] { true, false }, new ZMove(SupersonicSkystrike, 180), -3);
        public static readonly Move Bounce = new Move("Bounce", Flying, 85, 0.85, 5, 'P', new double[] { 1, 0.3 }, new Effect[] { SemiInvulnerable, Paralysis }, new bool[] { true, false }, new ZMove(SupersonicSkystrike, 160), 0);
        public static readonly Move BraveBird = new Move("Brave Bird", Flying, 120, 1, 15, 'P', new double[] { 1 }, new Effect[] { Recoil.ThirdDmgDealt }, new bool[] { false }, new ZMove(SupersonicSkystrike, 190), 0);
        public static readonly Move Chatter = new Move("Chatter", Flying, 65, 1, 20, 'M', new double[] { 1 }, new Effect[] { Confused }, new bool[] { false }, new ZMove(SupersonicSkystrike, 120), 0);
        public static readonly Move Defog = new Move("Defog", Flying, 0, -1, 15, 'S', new double[] { 1, 1 }, new Effect[] { RemoveEntryHazards, BreakScreens }, new bool[] { false, false }, ZDefog, 0);
        public static readonly Move DragonAscent = new Move("DragonAscent", Flying, 120, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { DefDwn1, SpDefDwn1 }, new bool[] { true, true }, new ZMove(SupersonicSkystrike, 190), 0);
        public static readonly Move DrillPeck = new Move("Drill Peck", Flying, 80, 1, 20, 'P', null, null, null, new ZMove(SupersonicSkystrike, 160), 0);
        public static readonly Move FeatherDance = new Move("Feather Dance", Flying, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { AtkDwn2 }, new bool[] { false }, ZFeatherDance, 0);
        public static readonly Move Fly = new Move("Fly", Flying, 90, 0.95, 15, 'P', new double[] { 1 }, new Effect[] { SemiInvulnerable }, new bool[] { true }, new ZMove(SupersonicSkystrike, 175), 0);
        public static readonly Move Gust = new Move("Gust", Flying, 40, 1, 35, 'M', new double[] { 1, 1, 1 }, new Effect[] { ifInAir, Ignore.Fly, DoublePower }, new bool[] { false, true }, SupersonicSkystrike, 0);
        public static readonly Move Hurricane = new Move("Hurricane", Flying, 110, 0.7, 10, 'M', new double[] { 0.3 }, new Effect[] { Confused }, new bool[] { false }, new ZMove(SupersonicSkystrike, 185), 0);
        public static readonly Move MirrorMove = new Move("Mirror Move", Flying, -1, -1, 20, 'S', new double[] { 1 }, new Effect[] { UseLastMove }, new bool[] { false }, ZMirrorMove, 0);
        public static readonly Move OblivionWing = new Move("Oblivion Wing", Flying, 80, 1, 10, 'M', new double[] { 1 }, new Effect[] { ThreeQuarterDmgInflicted }, new bool[] { false }, new ZMove(SupersonicSkystrike, 160), 0);
        public static readonly Move Peck = new Move("Peck", Flying, 35, 1, 35, 'P', null, null, null, SupersonicSkystrike, 0);
        public static readonly Move Pluck = new Move("Pluck", Flying, 60, 1, 20, 'P', new double[] { 1, 1 }, new Effect[] { ifTgtHoldBerry, ConsumeItem }, new bool[] { false, false }, new ZMove(SupersonicSkystrike, 120), 0);
        public static readonly Move Roost = new Move("Roost", Flying, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { HalfHPRestore, RoostEffect }, new bool[] { true, true }, ZRoost, 0);
        public static readonly Move SkyAttack = new Move("Sky Attack", Flying, 140, 0.9, 5, 'P', new double[] { 1, 0.3 }, new Effect[] { Glowing, Flinch }, new bool[] { true, false }, new ZMove(SupersonicSkystrike, 200), 0);
        public static readonly Move SkyDrop = new Move("Sky Drop", Flying, 60, 1, 10, 'P', new double[] { 1 }, new Effect[] { SkyDropEffect }, new bool[] { false }, new ZMove(SupersonicSkystrike, 120), 0);
        public static readonly Move Tailwind = new Move("Tailwind", Flying, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { DoublePartySpeed4turns }, new bool[] { true }, ZTailwind, 0);
        public static readonly Move WingAttack = new Move("Wing Attack", Flying, 60, 1, 35, 'P', null, null, null, new ZMove(SupersonicSkystrike, 120), 0);
        #endregion

        #region Psychic
        public static readonly Move Agility = new Move("Agility", Psychic, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { SpdUp2 }, new bool[] { true }, ZAgility, 0);
        public static readonly Move AllySwitch = new Move("Ally Switch", Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { SwitchPlacesAlly }, new bool[] { true }, ZAllySwitch, 2);
        public static readonly Move Amnesia = new Move("Amnesia", Psychic, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { SpDefUp2 }, new bool[] { true }, ZAmnesia, 0);
        public static readonly Move Barrier = new Move("Barrier", Psychic, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { DefUp2 }, new bool[] { true }, ZBarrier, 0);
        public static readonly Move CalmMind = new Move("Calm Mind", Psychic, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { SpAtkUp1, SpDefUp1 }, new bool[] { true, true }, ZCalmMind, 0);
        public static readonly Move Confusion = new Move("Confusion", Psychic, 50, 1, 25, 'M', new double[] { 0.1 }, new Effect[] { Confused }, new bool[] { false }, ShatteredPsyche, 0);
        public static readonly Move CosmicPower = new Move("Cosmic Power", Psychic, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { DefUp1, SpDefUp1 }, new bool[] { true, true }, ZCosmicPower, 0);
        public static readonly Move DreamEater = new Move("Dream Eater", Psychic, 100, 1, 15, 'M', new double[] { 1, 1, 1, 1 }, new Effect[] { DealsNoDmg, isAsleep, DealsDmg, HealHalfDmgInflicted }, new bool[] { true, false, true, true }, new ZMove(ShatteredPsyche, 180), 0);
        public static readonly Move Extrasensory = new Move("Extrasensory", Psychic, 80, 1, 20, 'M', new double[] { 0.1 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(ShatteredPsyche, 160), 0);
        public static readonly Move FutureSight = new Move("Future Sight", Psychic, 120, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { Wait.TwoTurns, Ignore.AllProtection }, new bool[] { true, true }, new ZMove(ShatteredPsyche, 190), 0);
        public static readonly Move Gravity = new Move("Gravity", Psychic, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { GravityEffect }, new bool[] { false }, ZGravity, 0);
        public static readonly Move GuardSplit = new Move("Guard Split", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Split.Guard }, new bool[] { true }, ZGuardSplit, 0);
        public static readonly Move GuardSwap = new Move("Guard Swap", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Swap.DefSpDefBoosts }, new bool[] { false }, ZGuardSwap, 0);
        public static readonly Move HealBlock = new Move("Heal Block", Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { HealBlockStatus }, new bool[] { false }, ZHealBlock, 0);
        public static readonly Move HealPulse = new Move("Heal Pulse", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { HalfHPRestore }, new bool[] { false }, ZHealPulse, 0);
        public static readonly Move HealingWish = new Move("Healing Wish", Psychic, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { SelfDestruction, SwitchInFullHeal }, new bool[] { true, true }, NO_EFFECT, 0);
        public static readonly Move HeartStamp = new Move("Heart Stamp", Psychic, 60, 1, 25, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(ShatteredPsyche, 120), 0);
        public static readonly Move HeartSwap = new Move("Heart Swap", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Swap.StatChanges }, new bool[] { false }, ZHeartSwap, 0);
        public static readonly Move HyperspaceHole = new Move("Hyperspace Hole", Psychic, 80, 1, 5, 'M', new double[] { 1 }, new Effect[] { Ignore.Protection }, new bool[] { true }, new ZMove(ShatteredPsyche, 160), 0);
        public static readonly Move Hypnosis = new Move("Hypnosis", Psychic, 0, 0.6, 20, 'S', new double[] { 1 }, new Effect[] { Sleep }, new bool[] { false }, ZHypnosis, 0);
        public static readonly Move Imprison = new Move("Imprison", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { ImprisonEffect }, new bool[] { false }, ZImprison, 0);
        public static readonly Move Instruct = new Move("Instruct", Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { InstructEffect }, new bool[] { false }, ZInstruct, 0);
        public static readonly Move Kinesis = new Move("Kinesis", Psychic, 0, 0.8, 15, 'S', new double[] { 1 }, new Effect[] { AccDwn1 }, new bool[] { false }, ZKinesis, 0);
        public static readonly Move LightScreen = new Move("Light Screen", Psychic, 0, -1, 30, 'S', new double[] { 1 }, new Effect[] { SpecialScreen }, new bool[] { true }, ZLightScreen, 0);
        public static readonly Move LunarDance = new Move("Lunar Dance", Psychic, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { SelfDestruction, SwitchInFullHeal }, new bool[] { true, true }, NO_EFFECT, 0);
        public static readonly Move LusterPurge = new Move("Luster Purge", Psychic, 70, 1, 5, 'M', new double[] { 0.5 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, new ZMove(ShatteredPsyche, 140), 0);
        public static readonly Move MagicCoat = new Move("Magic Coat", Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { MagicCoatStatus }, new bool[] { true }, ZMagicCoat, 4);
        public static readonly Move MagicRoom = new Move("Magic Room", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { MagicRoomEffect }, new bool[] { false }, ZMagicRoom, 0);
        public static readonly Move Meditate = new Move("Meditate", Psychic, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { AtkUp1 }, new bool[] { true }, ZMeditate, 0);
        public static readonly Move MiracleEye = new Move("Miracle Eye", Psychic, 0, -1, 40, 'S', new double[] { 1 }, new Effect[] { MiracleEyeEffect }, new bool[] { false }, ZMiracleEye, 0);
        public static readonly Move MirrorCoat = new Move("Mirror Coat", Psychic, 0, 1, 20, 'M', new double[] { 1, 1, 1 }, new Effect[] { isHitBySpMv, CopyLastMove, DoublePower }, new bool[] { true, false, true }, ShatteredPsyche, -5);
        public static readonly Move MistBall = new Move("Mist Ball", Psychic, 70, 1, 5, 'M', new double[] { 0.5 }, new Effect[] { SpAtkDwn1 }, new bool[] { false }, new ZMove(ShatteredPsyche, 140), 0);
        public static readonly Move PowerSplit = new Move("Power Split", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Split.Power }, new bool[] { false }, ZPowerSplit, 0);
        public static readonly Move PowerSwap = new Move("Power Swap", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { PwrSwap }, new bool[] { false }, ZPowerSwap, 0);
        public static readonly Move PowerTrick = new Move("Power Trick", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Swap.AtkDef }, new bool[] { true }, ZPowerTrick, 0);
        public static readonly Move Psybeam = new Move("Psybeam", Psychic, 65, 1, 20, 'M', new double[] { 0.1 }, new Effect[] { Confused }, new bool[] { false }, new ZMove(ShatteredPsyche, 120), 0);
        public static readonly Move psychic = new Move("Psychic", Psychic, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, new ZMove(ShatteredPsyche, 175), 0);
        public static readonly Move PsychicFangs = new Move("Psychic Fangs", Psychic, 85, 1, 10, 'P', new double[] { 1 }, new Effect[] { BreakScreens }, new bool[] { false }, new ZMove(ShatteredPsyche, 160), 0);
        public static readonly Move PsychicTerrain = new Move("Psychic Terrain", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { PsyTerrainEffect }, new bool[] { false }, ZPsychicTerrain, 0);
        public static readonly Move PsychoBoost = new Move("Psycho Boost", Psychic, 120, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { SpAtkDwn2 }, new bool[] { true }, new ZMove(ShatteredPsyche, 200), 0);
        public static readonly Move PsychoCut = new Move("Psycho Cut", Psychic, 70, 1, 20, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(ShatteredPsyche, 140), 0);
        public static readonly Move PsychoShift = new Move("Psycho Shift", Psychic, 0, 0.9, 10, 'S', new double[] { 1 }, new Effect[] { TransferStatus }, new bool[] { false }, ZPsychoShift, 0);
        public static readonly Move Psyshock = new Move("Psyshock", Psychic, 80, 1, 10, 'M', new double[] { 1 }, new Effect[] { DmgBasedOnOppositeStat }, new bool[] { false }, new ZMove(ShatteredPsyche, 160), 0);
        public static readonly Move Psystrike = new Move("Psystrike", Psychic, 100, 1, 10, 'M', new double[] { 1 }, new Effect[] { DmgBasedOnOppositeStat }, new bool[] { false }, new ZMove(ShatteredPsyche, 180), 0);
        public static readonly Move Psywave = new Move("Psywave", Psychic, -1, 1, 15, 'M', new double[] { 1 }, new Effect[] { PsywaveEffect }, new bool[] { false }, ShatteredPsyche, 0);
        public static readonly Move Reflect = new Move("Reflect", Psychic, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { AttackScreen }, new bool[] { true }, ZReflect, 0);
        public static readonly Move Rest = new Move("Rest", Psychic, 0, -1, 10, 'S', new double[] { 1, 1, 1, 1 }, new Effect[] { FullHPRestore, Sleep, Wait.TwoTurns, CureSleep }, new bool[] { true, true, true, true }, ZRest, 0);
        public static readonly Move RolePlay = new Move("Role Play", Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { CopyAbility }, new bool[] { true }, ZRolePlay, 0);
        public static readonly Move SkillSwap = new Move("Skill Swap", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Swap.Ability }, new bool[] { false }, ZSkillSwap, 0);
        public static readonly Move SpeedSwap = new Move("Speed Swap", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { Swap.Speed }, new bool[] { false }, ZSpeedSwap, 0);
        public static readonly Move Synchronoise = new Move("Synchronoise", Psychic, 120, 1, 15, 'M', new double[] { 1 }, new Effect[] { SynchronoiseEffect }, new bool[] { false }, new ZMove(ShatteredPsyche, 190), 0);
        public static readonly Move Telekinesis = new Move("Telekinesis", Psychic, 0, -1, 15, 'S', new double[] { 1 }, new Effect[] { TelekinesisStatus }, new bool[] { true }, ZTelekinesis, 0);
        public static readonly Move Teleport = new Move("Teleport", Psychic, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Switchout }, new bool[] { true }, ZTeleport, 0);
        public static readonly Move Trick = new Move("Trick", Psychic, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { Swap.Item }, new bool[] { false }, ZTrick, 0);
        public static readonly Move TrickRoom = new Move("Trick Room", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { TrickRoomEffect }, new bool[] { true }, ZTrickRoom, -7);
        public static readonly Move WonderRoom = new Move("Wonder Room", Psychic, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { WonderRoomEffect }, new bool[] { false }, ZWonderRoom, 0);
        public static readonly Move ZenHeadbutt = new Move("Zen Headbutt", Psychic, 80, 0.9, 15, 'P', new double[] { 0.2 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(ShatteredPsyche, 160), 0);
        #endregion

        #region Rock
        public static readonly Move Accelerock = new Move("Accelerock", Rock, 40, 1, 20, 'P', null, null, null, ContinentalCrush, 1);
        public static readonly Move AncientPower = new Move("Ancient Power", Rock, 60, 1, 5, 'M', new double[] { 0.1, 0.1, 0.1, 0.1, 0.1 }, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true }, new ZMove(ContinentalCrush, 120), 0);
        public static readonly Move DiamondStorm = new Move("Diamond Storm", Rock, 100, 0.95, 5, 'P', new double[] { 0.5 }, new Effect[] { DefUp2 }, new bool[] { true }, new ZMove(ContinentalCrush, 180), 0);
        public static readonly Move HeadSmash = new Move("Head Smash", Rock, 150, 0.8, 5, 'P', new double[] { 1 }, new Effect[] { Recoil.HalfDmgDealt }, new bool[] { true }, new ZMove(ContinentalCrush, 200), 0);
        public static readonly Move PowerGem = new Move("Power Gem", Rock, 80, 1, 20, 'M', null, null, null, new ZMove(ContinentalCrush, 160), 0);
        public static readonly Move RockBlast = new Move("Rock Blast", Rock, 25, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, new ZMove(ContinentalCrush, 140), 0);
        public static readonly Move RockPolish = new Move("Rock Polish", Rock, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { SpdUp2 }, new bool[] { true }, ZRockPolish, 0);
        public static readonly Move RockSlide = new Move("Rock Slide", Rock, 75, 0.9, 10, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(ContinentalCrush, 140), 0);
        public static readonly Move RockThrow = new Move("Rock Throw", Rock, 50, 0.9, 15, 'P', null, null, null, ContinentalCrush, 0);
        public static readonly Move RockTomb = new Move("Rock Tomb", Rock, 60, 0.95, 15, 'P', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, new ZMove(ContinentalCrush, 120), 0);
        public static readonly Move RockWrecker = new Move("Rock Wrecker", Rock, 150, 0.9, 5, 'P', new double[] { 1 }, new Effect[] { Recharging }, new bool[] { true }, new ZMove(ContinentalCrush, 200), 0);
        public static readonly Move Rollout = new Move("Rollotu", Rock, 30, 0.9, 20, 'P', new double[] { 1 }, new Effect[] { IncrementalDamageMux }, new bool[] { true }, ContinentalCrush, 0);
        public static readonly Move Sandstorm = new Move("Sandstorm", Rock, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { SandstormWeather }, new bool[] { false }, ZSandstorm, 0);
        public static readonly Move SmackDown = new Move("Smack Down", Rock, 50, 1, 15, 'P', new double[] { 1 }, new Effect[] { Grounded }, new bool[] { false }, ContinentalCrush, 0);
        public static readonly Move StealthRock = new Move("Stealth Rock", Rock, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { SetEntryHazards.StealthRock }, new bool[] { false }, ZStealthRock, 0);
        public static readonly Move StoneEdge = new Move("Stone Edge", Rock, 100, 0.8, 5, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(ContinentalCrush, 180), 0);
        public static readonly Move WideGuard = new Move("Wide Guard", Rock, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { WideGuardEffect }, new bool[] { true }, ZWideGuard, 3);
        #endregion

        #region Bug
        public static readonly Move AttackOrder = new Move("Attack Order", Bug, 90, 1, 15, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(SavageSpinOut, 175), 0);
        public static readonly Move BugBite = new Move("Bug Bite", Bug, 60, 1, 20, 'P', new double[] { 1 }, new Effect[] { ifTgtHoldBerry, ConsumeItem }, new bool[] { false, false }, new ZMove(SavageSpinOut, 120), 0);
        public static readonly Move BugBuzz = new Move("Bug Buzz", Bug, 90, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, new ZMove(SavageSpinOut, 175), 0);
        public static readonly Move DefendOrder = new Move("Defend Order", Bug, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { DefUp1, SpDefUp1 }, new bool[] { true, true }, ZDefendOrder, 0);
        public static readonly Move FellStinger = new Move("Fell Stinger", Bug, 50, 1, 25, 'P', new double[] { 1, 1 }, new Effect[] { ifTgtFaints, AtkUp2 }, new bool[] { false, true }, SavageSpinOut, 0);
        public static readonly Move FirstImpression = new Move("First Impression", Bug, 90, 1, 10, 'P', new double[] { 1, 1, 1 }, new Effect[] { DealsNoDmg, ifFirstTurn, DealsDmg }, new bool[] { true, true, true }, new ZMove(SavageSpinOut, 175), 2);
        public static readonly Move FuryCutter = new Move("Fury Cutter", Bug, 40, 0.95, 20, 'P', new double[] { 1 }, new Effect[] { FuryCutterEffect }, new bool[] { true }, SavageSpinOut, 0);
        public static readonly Move HealOrder = new Move("Heal Order", Bug, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { HalfHPRestore }, new bool[] { true }, ZHealOrder, 0);
        public static readonly Move Infestation = new Move("Infestation", Bug, 20, 1, 20, 'M', new double[] { 1 }, new Effect[] { Bound }, new bool[] { false }, SavageSpinOut, 0);
        public static readonly Move LeechLife = new Move("Leech Life", Bug, 80, 1, 10, 'P', new double[] { 1 }, new Effect[] { HealHalfDmgInflicted }, new bool[] { true }, new ZMove(SavageSpinOut, 160), 0);
        public static readonly Move Lunge = new Move("Lunge", Bug, 80, 1, 15, 'P', new double[] { 1 }, new Effect[] { AtkDwn1 }, new bool[] { false }, new ZMove(SavageSpinOut, 160), 0);
        public static readonly Move Megahorn = new Move("Megahorn", Bug, 120, 0.85, 10, 'P', null, null, null, new ZMove(SavageSpinOut, 190), 0);
        public static readonly Move PinMissile = new Move("Pin Missile", Bug, 25, 0.85, 20, 'P', new double[] { 1 }, new Effect[] { HitsMultipleTimes }, new bool[] { false }, new ZMove(SavageSpinOut, 140), 0);
        public static readonly Move PollenPuff = new Move("Pollen Puff", Bug, 90, 1, 15, 'M', new double[] { 1, 1, 1 }, new Effect[] { tgtIsAlly, DealsNoDmg, HalfHPRestore }, new bool[] { false, true, false }, new ZMove(SavageSpinOut, 175), 0);
        public static readonly Move Powder = new Move("Powder", Bug, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { Powdered }, new bool[] { false }, ZPowder, 1);
        public static readonly Move QuiverDance = new Move("Quiver Dance", Bug, 0, -1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true }, ZQuiverDance, 0);
        public static readonly Move RagePowder = new Move("Rage Powder", Bug, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { CenterofAttention }, new bool[] { true }, ZRagePowder, 2);
        public static readonly Move SignalBeam = new Move("Signal Beam", Bug, 75, 1, 15, 'M', new double[] { 0.1 }, new Effect[] { Confused }, new bool[] { false }, new ZMove(SavageSpinOut, 140), 0);
        public static readonly Move SilverWind = new Move("Silver Wind", Bug, 60, 1, 5, 'M', new double[] { 0.1, 0.1, 0.1, 0.1, 0.1 }, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true }, new ZMove(SavageSpinOut, 120), 0);
        public static readonly Move SpiderWeb = new Move("Spider Web", Bug, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { LegHold }, new bool[] { false }, ZSpiderWeb, 0);
        public static readonly Move Steamroller = new Move("Steamroller", Bug, 65, 1, 20, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(SavageSpinOut, 120), 0);
        public static readonly Move StickyWeb = new Move("Sticky Web", Bug, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { SetEntryHazards.StickyWeb }, new bool[] { false }, ZStickyWeb, 0);
        public static readonly Move StringShot = new Move("String Shot", Bug, 0, 0.95, 40, 'S', new double[] { 1 }, new Effect[] { SpdDwn1 }, new bool[] { false }, ZStringShot, 0);
        public static readonly Move StruggleBug = new Move("Struggle Bug", Bug, 50, 1, 20, 'M', new double[] { 1 }, new Effect[] { SpAtkDwn1 }, new bool[] { false }, SavageSpinOut, 0);
        public static readonly Move TailGlow = new Move("Tail Glow", Bug, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { AtkUp3 }, new bool[] { true }, ZTailGlow, 0);
        public static readonly Move Twineedle = new Move("Twineedle", Bug, 25, 1, 20, 'P', new double[] { 0.2, 1 }, new Effect[] { Poisoned, HitTwiceOneTurn }, new bool[] { false, false }, SavageSpinOut, 0);
        public static readonly Move UTurn = new Move("U-Turn", Bug, 70, 1, 20, 'P', new double[] { 1 }, new Effect[] { Switchout }, new bool[] { true }, new ZMove(SavageSpinOut, 140), 0);
        public static readonly Move XScissor = new Move("X-Scissor", Bug, 80, 1, 15, 'P', null, null, null, new ZMove(SavageSpinOut, 160), 0);
        #endregion

        #region Dragon
        public static readonly Move ClangingScales = new Move("Clanging Scales", Dragon, 110, 1, 5, 'M', new double[] { 1 }, new Effect[] { DefDwn1 }, new bool[] { true }, new ZMove(DevastatingDrake, 185), 0);
        public static readonly Move CoreEnforcer = new Move("Core Enforcer", Dragon, 100, 1, 10, 'M', null, null, null, new ZMove(DevastatingDrake, 140), 0);
        public static readonly Move DracoMeteor = new Move("Draco Meteor", Dragon, 130, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { SpAtkDwn2 }, new bool[] { true }, new ZMove(DevastatingDrake, 195), 0);
        public static readonly Move DragonBreath = new Move("Dragon Breath", Dragon, 60, 1, 20, 'M', new double[] { 0.3 }, new Effect[] { Paralysis }, new bool[] { false }, new ZMove(DevastatingDrake, 120), 0);
        public static readonly Move DragonClaw = new Move("Dragon Claw", Dragon, 80, 1, 15, 'P', null, null, null, new ZMove(DevastatingDrake, 160), 0);
        public static readonly Move DragonDance = new Move("Dragon Dance", Dragon, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { AtkUp1, SpdUp1 }, new bool[] { true, true }, ZDragonDance, 0);
        public static readonly Move DragonHammer = new Move("Dragon Hammer", Dragon, 90, 1, 15, 'P', null, null, null, new ZMove(DevastatingDrake, 175), 0);
        public static readonly Move DragonPulse = new Move("Dragon Pulse", Dragon, 85, 1, 10, 'M', null, null, null, new ZMove(DevastatingDrake, 160), 0);
        public static readonly Move DragonRage = new Move("Dragon Rage", Dragon, 40, 1, 10, 'M', new double[] { 1 }, new Effect[] { DoBPInDmg }, new bool[] { false }, DevastatingDrake, 0);
        public static readonly Move DragonRush = new Move("Dragon Rush", Dragon, 100, 0.75, 10, 'P', new double[] { 0.2 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(DevastatingDrake, 180), 0);
        public static readonly Move DragonTail = new Move("Dragon Tail", Dragon, 60, 0.9, 10, 'P', new double[] { 1 }, new Effect[] { Switchout }, new bool[] { false }, new ZMove(DevastatingDrake, 120), -6);
        public static readonly Move DualChop = new Move("Dual Chop", Dragon, 40, 0.9, 15, 'P', new double[] { 1 }, new Effect[] { HitTwiceOneTurn }, new bool[] { true }, DevastatingDrake, 0);
        public static readonly Move Outrage = new Move("Outrage", Dragon, 120, 1, 10, 'P', new double[] { 1 }, new Effect[] { ThrashEffect }, new bool[] { true }, new ZMove(DevastatingDrake, 190), 0);
        public static readonly Move RoarOfTime = new Move("Roar of Time", Dragon, 150, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { Recharging }, new bool[] { true }, new ZMove(DevastatingDrake, 200), 0);
        public static readonly Move SpacialRend = new Move("Spacial Rend", Dragon, 100, 0.95, 5, 'M', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(DevastatingDrake, 180), 0);
        public static readonly Move Twister = new Move("Twister", Dragon, 40, 1, 20, 'M', new double[] { 1, 1 }, new Effect[] { ifInAir, DoublePower }, new bool[] { false, true }, DevastatingDrake, 0);
        #endregion

        #region Ghost
        public static readonly Move Astonish = new Move("Astonish", Ghost, 30, 1, 15, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, NeverEndingNightmare, 0);
        public static readonly Move ConfuseRay = new Move("Confuse Ray", Ghost, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { Confused }, new bool[] { false }, ZConfuseRay, 0);
        public static readonly Move DestinyBond = new Move("Destiny Bond", Ghost, 0, -1, 5, 'S', new double[] { 1, 1 }, new Effect[] { Destiny, Destiny }, new bool[] { true, false }, ZDestinyBond, 0);
        public static readonly Move GhostCurse = new Move("Curse", Ghost, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { Recoil.HalfMaxHP, CurseStatus }, new bool[] { true, false }, ZGhostCurse, 0);
        public static readonly Move Grudge = new Move("Grudge", Ghost, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { GrudgeStatus }, new bool[] { false }, ZGrudge, 0);
        public static readonly Move Hex = new Move("Hex", Ghost, 65, 1, 10, 'M', new double[] { 1, 1 }, new Effect[] { ifAfflicted, DoublePower }, new bool[] { false, true }, new ZMove(NeverEndingNightmare, 160), 0);
        public static readonly Move Lick = new Move("Lick", Ghost, 30, 1, 30, 'P', new double[] { 0.3 }, new Effect[] { Paralysis }, new bool[] { false }, NeverEndingNightmare, 0);
        public static readonly Move MoongeistBeam = new Move("Moongeist Beam", Ghost, 100, 1, 5, 'M', new double[] { 1 }, new Effect[] { Ignore.Ability }, new bool[] { false }, new ZMove(NeverEndingNightmare, 180), 0);
        public static readonly Move Nightmare = new Move("Nightmare", Ghost, 0, 1, 15, 'M', new double[] { 1 }, new Effect[] { NightmareStatus }, new bool[] { false }, ZNightmare, 0);
        public static readonly Move NightShade = new Move("Night Shade", Ghost, -1, 1, 15, 'M', new double[] { 1 }, new Effect[] { DealsDmgEqualToLvl }, new bool[] { true }, NeverEndingNightmare, 0);
        public static readonly Move NonGhostCurse = new Move("Curse", Ghost, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { SpdDwn1, AtkUp1, DefUp1 }, new bool[] { true, true, true }, ZNonGhostCurse, 0);
        public static readonly Move OminousWind = new Move("Ominous Wind", Ghost, 60, 1, 5, 'M', new double[] { 0.1, 0.1, 0.1, 0.1, 0.1 }, new Effect[] { AtkUp1, DefUp1, SpAtkUp1, SpDefUp1, SpdUp1 }, new bool[] { true, true, true, true, true }, new ZMove(NeverEndingNightmare, 120), 0);
        public static readonly Move PhantomForce = new Move("Phantom Force", Ghost, 90, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { Wait.OneTurn, Ignore.Protection }, new bool[] { true, true }, new ZMove(NeverEndingNightmare, 175), 0);
        public static readonly Move ShadowBall = new Move("Shadow Ball", Ghost, 80, 1, 15, 'M', new double[] { 0.2 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, new ZMove(NeverEndingNightmare, 160), 0);
        public static readonly Move ShadowBone = new Move("Shadow Bone", Ghost, 85, 1, 10, 'P', new double[] { 0.2 }, new Effect[] { DefDwn1 }, new bool[] { false }, new ZMove(NeverEndingNightmare, 160), 0);
        public static readonly Move ShadowClaw = new Move("Shadow Claw", Ghost, 70, 1, 15, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(NeverEndingNightmare, 140), 0);
        public static readonly Move ShadowForce = new Move("Shadow Force", Ghost, 120, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { Wait.OneTurn, Ignore.Protection }, new bool[] { true, true }, new ZMove(NeverEndingNightmare, 190), 0);
        public static readonly Move ShadowPunch = new Move("Shadow Punch", Ghost, 60, -1, 20, 'P', null, null, null, new ZMove(NeverEndingNightmare, 120), 0);
        public static readonly Move ShadowSneak = new Move("Shadow Sneak", Ghost, 40, 1, 30, 'P', null, null, null, NeverEndingNightmare, 1);
        public static readonly Move SpectralThief = new Move("Spectral Thief", Ghost, 90, 1, 10, 'P', new double[] { 1 }, new Effect[] { TransferStatBoosts }, new bool[] { false }, new ZMove(NeverEndingNightmare, 175), 0);
        public static readonly Move SpiritShackle = new Move("Spirit Shackle", Ghost, 80, 1, 10, 'P', new double[] { 1 }, new Effect[] { LegHold }, new bool[] { false }, new ZMove(NeverEndingNightmare, 160), 0);
        public static readonly Move Spite = new Move("Spite", Ghost, 0, 1, 10, 'S', new double[] { 1 }, new Effect[] { ReduceLastMoveBy4PP }, new bool[] { false }, ZSpite, 0);
        public static readonly Move TrickOrTreat = new Move("Trick-or-Treat", Ghost, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { AddTypeToTarget.Ghost }, new bool[] { false }, ZTrickOrTreat, 0);
        #endregion

        #region Dark
        public static readonly Move Assurance = new Move("Assurance", Dark, 60, 1, 10, 'P', new double[] { 1 }, new Effect[] { ifTakenDmgThisTurn, DoublePower }, new bool[] { false, true }, new ZMove(BlackHoleEclipse, 120), 0);
        public static readonly Move BeatUp = new Move("Beat Up", Dark, -1, 1, 30, 'P', new double[] { 1 }, new Effect[] { BeatUpEffect }, new bool[] { false }, BlackHoleEclipse, 0);
        public static readonly Move Bite = new Move("Bite", Dark, 60, 1, 25, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(BlackHoleEclipse, 120), 0);
        public static readonly Move BrutalSwing = new Move("Brutal Swing", Dark, 60, 1, 20, 'P', null, null, null, new ZMove(BlackHoleEclipse, 120), 0);
        public static readonly Move Crunch = new Move("Crunch", Dark, 80, 1, 15, 'P', new double[] { 0.2 }, new Effect[] { DefDwn1 }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
        public static readonly Move DarkPulse = new Move("Dark Pulse", Dark, 80, 1, 15, 'M', new double[] { 0.2 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
        public static readonly Move DarkVoid = new Move("Dark Void", Dark, 0, 0.5, 10, 'S', new double[] { 1, 1 }, new Effect[] { HitAllFoes, Sleep }, new bool[] { false, false }, ZDarkVoid, 0);
        public static readonly Move DarkestLariat = new Move("Darkest Lariat", Dark, 85, 1, 10, 'P', new double[] { 1 }, new Effect[] { IgnoreStatChanges }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
        public static readonly Move Embargo = new Move("Embargo", Dark, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { EmbargoStatus }, new bool[] { false }, ZEmbargo, 0);
        public static readonly Move FakeTears = new Move("Fake Tears", Dark, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { SpDefDwn2 }, new bool[] { false }, ZFakeTears, 0);
        public static readonly Move FeintAttack = new Move("Feint Attack", Dark, 60, -1, 20, 'P', null, null, null, new ZMove(BlackHoleEclipse, 120), 0);
        public static readonly Move Flatter = new Move("Flatter", Dark, 0, 1, 15, 'S', new double[] { 1, 1 }, new Effect[] { Confused, SpAtkUp2 }, new bool[] { false, false }, ZFlatter, 0);
        public static readonly Move Fling = new Move("Fling", Dark, -1, 1, 10, 'P', new double[] { 1 }, new Effect[] { FlingEffect }, new bool[] { true }, BlackHoleEclipse, 0);
        public static readonly Move FoulPlay = new Move("Foul Play", Dark, 95, 1, 15, 'P', new double[] { 1 }, new Effect[] { UseTgtAtk }, new bool[] { false }, new ZMove(BlackHoleEclipse, 175), 0);
        public static readonly Move HoneClaws = new Move("Hone Claws", Dark, 0, -1, 15, 'S', new double[] { 1, 1 }, new Effect[] { AtkUp1, AccUp1 }, new bool[] { true, true }, ZHoneClaws, 0);
        public static readonly Move HyperspaceFury = new Move("Hyperspace Fury", Dark, 100, -1, 5, 'P', new double[] { 1 }, new Effect[] { DefDwn1 }, new bool[] { true }, new ZMove(BlackHoleEclipse, 180), 0);
        public static readonly Move KnockOff = new Move("Knock Off", Dark, 65, 1, 20, 'P', new double[] { 1 }, new Effect[] { KnockOffEffect }, new bool[] { false }, new ZMove(BlackHoleEclipse, 120), 0);
        public static readonly Move Memento = new Move("Memento", Dark, 0, 1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { SelfDestruction, AtkDwn2, SpAtkDwn2 }, new bool[] { true, false, false }, ZMemento, 0);
        public static readonly Move NastyPlot = new Move("Nasty Plot", Dark, 0, -1, 20, 'S', new double[] { 1 }, new Effect[] { SpAtkUp2 }, new bool[] { true }, ZNastyPlot, 0);
        public static readonly Move NightDaze = new Move("Night Daze", Dark, 85, 0.95, 10, 'M', new double[] { 0.4 }, new Effect[] { AccDwn1 }, new bool[] { true }, new ZMove(BlackHoleEclipse, 160), 0);
        public static readonly Move NightSlash = new Move("Night Slash", Dark, 70, 1, 15, 'P', new double[] { 1 }, new Effect[] { HighCrit }, new bool[] { true }, new ZMove(BlackHoleEclipse, 140), 0);
        public static readonly Move PartingShot = new Move("Parting Shot", Dark, 0, 1, 20, 'S', new double[] { 1, 1, 1 }, new Effect[] { AtkDwn1, SpAtkDwn1, Switchout }, new bool[] { false, false, true }, ZPartingShot, 0);
        public static readonly Move Payback = new Move("Payback", Dark, 50, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { isHitBeforeNextMove, DoublePower }, new bool[] { true, true }, BlackHoleEclipse, 0);
        public static readonly Move PowerTrip = new Move("Power Trip", Dark, 20, 1, 10, 'P', new double[] { 1 }, new Effect[] { PowerTripEffect }, new bool[] { true }, new ZMove(BlackHoleEclipse, 160), 0);
        public static readonly Move Punishment = new Move("Punishment", Dark, -1, 1, 5, 'P', new double[] { 1 }, new Effect[] { PunishmentEffect }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
        public static readonly Move Pursuit = new Move("Pursuit", Dark, 40, 1, 20, 'P', new double[] { 1 }, new Effect[] { PursuitEffect }, new bool[] { false }, BlackHoleEclipse, 0);
        public static readonly Move Quash = new Move("Quash", Dark, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { TgtMvLastThisTurn }, new bool[] { false }, ZQuash, 0);
        public static readonly Move Snarl = new Move("Snarl", Dark, 55, 0.95, 15, 'M', new double[] { 1 }, new Effect[] { SpAtkDwn1 }, new bool[] { false }, BlackHoleEclipse, 0);
        public static readonly Move Snatch = new Move("Snatch", Dark, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { CopyNextMove }, new bool[] { false }, ZSnatch, 4);
        public static readonly Move SuckerPunch = new Move("Sucker Punch", Dark, 70, 1, 5, 'P', new double[] { 1, 1 }, new Effect[] { DealsNoDmg, tgtReadyingAttack, DealsDmg }, new bool[] { true, false, true }, new ZMove(BlackHoleEclipse, 140), 1);
        public static readonly Move Switcheroo = new Move("Switcheroo", Dark, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { Swap.Item }, new bool[] { false }, ZSwitcheroo, 0);
        public static readonly Move Taunt = new Move("Taunt", Dark, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { TauntStatus }, new bool[] { false }, ZTaunt, 0);
        public static readonly Move Thief = new Move("Thief", Dark, 40, 1, 10, 'P', new double[] { 1 }, new Effect[] { TransferItem }, new bool[] { false }, new ZMove(BlackHoleEclipse, 120), 0);
        public static readonly Move ThroatChop = new Move("Throat Chop", Dark, 80, 1, 15, 'P', new double[] { 1 }, new Effect[] { ThroatChopEffect }, new bool[] { false }, new ZMove(BlackHoleEclipse, 160), 0);
        public static readonly Move TopsyTurvy = new Move("Topsy-Turvy", Dark, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { ReverseStatChanges }, new bool[] { false }, ZTopsyTurvy, 0);
        public static readonly Move Torment = new Move("Torment", Dark, 0, 1, 15, 'S', new double[] { 1 }, new Effect[] { TormentStatus }, new bool[] { false }, ZTorment, 0);
        #endregion

        #region Steel
        public static readonly Move AnchorShot = new Move("Anchor Shot", Steel, 80, 1, 20, 'P', new double[] { 1 }, new Effect[] { LegHold }, new bool[] { false }, new ZMove(CorkscrewCrash, 160), 0);
        public static readonly Move Autotomize = new Move("Autotomize", Steel, 0, -1, 15, 'S', new double[] { 1, 1 }, new Effect[] { HalveWeight, SpdUp2 }, new bool[] { true, true }, ZAutotomize, 0);
        public static readonly Move BulletPunch = new Move("Bullet Punch", Steel, 40, 1, 30, 'P', null, null, null, CorkscrewCrash, 1);
        public static readonly Move DoomDesire = new Move("Doom Desire", Steel, 140, 1, 5, 'M', new double[] { 1, 1 }, new Effect[] { Wait.TwoTurns, DealsDmg }, new bool[] { true, true }, new ZMove(CorkscrewCrash, 200), 0);
        public static readonly Move FlashCannon = new Move("Flash Cannon", Steel, 80, 1, 10, 'M', new double[] { 0.1 }, new Effect[] { SpDefDwn1 }, new bool[] { false }, new ZMove(CorkscrewCrash, 160), 0);
        public static readonly Move GearGrind = new Move("Gear Grind", Steel, 50, 0.85, 15, 'P', new double[] { 1 }, new Effect[] { HitTwiceOneTurn }, new bool[] { false }, new ZMove(CorkscrewCrash, 180), 0);
        public static readonly Move GearUp = new Move("Gear Up", Steel, 0, -1, 20, 'S', new double[] { 1, 1, 1, 1 }, new Effect[] { HitAllAllies, hasPlusMinus, AtkUp1, SpAtkUp1 }, new bool[] { true, false, false, false }, ZGearUp, 0);
        public static readonly Move GyroBall = new Move("Gyro Ball", Steel, -1, 1, 5, 'P', new double[] { 1 }, new Effect[] { GyroBallEffect }, new bool[] { false }, new ZMove(CorkscrewCrash, 160), 0);
        public static readonly Move HeavySlam = new Move("Heavy Slam", Steel, -1, 1, 10, 'P', new double[] { 1 }, new Effect[] { HeavierMoreDmg }, new bool[] { false }, new ZMove(CorkscrewCrash, 160), 0);
        public static readonly Move IronDefense = new Move("Iron Defense", Steel, -1, -1, 15, 'S', new double[] { 1 }, new Effect[] { DefUp2 }, new bool[] { true }, ZIronDefense, 0);
        public static readonly Move IronHead = new Move("Iron Head", Steel, 80, 1, 15, 'P', new double[] { 0.3 }, new Effect[] { Flinch }, new bool[] { false }, new ZMove(CorkscrewCrash, 160), 0);
        public static readonly Move IronTail = new Move("Iron Tail", Steel, 100, 75, 15, 'P', new double[] { 0.3 }, new[] { DefDwn1 }, new bool[] { false }, new ZMove(CorkscrewCrash, 180), 0);
        public static readonly Move KingsShield = new Move("King's Shield", Steel, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { KingsShieldEffect, isHitByPhysMv, AtkDwn2 }, new bool[] { true, true, false }, ZKingsShield, 4);
        public static readonly Move MagnetBomb = new Move("Magnet Bomb", Steel, 60, -1, 20, 'P', null, null, null, new ZMove(CorkscrewCrash, 120), 0);
        public static readonly Move MetalBurst = new Move("Metal Burst", Steel, -1, 1, 10, 'P', new double[] { 1, 1 }, new Effect[] { MetalBurstEffect }, new bool[] { true }, CorkscrewCrash, 0);
        public static readonly Move MetalClaw = new Move("Metal Claw", Steel, 50, 0.95, 35, 'P', new double[] { 0.1 }, new Effect[] { AtkUp1 }, new bool[] { true }, CorkscrewCrash, 0);
        public static readonly Move MetalSound = new Move("Metal Sound", Steel, 0, 0.85, 40, 'S', new double[] { 1 }, new Effect[] { SpDefDwn2 }, new bool[] { false }, ZMetalSound, 0);
        public static readonly Move MeteorMash = new Move("Meteor Mash", Steel, 90, 0.9, 10, 'P', new double[] { 0.2 }, new Effect[] { AtkDwn1 }, new bool[] { false }, new ZMove(CorkscrewCrash, 175), 0);
        public static readonly Move MirrorShot = new Move("Mirror Shot", Steel, 65, 0.85, 10, 'M', new double[] { 0.3 }, new Effect[] { AccDwn1 }, new bool[] { false }, new ZMove(CorkscrewCrash, 120), 0);
        public static readonly Move ShiftGear = new Move("Shift Gear", Steel, 0, -1, 10, 'S', new double[] { 1, 1 }, new Effect[] { AtkUp1, SpdUp2 }, new bool[] { true, true }, ZShiftGear, 0);
        public static readonly Move SmartStrike = new Move("Smart Strike", Steel, 70, -1, 10, 'P', null, null, null, new ZMove(CorkscrewCrash, 140), 0);
        public static readonly Move SteelWing = new Move("Steel Wing", Steel, 70, 0.9, 25, 'P', new double[] { 0.1 }, new Effect[] { DefDwn1 }, new bool[] { false }, new ZMove(CorkscrewCrash, 140), 0);
        public static readonly Move SunsteelStrike = new Move("Sunsteel Strike", Steel, 100, 1, 5, 'P', new double[] { 1 }, new Effect[] { Ignore.Ability }, new bool[] { false }, new ZMove(CorkscrewCrash, 180), 0);
        #endregion

        #region Fairy
        public static readonly Move AromaticMist = new Move("Aromatic Mist", Fairy, 0, -1, 20, 'S', new double[] { 1, 1 }, new Effect[] { HitAllAllies, SpDefUp1 }, new bool[] { false, false }, ZAromaticMist, 0);
        public static readonly Move BabyDollEyes = new Move("Baby-Doll Eyes", Fairy, 0, 1, 30, 'S', new double[] { 1 }, new Effect[] { AtkDwn1 }, new bool[] { false }, ZBabyDollEyes, 1);
        public static readonly Move Charm = new Move("Charm", Fairy, 0, 1, 20, 'S', new double[] { 1 }, new Effect[] { AtkDwn2 }, new bool[] { false }, ZCharm, 0);
        public static readonly Move CraftyShield = new Move("Crafty Shield", Fairy, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { CraftyShieldEffect }, new bool[] { true }, ZCraftyShield, 3);
        public static readonly Move DazzlingGleam = new Move("Dazzling Gleam", Fairy, 80, 1, 10, 'M', new double[] { 1 }, new Effect[] { HitAllFoes }, new bool[] { false }, new ZMove(TwinkleTackle, 160), 0);
        public static readonly Move DisarmingVoice = new Move("Disarming Voice", Fairy, 40, -1, 15, 'M', null, null, null, TwinkleTackle, 0);
        public static readonly Move DrainingKiss = new Move("Draining Kiss", Fairy, 50, 1, 10, 'M', new double[] { 1 }, new Effect[] { ThreeQuarterDmgInflicted }, new bool[] { true }, TwinkleTackle, 0);
        public static readonly Move FairyLock = new Move("Fairy Lock", Fairy, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { FairyLockEffect }, new bool[] { false }, ZFairyLock, 0);
        public static readonly Move FairyWind = new Move("Fairy Wind", Fairy, 40, 1, 30, 'M', null, null, null, TwinkleTackle, 0);
        public static readonly Move FleurCannon = new Move("Fleur Cannon", Fairy, 130, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { SpAtkDwn2 }, new bool[] { true }, new ZMove(TwinkleTackle, 195), 0);
        public static readonly Move FloralHealing = new Move("Floral Healing", Fairy, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { FloralHealingEffect }, new bool[] { false }, ZFloralHealing, 0);
        public static readonly Move FlowerShield = new Move("Flower Shield", Fairy, 0, -1, 10, 'S', new double[] { 1, 1, 1 }, new Effect[] { HitAllAdjacent, ifGrassType, DefUp1 }, new bool[] { false, false, false }, ZFlowerShield, 0);
        public static readonly Move Geomancy = new Move("Geomancy", Fairy, 0, -1, 10, 'S', new double[] { 1, 1, 1, 1 }, new Effect[] { Charge1Turn, SpAtkUp2, SpDefUp2, SpdUp2 }, new bool[] { true, true, true, true }, ZGeomancy, 0);
        public static readonly Move LightOfRuin = new Move("Light of Ruin", Fairy, 140, 0.9, 5, 'M', new double[] { 1 }, new Effect[] { Recoil.HalfDmgDealt }, new bool[] { true }, new ZMove(TwinkleTackle, 200), 0);
        public static readonly Move MistyTerrain = new Move("Misty Terrain", Fairy, 0, -1, 10, 'S', new double[] { 1 }, new Effect[] { FairyTerrainEffect }, new bool[] { false }, ZMistyTerrain, 0);
        public static readonly Move Moonblast = new Move("Moonblast", Fairy, 95, 1, 15, 'M', new double[] { 0.3 }, new Effect[] { SpAtkDwn1 }, new bool[] { false }, new ZMove(TwinkleTackle, 175), 0);
        public static readonly Move Moonlight = new Move("Moonlight", Fairy, 0, -1, 5, 'S', new double[] { 1 }, new Effect[] { WeatherBasedHPRestore }, new bool[] { true }, ZMoonlight, 0);
        public static readonly Move NaturesMadness = new Move("Nature's Madness", Fairy, 0, 0.9, 10, 'M', new double[] { 1 }, new Effect[] { DoesHalfTargetHPDmg }, new bool[] { false }, TwinkleTackle, 0);
        public static readonly Move PlayRough = new Move("Play Rough", Fairy, 90, 0.9, 10, 'P', new double[] { 0.1 }, new Effect[] { AtkDwn1 }, new bool[] { false }, new ZMove(TwinkleTackle, 175), 0);
        public static readonly Move StoredPower = new Move("Stored Power", Fairy, 20, 1, 10, 'M', new double[] { 1 }, new Effect[] { StoredPwr }, new bool[] { true }, new ZMove(TwinkleTackle, 160), 0);
        public static readonly Move SweetKiss = new Move("Sweet Kiss", Fairy, 0, 0.75, 10, 'S', new double[] { 1 }, new Effect[] { Confused }, new bool[] { false }, ZSweetKiss, 0);
        #endregion
        #endregion

        #region Weather
        public static readonly Effect ClearSkies = new Effect("Clear Skies", "Absence of weather.");
        public static readonly Effect ExHarshSunlight = new Effect("Extremely Harsh Sunlight", "Sunlight shines heavily on the battlefield.");
        public static readonly Effect HailWeather = new Effect("Hail", "Pelting hail falls on the battlefield");
        public static readonly Effect HarshSunlight = new Effect("Harsh Sunlight", "Strong sunlight shines on the battlefield.");
        public static readonly Effect HeavyRain = new Effect("Heavy Rain", "Rain falls chaotically on the battlefield.");
        public static readonly Effect OddCurrent = new Effect("Mysterious Air Current", "A strong air current blows across the battlefield.");
        public static readonly Effect Rain = new Effect("Rain", "Rain falls on the battlefield.");
        public static readonly Effect SandstormWeather = new Effect("Sandstorm", "Stinging sand whips across the battlefield.");
        #endregion

        #region Stats
        public static Stat Accuracy = new Stat("Accuracy", "Accuracy");
        public static Stat Atk = new Stat("Attack", "Atk");
        public static Stat Crit = new Stat("Critical Ratio", "Crit");
        public static Stat Def = new Stat("Defense", "Def");
        public static Stat Evasion = new Stat("Evasion", "Evasion");
        public static Stat Happiness = new Stat("Happiness", "Happiness");
        public static Stat HP = new Stat("HP", "HP");
        public static Stat SpAtk = new Stat("Special Attack", "Sp. Atk");
        public static Stat Spd = new Stat("Speed", "Spd");
        public static Stat SpDef = new Stat("Special Defense", "Sp. Def");
        public static Stat Weight = new Stat("Weight", "Wgt");
        #endregion

        #region Pkmn
        #region Kanto
        public static readonly Pokemon Bulbasaur = new Pokemon(1, Chlorophyll.name, Grass, Poison, new Ability[] { Overgrow, Chlorophyll }, new double[] { 45, 49, 49, 65, 65, 45, 15.2 }, new Move[] { Tackle, Growl, VineWhip, PoisonPowder, SleepPowder, TakeDown, RazorLeaf, SweetScent, Growth, DoubleEdge, WorrySeed, Synthesis, SeedBomb, Amnesia, Charm, NonGhostCurse, Endure, GigaDrain, GrassWhistle, GrassyTerrain, Ingrain, LeafStorm, MagicalLeaf, NaturePower, PetalDance, PowerWhip, SkullBash, Sludge, FrenzyPlant, WorkUp, Toxic, Venoshock, HiddenPower, SunnyDay, LightScreen, Protect, Safeguard, Frustration, SolarBeam, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Round, EchoedVoice, EnergyBall, SwordsDance, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, Confide });
        public static readonly Pokemon Ivysaur = new Pokemon(2, "Ivysaur", Grass, Poison, new Ability[] { Overgrow, Chlorophyll }, new double[] { 60, 62, 63, 80, 80, 60, 28.7 }, new Move[] { Growl, Tackle, LeechSeed, VineWhip, PoisonPowder, SleepPowder, TakeDown, RazorLeaf, SweetScent, Growth, DoubleEdge, WorrySeed, Synthesis, SolarBeam, Amnesia, Charm, NonGhostCurse, Endure, GigaDrain, GrassWhistle, GrassyTerrain, Ingrain, LeafStorm, MagicalLeaf, NaturePower, PetalDance, PowerWhip, SkullBash, Sludge, FrenzyPlant, WorkUp, Toxic, Venoshock, HiddenPower, SunnyDay, LightScreen, Protect, Safeguard, Frustration, SolarBeam, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Round, EchoedVoice, EnergyBall, SwordsDance, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, Confide });
        public static readonly Pokemon Venusaur = new Pokemon(3, "Venusaur", Grass, Poison, new Ability[] { Overgrow, Chlorophyll }, new double[] { 80, 82, 83, 100, 100, 80, 220.5 }, new Move[] { Growl, PetalDance, Tackle, VineWhip, LeechSeed, PoisonPowder, SleepPowder, TakeDown, RazorLeaf, SweetScent, Growth, DoubleEdge, WorrySeed, Synthesis, PetalBlizzard, SolarBeam, PetalDance, Amnesia, Charm, NonGhostCurse, Endure, GigaDrain, GrassWhistle, GrassyTerrain, Ingrain, LeafStorm, MagicalLeaf, NaturePower, PowerWhip, SkullBash, Sludge, FrenzyPlant, GrassPledge, WorkUp, Roar, Toxic, Venoshock, HiddenPower, SunnyDay, HyperBeam, LightScreen, Protect, Safeguard, Frustration, SolarBeam, Earthquake, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Round, EchoedVoice, EnergyBall, GigaImpact, SwordsDance, Bulldoze, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, Confide });
        public static readonly Pokemon MegaVenusaur = new Pokemon(-3, "Mega Venusaur", Grass, Poison, new Ability[] { ThickFat }, new double[] { 80, 100, 123, 122, 120, 80, 342.8 }, new Move[] { Growl, PetalDance, Tackle, VineWhip, LeechSeed, PoisonPowder, SleepPowder, TakeDown, RazorLeaf, SweetScent, Growth, DoubleEdge, WorrySeed, Synthesis, PetalBlizzard, SolarBeam, PetalDance, Amnesia, Charm, NonGhostCurse, Endure, GigaDrain, GrassWhistle, GrassyTerrain, Ingrain, LeafStorm, MagicalLeaf, NaturePower, PowerWhip, SkullBash, Sludge, FrenzyPlant, GrassPledge, WorkUp, Roar, Toxic, Venoshock, HiddenPower, SunnyDay, HyperBeam, LightScreen, Protect, Safeguard, Frustration, SolarBeam, Earthquake, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Round, EchoedVoice, EnergyBall, GigaImpact, SwordsDance, Bulldoze, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, Confide });
        public static readonly Pokemon Charmander = new Pokemon(4, "Charmander", Fire, Typeless, new Ability[] { Blaze, SolarPower }, new double[] { 39, 52, 43, 60, 50, 65, 18.7 }, new Move[] { Growl, Scratch, Ember, Smokescreen, DragonRage, ScaryFace, FireFang, FireBlast, Slash, Flamethrower, FireSpin, Inferno, AirCutter, AncientPower, BeatUp, BellyDrum, Bite, Counter, Crunch, DragonDance, DragonPulse, DragonRush, FlareBlitz, FocusPunch, MetalClaw, Outrage, WorkUp, DragonClaw, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, BrickBreak, DoubleTeam, BlastBurn, FireBlast, RockTomb, AerialAce, Facade, FlameCharge, Rest, Attract, Round, EchoedVoice, Overheat, Fling, WillOWisp, ShadowClaw, SwordsDance, RockSlide, Swagger, SleepTalk, Substitute, Confide });
        public static readonly Pokemon Charmeleon = new Pokemon(5, "Charmeleon", Fire, Typeless, new Ability[] { Blaze, SolarPower }, new double[] { 58, 64, 58, 80, 65, 80, 41.9 }, new Move[] { Scratch, Growl, Ember, Smokescreen, DragonRage, ScaryFace, FireFang, FlameBurst, Slash, Flamethrower, FireSpin, Inferno, WorkUp, DragonClaw, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, BrickBreak, DoubleEdge, FireBlast, RockTomb, AerialAce, Facade, FlameCharge, Rest, Attract, Round, EchoedVoice, Overheat, Fling, WillOWisp, ShadowClaw, SwordsDance, RockSlide, Swagger, SleepTalk, Substitute, Confide, AirCutter, AncientPower, BeatUp, BellyDrum, Bite, Counter, Crunch, DragonDance, DragonPulse, DragonRush, FlareBlitz, FocusPunch, MetalClaw, Outrage });
        public static readonly Pokemon Charizard = new Pokemon(6, "Charizard", Fire, Flying, new Ability[] { Blaze, SolarPower }, new double[] { 78, 84, 78, 109, 85, 100, 199.5 }, new Move[] { WingAttack, FlareBlitz, HeatWave, DragonClaw, ShadowClaw, AirSlash, Scratch, Growl, Ember, Smokescreen, DragonRage, ScaryFace, FireFang, Slash, Flamethrower, FireSpin, Inferno, HeatWave, FlareBlitz, WorkUp, DragonClaw, Roar, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, Roost, Frustration, SolarBeam, Earthquake, Return, BrickBreak, DoubleTeam, FireBlast, RockTomb, AerialAce, Facade, FlameCharge, Rest, Attract, Round, EchoedVoice, Overheat, SteelWing, FocusBlast, Fling, SkyDrop, BrutalSwing, WillOWisp, ShadowClaw, GigaImpact, SwordsDance, Fly, Bulldoze, RockSlide, DragonTail, Swagger, SleepTalk, Substitute, Confide, AirCutter, AncientPower, BeatUp, BellyDrum, Bite, Counter, Crunch, DragonDance, DragonPulse, DragonRush, FlareBlitz, FocusPunch, MetalClaw, BlastBurn, FirePledge, SeismicToss });
        public static readonly Pokemon MegaCharizardX = new Pokemon(-6, "Mega Charizard X", Fire, Dragon, new Ability[] { ToughClaws }, new double[] { 78, 130, 111, 130, 85, 100, 243.6 }, new Move[] { WingAttack, FlareBlitz, HeatWave, DragonClaw, ShadowClaw, AirSlash, Scratch, Growl, Ember, Smokescreen, DragonRage, ScaryFace, FireFang, Slash, Flamethrower, FireSpin, Inferno, HeatWave, FlareBlitz, WorkUp, DragonClaw, Roar, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, Roost, Frustration, SolarBeam, Earthquake, Return, BrickBreak, DoubleTeam, FireBlast, RockTomb, AerialAce, Facade, FlameCharge, Rest, Attract, Round, EchoedVoice, Overheat, SteelWing, FocusBlast, Fling, SkyDrop, BrutalSwing, WillOWisp, ShadowClaw, GigaImpact, SwordsDance, Fly, Bulldoze, RockSlide, DragonTail, Swagger, SleepTalk, Substitute, Confide, AirCutter, AncientPower, BeatUp, BellyDrum, Bite, Counter, Crunch, DragonDance, DragonPulse, DragonRush, FlareBlitz, FocusPunch, MetalClaw, BlastBurn, FirePledge, SeismicToss });
        public static readonly Pokemon MegaCharizardY = new Pokemon(-6.1, "Mega Charizard Y", Fire, Flying, new Ability[] { Drought }, new double[] { 78, 104, 78, 159, 115, 100, 221.6 }, new Move[] { WingAttack, FlareBlitz, HeatWave, DragonClaw, ShadowClaw, AirSlash, Scratch, Growl, Ember, Smokescreen, DragonRage, ScaryFace, FireFang, Slash, Flamethrower, FireSpin, Inferno, HeatWave, FlareBlitz, WorkUp, DragonClaw, Roar, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, Roost, Frustration, SolarBeam, Earthquake, Return, BrickBreak, DoubleTeam, FireBlast, RockTomb, AerialAce, Facade, FlameCharge, Rest, Attract, Round, EchoedVoice, Overheat, SteelWing, FocusBlast, Fling, SkyDrop, BrutalSwing, WillOWisp, ShadowClaw, GigaImpact, SwordsDance, Fly, Bulldoze, RockSlide, DragonTail, Swagger, SleepTalk, Substitute, Confide, AirCutter, AncientPower, BeatUp, BellyDrum, Bite, Counter, Crunch, DragonDance, DragonPulse, DragonRush, FlareBlitz, FocusPunch, MetalClaw, BlastBurn, FirePledge, SeismicToss });
        public static readonly Pokemon Squirtle = new Pokemon(7, "Squirtle", Water, Typeless, new Ability[] { Torrent, RainDish }, new double[] { 44, 48, 65, 50, 64, 43, 19.8 }, new Move[] { Tackle, TailWhip, WaterGun, Withdraw, Bubble, Bite, RapidSpin, Protect, WaterPulse, AquaTail, SkullBash, IronDefense, RainDance, HydroPump, WorkUp, Toxic, Hail, HiddenPower, IceBeam, Blizzard, Protect, RainDance, Frustration, Return, BrickBreak, DoubleTeam, RockTomb, Facade, Rest, Attract, Round, Scald, Fling, GyroBall, Swagger, SleepTalk, Substitute, Surf, Waterfall, Confide, AquaJet, AquaRing, AuraSphere, Brine, DragonPulse, FakeOut, Flail, Foresight, Haze, MirrorCoat, Mist, MudSport, MuddyWater, Refresh, WaterSpout, Yawn, WaterPledge });
        public static readonly Pokemon Wartortle = new Pokemon(8, "Wartortle", Water, Typeless, new Ability[] { Torrent, RainDish }, new double[] { 59, 63, 80, 65, 80, 58, 49.6 }, new Move[] { Tackle, TailWhip, WaterGun, Withdraw, Bubble, Bite, RapidSpin, Protect, WaterPulse, AquaTail, SkullBash, IronDefense, RainDance, HydroPump, WorkUp, Toxic, Hail, HiddenPower, IceBeam, Blizzard, Protect, RainDance, Frustration, Return, BrickBreak, DoubleTeam, RockTomb, Facade, Rest, Attract, Round, Scald, Fling, GyroBall, Swagger, SleepTalk, Substitute, Surf, Waterfall, Confide, AquaJet, AquaRing, AuraSphere, Brine, DragonPulse, FakeOut, Flail, Foresight, Haze, MirrorCoat, Mist, MudSport, MuddyWater, Refresh, WaterSpout, Yawn, WaterPledge });
        public static readonly Pokemon Blastoise = new Pokemon(9, "Blastoise", Water, Typeless, new Ability[] { Torrent, RainDish }, new double[] { 79, 83, 100, 85, 105, 78, 188.5 }, new Move[] { FlashCannon, Tackle, TailWhip, WaterGun, Withdraw, Bubble, Bite, RapidSpin, Protect, WaterPulse, AquaTail, SkullBash, IronDefense, RainDance, HydroPump, WorkUp, Roar, Toxic, Hail, HiddenPower, IceBeam, Blizzard, HyperBeam, Protect, RainDance, Frustration, SmackDown, Earthquake, Return, BrickBreak, DoubleTeam, RockTomb, Facade, Rest, Attract, Round, FocusBlast, Scald, Fling, GigaImpact, GyroBall, Bulldoze, RockSlide, DragonTail, Swagger, SleepTalk, Substitute, Surf, DarkPulse, Waterfall, Confide, AquaJet, AquaRing, AuraSphere, Brine, DragonPulse, FakeOut, Flail, Foresight, Haze, MirrorCoat, Mist, MudSport, MuddyWater, Refresh, WaterSpout, Yawn, HydroCannon, WaterPledge });
        public static readonly Pokemon MegaBlastoise = new Pokemon(-9, "Mega Blastoise", Water, Typeless, new Ability[] { MegaLauncher }, new double[] { 79, 103, 120, 135, 115, 78, 222.9 }, new Move[] { FlashCannon, Tackle, TailWhip, WaterGun, Withdraw, Bubble, Bite, RapidSpin, Protect, WaterPulse, AquaTail, SkullBash, IronDefense, RainDance, HydroPump, WorkUp, Roar, Toxic, Hail, HiddenPower, IceBeam, Blizzard, HyperBeam, Protect, RainDance, Frustration, SmackDown, Earthquake, Return, BrickBreak, DoubleTeam, RockTomb, Facade, Rest, Attract, Round, FocusBlast, Scald, Fling, GigaImpact, GyroBall, Bulldoze, RockSlide, DragonTail, Swagger, SleepTalk, Substitute, Surf, DarkPulse, Waterfall, Confide, AquaJet, AquaRing, AuraSphere, Brine, DragonPulse, FakeOut, Flail, Foresight, Haze, MirrorCoat, Mist, MudSport, MuddyWater, Refresh, WaterSpout, Yawn, HydroCannon, WaterPledge });
        public static readonly Pokemon Caterpie = new Pokemon(10, "Caterpie", Bug, Typeless, new Ability[] { ShieldDust, RunAway }, new double[] { 45, 30, 35, 20, 20, 45, 6.4 }, new Move[] { Tackle, StringShot, BugBite });
        public static readonly Pokemon Metapod = new Pokemon(11, "Metapod", Bug, Typeless, new Ability[] { ShedSkin }, new double[] { 50, 20, 55, 25, 25, 30, 21.8 }, new Move[] { Tackle, StringShot, BugBite, Harden });
        public static readonly Pokemon Butterfree = new Pokemon(12, "Butterfree", Bug, Flying, new Ability[] { CompoundEyes, TintedLens }, new double[] { 60, 45, 50, 90, 80, 70, 70.5 }, new Move[] { Gust, Confusion, PoisonPowder, StunSpore, SleepPowder, Psybeam, SilverWind, Supersonic, Safeguard, Whirlwind, BugBuzz, RagePowder, Captivate, Tailwind, AirSlash, QuiverDance, Toxic, Venoshock, HiddenPower, SunnyDay, HyperBeam, Protect, RainDance, Roost, Safeguard, Frustration, SolarBeam, Return, psychic, ShadowBall, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, EnergyBall, Acrobatics, GigaImpact, PsychUp, Infestation, DreamEater, Swagger, SleepTalk, UTurn, Substitute, Confide, Tackle, StringShot, BugBite, Harden });
        public static readonly Pokemon Weedle = new Pokemon(13, "Weedle", Bug, Poison, new Ability[] { ShieldDust, RunAway }, new double[] { 40, 35, 30, 20, 20, 50, 7.1 }, new Move[] { PoisonSting, StringShot, BugBite });
        public static readonly Pokemon Kakuna = new Pokemon(14, "Kakuna", Bug, Poison, new Ability[] { ShedSkin }, new double[] { 45, 25, 50, 25, 25, 35, 22.0 }, new Move[] { PoisonSting, StringShot, BugBite, Harden });
        public static readonly Pokemon Beedrill = new Pokemon(15, "Beedrill", Bug, Poison, new Ability[] { Swarm, Sniper }, new double[] { 65, 90, 40, 45, 80, 75, 65.0 }, new Move[] { Twineedle, FuryAttack, Rage, Pursuit, FocusEnergy, Venoshock, Assurance, ToxicSpikes, PinMissile, PoisonJab, Agility, Endeavor, FellStinger, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, Roost, Frustration, SolarBeam, Return, BrickBreak, DoubleTeam, SludgeBomb, AerialAce, Facade, Rest, Attract, Thief, Round, FalseSwipe, BrutalSwing, Acrobatics, Payback, GigaImpact, SwordsDance, XScissor, Infestation, PoisonJab, Swagger, SleepTalk, UTurn, Substitute, Confide, PoisonSting, StringShot, BugBite, Harden });
        public static readonly Pokemon MegaBeedrill = new Pokemon(-15, "Mega Beedrill", Bug, Poison, new Ability[] { Adaptabililty }, new double[] { 65, 150, 40, 15, 80, 145, 89.3 }, new Move[] { Twineedle, FuryAttack, Rage, Pursuit, FocusEnergy, Venoshock, Assurance, ToxicSpikes, PinMissile, PoisonJab, Agility, Endeavor, FellStinger, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, Roost, Frustration, SolarBeam, Return, BrickBreak, DoubleTeam, SludgeBomb, AerialAce, Facade, Rest, Attract, Thief, Round, FalseSwipe, BrutalSwing, Acrobatics, Payback, GigaImpact, SwordsDance, XScissor, Infestation, PoisonJab, Swagger, SleepTalk, UTurn, Substitute, Confide, PoisonSting, StringShot, BugBite, Harden });
        public static readonly Pokemon Pidgey = new Pokemon(16, "Pidgey", Normal, Flying, new Ability[] { KeenEye, TangledFeet, BigPecks }, new double[] { 40, 45, 40, 35, 35, 56, 4.0 }, new Move[] { Tackle, SandAttack, Gust, QuickAttack, Whirlwind, Twister, FeatherDance, Agility, WingAttack, Roost, Tailwind, MirrorMove, AirSlash, Hurricane, WorkUp, Toxic, HiddenPower, SunnyDay, Protect, RainDance, Roost, Frustration, Return, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, SteelWing, Fly, Swagger, SleepTalk, UTurn, Substitute, Confide, AirCutter, AirSlash, BraveBird, Defog, FeintAttack, Foresight, Pursuit, SteelWing, Uproar });
        public static readonly Pokemon Pidgeotto = new Pokemon(17, "Pidgeotto", Normal, Flying, new Ability[] { KeenEye, TangledFeet, BigPecks }, new double[] { 63, 60, 55, 50, 50, 71, 66.1 }, new Move[] { Tackle, SandAttack, Gust, QuickAttack, Whirlwind, Twister, FeatherDance, Agility, WingAttack, Roost, Tailwind, MirrorMove, AirSlash, Hurricane, WorkUp, Toxic, HiddenPower, SunnyDay, Protect, RainDance, Roost, Frustration, Return, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, SteelWing, Fly, Swagger, SleepTalk, UTurn, Substitute, Confide, AirCutter, AirSlash, BraveBird, Defog, FeintAttack, Foresight, Pursuit, SteelWing, Uproar });
        public static readonly Pokemon Pidgeot = new Pokemon(18, "Pidgeot", Normal, Flying, new Ability[] { KeenEye, TangledFeet, BigPecks }, new double[] { 83, 80, 75, 70, 70, 91, 87.1 }, new Move[] { Tackle, SandAttack, Gust, QuickAttack, Whirlwind, Twister, FeatherDance, Agility, WingAttack, Roost, Tailwind, MirrorMove, AirSlash, Hurricane, WorkUp, Toxic, HiddenPower, SunnyDay, Protect, RainDance, Roost, Frustration, Return, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, SteelWing, Fly, Swagger, SleepTalk, UTurn, Substitute, Confide, AirCutter, AirSlash, BraveBird, Defog, FeintAttack, Foresight, Pursuit, SteelWing, Uproar });
        public static readonly Pokemon MegaPidgeot = new Pokemon(-18, "Mega Pidgeot", Normal, Flying, new Ability[] { NoGuard }, new double[] { 83, 80, 80, 135, 80, 121, 111.3 }, new Move[] { Tackle, SandAttack, Gust, QuickAttack, Whirlwind, Twister, FeatherDance, Agility, WingAttack, Roost, Tailwind, MirrorMove, AirSlash, Hurricane, WorkUp, Toxic, HiddenPower, SunnyDay, Protect, RainDance, Roost, Frustration, Return, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, SteelWing, Fly, Swagger, SleepTalk, UTurn, Substitute, Confide, AirCutter, AirSlash, BraveBird, Defog, FeintAttack, Foresight, Pursuit, SteelWing, Uproar });
        public static readonly Pokemon Rattata = new Pokemon(19, "Rattata", Normal, Typeless, new Ability[] { RunAway, Guts, Hustle }, new double[] { 30, 56, 35, 25, 35, 72, 7.7 }, new Move[] { Tackle, TailWhip, QuickAttack, Bite, Pursuit, HyperFang, Assurance, Crunch, SuckerPunch, SuperFang, DoubleEdge, Endeavor, WorkUp, Toxic, HiddenPower, SunnyDay, Taunt, IceBeam, Blizzard, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, ShadowBall, DoubleTeam, Facade, Rest, Attract, Thief, Round, ChargeBeam, ThunderWave, GrassKnot, Swagger, SleepTalk, UTurn, Substitute, WildCharge, Confide, Bite, Counter, FinalGambit, FlameWheel, FurySwipes, LastResort, MeFirst, Revenge, Reversal, Screech, Uproar });
        public static readonly Pokemon AlolanRattata = new Pokemon(-19, "Alolan Rattata", Dark, Normal, new Ability[] { Gluttony, Hustle, ThickFat }, new double[] { 30, 56, 35, 25, 35, 72, 8.4 }, new Move[] { Tackle, TailWhip, QuickAttack, FocusEnergy, Bite, Pursuit, HyperFang, Assurance, Crunch, SuckerPunch, SuperFang, DoubleEdge, Endeavor, Toxic, HiddenPower, SunnyDay, Taunt, IceBeam, Blizzard, Protect, RainDance, Frustration, Return, ShadowBall, DoubleTeam, SludgeBomb, Torment, Facade, Rest, Attract, Thief, Round, Quash, Embargo, ShadowClaw, GrassKnot, Swagger, SleepTalk, UTurn, Substitute, Snarl, DarkPulse, Confide, Counter, FinalGambit, FurySwipes, LastResort, MeFirst, Revenge, Reversal, Snatch, Stockpile, Swallow, Switcheroo, Uproar });
        public static readonly Pokemon Raticate = new Pokemon(20, "Raticate", Normal, Typeless, new Ability[] { RunAway, Guts, Hustle }, new double[] { 55, 81, 60, 50, 70, 97, 40.8 }, new Move[] { SwordsDance, Tackle, TailWhip, QuickAttack, FocusEnergy, Bite, Pursuit, HyperFang, Assurance, Crunch, SuckerPunch, SuperFang, DoubleEdge, Endeavor, WorkUp, Roar, Toxic, HiddenPower, SunnyDay, Taunt, IceBeam, Blizzard, HyperBeam, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, ShadowBall, DoubleTeam, Facade, Rest, Attract, Thief, Round, ChargeBeam, GigaImpact, ThunderWave, SwordsDance, GrassKnot, Swagger, SleepTalk, UTurn, Substitute, WildCharge, Confide, Counter, FinalGambit, FlameWheel, FurySwipes, LastResort, MeFirst, Revenge, Reversal, Screech, Uproar });
        public static readonly Pokemon AlolanRaticate = new Pokemon(-20, "Alolan Raticate", Dark, Normal, new Ability[] { Gluttony, Hustle, ThickFat }, new double[] { 75, 71, 70, 40, 80, 77, 56.2 }, new Move[] { SwordsDance, Tackle, TailWhip, QuickAttack, FocusEnergy, Bite, Pursuit, HyperFang, Assurance, Crunch, SuckerPunch, SuperFang, DoubleEdge, Endeavor, Roar, Toxic, BulkUp, Venoshock, HiddenPower, SunnyDay, Taunt, IceBeam, Blizzard, HyperBeam, Protect, RainDance, Frustration, Return, ShadowBall, DoubleTeam, SludgeWave, SludgeBomb, Torment, Facade, Rest, Attract, Thief, Round, Quash, Embargo, ShadowClaw, GigaImpact, SwordsDance, GrassKnot, Swagger, SleepTalk, UTurn, Substitute, Snarl, DarkPulse, Confide, Counter, FinalGambit, FurySwipes, MeFirst, Revenge, Reversal, Snatch, Stockpile, Swallow, Switcheroo, Uproar });
        public static readonly Pokemon Spearow = new Pokemon(21, "Spearow", Normal, Flying, new Ability[] { KeenEye, Sniper }, new double[] { 40, 60, 30, 31, 31, 70, 4.4 }, new Move[] { Peck, Growl, Leer, Pursuit, FuryAttack, AerialAce, MirrorMove, Assurance, Agility, FocusEnergy, Roost, DrillPeck, WorkUp, Toxic, HiddenPower, SunnyDay, Protect, RainDance, Roost, Frustration, Return, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, EchoedVoice, SteelWing, FalseSwipe, Fly, Swagger, SleepTalk, UTurn, Substitute, Confide, Astonish, FeatherDance, FeintAttack, QuickAttack, RazorWind, ScaryFace, SkyAttack, SteelWing, TriAttack, Uproar, Whirlwind });
        public static readonly Pokemon Fearow = new Pokemon(22, "Fearow", Normal, Flying, new Ability[] { KeenEye, Sniper }, new double[] { 65, 90, 65, 61, 61, 100, 83.8 }, new Move[] { DrillRun, Pluck, Peck, Growl, Leer, Pursuit, FuryAttack, AerialAce, MirrorMove, Assurance, Agility, FocusEnergy, Roost, DrillPeck, WorkUp, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, RainDance, Roost, Frustration, Return, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, EchoedVoice, SteelWing, FalseSwipe, GigaImpact, Fly, Swagger, SleepTalk, UTurn, Substitute, Confide, Astonish, FeatherDance, FeintAttack, QuickAttack, RazorWind, ScaryFace, SkyAttack, SteelWing, TriAttack, Uproar, Whirlwind });
        public static readonly Pokemon Ekans = new Pokemon(23, "Ekans", Poison, Typeless, new Ability[] { Intimidate, ShedSkin, Unnerve }, new double[] { 35, 60, 44, 40, 54, 55, 15.2 }, new Move[] { Wrap, Leer, PoisonSting, Bite, Glare, Screech, Acid, Stockpile, Swallow, SpitUp, AcidSpray, MudBomb, GastroAcid, Belch, Haze, Coil, GunkShot, Toxic, Venoshock, HiddenPower, SunnyDay, Protect, RainDance, Frustration, Earthquake, Return, DoubleTeam, SludgeWave, SludgeBomb, RockTomb, Torment, Facade, Rest, Attract, Thief, Round, BrutalSwing, Payback, Bulldoze, RockSlide, Infestation, PoisonJab, Swagger, SleepTalk, Substitute, DarkPulse, Confide, BeatUp, Disable, IronTail, PoisonFang, PoisonTail, Pursuit, ScaryFace, Slam, Snatch, Spite, SuckerPunch, Switcheroo });
        public static readonly Pokemon Arbok = new Pokemon(24, "Arbok", Poison, Typeless, new Ability[] { Intimidate, ShedSkin, Unnerve }, new double[] { 60, 95, 69, 65, 79, 80, 143.3 }, new Move[] { Crunch, IceFang, ThunderFang, FireFang, Wrap, Leer, PoisonSting, Bite, Crunch, Glare, Screech, Acid, Stockpile, Swallow, SpitUp, AcidSpray, MudBomb, GastroAcid, Belch, Haze, Coil, GunkShot, Toxic, Venoshock, HiddenPower, SunnyDay, Protect, RainDance, Frustration, Earthquake, Return, DoubleTeam, SludgeWave, SludgeBomb, RockTomb, Torment, Facade, Rest, Attract, Thief, Round, BrutalSwing, Payback, Bulldoze, RockSlide, Infestation, PoisonJab, Swagger, SleepTalk, Substitute, DarkPulse, Confide, BeatUp, Disable, IronTail, PoisonFang, PoisonTail, Pursuit, ScaryFace, Slam, Snatch, Spite, SuckerPunch, Switcheroo });
        public static readonly Pokemon Pikachu = new Pokemon(25, "Pikachu", Electric, Typeless, new Ability[] { Static, LightningRod }, new double[] { 35, 55, 40, 50, 50, 90, 13.2 }, new Move[] { TailWhip, ThunderShock, Growl, PlayNice, QuickAttack, ElectroBall, ThunderWave, Feint, DoubleTeam, Spark, Nuzzle, Discharge, Slam, Thunderbolt, Agility, WildCharge, LightScreen, Toxic, HiddenPower, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, BrickBreak, DoubleTeam, Facade, Rest, Attract, Round, EchoedVoice, Fling, ChargeBeam, VoltSwitch, ThunderWave, GrassKnot, Swagger, SleepTalk, Substitute, WildCharge, Confide, Bestow, Bide, Charge, DisarmingVoice, DoubleSlap, ElectricTerrain, Encore, Endure, FakeOut, Flail, LuckyChant, Present, Reversal, ThunderPunch, Tickle, VoltTackle, Wish, Charm, SweetKiss, NastyPlot, Celebrate, IronTail, HoldHands, TeeterDance, HappyHour });
        public static readonly Pokemon Raichu = new Pokemon(26, "Raichu", Electric, Typeless, new Ability[] { Static, LightningRod }, new double[] { 60, 90, 55, 90, 80, 110, 66.1 }, new Move[] { Thunderbolt, TailWhip, ThunderShock, Growl, PlayNice, QuickAttack, ElectroBall, ThunderWave, Feint, DoubleTeam, Spark, Nuzzle, Discharge, Slam, Thunderbolt, Agility, WildCharge, LightScreen, Toxic, HiddenPower, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, BrickBreak, DoubleTeam, Facade, Rest, Attract, Round, EchoedVoice, Fling, ChargeBeam, VoltSwitch, ThunderWave, GrassKnot, Swagger, SleepTalk, Substitute, WildCharge, Confide, Bestow, Bide, Charge, DisarmingVoice, DoubleSlap, ElectricTerrain, Encore, Endure, FakeOut, Flail, LuckyChant, Present, Reversal, ThunderPunch, Tickle, VoltTackle, Wish, Charm, SweetKiss, NastyPlot, Celebrate, IronTail, HoldHands, TeeterDance, HappyHour });
        public static readonly Pokemon AlolanRaichu = new Pokemon(-26, "Alolan-Raichu", Electric, Psychic, new Ability[] { SurgeSurfer }, new double[] { 60, 85, 50, 95, 85, 110, 46.3 }, new Move[] { psychic, SpeedSwap, Thunderbolt, TailWhip, ThunderShock, Growl, PlayNice, QuickAttack, ElectroBall, ThunderWave, Feint, DoubleTeam, Spark, Nuzzle, Discharge, Slam, Thunderbolt, Agility, WildCharge, LightScreen, Psyshock, CalmMind, Toxic, HiddenPower, HyperBeam, LightScreen, Protect, RainDance, Safeguard, Frustration, Thunderbolt, Thunder, Return, BrickBreak, DoubleTeam, Reflect, Facade, Rest, Attract, Thief, Round, EchoedVoice, FocusBlast, Fling, ChargeBeam, GigaImpact, VoltSwitch, ThunderWave, GrassKnot, Swagger, SleepTalk, Substitute, WildCharge, Confide, Bestow, Bide, Charge, DisarmingVoice, DoubleSlap, ElectricTerrain, Encore, Endure, FakeOut, Flail, LuckyChant, Present, Reversal, ThunderPunch, Tickle, VoltTackle, Wish });
        public static readonly Pokemon Sandshrew = new Pokemon(27, "Sandshrew", Ground, Typeless, new Ability[] { SandVeil, SandRush }, new double[] { 50, 75, 85, 20, 30, 40, 26.5 }, new Move[] { Scratch, DefenseCurl, SandAttack, PoisonSting, Rollout, RapidSpin, FuryCutter, Magnitude, Swift, FurySwipes, SandTomb, Slash, Dig, GyroBall, SwordsDance, Sandstorm, Earthquake, Toxic, HiddenPower, SunnyDay, Protect, Safeguard, Frustration, Return, BrickBreak, DoubleTeam, Sandstorm, RockTomb, AerialAce, Facade, Rest, Attract, Thief, Round, Fling, ShadowClaw, GyroBall, SwordsDance, Bulldoze, RockSlide, XScissor, PoisonJab, Swagger, SleepTalk, Substitute, Confide, ChipAway, Counter, CrushClaw, Endure, Flail, MudShot, NightSlash, RapidSpin, MetalClaw, RockClimb, Rototiller });
        public static readonly Pokemon AlolanSandshrew = new Pokemon(-27, "Alolan Sandshrew", Ice, Steel, new Ability[] { SnowCloak, SlushRush }, new double[] { 50, 75, 90, 10, 35, 40, 88.2 }, new Move[] { Scratch, DefenseCurl, Bide, PowderSnow, IceBall, RapidSpin, FuryCutter, MetalClaw, Swift, FurySwipes, IronDefense, Slash, IronHead, GyroBall, SwordsDance, Hail, Blizzard, WorkUp, Toxic, Hail, HiddenPower, SunnyDay, Blizzard, Protect, Safeguard, Frustration, Earthquake, Return, LeechLife, BrickBreak, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, Fling, ShadowClaw, AuroraVeil, GyroBall, SwordsDance, Bulldoze, FrostBreath, RockSlide, XScissor, PoisonJab, Swagger, SleepTalk, Substitute, Confide, Amnesia, ChipAway, Counter, CrushClaw, NonGhostCurse, Endure, Flail, IcicleCrash, IcicleSpear, MetalClaw, NightSlash });
        public static readonly Pokemon Sandslash = new Pokemon(28, "Sandslash", Ground, Typeless, new Ability[] { SandVeil, SandRush }, new double[] { 75, 100, 110, 45, 55, 65, 65.0 }, new Move[] { CrushClaw, Scratch, DefenseCurl, SandAttack, PoisonSting, Rollout, RapidSpin, FuryCutter, Magnitude, Swift, FurySwipes, SandTomb, Slash, Dig, GyroBall, SwordsDance, Sandstorm, Earthquake, Toxic, HiddenPower, SunnyDay, Protect, Safeguard, Frustration, Return, BrickBreak, DoubleTeam, Sandstorm, RockTomb, AerialAce, Facade, Rest, Attract, Thief, Round, Fling, ShadowClaw, GyroBall, SwordsDance, Bulldoze, RockSlide, XScissor, PoisonJab, Swagger, SleepTalk, Substitute, Confide, ChipAway, Counter, CrushClaw, Endure, Flail, MudShot, NightSlash, RapidSpin, MetalClaw, RockClimb, Rototiller });
        public static readonly Pokemon AlolanSandslash = new Pokemon(-28, "Alolan Sandslash", Ice, Steel, new Ability[] { SnowCloak, SlushRush }, new double[] { 75, 100, 120, 25, 65, 65, 121.3 }, new Move[] { IcicleSpear, MetalBurst, IcicleCrash, Scratch, DefenseCurl, Bide, PowderSnow, IceBall, RapidSpin, FuryCutter, MetalClaw, Swift, FurySwipes, IronDefense, Slash, IronHead, GyroBall, SwordsDance, Hail, Blizzard, WorkUp, Toxic, Hail, HiddenPower, SunnyDay, Blizzard, Protect, Safeguard, Frustration, Earthquake, Return, LeechLife, BrickBreak, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, Fling, ShadowClaw, AuroraVeil, GyroBall, SwordsDance, Bulldoze, FrostBreath, RockSlide, XScissor, PoisonJab, Swagger, SleepTalk, Substitute, Confide, Amnesia, ChipAway, Counter, CrushClaw, NonGhostCurse, Endure, Flail, IcicleCrash, IcicleSpear, MetalClaw, NightSlash });
        public static readonly Pokemon NidoranF = new Pokemon(29, "Nidoran ♀", Poison, Typeless, new Ability[] { PoisonPoint, Rivalry, Hustle }, new double[] { 55, 47, 52, 40, 40, 41, 15.4 }, new Move[] { Growl, Scratch, TailWhip, DoubleKick, PoisonSting, FurySwipes, Bite, HelpingHand, ToxicSpikes, Flatter, Crunch, Captivate, PoisonFang, Toxic, Venoshock, HiddenPower, SunnyDay, IceBeam, Blizzard, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, DoubleTeam, SludgeBomb, AerialAce, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, PoisonJab, Swagger, SleepTalk, Substitute, Confide, BeatUp, Charm, ChipAway, Counter, Disable, Endure, FocusEnergy, IronTail, PoisonTail, Pursuit, SkullBash, Supersonic, TakeDown, VenomDrench });
        public static readonly Pokemon Nidorina = new Pokemon(30, "Nidorina", Poison, Typeless, new Ability[] { PoisonPoint, Rivalry, Hustle }, new double[] { 70, 62, 67, 55, 55, 56, 44.1 }, new Move[] { Growl, Scratch, TailWhip, DoubleKick, PoisonSting, FurySwipes, Bite, HelpingHand, ToxicSpikes, Flatter, Crunch, Captivate, PoisonFang, Toxic, Venoshock, HiddenPower, SunnyDay, IceBeam, Blizzard, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, DoubleTeam, SludgeBomb, AerialAce, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, PoisonJab, Swagger, SleepTalk, Substitute, Confide, BeatUp, Charm, ChipAway, Counter, Disable, Endure, FocusEnergy, IronTail, PoisonTail, Pursuit, SkullBash, Supersonic, TakeDown, VenomDrench });
        public static readonly Pokemon Nidoqueen = new Pokemon(31, "Nidoqueen", Poison, Ground, new Ability[] { PoisonPoint, Rivalry, SheerForce }, new double[] { 90, 92, 87, 75, 85, 76, 132.3 }, new Move[] { Superpower, ChipAway, BodySlam, EarthPower, Growl, Scratch, TailWhip, DoubleKick, PoisonSting, FurySwipes, Bite, HelpingHand, ToxicSpikes, Flatter, Crunch, Captivate, PoisonFang, Roar, Toxic, Venoshock, HiddenPower, SunnyDay, Taunt, IceBeam, Blizzard, HyperBeam, Protect, RainDance, Frustration, SmackDown, Thunderbolt, Thunder, Earthquake, Return, ShadowBall, BrickBreak, DoubleTeam, SludgeWave, Flamethrower, SludgeBomb, Sandstorm, FireBlast, RockTomb, AerialAce, Torment, Facade, Rest, Attract, Thief, Round, EchoedVoice, FocusBlast, Fling, Quash, ShadowClaw, GigaImpact, StoneEdge, Bulldoze, RockSlide, DragonTail, PoisonJab, Swagger, SleepTalk, Substitute, Surf, Confide });
        public static readonly Pokemon NidoranM = new Pokemon(32, "Nidroan ♂", Poison, Typeless, new Ability[] { PoisonPoint, Rivalry, Hustle }, new double[] { 46, 57, 40, 40, 40, 50, 19.8 }, new Move[] { Leer, Peck, FocusEnergy, DoubleKick, PoisonSting, FuryAttack, HornAttack, HelpingHand, ToxicSpikes, Flatter, PoisonJab, Captivate, HornDrill, Toxic, Venoshock, HiddenPower, SunnyDay, IceBeam, Blizzard, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, SmartStrike, PoisonJab, Swagger, SleepTalk, Substitute, Confide, Amnesia, BeatUp, ChipAway, Confusion, Counter, Disable, Endure, HeadSmash, IronTail, PoisonTail, SuckerPunch, Supersonic, TakeDown, VenomDrench });
        public static readonly Pokemon Nidorino = new Pokemon(33, "Nidorino", Poison, Typeless, new Ability[] { PoisonPoint, Rivalry, Hustle }, new double[] { 61, 72, 57, 55, 55, 65, 43.0 }, new Move[] { Leer, Peck, FocusEnergy, DoubleKick, PoisonSting, FuryAttack, HornAttack, HelpingHand, ToxicSpikes, Flatter, PoisonJab, Captivate, HornDrill, Toxic, Venoshock, HiddenPower, SunnyDay, IceBeam, Blizzard, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, SmartStrike, PoisonJab, Swagger, SleepTalk, Substitute, Confide, Amnesia, BeatUp, ChipAway, Confusion, Counter, Disable, Endure, HeadSmash, IronTail, PoisonTail, SuckerPunch, Supersonic, TakeDown, VenomDrench });
        public static readonly Pokemon Nidoking = new Pokemon(34, "Nidoking", Poison, Ground, new Ability[] { PoisonPoint, Rivalry, SheerForce }, new double[] { 81, 102, 77, 85, 75, 85, 136.7 }, new Move[] { Megahorn, ChipAway, Thrash, EarthPower, Leer, Peck, FocusEnergy, DoubleKick, PoisonSting, FuryAttack, HornAttack, HelpingHand, ToxicSpikes, Flatter, PoisonJab, Captivate, HornDrill, Toxic, Venoshock, HiddenPower, SunnyDay, IceBeam, Blizzard, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, SmartStrike, PoisonJab, Swagger, SleepTalk, Substitute, Confide, Amnesia, BeatUp, ChipAway, Confusion, Counter, Disable, Endure, HeadSmash, IronTail, PoisonTail, SuckerPunch, Supersonic, TakeDown, VenomDrench });
        public static readonly Pokemon Clefairy = new Pokemon(35, "Clefairy", Fairy, Typeless, new Ability[] { CuteCharm, MagicGuard, FriendGuard }, new double[] { 70, 45, 48, 60, 65, 35, 16.5 }, new Move[] { Spotlight, DisarmingVoice, Pound, Growl, Encore, Sing, DoubleSlap, DefenseCurl, FollowMe, Bestow, WakeUpSlap, Minimize, StoredPower, Metronome, CosmicPower, LuckyChant, BodySlam, Moonlight, Moonblast, Gravity, MeteorMash, HealingWish, AfterYou, WorkUp, Psyshock, CalmMind, Toxic, HiddenPower, SunnyDay, IceBeam, Blizzard, LightScreen, Protect, RainDance, Safeguard, Frustration, SolarBeam, Thunderbolt, Thunder, Return, psychic, ShadowBall, BrickBreak, DoubleTeam, Reflect, Flamethrower, FireBlast, Facade, Rest, Attract, Round, EchoedVoice, Fling, ChargeBeam, ThunderWave, PsychUp, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, DazzlingGleam, Confide, Amnesia, Aromatherapy, BellyDrum, Covet, FakeTears, HealPulse, Metronome, Mimic, MistyTerrain, Present, Splash, StoredPower, Tickle, Wish, Charm, SweetKiss, Copycat, MagicalLeaf });
        public static readonly Pokemon Clefable = new Pokemon(36, "Clefable", Fairy, Typeless, new Ability[] { CuteCharm, MagicGuard, Unaware }, new double[] { 95, 70, 73, 95, 90, 60, 88.2 }, new Move[] { Spotlight, DisarmingVoice, Pound, Growl, Encore, Sing, DoubleSlap, DefenseCurl, FollowMe, Bestow, WakeUpSlap, Minimize, StoredPower, Metronome, CosmicPower, LuckyChant, BodySlam, Moonlight, Moonblast, Gravity, MeteorMash, HealingWish, AfterYou, WorkUp, Psyshock, CalmMind, Toxic, HiddenPower, SunnyDay, IceBeam, Blizzard, LightScreen, Protect, RainDance, Safeguard, Frustration, SolarBeam, Thunderbolt, Thunder, Return, psychic, ShadowBall, BrickBreak, DoubleTeam, Reflect, Flamethrower, FireBlast, Facade, Rest, Attract, Round, EchoedVoice, Fling, ChargeBeam, ThunderWave, PsychUp, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, DazzlingGleam, Confide, Amnesia, Aromatherapy, BellyDrum, Covet, FakeTears, HealPulse, Metronome, Mimic, MistyTerrain, Present, Splash, StoredPower, Tickle, Wish, Charm, SweetKiss, Copycat, MagicalLeaf });
        public static readonly Pokemon Vulpix = new Pokemon(37, "Vulpix", Fire, Typeless, new Ability[] { FlashFire, Drought }, new double[] { 38, 41, 40, 50, 65, 65, 21.8 }, new Move[] { Ember, TailWhip, Roar, BabyDollEyes, QuickAttack, ConfuseRay, FireSpin, Payback, WillOWisp, FeintAttack, Hex, FlameBurst, Extrasensory, Safeguard, Flamethrower, Imprison, FireBlast, Grudge, Captivate, Inferno, Roar, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, DoubleTeam, Facade, FlameCharge, Rest, Attract, Round, Overheat, EnergyBall, Payback, PsychUp, Swagger, SleepTalk, Substitute, DarkPulse, Confide, Disable, Flail, FlareBlitz, HeatWave, Howl, Hypnosis, PowerSwap, Spite, SecretPower, TailSlap});
        public static readonly Pokemon AlolanVulpix = new Pokemon(-37, "Alolan Vulpix", Ice, Typeless, new Ability[] { SnowCloak, SnowWarning }, new double[] { 38, 41, 40, 50, 65, 65, 21.8 }, new Move[] { PowderSnow, TailWhip, Roar, BabyDollEyes, IceShard, ConfuseRay, IcyWind, Payback, Mist, FeintAttack, Hex, AuroraBeam, Extrasensory, Safeguard, IceBeam, Imprison, Blizzard, Grudge, Captivate, SheerCold, Toxic, Hail, HiddenPower, Protect, RainDance, Frustration, Return, DoubleTeam, Facade, Rest, Attract, Round, Payback, AuroraVeil, PsychUp, FrostBreath, Swagger, SleepTalk, Substitute, DarkPulse, Confide, Agility, Charm, Disable, Encore, Extrasensory, Flail, FreezeDry, Howl, Hypnosis, Moonblast, PowerSwap, Spite, SecretPower, TailSlap, Celebrate });
        public static readonly Pokemon Ninetales = new Pokemon(38, "Ninetales", Fire, Typeless, new Ability[] { FlashFire, Drought }, new double[] { 73, 76, 75, 81, 100, 100, 43.9 }, new Move[] { NastyPlot, Ember, TailWhip, Roar, BabyDollEyes, QuickAttack, ConfuseRay, FireSpin, Payback, WillOWisp, FeintAttack, Hex, FlameBurst, Extrasensory, Safeguard, Flamethrower, Imprison, FireBlast, Grudge, Captivate, Inferno, Roar, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, DoubleTeam, Facade, FlameCharge, Rest, Attract, Round, Overheat, EnergyBall, Payback, PsychUp, Swagger, SleepTalk, Substitute, DarkPulse, Confide, Disable, Flail, FlareBlitz, HeatWave, Howl, Hypnosis, PowerSwap, Spite, SecretPower, TailSlap });
        public static readonly Pokemon AlolanNinetales = new Pokemon(-38, "Alolan Ninetales", Ice, Fairy, new Ability[] { SnowCloak, SnowWarning }, new double[] { 73, 67, 75, 81, 100, 109, 43.9 }, new Move[] {DazzlingGleam, NastyPlot, PowderSnow, TailWhip, Roar, BabyDollEyes, IceShard, ConfuseRay, IcyWind, Payback, Mist, FeintAttack, Hex, AuroraBeam, Extrasensory, Safeguard, IceBeam, Imprison, Blizzard, Grudge, Captivate, SheerCold, Toxic, Hail, HiddenPower, Protect, RainDance, Frustration, Return, DoubleTeam, Facade, Rest, Attract, Round, Payback, AuroraVeil, PsychUp, FrostBreath, Swagger, SleepTalk, Substitute, DarkPulse, Confide, Agility, Charm, Disable, Encore, Extrasensory, Flail, FreezeDry, Howl, Hypnosis, Moonblast, PowerSwap, Spite, SecretPower, TailSlap, Celebrate });
        public static readonly Pokemon Jigglypuff = new Pokemon(39, "Jigglypuff", Normal, Fairy, new Ability[] { CuteCharm, Competitive, FriendGuard }, new double[] { 115, 45, 20, 45, 25, 20, 12.1 }, new Move[] { Sing, DefenseCurl, Pound, PlayNice, DisarmingVoice, Disable, DoubleSlap, Rollout, Round, Stockpile, Swallow, SpitUp, WakeUpSlap, Rest, BodySlam, GyroBall, Mimic, HyperVoice, DoubleEdge, WorkUp, Toxic, HiddenPower, SunnyDay, IceBeam, Blizzard, LightScreen, Protect, RainDance, Safeguard, Frustration, SolarBeam, Thunderbolt, Thunder, Return, psychic, ShadowBall, BrickBreak, DoubleTeam, Reflect, Flamethrower, FireBlast, Facade, Rest, Attract, Round, EchoedVoice, Fling, ChargeBeam, ThunderWave, GyroBall, PsychUp, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, WildCharge, DazzlingGleam, Confide, Captivate, Covet, FakeTears, FeintAttack, Gravity, HealPulse, LastResort, MistyTerrain, PerishSong, Present, Punishment, SleepTalk, Wish, Charm, SweetKiss, Copycat });
        public static readonly Pokemon Wigglytuff = new Pokemon(40, "Wigglytuff", Normal, Fairy, new Ability[] { CuteCharm, Competitive, Frisk }, new double[] { 140, 70, 45, 85, 50, 45, 26.5 }, new Move[] { DoubleEdge, PlayRough, Sing, DefenseCurl, Disable, DoubleSlap, Sing, DefenseCurl, Pound, PlayNice, DisarmingVoice, Disable, DoubleSlap, Rollout, Round, Stockpile, Swallow, SpitUp, WakeUpSlap, Rest, BodySlam, GyroBall, Mimic, HyperVoice, DoubleEdge, WorkUp, Toxic, HiddenPower, SunnyDay, IceBeam, Blizzard, LightScreen, Protect, RainDance, Safeguard, Frustration, SolarBeam, Thunderbolt, Thunder, Return, psychic, ShadowBall, BrickBreak, DoubleTeam, Reflect, Flamethrower, FireBlast, Facade, Rest, Attract, Round, EchoedVoice, Fling, ChargeBeam, ThunderWave, GyroBall, PsychUp, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, WildCharge, DazzlingGleam, Confide, Captivate, Covet, FakeTears, FeintAttack, Gravity, HealPulse, LastResort, MistyTerrain, PerishSong, Present, Punishment, SleepTalk, Wish, Charm, SweetKiss, Copycat });
        public static readonly Pokemon Zubat = new Pokemon(41, "Zubat", Poison, Flying, new Ability[] { InnerFocus, Infiltrator }, new double[] { 40, 45, 35, 30, 40, 55, 16.5 }, new Move[] { Absorb, Supersonic, Astonish, Bite, WingAttack, ConfuseRay, AirCutter, Swift, PoisonFang, MeanLook, LeechLife, Haze, Venoshock, AirSlash, QuickGuard, Toxic, HiddenPower, SunnyDay, Taunt, Protect, RainDance, Roost, Frustration, Return, ShadowBall, DoubleTeam, SludgeBomb, AerialAce, Torment, Facade, Rest, Attract, Thief, Round, SteelWing, Acrobatics, Payback, Fly, Swagger, SleepTalk, UTurn, Substitute, Confide, BraveBird, NonGhostCurse, Defog, FeintAttack, GigaDrain, Gust, Hypnosis, NastyPlot, Pursuit, QuickAttack, SteelWing, VenomDrench, Whirlwind, ZenHeadbutt });
        public static readonly Pokemon Golbat = new Pokemon(42, "Golbat", Poison, Flying, new Ability[] { InnerFocus, Infiltrator }, new double[] { 75, 80, 70, 65, 75, 90, 121.3 }, new Move[] { Screech, Absorb, Supersonic, Astonish, Bite, WingAttack, ConfuseRay, AirCutter, Swift, PoisonFang, MeanLook, LeechLife, Haze, Venoshock, AirSlash, QuickGuard, Toxic, HiddenPower, SunnyDay, Taunt, Protect, RainDance, Roost, Frustration, Return, ShadowBall, DoubleTeam, SludgeBomb, AerialAce, Torment, Facade, Rest, Attract, Thief, Round, SteelWing, Acrobatics, Payback, Fly, Swagger, SleepTalk, UTurn, Substitute, Confide, BraveBird, NonGhostCurse, Defog, FeintAttack, GigaDrain, Gust, Hypnosis, NastyPlot, Pursuit, QuickAttack, SteelWing, VenomDrench, Whirlwind, ZenHeadbutt });
        public static readonly Pokemon Oddish = new Pokemon(43, "Oddish", Grass, Poison, new Ability[] { Chlorophyll, RunAway }, new double[] { 45, 50, 55, 75, 65, 30, 11.9 }, new Move[] { Absorb, Growth, SweetScent, Acid, PoisonPowder, StunSpore, MegaDrain, LuckyChant, Moonlight, GigaDrain, Toxic, NaturalGift, Moonblast, GrassyTerrain, PetalDance, Venoshock, HiddenPower, SunnyDay, Protect, Frustration, SolarBeam, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Round, EnergyBall, SwordsDance, Infestation, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, DazzlingGleam, Confide, AfterYou, Charm, Flail, Ingrain, NaturePower, RazorLeaf, SecretPower, Synthesis, TeeterDance, Tickle });
        public static readonly Pokemon Gloom = new Pokemon(44, "Gloom", Grass, Poison, new Ability[] { Chlorophyll, Stench }, new double[] { 60, 65, 70, 85, 75, 40, 19.0 }, new Move[] { PetalBlizzard, Absorb, Growth, SweetScent, Acid, PoisonPowder, StunSpore, MegaDrain, LuckyChant, Moonlight, GigaDrain, Toxic, NaturalGift, Moonblast, GrassyTerrain, PetalDance, Venoshock, HiddenPower, SunnyDay, Protect, Frustration, SolarBeam, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Round, EnergyBall, SwordsDance, Infestation, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, DazzlingGleam, Confide, AfterYou, Charm, Flail, Ingrain, NaturePower, RazorLeaf, SecretPower, Synthesis, TeeterDance, Tickle });
        public static readonly Pokemon Vileplume = new Pokemon(45, "Vileplume", Grass, Poison, new Ability[] { Chlorophyll, EffectSpore }, new double[] { 75, 80, 85, 110, 90, 50, 41.0 }, new Move[] { Aromatherapy, PetalBlizzard, Absorb, Growth, SweetScent, Acid, PoisonPowder, StunSpore, MegaDrain, LuckyChant, Moonlight, GigaDrain, Toxic, NaturalGift, Moonblast, GrassyTerrain, PetalDance, Venoshock, HiddenPower, SunnyDay, Protect, Frustration, SolarBeam, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Round, EnergyBall, SwordsDance, Infestation, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, DazzlingGleam, Confide, AfterYou, Charm, Flail, Ingrain, NaturePower, RazorLeaf, SecretPower, Synthesis, TeeterDance, Tickle });
        public static readonly Pokemon Paras = new Pokemon(46, "Paras", Bug, Grass, new Ability[] { EffectSpore, DrySkin, Damp }, new double[] { 35, 70, 55, 45, 55, 25, 11.9 }, new Move[] { Scratch, StunSpore, PoisonPowder, Absorb, FuryCutter, Spore, Slash, Growth, GigaDrain, Aromatherapy, RagePowder, XScissor, Toxic, Venoshock, HiddenPower, SunnyDay, LightScreen, Protect, Frustration, SolarBeam, Return, LeechLife, BrickBreak, DoubleTeam, SludgeBomb, AerialAce, Facade, Rest, Attract, Thief, Round, EnergyBall, FalseSwipe, SwordsDance, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, Confide, Agility, BugBite, Counter, CrossPoison, Endure, FellStinger, Flail, LeechSeed, MetalClaw, NaturalGift, Psybeam, Pursuit, Rototiller, Screech, SweetScent, WideGuard });
        public static readonly Pokemon Parasect = new Pokemon(47, "Parasect", Bug, Grass, new Ability[] { EffectSpore, DrySkin, Damp }, new double[] { 60, 95, 80, 60, 80, 30, 65.0 }, new Move[] { Scratch, StunSpore, PoisonPowder, Absorb, FuryCutter, Spore, Slash, Growth, GigaDrain, Aromatherapy, RagePowder, XScissor, Toxic, Venoshock, HiddenPower, SunnyDay, LightScreen, Protect, Frustration, SolarBeam, Return, LeechLife, BrickBreak, DoubleTeam, SludgeBomb, AerialAce, Facade, Rest, Attract, Thief, Round, EnergyBall, FalseSwipe, SwordsDance, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, Confide, Agility, BugBite, Counter, CrossPoison, Endure, FellStinger, Flail, LeechSeed, MetalClaw, NaturalGift, Psybeam, Pursuit, Rototiller, Screech, SweetScent, WideGuard });
        public static readonly Pokemon Venonat = new Pokemon(48, "Venonat", Bug, Poison, new Ability[] { CompoundEyes, TintedLens, RunAway }, new double[] { 60, 55, 50, 40, 55, 45, 66.1 }, new Move[] { Tackle, Disable, Foresight, Supersonic, Confusion, PoisonPowder, Psybeam, StunSpore, SignalBeam, SleepPowder, LeechLife, ZenHeadbutt, PoisonFang, psychic, Toxic, Venoshock, HiddenPower, SunnyDay, Protect, Frustration, SolarBeam, Return, SludgeBomb, Facade, Rest, Attract, Thief, Round, Infestation, Swagger, SleepTalk, Substitute, Confide, Agility, BatonPass, BugBite, GigaDrain, MorningSun, RagePowder, Screech, SecretPower, SkillSwap, ToxicSpikes });
        public static readonly Pokemon Venomoth = new Pokemon(49, "Venomoth", Bug, Poison, new Ability[] { ShieldDust, TintedLens, WonderSkin }, new double[] { 70, 65, 60, 90, 75, 90, 27.6 }, new Move[] { Gust, QuiverDance, BugBuzz, SilverWind, Tackle, Disable, Foresight, Supersonic, Confusion, PoisonPowder, Psybeam, StunSpore, SignalBeam, SleepPowder, LeechLife, ZenHeadbutt, PoisonFang, psychic, Toxic, Venoshock, HiddenPower, SunnyDay, Protect, Frustration, SolarBeam, Return, SludgeBomb, Facade, Rest, Attract, Thief, Round, Infestation, Swagger, SleepTalk, Substitute, Confide, Agility, BatonPass, BugBite, GigaDrain, MorningSun, RagePowder, Screech, SecretPower, SkillSwap, ToxicSpikes });
        public static readonly Pokemon Diglett = new Pokemon(50, "Diglett", Ground, Typeless, new Ability[] { SandVeil, ArenaTrap, SandForce }, new double[] { 10, 55, 25, 35, 45, 95, 1.8 }, new Move[] { SandAttack, Scratch, Growl, Astonish, MudSlap, Magnitude, Bulldoze, SuckerPunch, MudBomb, EarthPower, Dig, Slash, Earthquake, Fissure, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, DoubleTeam, SludgeBomb, Sandstorm, RockTomb, AerialAce, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, RockSlide, Swagger, SleepTalk, Substitute, Confide, AncientPower, BeatUp, Endure, FeintAttack, FinalGambit, Headbutt, Memento, MudBomb, Pursuit, Reversal, Screech, Uproar });
        public static readonly Pokemon AlolanDiglett = new Pokemon(-50, "Alolan Diglett", Ground, Steel, new Ability[] { SandVeil, TanglingHair, SandForce }, new double[] { 10, 55, 30, 35, 45, 90, 2.2 }, new Move[] { SandAttack, MetalClaw, Growl, Astonish, MudSlap, Magnitude, Bulldoze, SuckerPunch, MudBomb, EarthPower, Dig, IronHead, Earthquake, Fissure, WorkUp, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, DoubleTeam, SludgeBomb, Sandstorm, RockTomb, AerialAce, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, RockSlide, Swagger, SleepTalk, Substitute, FlashCannon, Confide, AncientPower, BeatUp, Endure, FeintAttack, FinalGambit, Headbutt, Memento, MetalSound, Pursuit, Reversal, Thrash });
        public static readonly Pokemon Dugtrio = new Pokemon(51, "Dugtrio", Ground, Typeless, new Ability[] { SandVeil, ArenaTrap, SandForce }, new double[] { 35, 100, 50, 50, 70, 120, 73.4 }, new Move[] { SandTomb, Rototiller, NightSlash, TriAttack, SandAttack, Scratch, Growl, Astonish, MudSlap, Magnitude, Bulldoze, SuckerPunch, MudBomb, EarthPower, Dig, Slash, Earthquake, Fissure, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, DoubleTeam, SludgeBomb, Sandstorm, RockTomb, AerialAce, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, RockSlide, Swagger, SleepTalk, Substitute, Confide, AncientPower, BeatUp, Endure, FeintAttack, FinalGambit, Headbutt, Memento, MudBomb, Pursuit, Reversal, Screech, Uproar });
        public static readonly Pokemon AlolanDugtrio = new Pokemon(-51, "Alolan Dugtrio", Ground, Steel, new Ability[] { SandVeil, TanglingHair, SandForce }, new double[] { 35, 100, 60, 50, 70, 110, 146.8 }, new Move[] { SandTomb, Rototiller, NightSlash, TriAttack, SandAttack, MetalClaw, Growl, Astonish, MudSlap, Magnitude, Bulldoze, SuckerPunch, MudBomb, EarthPower, Dig, IronHead, Earthquake, Fissure, WorkUp, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, DoubleTeam, SludgeBomb, Sandstorm, RockTomb, AerialAce, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, RockSlide, Swagger, SleepTalk, Substitute, FlashCannon, Confide, AncientPower, BeatUp, Endure, FeintAttack, FinalGambit, Headbutt, Memento, MetalSound, Pursuit, Reversal, Thrash });
        public static readonly Pokemon Meowth = new Pokemon(52, "Meowth", Normal, Typeless, new Ability[] { Pickup, Technician, Unnerve }, new double[] { 40, 45, 35, 40, 40, 90, 9.3 }, new Move[] { Scratch, Growl, Bite, FakeOut, FurySwipes, Screech, FeintAttack, Taunt, PayDay, Slash, NastyPlot, Assurance, Captivate, NightSlash, Feint, WorkUp, Toxic, HiddenPower, SunnyDay, Taunt, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, ShadowBall, DoubleTeam, AerialAce, Torment, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, Payback, PsychUp, DreamEater, Swagger, SleepTalk, UTurn, Substitute, DarkPulse, Confide, Amnesia, Assist, Charm, Flail, FoulPlay, Hypnosis, LastResort, OdorSleuth, IronTail, Punishment, Snatch, Spite, TailWhip });
        public static readonly Pokemon AlolanMeowth = new Pokemon(-52, "Alolan Meowth", Dark, Typeless, new Ability[] { Pickup, Technician, Rattled }, new double[] { 40, 35, 35, 50, 40, 90, 9.3 }, new Move[] { Scratch, Growl, Bite, FakeOut, FurySwipes, Screech, FeintAttack, Taunt, PayDay, Slash, NastyPlot, Assurance, Captivate, NightSlash, Feint, DarkPulse, WorkUp, Toxic, HiddenPower, SunnyDay, Taunt, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, ShadowBall, DoubleTeam, AerialAce, Torment, Facade, Rest, Attract, Thief, Round, EchoedVoice, Quash, Embargo, ShadowClaw, Payback, PsychUp, DreamEater, Swagger, SleepTalk, UTurn, Substitute, Confide, Amnesia, Assist, Charm, Covet, Flail, Flatter, FoulPlay, Hypnosis, PartingShot, Punishment, Snatch, Spite });
        public static readonly Pokemon Persian = new Pokemon(53, "Persian", Normal, Typeless, new Ability[] { Limber, Technician, Unnerve }, new double[] { 65, 70, 60, 65, 65, 115, 70.5 }, new Move[] { Swift, PlayRough, Switcheroo, PowerGem, Scratch, Growl, Bite, FakeOut, FurySwipes, Screech, FeintAttack, Taunt, PayDay, Slash, NastyPlot, Assurance, Captivate, NightSlash, Feint, WorkUp, Toxic, HiddenPower, SunnyDay, Taunt, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, ShadowBall, DoubleTeam, AerialAce, Torment, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, Payback, PsychUp, DreamEater, Swagger, SleepTalk, UTurn, Substitute, DarkPulse, Confide, Amnesia, Assist, Charm, Flail, FoulPlay, Hypnosis, LastResort, OdorSleuth, IronTail, Punishment, Snatch, Spite, TailWhip });
        public static readonly Pokemon AlolanPersian = new Pokemon(-53, "Alolan Persian", Dark, Typeless, new Ability[] { FurCoat, Technician, Rattled }, new double[] { 65, 60, 60, 75, 65, 115, 72.8 }, new Move[] { Swift, Quash, PlayRough, Switcheroo, Scratch, Growl, Bite, FakeOut, FurySwipes, Screech, FeintAttack, Taunt, PayDay, Slash, NastyPlot, Assurance, Captivate, NightSlash, Feint, WorkUp, Toxic, HiddenPower, SunnyDay, Taunt, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, ShadowBall, DoubleTeam, AerialAce, Torment, Facade, Rest, Attract, Thief, Round, EchoedVoice, ShadowClaw, Payback, PsychUp, DreamEater, Swagger, SleepTalk, UTurn, Substitute, DarkPulse, Confide, Amnesia, Assist, Charm, Flail, FoulPlay, Hypnosis, LastResort, OdorSleuth, IronTail, Punishment, Snatch, Spite, TailWhip });
        public static readonly Pokemon Psyduck = new Pokemon(54, "Psyduck", Water, Typeless, new Ability[] { Damp, CloudNine, SwiftSwim }, new double[] { 50, 52, 48, 65, 50, 55, 43.2 }, new Move[] { WaterSport, Scratch, TailWhip, WaterGun, Confusion, FurySwipes, WaterPulse, Disable, Screech, ZenHeadbutt, AquaTail, Soak, PsychUp, Amnesia, HydroPump, WonderRoom, Psyshock, CalmMind, Toxic, Hail, HiddenPower, IceBeam, Blizzard, LightScreen, Protect, RainDance, Frustration, Return, psychic, BrickBreak, DoubleTeam, AerialAce, Facade, Rest, Attract, Round, Scald, Fling, ShadowClaw, PsychUp, Swagger, SleepTalk, Substitute, Surf, Waterfall, Confide, ClearSmog, ConfuseRay, CrossChop, Encore, Foresight, FutureSight, Hypnosis, MudBomb, Psybeam, Refresh, SecretPower, SimpleBeam, SleepTalk, Synchronoise, Yawn });
        public static readonly Pokemon Golduck = new Pokemon(55, "Golduck", Water, Typeless, new Ability[] { Damp, CloudNine, SwiftSwim }, new double[] { 80, 82, 78, 95, 80, 85, 168.9 }, new Move[] { MeFirst, AquaJet, WaterSport, Scratch, TailWhip, WaterGun, Confusion, FurySwipes, WaterPulse, Disable, Screech, ZenHeadbutt, AquaTail, Soak, PsychUp, Amnesia, HydroPump, WonderRoom, Psyshock, CalmMind, Toxic, Hail, HiddenPower, IceBeam, Blizzard, LightScreen, Protect, RainDance, Frustration, Return, psychic, BrickBreak, DoubleTeam, AerialAce, Facade, Rest, Attract, Round, Scald, Fling, ShadowClaw, PsychUp, Swagger, SleepTalk, Substitute, Surf, Waterfall, Confide, ClearSmog, ConfuseRay, CrossChop, Encore, Foresight, FutureSight, Hypnosis, MudBomb, Psybeam, Refresh, SecretPower, SimpleBeam, SleepTalk, Synchronoise, Yawn });
        public static readonly Pokemon Mankey = new Pokemon(56, "Mankey", Fighting, Typeless, new Ability[] { VitalSpirit, AngerPoint, Defiant }, new double[] { 40, 80, 35, 35, 45, 70, 61.7 }, new Move[] { Covet, Scratch, LowKick, Leer, FocusEnergy, FurySwipes, KarateChop, Pursuit, SeismicToss, Swagger, CrossChop, Assurance, Punishment, Thrash, CloseCombat, Screech, StompingTantrum, Outrage, FinalGambit, WorkUp, Toxic, BulkUp, HiddenPower, SunnyDay, Taunt, Protect, RainDance, Frustration, SmackDown, Thunderbolt, Thunder, Earthquake, Return, BrickBreak, DoubleTeam, RockTomb, AerialAce, Facade, Rest, Attract, Thief, LowSweep, Round, Overheat, FocusBlast, Fling, Acrobatics, Payback, Bulldoze, RockSlide, PoisonJab, Swagger, SleepTalk, UTurn, Substitute, Confide, BeatUp, CloseCombat, Counter, Encore, FocusPunch, Foresight, Meditate, NightSlash, PowerTrip, Revenge, Reversal, SleepTalk, SmellingSalts });
        public static readonly Pokemon Primeape = new Pokemon(57, "Primeape", Fighting, Typeless, new Ability[] { VitalSpirit, AngerPoint, Defiant }, new double[] { 65, 105, 60, 60, 70, 95, 70.5 }, new Move[] { Rage, Fling, Covet, Scratch, LowKick, Leer, FocusEnergy, FurySwipes, KarateChop, Pursuit, SeismicToss, Swagger, CrossChop, Assurance, Punishment, Thrash, CloseCombat, Screech, StompingTantrum, Outrage, FinalGambit, WorkUp, Toxic, BulkUp, HiddenPower, SunnyDay, Taunt, Protect, RainDance, Frustration, SmackDown, Thunderbolt, Thunder, Earthquake, Return, BrickBreak, DoubleTeam, RockTomb, AerialAce, Facade, Rest, Attract, Thief, LowSweep, Round, Overheat, FocusBlast, Fling, Acrobatics, Payback, Bulldoze, RockSlide, PoisonJab, Swagger, SleepTalk, UTurn, Substitute, Confide, BeatUp, CloseCombat, Counter, Encore, FocusPunch, Foresight, Meditate, NightSlash, PowerTrip, Revenge, Reversal, SleepTalk, SmellingSalts });
        public static readonly Pokemon Growlithe = new Pokemon(58, "Growlithe", Fire, Typeless, new Ability[] { Intimidate, FlashFire, Justified }, new double[] { 55, 70, 45, 70, 50, 60, 41.9 }, new Move[] { Bite, Roar, Ember, Leer, OdorSleuth, HelpingHand, FlameWheel, Reversal, FireFang, TakeDown, FlameBurst, Agility, Retaliate, Flamethrower, Crunch, HeatWave, Outrage, FlareBlitz, Roar, Toxic, HiddenPower, SunnyDay, Protect, Safeguard, Frustration, Return, DoubleTeam, FireBlast, AerialAce, Facade, FlameCharge, Rest, Attract, Thief, Round, Overheat, WillOWisp, Swagger, SleepTalk, Substitute, WildCharge, Snarl, Confide, BodySlam, BurnUp, CloseCombat, Covet, Crunch, DoubleEdge, DoubleKick, FireSpin, Howl, IronTail, MorningSun, Thrash });
        public static readonly Pokemon Arcanine = new Pokemon(59, "Arcanine", Fire, Typeless, new Ability[] { Intimidate, FlashFire, Justified }, new double[] { 90, 110, 80, 100, 80, 95, 341.7 }, new Move[] { ThunderFang, ExtremeSpeed, Bite, Roar, Ember, Leer, OdorSleuth, HelpingHand, FlameWheel, Reversal, FireFang, TakeDown, FlameBurst, Agility, Retaliate, Flamethrower, Crunch, HeatWave, Outrage, FlareBlitz, Roar, Toxic, HiddenPower, SunnyDay, Protect, Safeguard, Frustration, Return, DoubleTeam, FireBlast, AerialAce, Facade, FlameCharge, Rest, Attract, Thief, Round, Overheat, WillOWisp, Swagger, SleepTalk, Substitute, WildCharge, Snarl, Confide, BodySlam, BurnUp, CloseCombat, Covet, Crunch, DoubleEdge, DoubleKick, FireSpin, Howl, IronTail, MorningSun, Thrash });
        public static readonly Pokemon Poliwag = new Pokemon(60, "Poliwag", Water, Typeless, new Ability[] { WaterAbsorb, Damp, SwiftSwim }, new double[] { 40, 50, 40, 40, 40, 90, 27.3 }, new Move[] { WaterSport, WaterGun, Hypnosis, Bubble, DoubleSlap, RainDance, BodySlam, BubbleBeam, MudShot, BellyDrum, WakeUpSlap, HydroPump, MudBomb, Toxic, Hail, HiddenPower, IceBeam, Blizzard, Protect, Frustration, Return, psychic, DoubleTeam, Facade, Rest, Attract, Thief, Round, Scald, Swagger, SleepTalk, Substitute, Surf, Waterfall, Confide, Encore, Endeavor, Endure, Haze, IceBall, MindReader, Mist, MudShot, Refresh, Splash, WaterPulse });
        public static readonly Pokemon Poliwhirl = new Pokemon(61, "Poliwhirl", Water, Typeless, new Ability[] { WaterAbsorb, Damp, SwiftSwim }, new double[] { 65, 65, 65, 50, 50, 90, 44.1 }, new Move[] { WaterSport, WaterGun, Hypnosis, Bubble, DoubleSlap, RainDance, BodySlam, BubbleBeam, MudShot, BellyDrum, WakeUpSlap, HydroPump, MudBomb, Toxic, Hail, HiddenPower, IceBeam, Blizzard, Protect, Frustration, Return, psychic, DoubleTeam, Facade, Rest, Attract, Thief, Round, Scald, Swagger, SleepTalk, Substitute, Surf, Waterfall, Confide, Encore, Endeavor, Endure, Haze, IceBall, MindReader, Mist, MudShot, Refresh, Splash, WaterPulse });
        public static readonly Pokemon Poliwrath = new Pokemon(62, "Poliwrath", Water, Fighting, new Ability[] { WaterAbsorb, Damp, SwiftSwim }, new double[] { 90, 95, 95, 70, 90, 70, 119.0 }, new Move[] { Submission, CircleThrow, DynamicPunch, MindReader, WaterSport, WaterGun, Hypnosis, Bubble, DoubleSlap, RainDance, BodySlam, BubbleBeam, MudShot, BellyDrum, WakeUpSlap, HydroPump, MudBomb, Toxic, Hail, HiddenPower, IceBeam, Blizzard, Protect, Frustration, Return, psychic, BrickBreak, DoubleTeam, Facade, Rest, Attract, Thief, LowSweep, Round, FocusBlast, Scald, Swagger, SleepTalk, Substitute, Surf, Waterfall, Confide, Encore, Endeavor, Endure, Haze, IceBall, MindReader, Mist, MudShot, Refresh, Splash, WaterPulse });

        // CHECK ALL ABOVE MOVES FOR CORRECTNESS, WAS USING FAULTY LOGIC
        public static readonly Pokemon Abra = new Pokemon(63, "Abra", Psychic, Typeless, new Ability[] { Synchronize, InnerFocus, MagicGuard }, new double[] { 25, 20, 15, 105, 55, 90, 43.0 }, new Move[] { Teleport, Psyshock, CalmMind, Toxic, HiddenPower, SunnyDay, Taunt, LightScreen, Protect, RainDance, Safeguard, Frustration, Return, psychic, ShadowBall, DoubleTeam, Reflect, Torment, Facade, Rest, Attract, Thief, Round, EnergyBall, Fling, ChargeBeam, Embargo, ThunderWave, PsychUp, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, TrickRoom, DazzlingGleam, Confide, AllySwitch, Barrier, Encore, FirePunch, GuardSplit, GuardSwap, IcePunch, KnockOff, PowerTrick, PsychoShift, SkillSwap, ThunderPunch });
        public static readonly Pokemon Kadabra = new Pokemon(64, "Kadabra", Psychic, Typeless, new Ability[] { Synchronize, InnerFocus, MagicGuard }, new double[] { 40, 35, 30, 120, 70, 105, 124.6 }, new Move[] { Kinesis, Teleport, Confusion, Disable, Psybeam, MiracleEye, Reflect, PsychoCut, Recover, Telekinesis, AllySwitch, psychic, RolePlay, FutureSight, Trick, Psyshock, CalmMind, Toxic, HiddenPower, SunnyDay, Taunt, LightScreen, Protect, RainDance, Safeguard, Frustration, Return, psychic, ShadowBall, DoubleTeam, Reflect, Torment, Facade, Rest, Attract, Thief, Round, EnergyBall, Fling, ChargeBeam, Embargo, ThunderWave, PsychUp, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, TrickRoom, DazzlingGleam, Confide, AllySwitch, Barrier, Encore, FirePunch, GuardSplit, GuardSwap, IcePunch, KnockOff, PowerTrick, PsychoShift, SkillSwap, ThunderPunch });
        public static readonly Pokemon Alakazam = new Pokemon(65, "Alakazam", Psychic, Typeless, new Ability[] { Synchronize, InnerFocus, MagicGuard }, new double[] { 55, 50, 45, 135, 95, 120, 105.8 }, new Move[] { Kinesis, Teleport, Confusion, Disable, Psybeam, MiracleEye, Reflect, PsychoCut, Recover, Telekinesis, AllySwitch, psychic, CalmMind, FutureSight, Trick, Psyshock, CalmMind, Toxic, HiddenPower, SunnyDay, Taunt, HyperBeam, LightScreen, Protect, RainDance, Safeguard, Frustration, Return, psychic, ShadowBall, DoubleTeam, Reflect, Torment, Facade, Rest, Attract, Thief, Round, FocusBlast, EnergyBall, Fling, ChargeBeam, Embargo, GigaImpact, ThunderWave, PsychUp, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, TrickRoom, DazzlingGleam, Confide, Barrier, Encore, FirePunch, GuardSplit, GuardSwap, IcePunch, KnockOff, PowerTrick, PsychoShift, SkillSwap, ThunderPunch });
        public static readonly Pokemon MegaAlakazam = new Pokemon(-65, "Mega Alakazam", Psychic, Typeless, new Ability[] { Trace }, new double[] { 55, 50, 65, 175, 105, 150, 105.8 }, new Move[] { Kinesis, Teleport, Confusion, Disable, Psybeam, MiracleEye, Reflect, PsychoCut, Recover, Telekinesis, AllySwitch, psychic, CalmMind, FutureSight, Trick, Psyshock, CalmMind, Toxic, HiddenPower, SunnyDay, Taunt, HyperBeam, LightScreen, Protect, RainDance, Safeguard, Frustration, Return, psychic, ShadowBall, DoubleTeam, Reflect, Torment, Facade, Rest, Attract, Thief, Round, FocusBlast, EnergyBall, Fling, ChargeBeam, Embargo, GigaImpact, ThunderWave, PsychUp, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, TrickRoom, DazzlingGleam, Confide, Barrier, Encore, FirePunch, GuardSplit, GuardSwap, IcePunch, KnockOff, PowerTrick, PsychoShift, SkillSwap, ThunderPunch });
        public static readonly Pokemon Machop = new Pokemon(66, "Machop", Fighting, Typeless, new Ability[] { Guts, NoGuard, Steadfast }, new double[] { 70, 80, 50, 35, 35, 35, 43.0 }, new Move[] { LowKick, Leer, FocusEnergy, KarateChop, Foresight, LowSweep, SeismicToss, Revenge, KnockOff, VitalThrow, WakeUpSlap, DualChop, Submission, BulkUp, CrossChop, ScaryFace, DynamicPunch, WorkUp, Toxic, HiddenPower, SunnyDay, LightScreen, Protect, RainDance, Frustration, SmackDown, Earthquake, Return, BrickBreak, DoubleTeam, Flamethrower, FireBlast, RockTomb, Facade, Rest, Attract, Thief, Round, FocusBlast, Fling, Payback, Bulldoze, RockSlide, PoisonJab, Swagger, SleepTalk, Substitute, Confide, BulletPunch, CloseCombat, Counter, Encore, FirePunch, HeavySlam, IcePunch, KnockOff, Meditate, PowerTrick, QuickGuard, RollingKick, SmellingSalts, ThunderPunch, Tickle });
        public static readonly Pokemon Machoke = new Pokemon(67, "Machoke", Fighting, Typeless, new Ability[] { Guts, NoGuard, Steadfast }, new double[] { 80, 100, 70, 50, 60, 45, 155.4 }, new Move[] { LowKick, Leer, FocusEnergy, KarateChop, Foresight, LowSweep, SeismicToss, Revenge, KnockOff, VitalThrow, WakeUpSlap, DualChop, Submission, BulkUp, CrossChop, ScaryFace, DynamicPunch, WorkUp, Toxic, HiddenPower, SunnyDay, LightScreen, Protect, RainDance, Frustration, SmackDown, Earthquake, Return, BrickBreak, DoubleTeam, Flamethrower, FireBlast, RockTomb, Facade, Rest, Attract, Thief, Round, FocusBlast, Fling, Payback, Bulldoze, RockSlide, PoisonJab, Swagger, SleepTalk, Substitute, Confide, BulletPunch, CloseCombat, Counter, Encore, FirePunch, HeavySlam, IcePunch, KnockOff, Meditate, PowerTrick, QuickGuard, RollingKick, SmellingSalts, ThunderPunch, Tickle });
        public static readonly Pokemon Machamp = new Pokemon(68, "Machamp", Fighting, Typeless, new Ability[] { Guts, NoGuard, Steadfast }, new double[] { 90, 130, 80, 65, 85, 55, 286.6 }, new Move[] { Strength, WideGuard, LowKick, Leer, FocusEnergy, KarateChop, Foresight, LowSweep, SeismicToss, Revenge, KnockOff, VitalThrow, WakeUpSlap, DualChop, Submission, BulkUp, CrossChop, ScaryFace, DynamicPunch, WorkUp, Toxic, HiddenPower, SunnyDay, HyperBeam, LightScreen, Protect, RainDance, Frustration, SmackDown, Earthquake, Return, BrickBreak, DoubleTeam, Flamethrower, FireBlast, RockTomb, Facade, Rest, Attract, Thief, Round, FocusBlast, Fling, Payback, GigaImpact, StoneEdge, Bulldoze, RockSlide, PoisonJab, Swagger, SleepTalk, Substitute, Confide, BulletPunch, CloseCombat, Counter, Encore, FirePunch, HeavySlam, IcePunch, KnockOff, Meditate, PowerTrick, QuickGuard, RollingKick, SmellingSalts, ThunderPunch, Tickle });
        public static readonly Pokemon Bellsprout = new Pokemon(69, "Bellsprout", Grass, Poison, new Ability[] { Chlorophyll, Gluttony }, new double[] { 50, 75, 35, 70, 30, 40, 8.8 }, new Move[] { VineWhip, Growth, Wrap, SleepPowder, PoisonPowder, StunSpore, Acid, KnockOff, SweetScent, GastroAcid, RazorLeaf, PoisonJab, Slam, WringOut, Toxic, Venoshock, HiddenPower, SunnyDay, Protect, Frustration, SolarBeam, Return, DoubleTeam, Reflect, SludgeBomb, Facade, Rest, Attract, Thief, Round, EnergyBall, SwordsDance, Infestation, PoisonJab, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, Confide, AcidSpray, Belch, BulletSeed, ClearSmog, Encore, GigaDrain, Ingrain, LeechLife, MagicalLeaf, NaturalGift, PowerWhip, Synthesis, Tickle, WeatherBall, WorrySeed });
        public static readonly Pokemon Weepinbell = new Pokemon(70, "Weepinbell", Grass, Poison, new Ability[] { Chlorophyll, Gluttony }, new double[] { 65, 90, 50, 85, 45, 55, 14.1 }, new Move[] { VineWhip, Growth, Wrap, SleepPowder, PoisonPowder, StunSpore, Acid, KnockOff, SweetScent, GastroAcid, RazorLeaf, PoisonJab, Slam, WringOut, Toxic, Venoshock, HiddenPower, SunnyDay, Protect, Frustration, SolarBeam, Return, DoubleTeam, Reflect, SludgeBomb, Facade, Rest, Attract, Thief, Round, EnergyBall, SwordsDance, Infestation, PoisonJab, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, Confide, AcidSpray, Belch, BulletSeed, ClearSmog, Encore, GigaDrain, Ingrain, LeechLife, MagicalLeaf, NaturalGift, PowerWhip, Synthesis, Tickle, WeatherBall, WorrySeed });
        public static readonly Pokemon Victreebel = new Pokemon(71, "Victreebel", Grass, Poison, new Ability[] { Chlorophyll, Gluttony }, new double[] { 80, 105, 65, 100, 60, 70, 34.2 }, new Move[] { LeafTornado, Stockpile, Swallow, SpitUp, VineWhip, SleepPowder, SweetScent, RazorLeaf, LeafStorm, LeafBlade, Toxic, Venoshock, HiddenPower, SunnyDay, HyperBeam, Protect, Frustration, SolarBeam, Return, DoubleTeam, Reflect, SludgeBomb, Facade, Rest, Attract, Thief, Round, EnergyBall, GigaImpact, SwordsDance, Infestation, PoisonJab, GrassKnot, Swagger, SleepTalk, Substitute, NaturePower, Confide, AcidSpray, Belch, BulletSeed, ClearSmog, Encore, GigaDrain, Ingrain, LeechLife, MagicalLeaf, NaturalGift, PowerWhip, Synthesis, Tickle, WeatherBall, WorrySeed, Growth, Wrap, PoisonPowder, StunSpore, Acid, KnockOff, GastroAcid, Slam, WringOut });
        public static readonly Pokemon Tentacool = new Pokemon(72, "Tentacool", Water, Poison, new Ability[] { ClearBody, LiquidOoze, RainDish }, new double[] { 40, 40, 35, 50, 100, 70, 100.3 }, new Move[] { PoisonSting, Supersonic, Constrict, Acid, ToxicSpikes, WaterPulse, Wrap, AcidSpray, BubbleBeam, Barrier, PoisonJab, Brine, Screech, Hex, SludgeWave, HydroPump, WringOut, Toxic, Hail, Venoshock, HiddenPower, IceBeam, Blizzard, Protect, RainDance, Safeguard, Frustration, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Thief, Round, Scald, Payback, SwordsDance, Infestation, PoisonJab, Swagger, SleepTalk, Substitute, Surf, Waterfall, DazzlingGleam, Confide, Acupressure, AquaRing, AuroraBeam, Bubble, ConfuseRay, Haze, KnockOff, MirrorCoat, MuddyWater, RapidSpin, Tickle });
        public static readonly Pokemon Tentacruel = new Pokemon(73, "Tentacruel", Water, Poison, new Ability[] { ClearBody, LiquidOoze, RainDish }, new double[] { 80, 70, 65, 80, 120, 100, 121.3 }, new Move[] { ReflectType, WringOut, PoisonSting, Supersonic, Constrict, Acid, ToxicSpikes, WaterPulse, Wrap, AcidSpray, BubbleBeam, Barrier, PoisonJab, Brine, Screech, Hex, SludgeWave, HydroPump, Toxic, Hail, Venoshock, HiddenPower, IceBeam, Blizzard, HyperBeam, Protect, RainDance, Safeguard, Frustration, Return, DoubleTeam, SludgeBomb, Facade, Rest, Attract, Thief, Round, Scald, Payback, GigaImpact, SwordsDance, Infestation, PoisonJab, Swagger, SleepTalk, Substitute, Surf, Waterfall, DazzlingGleam, Confide, Acupressure, AquaRing, AuroraBeam, Bubble, ConfuseRay, Haze, KnockOff, MirrorCoat, MuddyWater, RapidSpin, Tickle });
        public static readonly Pokemon Geodude = new Pokemon(74, "Geodude", Rock, Ground, new Ability[] { RockHead, Sturdy, SandVeil }, new double[] { 40, 80, 100, 30, 30, 20, 44.1 }, new Move[] { Tackle, DefenseCurl, MudSport, RockPolish, Rollout, Magnitude, RockThrow, SmackDown, Bulldoze, SelfDestruct, RockBlast, Earthquake, Explosion, DoubleEdge, StoneEdge, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, BrickBreak, DoubleTeam, Flamethrower, Sandstorm, FireBlast, RockTomb, Facade, Rest, Attract, Round, Fling, RockPolish, GyroBall, RockSlide, Swagger, SleepTalk, Substitute, NaturePower, Confide, Autotomize, Block, NonGhostCurse, Endure, Flail, FocusPunch, HammerArm, MegaPunch, RockClimb, WideGuard });
        public static readonly Pokemon AlolanGeodude = new Pokemon(-74, "Alolan Geodude", Rock, Electric, new Ability[] { MagnetPull, Sturdy, Galvanize }, new double[] { 40, 80, 100, 30, 30, 20, 44.8 }, new Move[] { Tackle, DefenseCurl, Charge, RockPolish, Rollout, Spark, RockThrow, SmackDown, ThunderPunch, SelfDestruct, StealthRock, RockBlast, Discharge, Explosion, DoubleEdge, StoneEdge, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Thunderbolt, Thunder, Earthquake, Return, BrickBreak, DoubleTeam, Flamethrower, Sandstorm, FireBlast, RockTomb, Facade, Rest, Attract, Round, Fling, ChargeBeam, BrutalSwing, VoltSwitch, GyroBall, Bulldoze, RockSlide, Swagger, SleepTalk, Substitute, NaturePower, Confide, Autotomize, Block, Counter, NonGhostCurse, Endure, Flail, MagnetRise, RockClimb, Screech, WideGuard });
        public static readonly Pokemon Graveler = new Pokemon(75, "Graveler", Rock, Ground, new Ability[] { RockHead, Sturdy, SandVeil }, new double[] { 55, 95, 115, 45, 45, 35, 231.5 }, new Move[] { Tackle, DefenseCurl, MudSport, RockPolish, Rollout, Magnitude, RockThrow, SmackDown, Bulldoze, SelfDestruct, StealthRock, RockBlast, Earthquake, Explosion, DoubleEdge, StoneEdge, Toxic, HiddenPower, SunnyDay, Protect, Frustration, Return, BrickBreak, DoubleTeam, Flamethrower, Sandstorm, FireBlast, RockTomb, Facade, Rest, Attract, Round, Fling, GyroBall, RockSlide, Swagger, SleepTalk, Substitute, NaturePower, Confide, Autotomize, Block, NonGhostCurse, Endure, Flail, FocusPunch, HammerArm, MegaPunch, RockClimb, WideGuard });
        public static readonly Pokemon AlolanGraveler = new Pokemon(-75, "Alolan Graveler", Rock, Electric, new Ability[] { MagnetPull, Sturdy, Galvanize }, new double[] { 55, 95, 115, 45, 45, 35, 242.5 }, new Move[] { Tackle, DefenseCurl, Charge, RockPolish, Rollout, Spark, RockThrow, SmackDown, ThunderPunch, SelfDestruct, StealthRock, RockBlast, Discharge, Explosion, DoubleEdge, StoneEdge, Toxic, HiddenPower, SunnyDay, Protect, Frustration, SmackDown, Thunderbolt, Thunder, Earthquake, Return, BrickBreak, DoubleTeam, Flamethrower, Sandstorm, FireBlast, RockTomb, Facade, Rest, Attract, Round, Fling, ChargeBeam, BrutalSwing, Explosion, RockPolish, VoltSwitch, GyroBall, Bulldoze, RockSlide, Swagger, SleepTalk, Substitute, NaturePower, Confide, Autotomize, Block, Counter, NonGhostCurse, Endure, Flail, MagnetRise, RockClimb, Screech, WideGuard });
        public static readonly Pokemon Golem = new Pokemon(76, "Golem", Rock, Ground, new Ability[] { RockHead, Sturdy, SandVeil }, new double[] { 80, 120, 130, 55, 65, 45, 661.4 }, new Move[] { HeavySlam, Tackle, DefenseCurl, MudSport, RockPolish, Steamroller, Magnitude, RockThrow, SmackDown, Bulldoze, SelfDestruct, StealthRock, RockBlast, Earthquake, Explosion, DoubleEdge, StoneEdge, Roar, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, Frustration, Return, BrickBreak, DoubleTeam, Flamethrower, Sandstorm, FireBlast, RockTomb, Facade, Rest, Attract, Round, FocusBlast, Fling, GigaImpact, RockPolish, GyroBall, RockSlide, Swagger, SleepTalk, Substitute, NaturePower, Confide, Autotomize, Block, NonGhostCurse, Endure, Flail, FocusPunch, HammerArm, MegaPunch, RockClimb, WideGuard, Rollout });
        public static readonly Pokemon AlolanGolem = new Pokemon(-76, "Alolan Golem", Rock, Electric, new Ability[] { MagnetPull, Sturdy, Galvanize }, new double[] { 80, 120, 130, 55, 65, 45, 696.7 }, new Move[] { HeavySlam, Tackle, DefenseCurl, Charge, RockPolish, Steamroller, Spark, RockThrow, SmackDown, ThunderPunch, SelfDestruct, StealthRock, RockBlast, Discharge, Explosion, DoubleEdge, StoneEdge, Roar, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, Frustration, SmackDown, Thunderbolt, Thunder, Earthquake, Return, BrickBreak, DoubleTeam, Flamethrower, Sandstorm, FireBlast, RockTomb, Facade, Rest, Attract, Round, EchoedVoice, FocusBlast, Fling, ChargeBeam, BrutalSwing, GigaImpact, VoltSwitch, GyroBall, RockSlide, Swagger, SleepTalk, Substitute, WildCharge, NaturePower, Confide, Autotomize, Block, Counter, NonGhostCurse, Endure, Flail, MagnetRise, RockClimb, Screech, WideGuard, Rollout });
        public static readonly Pokemon Ponyta = new Pokemon(77, "Ponyta", Fire, Typeless, new Ability[] { RunAway, FlashFire, FlameBody }, new double[] { 50, 85, 55, 65, 65, 90, 66.1 }, new Move[] { Growl, Tackle, TailWhip, Ember, FlameWheel, Stomp, FlameCharge, FireSpin, TakeDown, Inferno, Agility, FireBlast, Bounce, FlareBlitz, Toxic, HiddenPower, SunnyDay, Protect, Frustration, SolarBeam, Return, DoubleTeam, Flamethrower, FireBlast, Facade, FlameCharge, Rest, Attract, Round, EchoedVoice, Overheat, WillOWisp, Swagger, SleepTalk, Substitute, WildCharge, Confide, AllySwitch, Captivate, Charm, DoubleEdge, DoubleKick, FlameWheel, HornDrill, Hypnosis, LowKick, MorningSun, Thrash });
        public static readonly Pokemon Rapidash = new Pokemon(78, "Rapidash", Fire, Typeless, new Ability[] { RunAway, FlashFire, FlameBody }, new double[] { 65, 100, 70, 80, 80, 105, 209.4 }, new Move[] { FuryAttack, PoisonJab, Megahorn, Growl, QuickAttack, TailWhip, Ember, FlameWheel, Stomp, FlameCharge, FireSpin, TakeDown, Inferno, Agility, FireBlast, Bounce, FlareBlitz, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, Frustration, SolarBeam, Return, DoubleTeam, Flamethrower, FireBlast, Facade, FlameCharge, Rest, Attract, Round, EchoedVoice, Overheat, WillOWisp, SmartStrike, GigaImpact, PoisonJab, Swagger, SleepTalk, Substitute, WildCharge, Confide, AllySwitch, Charm, DoubleEdge, DoubleKick, FlameWheel, HornDrill, Hypnosis, LowKick, MorningSun, Thrash, Tackle });
        public static readonly Pokemon Slowpoke = new Pokemon(79, "Slowpoke", Water, Psychic, new Ability[] { Oblivious, OwnTempo, Regenerator }, new double[] { 90, 65, 65, 40, 40, 15, 79.4 }, new Move[] { NonGhostCurse, Yawn, Tackle, Growl, WaterGun, Confusion, Disable, Headbutt, WaterPulse, ZenHeadbutt, SlackOff, Amnesia, psychic, RainDance, PsychUp, HealPulse, Psyshock, CalmMind, Toxic, Hail, HiddenPower, SunnyDay, IceBeam, Blizzard, LightScreen, Protect, RainDance, Safeguard, Frustration, Earthquake, Return, psychic, ShadowBall, DoubleTeam, Flamethrower, FireBlast, Facade, Rest, Attract, Round, EchoedVoice, Scald, ThunderWave, PsychUp, Bulldoze, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, TrickRoom, Surf, Confide, Belch, BellyDrum, Block, FutureSight, MeFirst, MudSport, Snore, Stomp, WonderRoom });
        public static readonly Pokemon Slowbro = new Pokemon(80, "Slowbro", Water, Psychic, new Ability[] { Oblivious, OwnTempo, Regenerator }, new double[] { 95, 75, 110, 100, 80, 30, 173.1 }, new Move[] { Withdraw, HealPulse, NonGhostCurse, Yawn, Tackle, Growl, WaterGun, Confusion, Disable, Headbutt, WaterPulse, ZenHeadbutt, SlackOff, Amnesia, psychic, RainDance, PsychUp, Psyshock, CalmMind, Toxic, Hail, HiddenPower, SunnyDay, IceBeam, Blizzard, HyperBeam, LightScreen, Protect, RainDance, Safeguard, Frustration, Earthquake, Return, psychic, ShadowBall, BrickBreak, DoubleTeam, Flamethrower, FireBlast, AerialAce, Facade, Rest, Attract, Round, EchoedVoice, FocusBlast, Scald, Fling, GigaImpact, ThunderWave, PsychUp, Bulldoze, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, TrickRoom, Surf, Confide, Belch, BellyDrum, Block, FutureSight, MeFirst, MudSport, SleepTalk, Snore, Stomp, WonderRoom });
        public static readonly Pokemon MegaSlowbro = new Pokemon(-80, "Mega Slowbro", Water, Psychic, new Ability[] { ShellArmor }, new double[] { 95, 75, 180, 130, 80, 30, 264.6 }, new Move[] { Withdraw, HealPulse, NonGhostCurse, Yawn, Tackle, Growl, WaterGun, Confusion, Disable, Headbutt, WaterPulse, ZenHeadbutt, SlackOff, Amnesia, psychic, RainDance, PsychUp, Psyshock, CalmMind, Toxic, Hail, HiddenPower, SunnyDay, IceBeam, Blizzard, HyperBeam, LightScreen, Protect, RainDance, Safeguard, Frustration, Earthquake, Return, psychic, ShadowBall, BrickBreak, DoubleTeam, Flamethrower, FireBlast, AerialAce, Facade, Rest, Attract, Round, EchoedVoice, FocusBlast, Scald, Fling, GigaImpact, ThunderWave, PsychUp, Bulldoze, DreamEater, GrassKnot, Swagger, SleepTalk, Substitute, TrickRoom, Surf, Confide, Belch, BellyDrum, Block, FutureSight, MeFirst, MudSport, SleepTalk, Snore, Stomp, WonderRoom });
        public static readonly Pokemon Magnemite = new Pokemon(81, "Magnemite", Electric, Steel, new Ability[] { MagnetPull, Sturdy, Analytic }, new double[] { 25, 35, 70, 95, 55, 45, 13.2 }, new Move[] { Tackle, Supersonic, ThunderShock, MagnetBomb, ThunderWave, LightScreen, SonicBoom, Spark, MirrorShot, MetalSound, ElectroBall, FlashCannon, Screech, Discharge, LockOn, MagnetRise, GyroBall, ZapCannon, Toxic, HiddenPower, SunnyDay, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, DoubleTeam, Reflect, Facade, Rest, Round, ChargeBeam, Explosion, VoltSwitch, ThunderWave, GyroBall, PsychUp, Swagger, SleepTalk, Substitute, FlashCannon, WildCharge, Confide });
        public static readonly Pokemon Magneton = new Pokemon(82, "Magneton", Electric, Steel, new Ability[] { MagnetPull, Sturdy, Analytic }, new double[] { 50, 60, 95, 120, 70, 70, 132.3 }, new Move[] { TriAttack, ZapCannon, ElectricTerrain, Tackle, Supersonic, ThunderShock, MagnetBomb, ThunderWave, LightScreen, SonicBoom, Spark, MirrorShot, MetalSound, ElectroBall, FlashCannon, Screech, Discharge, LockOn, MagnetRise, GyroBall, Toxic, HiddenPower, SunnyDay, HyperBeam, Protect, RainDance, Frustration, Thunderbolt, Thunder, Return, DoubleTeam, Reflect, Facade, Rest, Round, ChargeBeam, Explosion, GigaImpact, VoltSwitch, ThunderWave, PsychUp, Swagger, SleepTalk, Substitute, WildCharge, Confide });
        public static readonly Pokemon Farfetchd = new Pokemon(83, "Farfetch'd", Normal, Flying, new Ability[] { KeenEye, InnerFocus, Defiant }, new double[] { 52, 90, 55, 58, 62, 60, 33.1 }, new Move[] { BraveBird, PoisonJab, Peck, SandAttack, Leer, FuryCutter, FuryAttack, AerialAce, KnockOff, Slash, AirCutter, SwordsDance, Agility, NightSlash, Acrobatics, Feint, FalseSwipe, AirSlash, WorkUp, Toxic, HiddenPower, SunnyDay, Protect, Roost, Frustration, Return, DoubleTeam, Facade, Rest, Attract, Thief, Round, SteelWing, FalseSwipe, BrutalSwing, SwordsDance, Fly, PsychUp, PoisonJab, Swagger, SleepTalk, UTurn, Substitute, Confide, Covet, NonGhostCurse, FeatherDance, Flail, Foresight, Gust, LeafBlade, MirrorMove, MudSlap, NightSlash, QuickAttack, Revenge, SimpleBeam, TrumpCard });
        public static readonly Pokemon Doduo = new Pokemon(84, "Doduo", Normal, Flying, new Ability[] { RunAway, EarlyBird, TangledFeet }, new double[] { 35, 85, 45, 35, 35, 75, 86.4 }, new Move[] { Peck, Growl, QuickAttack, Rage, FuryAttack, Pursuit, Pluck, DoubleHit, Agility, Uproar, Acupressure, SwordsDance, JumpKick, DrillPeck, Endeavor, Thrash, WorkUp, Toxic, HiddenPower, SunnyDay, Protect, Roost, Frustration, Return, DoubleTeam, AerialAce, Facade, Rest, Attract, Thief, Round, EchoedVoice, SteelWing, Fly, Swagger, SleepTalk, Substitute, Confide, Assurance, BraveBird, Endeavor, FeintAttack, Flail, Haze, MirrorMove, NaturalGift, Supersonic });
        public static readonly Pokemon Dodrio = new Pokemon(85, "Dodrio", Normal, Flying, new Ability[] { RunAway, EarlyBird, TangledFeet }, new double[] { 60, 110, 70, 60, 60, 110, 187.8 }, new Move[] { TriAttack, Peck, Growl, QuickAttack, Rage, FuryAttack, Pursuit, Pluck, DoubleHit, Agility, Uproar, Acupressure, SwordsDance, JumpKick, DrillPeck, Endeavor, Thrash, WorkUp, Toxic, HiddenPower, SunnyDay, Taunt, HyperBeam, Protect, Roost, Frustration, Return, DoubleTeam, AerialAce, Torment, Facade, Rest, Attract, Thief, Round, EchoedVoice, SteelWing, Payback, GigaImpact, Fly, Swagger, SleepTalk, Substitute, Confide, Assurance, BraveBird, FeintAttack, Flail, Haze, MirrorMove, NaturalGift, Supersonic });
        public static readonly Pokemon Seel;
        public static readonly Pokemon Dewgong;
        public static readonly Pokemon Grimer;
        public static readonly Pokemon AlolanGrimer;
        public static readonly Pokemon Muk;
        public static readonly Pokemon AlolanMuk;
        public static readonly Pokemon Shellder;
        public static readonly Pokemon Cloyster;
        public static readonly Pokemon Gastly;
        public static readonly Pokemon Haunter;
        public static readonly Pokemon Gengar;
        public static readonly Pokemon MegaGengar;
        public static readonly Pokemon Onix;
        public static readonly Pokemon Drowzee;
        public static readonly Pokemon Hypno;
        public static readonly Pokemon Krabby;
        public static readonly Pokemon Kingler;
        public static readonly Pokemon Voltorb;
        public static readonly Pokemon Electrode;
        public static readonly Pokemon Exeggcute;
        public static readonly Pokemon Exeggutor;
        public static readonly Pokemon AlolanExeggutor;
        public static readonly Pokemon Cubone;
        public static readonly Pokemon Marowak;
        public static readonly Pokemon AlolanMarowak;
        public static readonly Pokemon Hitmonlee;
        public static readonly Pokemon Hitmonchan;
        public static readonly Pokemon Lickitung;
        public static readonly Pokemon Koffing;
        public static readonly Pokemon Weezing;
        public static readonly Pokemon Rhyhorn;
        public static readonly Pokemon Rhydon;
        public static readonly Pokemon Chansey;
        public static readonly Pokemon Tangela;
        public static readonly Pokemon Kangaskhan;
        public static readonly Pokemon AlolanKangaskhan;
        public static readonly Pokemon Horsea;
        public static readonly Pokemon Seadra;
        public static readonly Pokemon Goldeen;
        public static readonly Pokemon Seaking;
        public static readonly Pokemon Staryu;
        public static readonly Pokemon Starmie;
        public static readonly Pokemon MrMime;
        public static readonly Pokemon Scyther;
        public static readonly Pokemon Jynx;
        public static readonly Pokemon Electabuzz;
        public static readonly Pokemon Magmar;
        public static readonly Pokemon Pinsir;
        public static readonly Pokemon MegaPinsir;
        public static readonly Pokemon Tauros;
        public static readonly Pokemon Magikarp;
        public static readonly Pokemon Gyarados;
        public static readonly Pokemon MegaGyarados;
        public static readonly Pokemon Lapras;
        public static readonly Pokemon Ditto;
        public static readonly Pokemon Eevee;
        public static readonly Pokemon Vaporeon;
        public static readonly Pokemon Jolteon;
        public static readonly Pokemon Flareon;
        public static readonly Pokemon Porygon;
        public static readonly Pokemon Omanyte;
        public static readonly Pokemon Omaster;
        public static readonly Pokemon Kabuto;
        public static readonly Pokemon Kabutops;
        public static readonly Pokemon Aerodactyl;
        public static readonly Pokemon MegaAerodactyl;
        public static readonly Pokemon Snorlax;
        public static readonly Pokemon Articuno;
        public static readonly Pokemon Zapdos;
        public static readonly Pokemon Moltres;
        public static readonly Pokemon Dratini;
        public static readonly Pokemon Dragonair;
        public static readonly Pokemon Dragonite;
        public static readonly Pokemon Mewtwo;
        public static readonly Pokemon MegaMewtwoX;
        public static readonly Pokemon MegaMewtwoY;
        public static readonly Pokemon Mew;
        #endregion

        #region Johto
        public static readonly Pokemon Chikorita;
        public static readonly Pokemon Bayleef;
        public static readonly Pokemon Meganium;
        public static readonly Pokemon Cyndaquil;
        public static readonly Pokemon Quilava;
        public static readonly Pokemon Typhlosion;
        public static readonly Pokemon Totodile;
        public static readonly Pokemon Croconaw;
        public static readonly Pokemon Feraligatr;
        public static readonly Pokemon Sentret;
        public static readonly Pokemon Furret;
        public static readonly Pokemon Hoothoot;
        public static readonly Pokemon Noctowl;
        public static readonly Pokemon Ledyba;
        public static readonly Pokemon Ledian;
        public static readonly Pokemon Spinarak;
        public static readonly Pokemon Ariados;
        public static readonly Pokemon Crobat;
        public static readonly Pokemon Chinchou;
        public static readonly Pokemon Lanturn;
        public static readonly Pokemon Pichu;
        public static readonly Pokemon Cleffa;
        public static readonly Pokemon Igglybuff;
        public static readonly Pokemon Togepi;
        public static readonly Pokemon Togetic;
        public static readonly Pokemon Natu;
        public static readonly Pokemon Xatu;
        public static readonly Pokemon Mareep;
        public static readonly Pokemon Flaaffy;
        public static readonly Pokemon Ampharos;
        public static readonly Pokemon MegaAmpharos;
        public static readonly Pokemon Bellossom;
        public static readonly Pokemon Marill;
        public static readonly Pokemon Azumarill;
        public static readonly Pokemon Sudowoodo;
        public static readonly Pokemon Politoed;
        public static readonly Pokemon Hoppip;
        public static readonly Pokemon Skiploom;
        public static readonly Pokemon Jumpluff;
        public static readonly Pokemon Aipom;
        public static readonly Pokemon Sunkern;
        public static readonly Pokemon Sunflora;
        public static readonly Pokemon Yanma;
        public static readonly Pokemon Wooper;
        public static readonly Pokemon Quagsire;
        public static readonly Pokemon Espeon;
        public static readonly Pokemon Umbreon;
        public static readonly Pokemon Murkrow;
        public static readonly Pokemon Slowking;
        public static readonly Pokemon Misdreavus;
        public static readonly Pokemon Unown;
        public static readonly Pokemon Wobbuffet;
        public static readonly Pokemon Girafarig;
        public static readonly Pokemon Pineco;
        public static readonly Pokemon Forretress;
        public static readonly Pokemon Dunsparce;
        public static readonly Pokemon Gligar;
        public static readonly Pokemon Steelix;
        public static readonly Pokemon MegaSteelix;
        public static readonly Pokemon Snubbull;
        public static readonly Pokemon Granbull;
        public static readonly Pokemon Qwilfish;
        public static readonly Pokemon Scizor;
        public static readonly Pokemon MegaScizor;
        public static readonly Pokemon Shuckle;
        public static readonly Pokemon Heracross;
        public static readonly Pokemon MegaHeracross;
        public static readonly Pokemon Sneasel;
        public static readonly Pokemon Teddiursa;
        public static readonly Pokemon Ursaring;
        public static readonly Pokemon Slugma;
        public static readonly Pokemon Magcargo;
        public static readonly Pokemon Swinub;
        public static readonly Pokemon Piloswine;
        public static readonly Pokemon Corsola;
        public static readonly Pokemon Reomraid;
        public static readonly Pokemon Octillery;
        public static readonly Pokemon Delibird;
        public static readonly Pokemon Mantine;
        public static readonly Pokemon Skarmory;
        public static readonly Pokemon Houndour;
        public static readonly Pokemon Houndoom;
        public static readonly Pokemon MegaHoundoom;
        public static readonly Pokemon Kingdra;
        public static readonly Pokemon Phanpy;
        public static readonly Pokemon Donphan;
        public static readonly Pokemon Porygon2;
        public static readonly Pokemon Stantler;
        public static readonly Pokemon Smeargle;
        public static readonly Pokemon Tyrogue;
        public static readonly Pokemon Hitmontop;
        public static readonly Pokemon Smoochum;
        public static readonly Pokemon Elekid;
        public static readonly Pokemon Magby;
        public static readonly Pokemon Miltank;
        public static readonly Pokemon Blissey;
        public static readonly Pokemon Raikou;
        public static readonly Pokemon Entei;
        public static readonly Pokemon Suicune;
        public static readonly Pokemon Larvitar;
        public static readonly Pokemon Pupitar;
        public static readonly Pokemon Tyranitar;
        public static readonly Pokemon MegaTyranitar;
        public static readonly Pokemon Lugia;
        public static readonly Pokemon HoOh;
        public static readonly Pokemon Celebi;
        #endregion

        #region Hoenn
        public static readonly Pokemon Treecko;
        public static readonly Pokemon Grovyle;
        public static readonly Pokemon Sceptile;
        public static readonly Pokemon MegaSceptile;
        public static readonly Pokemon Torchic;
        public static readonly Pokemon Combusken;
        public static readonly Pokemon Blaziken;
        public static readonly Pokemon MegaBlaziken;
        public static readonly Pokemon Mudkip;
        public static readonly Pokemon Marshtomp;
        public static readonly Pokemon Swampert;
        public static readonly Pokemon MegaSwampert;
        public static readonly Pokemon Poochyena;
        public static readonly Pokemon Mightyena;
        public static readonly Pokemon Zigzagoon;
        public static readonly Pokemon Linoone;
        public static readonly Pokemon Wurmple;
        public static readonly Pokemon Silcoon;
        public static readonly Pokemon Beautifly;
        public static readonly Pokemon Cascoon;
        public static readonly Pokemon Dustox;
        public static readonly Pokemon Lotad;
        public static readonly Pokemon Lombre;
        public static readonly Pokemon Ludicolo;
        public static readonly Pokemon Seedot;
        public static readonly Pokemon Nuzleaf;
        public static readonly Pokemon Shiftry;
        public static readonly Pokemon Taillow;
        public static readonly Pokemon Swellow;
        public static readonly Pokemon Wingull;
        public static readonly Pokemon Pelipper;
        public static readonly Pokemon Ralts;
        public static readonly Pokemon Kirlia;
        public static readonly Pokemon Gardevoir;
        public static readonly Pokemon MegaGardevoir;
        public static readonly Pokemon Surskit;
        public static readonly Pokemon Masquerain;
        public static readonly Pokemon Shroomish;
        public static readonly Pokemon Breloom;
        public static readonly Pokemon Slakoth;
        public static readonly Pokemon Vigoroth;
        public static readonly Pokemon Slaking;
        public static readonly Pokemon Nincada;
        public static readonly Pokemon Ninjask;
        public static readonly Pokemon Shedinja;
        public static readonly Pokemon Whismur;
        public static readonly Pokemon Loudred;
        public static readonly Pokemon Exploud;
        public static readonly Pokemon Makuhita;
        public static readonly Pokemon Hariyama;
        public static readonly Pokemon Azurill;
        public static readonly Pokemon Nosepass;
        public static readonly Pokemon Skitty;
        public static readonly Pokemon Delcatty;
        public static readonly Pokemon Sableye;
        public static readonly Pokemon MegaSableye;
        public static readonly Pokemon Mawile;
        public static readonly Pokemon MegaMawile;
        public static readonly Pokemon Aron;
        public static readonly Pokemon Lairon;
        public static readonly Pokemon Aggron;
        public static readonly Pokemon MegaAggron;
        public static readonly Pokemon Meditite;
        public static readonly Pokemon Medicham;
        public static readonly Pokemon MegaMedicham;
        public static readonly Pokemon Electrike;
        public static readonly Pokemon Manectric;
        public static readonly Pokemon MegaManectric;
        public static readonly Pokemon Plusle;
        public static readonly Pokemon Minun;
        public static readonly Pokemon Volbeat;
        public static readonly Pokemon Illumise;
        public static readonly Pokemon Roselia;
        public static readonly Pokemon Gulpin;
        public static readonly Pokemon Swalot;
        public static readonly Pokemon Carvanha;
        public static readonly Pokemon Sharpedo;
        public static readonly Pokemon MegaSharpedo;
        public static readonly Pokemon Wailmer;
        public static readonly Pokemon Wailord;
        public static readonly Pokemon Numel;
        public static readonly Pokemon Camerupt;
        public static readonly Pokemon MegaCamerupt;
        public static readonly Pokemon Torkoal;
        public static readonly Pokemon Spoink;
        public static readonly Pokemon Grumpig;
        public static readonly Pokemon Spinda;
        public static readonly Pokemon Trapinch;
        public static readonly Pokemon Vibrava;
        public static readonly Pokemon Flygon;
        public static readonly Pokemon Cacnea;
        public static readonly Pokemon Cacturne;
        public static readonly Pokemon Swablu;
        public static readonly Pokemon Altaria;
        public static readonly Pokemon MegaAltaria;
        public static readonly Pokemon Zangoose;
        public static readonly Pokemon Seviper;
        public static readonly Pokemon Lunatone;
        public static readonly Pokemon Solrock;
        public static readonly Pokemon Barboach;
        public static readonly Pokemon Whiscash;
        public static readonly Pokemon Corphish;
        public static readonly Pokemon Crawdaunt;
        public static readonly Pokemon Baltoy;
        public static readonly Pokemon Claydol;
        public static readonly Pokemon Lileep;
        public static readonly Pokemon Cradily;
        public static readonly Pokemon Anorith;
        public static readonly Pokemon Armaldo;
        public static readonly Pokemon Feebas;
        public static readonly Pokemon Milotic;
        public static readonly Pokemon Castform;
        public static readonly Pokemon Kecleon;
        public static readonly Pokemon Shuppet;
        public static readonly Pokemon Banette;
        public static readonly Pokemon MegaBanette;
        public static readonly Pokemon Duskull;
        public static readonly Pokemon Dusclops;
        public static readonly Pokemon Tropius;
        public static readonly Pokemon Chimecho;
        public static readonly Pokemon Absol;
        public static readonly Pokemon MegaAbsol;
        public static readonly Pokemon Wynaut;
        public static readonly Pokemon Snorunt;
        public static readonly Pokemon Glalie;
        public static readonly Pokemon MegaGlalie;
        public static readonly Pokemon Spheal;
        public static readonly Pokemon Sealeo;
        public static readonly Pokemon Walrein;
        public static readonly Pokemon Clamperl;
        public static readonly Pokemon Huntail;
        public static readonly Pokemon Gorebyss;
        public static readonly Pokemon Relicanth;
        public static readonly Pokemon Luvdisc;
        public static readonly Pokemon Bagon;
        public static readonly Pokemon Shelgon;
        public static readonly Pokemon Salamence;
        public static readonly Pokemon MegaSalamence;
        public static readonly Pokemon Beldum;
        public static readonly Pokemon Metang;
        public static readonly Pokemon Metagross;
        public static readonly Pokemon MegaMetagross;
        public static readonly Pokemon Regirock;
        public static readonly Pokemon Regice;
        public static readonly Pokemon Registeel;
        public static readonly Pokemon Latias;
        public static readonly Pokemon MegaLatias;
        public static readonly Pokemon Latios;
        public static readonly Pokemon MegaLatios;
        public static readonly Pokemon Kyogre;
        public static readonly Pokemon PrimalKyogre;
        public static readonly Pokemon Groudon;
        public static readonly Pokemon PrimalGroudon;
        public static readonly Pokemon Rayquaza;
        public static readonly Pokemon MegaRayquaza;
        public static readonly Pokemon Jirachi;
        public static readonly Pokemon NormalDeoxys;
        public static readonly Pokemon AttackDeoxys;
        public static readonly Pokemon DefenseDeoxys;
        public static readonly Pokemon SpeedDeoxys;
        #endregion

        #region Sinnoh
        public static readonly Pokemon Turtwig;
        public static readonly Pokemon Grotle;
        public static readonly Pokemon Torterra;
        public static readonly Pokemon Chimchar;
        public static readonly Pokemon Monferno;
        public static readonly Pokemon Infernape;
        public static readonly Pokemon Piplup;
        public static readonly Pokemon Empoleon;
        public static readonly Pokemon Starly;
        public static readonly Pokemon Staravia;
        public static readonly Pokemon Staraptor;
        public static readonly Pokemon Bidoof;
        public static readonly Pokemon Bibarel;
        public static readonly Pokemon Kricketot;
        public static readonly Pokemon Kricketune;
        public static readonly Pokemon Shinx;
        public static readonly Pokemon Luxio;
        public static readonly Pokemon Luxray;
        public static readonly Pokemon Budew;
        public static readonly Pokemon Roserade;
        public static readonly Pokemon Cranidos;
        public static readonly Pokemon Rampardos;
        public static readonly Pokemon Shieldon;
        public static readonly Pokemon Bastiodon;
        public static readonly Pokemon Burmy;
        public static readonly Pokemon TrashWormadam;
        public static readonly Pokemon SandyWormadam;
        public static readonly Pokemon PlantWormadam;
        public static readonly Pokemon Mothim;
        public static readonly Pokemon Combee;
        public static readonly Pokemon Vespiquen;
        public static readonly Pokemon Pachirisu;
        public static readonly Pokemon Buizel;
        public static readonly Pokemon Floatzel;
        public static readonly Pokemon Cherubi;
        public static readonly Pokemon Cherrim;
        public static readonly Pokemon Shellos;
        public static readonly Pokemon Gastrodon;
        public static readonly Pokemon Ambipom;
        public static readonly Pokemon Drifloon;
        public static readonly Pokemon Drifblim;
        public static readonly Pokemon Buneary;
        public static readonly Pokemon Lopunny;
        public static readonly Pokemon MegaLopunny;
        public static readonly Pokemon Mismagius;
        public static readonly Pokemon Honchkrow;
        public static readonly Pokemon Glameow;
        public static readonly Pokemon Purugly;
        public static readonly Pokemon Chingling;
        public static readonly Pokemon Stunky;
        public static readonly Pokemon Skuntank;
        public static readonly Pokemon Bronzor;
        public static readonly Pokemon Bronzong;
        public static readonly Pokemon Bonsly;
        public static readonly Pokemon MimeJr;
        public static readonly Pokemon Happiny;
        public static readonly Pokemon Chatot;
        public static readonly Pokemon Spiritomb;
        public static readonly Pokemon Gible;
        public static readonly Pokemon Gabite;
        public static readonly Pokemon Garchomp;
        public static readonly Pokemon MegaGarchomp;
        public static readonly Pokemon Munchlax;
        public static readonly Pokemon Riolu;
        public static readonly Pokemon Lucario;
        public static readonly Pokemon MegaLucario;
        public static readonly Pokemon Hippopotas;
        public static readonly Pokemon Hippowdon;
        public static readonly Pokemon Skorupi;
        public static readonly Pokemon Drapion;
        public static readonly Pokemon Croagunk;
        public static readonly Pokemon Toxicroak;
        public static readonly Pokemon Carnivine;
        public static readonly Pokemon Finneon;
        public static readonly Pokemon Lumineon;
        public static readonly Pokemon Mantyke;
        public static readonly Pokemon Snover;
        public static readonly Pokemon Abomasnow;
        public static readonly Pokemon MegaAbomasnow;
        public static readonly Pokemon Weavile;
        public static readonly Pokemon Magnezone;
        public static readonly Pokemon Lickilicky;
        public static readonly Pokemon Rhyperior;
        public static readonly Pokemon Tangrowth;
        public static readonly Pokemon Electivire;
        public static readonly Pokemon Magmortar;
        public static readonly Pokemon Togekiss;
        public static readonly Pokemon Yanmega;
        public static readonly Pokemon Leafeon;
        public static readonly Pokemon Glaceon;
        public static readonly Pokemon Gliscor;
        public static readonly Pokemon Mamoswine;
        public static readonly Pokemon PorygonZ;
        public static readonly Pokemon Gallade;
        public static readonly Pokemon MegaGallade;
        public static readonly Pokemon Probopass;
        public static readonly Pokemon Dusknoir;
        public static readonly Pokemon Froslass;
        public static readonly Pokemon Rotom;
        public static readonly Pokemon FrostRotom;
        public static readonly Pokemon FanRotom;
        public static readonly Pokemon MowRotom;
        public static readonly Pokemon WashRotom;
        public static readonly Pokemon HeatRotom;
        public static readonly Pokemon Uxie;
        public static readonly Pokemon Mespirit;
        public static readonly Pokemon Azelf;
        public static readonly Pokemon Dialga;
        public static readonly Pokemon Palkia;
        public static readonly Pokemon Heatran;
        public static readonly Pokemon Regigigas;
        public static readonly Pokemon Giratina;
        public static readonly Pokemon OriginGiratina;
        public static readonly Pokemon Cresselia;
        public static readonly Pokemon Phione;
        public static readonly Pokemon Manaphy;
        public static readonly Pokemon Darkrai;
        public static readonly Pokemon Shaymin;
        public static readonly Pokemon SkyShaymin;
        public static readonly Pokemon Arceus;
        #endregion

        #region Unova
        public static readonly Pokemon Victini;
        public static readonly Pokemon Snivy;
        public static readonly Pokemon Servine;
        public static readonly Pokemon Serperior;
        public static readonly Pokemon Tepig;
        public static readonly Pokemon Pignite;
        public static readonly Pokemon Emboar;
        public static readonly Pokemon Oshawott;
        public static readonly Pokemon Dewott;
        public static readonly Pokemon Samurott;
        public static readonly Pokemon Patrat;
        public static readonly Pokemon Watchog;
        public static readonly Pokemon Lillipup;
        public static readonly Pokemon Herdier;
        public static readonly Pokemon Stoutland;
        public static readonly Pokemon Purrloin;
        public static readonly Pokemon Liepard;
        public static readonly Pokemon Pansage;
        public static readonly Pokemon Simisage;
        public static readonly Pokemon Pansear;
        public static readonly Pokemon Simisear;
        public static readonly Pokemon Panpour;
        public static readonly Pokemon Simipour;
        public static readonly Pokemon Munna;
        public static readonly Pokemon Musharna;
        public static readonly Pokemon Pidove;
        public static readonly Pokemon Tranquill;
        public static readonly Pokemon Unfezant;
        public static readonly Pokemon Blitzle;
        public static readonly Pokemon Zebstrika;
        public static readonly Pokemon Roggenrola;
        public static readonly Pokemon Boldore;
        public static readonly Pokemon Gigalith;
        public static readonly Pokemon Woobat;
        public static readonly Pokemon Swoobat;
        public static readonly Pokemon Drilbur;
        public static readonly Pokemon Excadrill;
        public static readonly Pokemon Audino;
        public static readonly Pokemon MegaAudino;
        public static readonly Pokemon Timburr;
        public static readonly Pokemon Gurdurr;
        public static readonly Pokemon Conkeldurr;
        public static readonly Pokemon Tympole;
        public static readonly Pokemon Palpitoad;
        public static readonly Pokemon Seismitoad;
        public static readonly Pokemon Throh;
        public static readonly Pokemon Sawk;
        public static readonly Pokemon Sewaddle;
        public static readonly Pokemon Swadloon;
        public static readonly Pokemon Leavanny;
        public static readonly Pokemon Venipede;
        public static readonly Pokemon Whirlipede;
        public static readonly Pokemon Scolipede;
        public static readonly Pokemon Cottonee;
        public static readonly Pokemon Whimsicott;
        public static readonly Pokemon Petilil;
        public static readonly Pokemon Lilligant;
        public static readonly Pokemon Basculin;
        public static readonly Pokemon Sandile;
        public static readonly Pokemon Krokorok;
        public static readonly Pokemon Krookodile;
        public static readonly Pokemon Darumaka;
        public static readonly Pokemon Darmanitan;
        public static readonly Pokemon ZenDarmanitan;
        public static readonly Pokemon Maractus;
        public static readonly Pokemon Dwebble;
        public static readonly Pokemon Crustle;
        public static readonly Pokemon Scraggy;
        public static readonly Pokemon Scrafty;
        public static readonly Pokemon Sigilyph;
        public static readonly Pokemon Yamask;
        public static readonly Pokemon Cofagrigus;
        public static readonly Pokemon Tirtouga;
        public static readonly Pokemon Carracosta;
        public static readonly Pokemon Archen;
        public static readonly Pokemon Archeops;
        public static readonly Pokemon Trubbish;
        public static readonly Pokemon Garbodor;
        public static readonly Pokemon Zorua;
        public static readonly Pokemon Zoroark;
        public static readonly Pokemon Minccino;
        public static readonly Pokemon Cinccino;
        public static readonly Pokemon Gothita;
        public static readonly Pokemon Gothorita;
        public static readonly Pokemon Gothitelle;
        public static readonly Pokemon Solosis;
        public static readonly Pokemon Duosion;
        public static readonly Pokemon Reuniclus;
        public static readonly Pokemon Ducklett;
        public static readonly Pokemon Swanna;
        public static readonly Pokemon Vanillite;
        public static readonly Pokemon Vanillish;
        public static readonly Pokemon Vanilluxe;
        public static readonly Pokemon Deerling;
        public static readonly Pokemon Sawsbuck;
        public static readonly Pokemon Emolga;
        public static readonly Pokemon Karrablast;
        public static readonly Pokemon Escavalier;
        public static readonly Pokemon Foongus;
        public static readonly Pokemon Amoonguss;
        public static readonly Pokemon Frillish;
        public static readonly Pokemon Jellicent;
        public static readonly Pokemon Alomomola;
        public static readonly Pokemon Joltik;
        public static readonly Pokemon Galvantula;
        public static readonly Pokemon Ferroseed;
        public static readonly Pokemon Ferrothorn;
        public static readonly Pokemon Kilnk;
        public static readonly Pokemon Klang;
        public static readonly Pokemon Klinklang;
        public static readonly Pokemon Tynamo;
        public static readonly Pokemon Eelektrik;
        public static readonly Pokemon Eelektross;
        public static readonly Pokemon Elgyem;
        public static readonly Pokemon Beheeyem;
        public static readonly Pokemon Litwick;
        public static readonly Pokemon Lampent;
        public static readonly Pokemon Chandelure;
        public static readonly Pokemon Axew;
        public static readonly Pokemon Fraxure;
        public static readonly Pokemon Haxorus;
        public static readonly Pokemon Cubchoo;
        public static readonly Pokemon Beartic;
        public static readonly Pokemon Cryogonal;
        public static readonly Pokemon Shelmet;
        public static readonly Pokemon Accelgor;
        public static readonly Pokemon Stunfisk;
        public static readonly Pokemon Mienfoo;
        public static readonly Pokemon Mienshao;
        public static readonly Pokemon Druddigon;
        public static readonly Pokemon Golett;
        public static readonly Pokemon Golurk;
        public static readonly Pokemon Pawniard;
        public static readonly Pokemon Bisharp;
        public static readonly Pokemon Bouffalant;
        public static readonly Pokemon Rufflet;
        public static readonly Pokemon Braviary;
        public static readonly Pokemon Vullaby;
        public static readonly Pokemon Mandibuzz;
        public static readonly Pokemon Heatmor;
        public static readonly Pokemon Durant;
        public static readonly Pokemon Deino;
        public static readonly Pokemon Zweilous;
        public static readonly Pokemon Hydreigon;
        public static readonly Pokemon Larvesta;
        public static readonly Pokemon Volcarona;
        public static readonly Pokemon Cobalion;
        public static readonly Pokemon Terrakion;
        public static readonly Pokemon Virizion;
        public static readonly Pokemon Tornadus;
        public static readonly Pokemon TherianTornadus;
        public static readonly Pokemon Thundurus;
        public static readonly Pokemon TherianThundurus;
        public static readonly Pokemon Reshiram;
        public static readonly Pokemon Zekrom;
        public static readonly Pokemon Landorus;
        public static readonly Pokemon TherianLandorus;
        public static readonly Pokemon Kyurem;
        public static readonly Pokemon BlackKyurem;
        public static readonly Pokemon WhiteKyurem;
        public static readonly Pokemon Keldeo;
        public static readonly Pokemon ResoluteKeldeo;
        public static readonly Pokemon Meloetta;
        public static readonly Pokemon PirouetteMeloetta;
        public static readonly Pokemon Genesect;
        #endregion

        #region Kalos
        public static readonly Pokemon Chespin;
        public static readonly Pokemon Quilladin;
        public static readonly Pokemon Chesnaught;
        public static readonly Pokemon Fennekin;
        public static readonly Pokemon Braixen;
        public static readonly Pokemon Delphox;
        public static readonly Pokemon Froakie;
        public static readonly Pokemon Frogadier;
        public static readonly Pokemon Greninja;
        public static readonly Pokemon AshGreninja;
        public static readonly Pokemon Bunnelby;
        public static readonly Pokemon Diggersby;
        public static readonly Pokemon Fletchling;
        public static readonly Pokemon Fletchinder;
        public static readonly Pokemon Talonflame;
        public static readonly Pokemon Scatterbug;
        public static readonly Pokemon Spewpa;
        public static readonly Pokemon Vivillon;
        public static readonly Pokemon Litleo;
        public static readonly Pokemon Pyroar;
        public static readonly Pokemon Flabebe;
        public static readonly Pokemon Floette;
        public static readonly Pokemon Florges;
        public static readonly Pokemon Skiddo;
        public static readonly Pokemon Gogoat;
        public static readonly Pokemon Pancham;
        public static readonly Pokemon Pangoro;
        public static readonly Pokemon Furfrou;
        public static readonly Pokemon Espurr;
        public static readonly Pokemon MaleMeowstic;
        public static readonly Pokemon FemaleMeowstic;
        public static readonly Pokemon Honedge;
        public static readonly Pokemon Doublade;
        public static readonly Pokemon ShieldAegislash;
        public static readonly Pokemon BladeAegislash;
        public static readonly Pokemon Spritzee;
        public static readonly Pokemon Aromatisse;
        public static readonly Pokemon Swirlix;
        public static readonly Pokemon Slurpuff;
        public static readonly Pokemon Inkay;
        public static readonly Pokemon Malamar;
        public static readonly Pokemon Binacle;
        public static readonly Pokemon Barbaracle;
        public static readonly Pokemon Skrelp;
        public static readonly Pokemon Dragalge;
        public static readonly Pokemon Clauncher;
        public static readonly Pokemon Clawitzer;
        public static readonly Pokemon Helioptile;
        public static readonly Pokemon Heliolisk;
        public static readonly Pokemon Tyrunt;
        public static readonly Pokemon Tyrantrum;
        public static readonly Pokemon Amaura;
        public static readonly Pokemon Aurorus;
        public static readonly Pokemon Sylveon;
        public static readonly Pokemon Hawlucha;
        public static readonly Pokemon Dedenne;
        public static readonly Pokemon Carbink;
        public static readonly Pokemon Goomy;
        public static readonly Pokemon Sliggoo;
        public static readonly Pokemon Goodra;
        public static readonly Pokemon Klefki;
        public static readonly Pokemon Phantump;
        public static readonly Pokemon Trevenant;
        public static readonly Pokemon Pumpkaboo;
        public static readonly Pokemon SmallPumpkaboo;
        public static readonly Pokemon LargePumpkaboo;
        public static readonly Pokemon SuperPumpkaboo;
        public static readonly Pokemon Gourgeist;
        public static readonly Pokemon SmallGourgeist;
        public static readonly Pokemon LargeGourgeist;
        public static readonly Pokemon SuperGourgeist;
        public static readonly Pokemon Bergmite;
        public static readonly Pokemon Avalugg;
        public static readonly Pokemon Noibat;
        public static readonly Pokemon Noivern;
        public static readonly Pokemon Xerneas;
        public static readonly Pokemon Yveltal;
        public static readonly Pokemon Zygarde;
        public static readonly Pokemon CompleteZygarde;
        public static readonly Pokemon DogZygarde;
        public static readonly Pokemon Diancie;
        public static readonly Pokemon MegaDiancie;
        public static readonly Pokemon Hoopa;
        public static readonly Pokemon UnboundHoopa;
        public static readonly Pokemon Volcanion;
        #endregion

        #region Alola
        public static readonly Pokemon Rowlet;
        public static readonly Pokemon Dartrix;
        public static readonly Pokemon Decidueye;
        public static readonly Pokemon Litten;
        public static readonly Pokemon Torracat;
        public static readonly Pokemon Incineroar;
        public static readonly Pokemon Popplio;
        public static readonly Pokemon Brionne;
        public static readonly Pokemon Primarina;
        public static readonly Pokemon Pikipek;
        public static readonly Pokemon Trumbeak;
        public static readonly Pokemon Toucannon;
        public static readonly Pokemon Yungoos;
        public static readonly Pokemon Gumshoos;
        public static readonly Pokemon Grubbin;
        public static readonly Pokemon Charjabug;
        public static readonly Pokemon Vikavolt;
        public static readonly Pokemon Crabrawler;
        public static readonly Pokemon Crabominable;
        public static readonly Pokemon PauOricorio;
        public static readonly Pokemon SensuOricorio;
        public static readonly Pokemon PomPomOricorio;
        public static readonly Pokemon Cutiefly;
        public static readonly Pokemon Ribombee;
        public static readonly Pokemon Rockruff;
        public static readonly Pokemon MiddayLycanroc;
        public static readonly Pokemon MidnightLycanroc;
        public static readonly Pokemon SoloWishiwashi;
        public static readonly Pokemon SchoolWishiwashi;
        public static readonly Pokemon Mareanie;
        public static readonly Pokemon Toxapex;
        public static readonly Pokemon Mudbray;
        public static readonly Pokemon Mudsdale;
        public static readonly Pokemon Dewpider;
        public static readonly Pokemon Araquanid;
        public static readonly Pokemon Fomantis;
        public static readonly Pokemon Lurantis;
        public static readonly Pokemon Morelull;
        public static readonly Pokemon Shiinotic;
        public static readonly Pokemon Salandit;
        public static readonly Pokemon Salazzle;
        public static readonly Pokemon Stufful;
        public static readonly Pokemon Bewear;
        public static readonly Pokemon Bounsweet;
        public static readonly Pokemon Stenee;
        public static readonly Pokemon Tsareena;
        public static readonly Pokemon Comfey;
        public static readonly Pokemon Oranguru;
        public static readonly Pokemon Passimian;
        public static readonly Pokemon Wimpod;
        public static readonly Pokemon Golisopod;
        public static readonly Pokemon Sandygast;
        public static readonly Pokemon Palossand;
        public static readonly Pokemon Pyukumuku;
        public static readonly Pokemon TypeNull;
        public static readonly Pokemon Silvally;
        public static readonly Pokemon MeteorMinior;
        public static readonly Pokemon CoreMinior;
        public static readonly Pokemon Komala;
        public static readonly Pokemon Turtonator;
        public static readonly Pokemon Togedemaru;
        public static readonly Pokemon Mimikyu;
        public static readonly Pokemon Bruxish;
        public static readonly Pokemon Drampa;
        public static readonly Pokemon Dhelmise;
        public static readonly Pokemon Jangmoo;
        public static readonly Pokemon Hakamoo;
        public static readonly Pokemon Kommoo;
        public static readonly Pokemon TapuKoko;
        public static readonly Pokemon TapuLele;
        public static readonly Pokemon TapuBulu;
        public static readonly Pokemon TapuFini;
        public static readonly Pokemon Cosmog;
        public static readonly Pokemon Cosmoem;
        public static readonly Pokemon Solgaleo;
        public static readonly Pokemon Lunala;
        public static readonly Pokemon Nihilego;
        public static readonly Pokemon Buzzwole;
        public static readonly Pokemon Pheromosa;
        public static readonly Pokemon Xurkitree;
        public static readonly Pokemon Celesteela;
        public static readonly Pokemon Kartana;
        public static readonly Pokemon Guzzlord;
        public static readonly Pokemon Necrozma;
        public static readonly Pokemon Magearna;
        public static readonly Pokemon Marshadow;
        #endregion
        #endregion
    }

}



