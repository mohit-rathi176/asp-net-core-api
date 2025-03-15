namespace Core.Repository.Entities
{
    public class League : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
