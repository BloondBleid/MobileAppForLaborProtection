using SQLite;

namespace MasterDetailApp
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public int Trained { get; set; }
        public int Category { get; set; }
        public int CountQuestions { get; set; }
        public int CountRigth { get; set; }
        public string Complexity { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}