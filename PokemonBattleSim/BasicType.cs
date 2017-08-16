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
        /// List of no-effect types (defensive) - read this has no effect when hit by the list
        /// </summary>
        public List<BasicType> noEffectDefensive;

        /// <summary>
        /// List of no-effect types (offensive) - read this has no effect against the list
        /// </summary>
        public List<BasicType> noEffectOffensive;

        /// <summary>
        /// List of not-very-effective types (offensive) - read this is not-very-effective against the list
        /// </summary>
        public List<BasicType> notveryeffective;

        /// <summary>
        /// List of the type's resistances
        /// </summary>
        public List<BasicType> resistances;

        /// <summary>
        /// List of supereffective types (offensive) - read this is super-effective against the list
        /// </summary>
        public List<BasicType> supereffective;

        /// <summary>
        /// List of the type's weaknesses
        /// </summary>
        public List<BasicType> weaknesses;
        #endregion

        #region Basic Type Constructor
        /// <summary>
        /// Basic constructor to make a type
        /// </summary>
        /// <param name="name">Name of the type</param>
        /// <param name="w">List of weaknesses of the type</param>
        /// <param name="r">List of resistances of the type</param>
        public BasicType(string name, BasicType[] w, BasicType[] r, BasicType[] s, BasicType[] n, BasicType[] no, BasicType[] nd)
        {
            this.name = name;
            weaknesses = new List<BasicType>(w);
            resistances = new List<BasicType>(r);
            supereffective = new List<BasicType>(s);
            notveryeffective = new List<BasicType>(n);
            noEffectOffensive = new List<BasicType>(no);
            noEffectDefensive = new List<BasicType>(nd);
        }
        #endregion
    }
}
