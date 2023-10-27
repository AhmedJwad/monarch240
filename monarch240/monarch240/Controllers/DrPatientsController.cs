using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using monarch240.Helpers;
using monarch240.Models;

namespace monarch240.Controllers
{
    public class DrPatientsController : Controller
    {
        private readonly DbaccessContext _context;
        private readonly IcommunicationService _communicationService;

        public DrPatientsController(DbaccessContext context, IcommunicationService communicationService)
        {
            _context = context;
            _communicationService = communicationService;
        }

        // GET: DrPatients
        public async Task<IActionResult> Index()
        {
            try
            {
                // Send a command to the device
                string command = "YOUR_COMMAND_HERE"; // Replace with the actual command
                await _communicationService.OpenAsync("COM10", 19200, Parity.None, 8, StopBits.One);
                await _communicationService.SendCommandAsync(command);

                // Receive the response from the device asynchronously as a list of strings
                string responseList = await _communicationService.ReceiveResponseAsync();

                // Close the serial port
                //await _communicationService.CloseAsync();

                // Concatenate the list of strings into a single string
                string response = string.Join("|", responseList);

                // Implement your custom data parsing logic here
                string[] dataParts = response.Split('|');

                if (dataParts.Length >= 2)
                {
                    // Parse data from dataParts and create a DrAbsQc object
                    DrAbsQc data = new DrAbsQc
                    {
                        TestId = int.Parse(dataParts[0]),
                        TestName = dataParts[1],
                        TestDate = DateTime.Now, // Replace with the actual date from the response
                        Svalue = dataParts[2],
                        QcName = dataParts[3],
                        // Continue setting other properties accordingly
                    };

                    // Save the parsed data to the database
                    _context.DrAbsQcs.Add(data);
                    await _context.SaveChangesAsync();

                    return _context.DrPatients != null ?
                           View(await _context.DrPatients.ToListAsync()) :
                           Problem("Entity set 'DbaccessContext.DrPatients'  is null.");
                }
                else
                {
                    // Handle the case where data parsing fails
                    return View("ErrorView");
                }
            }
            catch (Exception ex)
            {
                return _context.DrPatients != null ?
                           View(await _context.DrPatients.ToListAsync()) :
                           Problem("Entity set 'DbaccessContext.DrPatients'  is null.");
            }
        
    
            
        }

        // GET: DrPatients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DrPatients == null)
            {
                return NotFound();
            }

            var drPatient = await _context.DrPatients
                .FirstOrDefaultAsync(m => m.PatId == id);
            if (drPatient == null)
            {
                return NotFound();
            }

            return View(drPatient);
        }

        // GET: DrPatients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DrPatients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatId,PatTestNo,PatDisk,PatPosition,PatBarcode,PatCaseNo,PatType,PatName,PatSex,PatAge,PatAgeUnit,PatRoom,PatBedNo,PatSampleType,PatDilute,PatVolume,PatCupType,PatProfile,PatSendingDate,PatTestingDate,PatReportDate,PatTestTime,PatDoctor,PatChecker,PatAssessor,PatClinic,PatRemark,PatAuditingInfo,PatPrintInfo,PatResultInfo,PatStandBy,PatFlag,PatBarFlag,PatRepeatCount,PatSerumFlag,PatProfileItems,BackStr1,BackStr2,BackInt1,BackInt2,BFlag,PatSendingTime,PatReportTime,PatSamplingDate,PatSamplingTime,SsmaTimeStamp")] DrPatient drPatient)
        {
            if (ModelState.IsValid)
            {

                _context.Add(drPatient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drPatient);
        }

        // GET: DrPatients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DrPatients == null)
            {
                return NotFound();
            }

            var drPatient = await _context.DrPatients.FindAsync(id);
            if (drPatient == null)
            {
                return NotFound();
            }
            return View(drPatient);
        }

        // POST: DrPatients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatId,PatTestNo,PatDisk,PatPosition,PatBarcode,PatCaseNo,PatType,PatName,PatSex,PatAge,PatAgeUnit,PatRoom,PatBedNo,PatSampleType,PatDilute,PatVolume,PatCupType,PatProfile,PatSendingDate,PatTestingDate,PatReportDate,PatTestTime,PatDoctor,PatChecker,PatAssessor,PatClinic,PatRemark,PatAuditingInfo,PatPrintInfo,PatResultInfo,PatStandBy,PatFlag,PatBarFlag,PatRepeatCount,PatSerumFlag,PatProfileItems,BackStr1,BackStr2,BackInt1,BackInt2,BFlag,PatSendingTime,PatReportTime,PatSamplingDate,PatSamplingTime,SsmaTimeStamp")] DrPatient drPatient)
        {
            if (id != drPatient.PatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drPatient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrPatientExists(drPatient.PatId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(drPatient);
        }

        // GET: DrPatients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DrPatients == null)
            {
                return NotFound();
            }

            var drPatient = await _context.DrPatients
                .FirstOrDefaultAsync(m => m.PatId == id);
            if (drPatient == null)
            {
                return NotFound();
            }

            return View(drPatient);
        }

        // POST: DrPatients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DrPatients == null)
            {
                return Problem("Entity set 'DbaccessContext.DrPatients'  is null.");
            }
            var drPatient = await _context.DrPatients.FindAsync(id);
            if (drPatient != null)
            {
                _context.DrPatients.Remove(drPatient);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrPatientExists(int id)
        {
          return (_context.DrPatients?.Any(e => e.PatId == id)).GetValueOrDefault();
        }
        public string FormatData(DrPatient data)
        {
            //Customize this method to format the data as needed for the device
            string formattedData = $"{data.BackInt1}|{data.BackInt2}|{data.BackInt1}";
            return formattedData;
        }
    }
}
