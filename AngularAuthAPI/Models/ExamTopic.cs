namespace AngularAuthAPI.Models
{
    public class ExamTopic
    {
        public int ExamTopicId { get; set; }
        public string Title { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
