using AngularAuthAPI.Models;

namespace AngularAuthAPI.DTO
{
    public class ExamQsOptDTO
    {
        public string Head { get; set; }
        public int TopicId { get; set; }
        public List<QsOptionDTO> options { get; set; }
    }
}
