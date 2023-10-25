//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using monarch240.Helpers;
//using monarch240.Models;
//using System.Globalization;
//using System.IO.Ports;
//using System.Xml.Linq;

//namespace monarch240.Controllers
//{
//    public class DataController : Controller
//    {
       
//        private readonly DbaccessContext _context;
//        private readonly IcommunicationService _communicationService;

//        public DataController(DbaccessContext context, IcommunicationService communicationService)
//        {
//            _context = context;
//           _communicationService = communicationService;
            
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }
//        public IActionResult ReceiveData()
//        {
//            // Send a command to the device
//            string command = "YOUR_COMMAND_HERE"; // Replace with the actual command
//            _communicationService.OpenAsync("COM10", 19200, Parity.None, 8, StopBits.One);
//            _communicationService.SendCommandAsync(command);

//            // Receive the response from the device asynchronously as a list of strings
//            List<string> responseList =  _communicationService.ReceiveResponseAsync();

//            // Implement your custom data parsing logic here
//            string[] dataParts = response.Split('|');

//            if (dataParts.Length >= 2)
//            {
//                // Parse data from dataParts and create a DrAbsQc object
//                DrPatient data = new DrPatient
//                {
//                    PatId = int.Parse(dataParts[0]),
//                    PatDisk = dataParts[1],
//                    PatTestingDate = DateTime.Now,
//                    PatClinic = dataParts[2],
//                    PatName = dataParts[3],
//                    // Continue setting other properties accordingly
//                };

//                // Save the parsed data to the database
//                _context.DrPatients.Add(data);
//                _context.SaveChanges();

//                return View(data);
//            }
//            else
//            {
//                // Handle the case where the date parsing fails
//                return View("ErrorView");
//            }
//        }



//        public IActionResult SendDataToDevice()
//        {
//            // Retrieve data from the database
//            var data = _context.DrPatients.FirstOrDefault();

//            if (data != null)
//            {
//                // Convert the data to a string for sending to the device
//                string dataToSendToDevice = FormatData(data);

//                // Send the data to the device
//                string response = _communicationService.SendCommand(dataToSendToDevice);

//                // Process the response from the device, if needed

//                return View("DataSent", response);
//            }
//            else
//            {
//                return View("DataNotAvailable");
//            }
//        }

//        public string FormatData(DrPatient data)
//        {
//            // Customize this method to format the data as needed for the device
//            string formattedData = $"{data.BackInt1}|{data.BackInt2}|{data.BackInt1}";
//            return formattedData;
//        }

//    }

//}
