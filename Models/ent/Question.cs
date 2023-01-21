namespace elforo_be.Models.ent 
{
    public class Question
    {
        public int Id {get; set;}
        public DateOnly Date {get; set;}
        public bool Anonymous {get; set;}
        public List<String>? Tags {get; set;}
        public User? Person {get; set;}
        public List<Comentario>? Comments {get; set;}
    }
}