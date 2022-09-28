using SQLite;
using System;

namespace MasterDetailApp
{
    [Table("Questions")]
    public class Questions
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string TextQuestion { get; set; }
        public int Category { get; set; }
        public int Relevance { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
