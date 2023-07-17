using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AngularAuthAPI.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Head { get; set; }
        [ForeignKey("ExamTopic")]
        public int TopicId { get; set; }
        public ExamTopic ExamTopic { get; set; }
        
        public ICollection<Option> Options { get; set; } = new List<Option>();


    }
}
