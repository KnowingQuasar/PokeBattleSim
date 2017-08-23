using System.Collections.Generic;

namespace PokemonBattleSim
{
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
}
