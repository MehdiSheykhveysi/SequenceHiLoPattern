namespace SequenceHiloPattern.Entitties
{
    public class Category : BaseEntity<string>
    {
        public string Title { get; set; }

        //Navigation Property

        public int ProducId { get; set; }
        public Product Product { get; set; }
    }
}
