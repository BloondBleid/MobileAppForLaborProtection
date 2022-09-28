using SQLite;
using System;

namespace MasterDetailApp
{
    [Table("Answers")]
    public class Answers
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Answer { get; set; }
        public int CorrectAnswer { get; set; }
        public int ForQuestionID { get; set; }
    }
}