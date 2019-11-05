using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExamMvcLogin.Models;
using Microsoft.AspNetCore.Authorization;


namespace ExamMvcLogin.Controllers
{
    [Authorize]
    public class PersonsController : Controller
    {

    }
}
