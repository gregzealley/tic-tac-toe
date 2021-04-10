using tic_tac_toe;

namespace UnitTests
{
    public class Player
    {
        public string Name {get;}
        public char Mark { get; }
        public PlayerType Type { get; }

        public Player(string name, char mark, PlayerType type)
        {
            this.Name = name;
            this.Mark = mark;
            this.Type = type;
        }
    }
}