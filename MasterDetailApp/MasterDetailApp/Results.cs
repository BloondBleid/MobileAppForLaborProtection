using SQLite;
using System;

namespace MasterDetailApp
{
    [Table("Results")]
    public class Results
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string dateTimeAnsw { get; set; }
        public int userId { get; set; }
        public int check { get; set; }
        public int forQuestionID { get; set; }
    }
}