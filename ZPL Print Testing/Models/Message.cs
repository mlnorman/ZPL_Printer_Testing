namespace ZPL_Print_Testing.Models
{
    public class Message
    {
        public string MessageDescription { get; set; }

        public byte[] ImageBytes { get; set; }

        public string ZPLString { get; set; }
        
        public Message(string message, byte[] imageBytes)
        {
            MessageDescription = message;
            ImageBytes = imageBytes;
        }

        public Message(string message, byte[] imageBytes, string zpl)
        {
            MessageDescription = message;
            ImageBytes = imageBytes;
            ZPLString = zpl;
        }
    }
}
