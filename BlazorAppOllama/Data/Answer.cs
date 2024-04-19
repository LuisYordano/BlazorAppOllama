namespace BlazorAppOllama.Data
{
    public class Answer
    {
        public string model { get; set; }
        public string created_at { get; set; }
        public string response { get; set; }
        public bool done { get; set; }
    }
}
