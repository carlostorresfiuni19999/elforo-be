namespace elforo_be.Models.ent
{
    
    public class Subject
    {
    
        public int Id{get; set;}
        public String? Name {get; set;}
        public int PP {get; set;}
        public int PF {get; set;}
        public int Score {get; set;}
        public DateOnly Year {get; set;}

        public virtual User? User {get; set;}
        public String? UserId {get; set;}
    }
}