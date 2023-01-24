namespace elforo_be.Models.ent 
{
    public class Question
    {
        public int Id {get; set;}
        public DateOnly Date {get; set;}
        public bool Anonymous {get; set;}
        public List<Tag>? Tags {get; set;}
        public User? Person {get; set;}
        public int UserId {get; set; }
        public List<Comentario>? Comments {get; set;}
        public String? Ask {get; set; }
    }
}