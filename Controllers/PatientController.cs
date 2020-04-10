using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientModelBinding.Models;

namespace PatientModelBinding.Controllers
{
    public class PatientController : Controller
    {
        public ViewResult PatientInfo()
        {
            Patient patient = new Patient();
            return View(patient);
        }
        [HttpPost]
        public ViewResult PatientInfo(Patient patient)
        {
            return View(patient);
        }
    }
}