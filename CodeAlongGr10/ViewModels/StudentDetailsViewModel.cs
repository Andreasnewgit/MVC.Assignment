
using MCV.Models;

namespace MCV.ViewModels
{
    public class StudentDetailsViewModel
    {
        public Student? Student { get; set; }
        public Address? Address { get; set; }
        public string? Title { get; set; }
        public string? Header { get; set; }
    }
}
