using System.IO.Ports;

namespace monarch240.Helpers
{
    public interface IcommunicationService
    {
        Task OpenAsync(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits);
        Task SendCommandAsync(string command);
        Task<string> ReceiveResponseAsync();
        Task CloseAsync();
    }
}
