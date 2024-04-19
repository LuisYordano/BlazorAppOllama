namespace BlazorAppOllama.Data
{
    public class Question
    {
        public string model { get; set; } = "llama3";
        public string prompt { get; set; } = string.Empty;
        public bool stream { get; set; } = false;
    }
}
