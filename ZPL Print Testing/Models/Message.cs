namespace ZPL_Print_Testing.Models
{
    public class Message
    {
        public string MessageDescription { get; set; }

        public byte[] ImageBytes { get; set; }
        
        public Message(string message, byte[] imageBytes)
        {
            MessageDescription = message;
            ImageBytes = imageBytes;
        }
    }
}
