namespace SaleKinowe
{
    public abstract class SalaKinowa
    {
        public Dictionary<int, List<int>> Rzedy { get; set; }

        protected SalaKinowa(Dictionary<int, List<int>> rzedy)
        {
            Rzedy = rzedy;
        }

        public abstract Dictionary<int, Tuple<int, int>> ZnajdzNajlepszeMiejsca();

        protected abstract Tuple<int, int> ZnajdzNajlepszeMiejscaWRzedzie(List<int> rzad);
    }
}
