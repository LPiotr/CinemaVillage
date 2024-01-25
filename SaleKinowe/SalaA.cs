namespace SaleKinowe
{
    public class SalaA : SalaKinowa
    {
        public SalaA(Dictionary<int, List<int>> rzedy) : base(rzedy) { }

        public override Dictionary<int, Tuple<int, int>> ZnajdzNajlepszeMiejsca()
        {
            var najlepszeMiejsca = new Dictionary<int, Tuple<int, int>>();
            int iloscRzedow = Rzedy.Count;
            int srodekSali = iloscRzedow / 2;

            List<int> najlepszeRzedy;
            if (iloscRzedow % 2 == 0)
            {
                najlepszeRzedy = new List<int> { srodekSali, srodekSali + 1 };
            }
            else
            {
                najlepszeRzedy = new List<int> { srodekSali + 1 };
            }

            foreach (var rzadKey in najlepszeRzedy)
            {
                var rzad = Rzedy[rzadKey];
                var najlepszeMiejscaWRzedzie = ZnajdzNajlepszeMiejscaWRzedzie(rzad);
                najlepszeMiejsca.Add(rzadKey, najlepszeMiejscaWRzedzie);
            }

            return najlepszeMiejsca;
        }

        protected override Tuple<int, int> ZnajdzNajlepszeMiejscaWRzedzie(List<int> rzad)
        {
            int sumaPrzesunieciaSrodka = (rzad.Count(x => x == 0) + rzad.TakeWhile(m => m != 0).Count());
            int przesunOWartosc = (int)(sumaPrzesunieciaSrodka * 0.8);
            var dostepneMiejsca = rzad.Select((miejsce, indeks) => new { Miejsce = miejsce, Indeks = indeks })
                                        .Where(x => x.Miejsce != 0)
                                        .ToList();

            int srodek = (dostepneMiejsca.Count / 2) - 4;
            int indeksSrodka = srodek - (dostepneMiejsca.Count % 2 == 0 ? 1 : 0);

            int najlepszeMiejsceA = dostepneMiejsca[indeksSrodka].Indeks;
            int najlepszeMiejsceB = dostepneMiejsca[indeksSrodka + 1].Indeks;

            if (rzad[najlepszeMiejsceA] == 2 && najlepszeMiejsceB - najlepszeMiejsceA == 1)
            {
                return new Tuple<int, int>(najlepszeMiejsceA + 1, najlepszeMiejsceB + 1);
            }
            else
            {
                najlepszeMiejsceA = dostepneMiejsca[Math.Min(indeksSrodka + 1, dostepneMiejsca.Count - 1)].Indeks;
                najlepszeMiejsceB = dostepneMiejsca[Math.Min(indeksSrodka + 2, dostepneMiejsca.Count - 1)].Indeks;

                return new Tuple<int, int>(najlepszeMiejsceA + 1, najlepszeMiejsceB + 1);
            }
        }
    }
}
