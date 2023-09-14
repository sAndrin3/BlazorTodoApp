namespace MyBlazorApp.Models{
    public class TodoDto{
        public Guid Id {get; set; }
        public string Title {get; set; } = string.Empty;
        public string Description {get; set;} = string.Empty;
        public string Priority {get; set; } = string.Empty;
        public string Duration {get; set; } = string.Empty;
       public DateTime CreatedAt { get; set; } = DateTime.Now;
     
    }
}