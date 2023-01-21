namespace elforo_be.Models.dto
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public String? Email { get; set; }
        public bool Anonymous { get; set; }
        public String? Date {get; set; }
        public List<String>? Tags {get; set; }
        public int CantComment {get; set; }
        
    }
}