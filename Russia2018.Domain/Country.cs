namespace Russia2018.Domain
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Continent Continent { get; set; }

        public byte[] Flag { get; set; }

        public string Capital { get; set; }

        public decimal Area { get; set; }

        public decimal Population { get; set; }

        public decimal Density { get; set; }

    }
}