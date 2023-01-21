namespace elforo_be.Models.ent
{
    public class Comentario
    {
        public int Id { get; set;}
        public String? Comment {get; set;}
        public Question? Question {get; set;}
        public User? User {get; set;}
    }
}