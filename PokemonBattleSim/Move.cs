using System.Collections.Generic;

namespace PokemonBattleSim
{
    #region Move
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

    #region ZMove
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
            if(zeffects != null)
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
}
