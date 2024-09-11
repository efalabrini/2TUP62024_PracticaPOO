namespace Web.Ej5
{
    public static class Turn{
        public static List<string> AttackEachOther(IList<Character> characters){
            List<string> attackList = new List<string>();
            foreach(var character in characters){
                attackList.Add(character.Attack());
        }
        return attackList;
        }
        public static void MovePieces(IMove piece,int distanceX, int distanceY, string x, string y){
            piece.MoveXAxis(distanceX,x);
            piece.MoveYAxis(distanceY,y);
        }
    }
}