namespace LogService.Models
{
    public class LogEntry
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Level { get; set; } = "INFO"; // INFO, WARNING, ERROR
        public string Message { get; set; } = string.Empty;
        public string? Exception { get; set; }
        public string? User { get; set; }
    }

}
