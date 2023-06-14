namespace WordSearchSolverWebUi.Data
{
    public static class ExampleDataProvider
    {
        public static char[][] GetTestBoard()
        {
            var b = new List<char[]>();
            b.Add(new[] { 'l', 'e', 'c', 'w', 'o', 't', 'a', 'h', 'e', 'a', 'd', 'c', 'e', 't' });
            b.Add(new[] { 't', 'a', 'l', 'w', 's', 'r', 'a', 'e', 'k', 'l', 'y', 'i', 'a', 'b' });
            b.Add(new[] { 'o', 'r', 'o', 'i', 't', 'e', 'e', 't', 'h', 'k', 'y', 'o', 'a', 'w' });
            b.Add(new[] { 'g', 'o', 'd', 'w', 'a', 'l', 'c', 'a', 'v', 'w', 'v', 'r', 'w', 'o' });
            b.Add(new[] { 'w', 'o', 'e', 't', 'l', 'o', 'l', 'm', 'k', 't', 'k', 'o', 'c', 'e' });
            b.Add(new[] { 'o', 'e', 'w', 't', 'd', 'k', 't', 's', 'g', 'o', 'e', 'a', 'c', 'b' });
            b.Add(new[] { 'f', 's', 'c', 'o', 'l', 'r', 'w', 't', 'c', 'm', 'o', 'a', 'm', 'e' });
            b.Add(new[] { 'g', 'k', 'v', 'f', 'c', 'r', 'h', 'o', 'a', 'o', 'k', 'i', 't', 'g' });
            b.Add(new[] { 'l', 'u', 'a', 'e', 'r', 'a', 'w', 'o', 't', 'o', 's', 'f', 'e', 't' });
            b.Add(new[] { 'g', 'e', 'k', 'k', 't', 'r', 'w', 'e', 'w', 'f', 't', 'a', 'i', 'l' });
            b.Add(new[] { 'l', 'o', 'e', 'i', 'o', 'o', 't', 'r', 'w', 'e', 'f', 'f', 't', 't' });
            b.Add(new[] { 'o', 'e', 'r', 't', 'e', 'g', 'c', 't', 'i', 'o', 'a', 'c', 'l', 'w' });
            b.Add(new[] { 'u', 'b', 'u', 't', 't', 'o', 'y', 'g', 's', 'r', 'o', 'k', 'r', 't' });
            b.Add(new[] { 'l', 'r', 'f', 'y', 'h', 'a', 'a', 'a', 't', 'e', 'r', 'f', 'e', 't' });

            return b.ToArray();
        }
        public static List<string> GetTestWords()
        {
            return new List<string>()
            {
                "kitty",
                "ears",
                "dog",
                "fur",
                "teeth",
                "woof",
                "bark",
                "tail",
                "meow",
                "claw",
                "vet",
                "cat"
            };
        }
    }
}
