namespace Journal.Models
{
    public class JournalItem
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = null!;
        public DateTime Date { get; set; }
        public bool Attendance { get; set; }
    }
}
