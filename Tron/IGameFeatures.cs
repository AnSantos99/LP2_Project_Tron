using System;
using System.Collections.Generic;
using System.Text;

namespace Tron
{
    interface IGameFeatures
    {
        /// <summary>
        /// Method used to draw the game world
        /// </summary>
        public void Draw();

        /// <summary>
        /// Method that checks if a position on the map is valid or if
        /// the player is able to walk on it
        /// </summary>
        /// <param name="x"> Checks rows </param>
        /// <param name="y"> Checks columns </param>
        /// <returns> false if position is not walkable or valid </returns>
        public bool IsPositionValid(int x, int y);
    }
}
