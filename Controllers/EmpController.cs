using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mysqlefcore;

namespace Database2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpController : ControllerBase
    {
        LibraryContext libraryContext;
        public EmpController()
        {
          libraryContext = new LibraryContext();  
        }
       [HttpGet]
       public IActionResult Get(){
           var result = libraryContext.Emptb.AsQueryable();
           return Ok(result);
       }

        /*[HttpGet]
        [Route("ById")]
       public IActionResult GetById(int empId){
           var result = libraryContext.Emptb.AsQueryable().Where(u=>u.EmpID == empId).FirstOrDefault();
           return Ok(result);
       }
       */

       [HttpPost]
       public IActionResult Post(EmpTB empTB){
           libraryContext.Add(empTB);
           libraryContext.SaveChanges();
           return Ok(empTB);
       }
    }
}
