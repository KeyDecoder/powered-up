namespace SharpBrick.PoweredUp.Protocol.Messages
{
    public class PortValueSingleMessage : PoweredUpMessage
    {
        public PortValueData[] Data { get; set; }
    }
}