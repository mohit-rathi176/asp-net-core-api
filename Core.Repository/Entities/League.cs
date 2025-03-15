namespace Core.Repository.Entities
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
