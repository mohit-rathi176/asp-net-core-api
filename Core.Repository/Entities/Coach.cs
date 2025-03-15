namespace Core.Repository.Entities
{
    public class Coach : BaseEntity
    {
        public string Name { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
