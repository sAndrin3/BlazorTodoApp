namespace BlazorRouting.Models{
    public class TodoDto{
        public int Id {get; set; }
        public string Title {get; set; } = string.Empty;
        public string Description {get; set;} = string.Empty;
        public string Priority {get; set; } = string.Empty;
         public int Duration { get; set; } 
       public DateTime CreatedAt { get; set; } = DateTime.Now;
     
    }
}