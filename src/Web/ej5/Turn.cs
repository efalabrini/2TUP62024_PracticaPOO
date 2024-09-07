namespace Web.ej5
{
    public static class Turn
    {
        public static IEnumerable<string> AttackEachOther(IList<Character> characters)
        {
            return characters.Select(character => character.Attack());
        }


        public static void MoveCards(IMove cards)
        {
            Random random = new Random();
            cards.MoveAxisX(random.Next(0, 15));
            cards.MoveAxisX(random.Next(0, 15));
        }

    }
}