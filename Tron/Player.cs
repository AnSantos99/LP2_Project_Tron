using System;
using System.Collections.Generic;
using System.Text;

namespace Tron
{
    /// <summary>
    /// This class contains all information about the player
    /// </summary>
    class Player
    {
        public uint Xpos { get; set; }
        public uint Ypos { get; set; }

        private string playerCharacter;

        private ConsoleColor playerColor;

        public Player(uint initalX, uint initalY) 
        {
            Xpos = initalX;
            Ypos = initalY;
            playerCharacter = "A";
            playerColor = ConsoleColor.Red;
        }

        public void Draw() 
        {

        }
    }
}
