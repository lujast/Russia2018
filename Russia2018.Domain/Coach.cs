namespace Russia2018.Domain
{
    public class Coach : Person
    {
        public virtual Team Team { get; set; }
    }
}