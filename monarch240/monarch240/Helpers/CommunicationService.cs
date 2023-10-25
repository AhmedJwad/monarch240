using System.IO.Ports;

namespace monarch240.Helpers
{
    public class CommunicationService : IcommunicationService
    {
        private SerialPort serialPort;
        public async Task OpenAsync(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            serialPort = new SerialPort(portName)
            {
                BaudRate = 19200,
                Parity = Parity.None,
                DataBits = 8, // Ahmed Almershady
                StopBits = StopBits.One, // Ahmed 
            };
            serialPort.Open();
            await Task.Yield();
        }

        public async Task SendCommandAsync(string command)
        {
            if (serialPort.IsOpen)
            {
                await serialPort.BaseStream.WriteAsync(System.Text.Encoding.ASCII.GetBytes(command), 0, command.Length);
            }
            else
            {
                throw new InvalidOperationException("Serial port is not open.");
            }
        }

        public async Task<string> ReceiveResponseAsync()
        {
            if (serialPort.IsOpen)
            {
                byte[] buffer = new byte[1024]; // Adjust buffer size as needed
                int bytesRead = await serialPort.BaseStream.ReadAsync(buffer, 0, buffer.Length);
                return System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
            }
            else
            {
                throw new InvalidOperationException("Serial port is not open.");
            }
        }

        public async Task CloseAsync()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            await Task.Yield();
        }
    }
}
