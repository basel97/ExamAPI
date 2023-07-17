using System.ComponentModel.DataAnnotations.Schema;

namespace AngularAuthAPI.Models
{
    public class Option
    {
        public int OptionId { get; set; }
        public string Value { get; set; }
        public int TrueValue { get; set; }
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
