namespace Messaging.Interfaces.Constants.Commands
{
    public interface IRegisterOrderCommand
    {
        public string PictureUrl { get; set; }
        public string UserEmail { get; set; }
        public byte[] ImageData { get; set; }
    }
}
