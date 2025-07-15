
namespace DpCalculator.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; } = "New Module";
        public double? TargetAverage { get; set; }
        
        public List<Assessment> Assessments { get; set; } = new();
        public double? CurrentAverage { get; set; }
    }
}