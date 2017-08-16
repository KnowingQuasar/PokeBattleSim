namespace PokemonBattleSim
{
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
}
