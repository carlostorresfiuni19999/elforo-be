namespace elforo_be.Models.ent
{
    public class Tag
    {
        public int Id
        {
            get; 
            set;
        }

        public String? TagName
        {
            get;
            set;
        }

        public Question? Question
        {
            get;
            set;
        }

        public int QuestionId
        {
            get;
            set;
        }
    }
}