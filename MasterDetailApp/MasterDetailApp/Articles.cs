using SQLite;

namespace MasterDetailApp
{
    [Table("Articles")]
    public class Article
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}