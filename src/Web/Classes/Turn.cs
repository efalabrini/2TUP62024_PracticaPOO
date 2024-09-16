using System.Numerics;
using Web.Interfaces;

namespace Web.Classes
{
    public static class Turn
    {
        public static List<string> attackEachOther(List<Character> characters)
        {
            List<string> attacks = new List<string>();
            foreach (var character in characters)
            {
                attacks.Add(character.attack());
            }
            return attacks;
        }

        public static Dictionary<string,int> move(int? x,int? y,Character character)
        {
            var moves = new Dictionary<string, int>();
            if (x.HasValue)
            {
                int xValue = (int)x.Value;
                character.moveX(xValue);
                moves["x"] = xValue;
            }

            if (y.HasValue)
            {
                int yValue = (int)y.Value;
                character.moveY(yValue);
                moves["y"] = yValue;
            }

            return moves;

            
        }
    }
}
