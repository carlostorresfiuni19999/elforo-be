namespace elforo_be.Models.dto
{
    public class CommentDTO
    {
        public int Id {get; set;}
        public int IdQuestion {get; set;}
        public String? IdPerson {get; set;}
        public String? Comment {get; set;}
    }
}