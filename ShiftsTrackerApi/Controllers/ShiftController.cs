using Microsoft.AspNetCore.Mvc;
using ShiftsTrackerLibrary.Data;
using ShiftsTrackerLibrary.Models;

namespace ShiftsTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        private IDatabaseData _db;

        public ShiftController(IDatabaseData db)
        {
            _db = db;
        }
        // GET: api/<ShiftController>
        [HttpGet]
        public IEnumerable<ShiftModel> Get()
        {
            return _db.GetAllShifts();
        }


        // POST api/<ShiftController>
        [HttpPost]
        public void Post([FromBody] ShiftModel shift)
        {
           
            _db.SaveShift(shift);
        }
    }
}



