
namespace DpCalculator.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public string Name { get; set; } = "New Assessment";
        public double Weight { get; set; } = 30;
        public double Score { get; set; } = 0;
        public int ModuleId { get; set; }
        public Module? Module { get; set; } 
    }
}