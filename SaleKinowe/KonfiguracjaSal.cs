namespace SaleKinowe
{
    public static class KonfiguracjaSal
    {
        public static Dictionary<int, List<int>> StworzUkladSaliA()
        {
            return new Dictionary<int, List<int>>
            {
                { 1, new List<int> {0, 0, 0, 0, 0, 0, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} },
                { 2, new List<int> {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} },
                { 3, new List<int> {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} },
                { 4, new List<int> {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} },
                { 5, new List<int> {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} },
                { 6, new List<int> {1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} },
                { 7, new List<int> {1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} },
                { 8, new List<int> {1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} },
                { 9, new List<int> {1, 2, 0, 0, 1, 1, 2, 2, 2, 2, 2, 2} },
                { 10, new List<int> {1, 2, 0, 0, 1, 1, 2, 2, 2, 2, 2, 2} },
                { 11, Enumerable.Repeat(2, 9).ToList() }
            };
        }
    }
}
