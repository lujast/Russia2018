using System.Collections.Generic;

namespace Russia2018.Domain
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Population { get; set; }

        public virtual List<View> Views { get; set; }

        
    }
}