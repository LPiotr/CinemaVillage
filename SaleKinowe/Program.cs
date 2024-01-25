namespace SaleKinowe
{
    class Program
    {
        static void Main()
        {
            var rzedy = KonfiguracjaSal.StworzUkladSaliA();
            var salaA = new SalaA(rzedy);
            var najlepszeMiejsca = salaA.ZnajdzNajlepszeMiejsca();
            
            foreach (var miejsce in najlepszeMiejsca)
            {
                Console.WriteLine($"Rząd {miejsce.Key}, Miejsca: {miejsce.Value.Item1}, {miejsce.Value.Item2}");
            }
        }
    }
}