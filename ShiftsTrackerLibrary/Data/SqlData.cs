using ShiftsTrackerLibrary.Database;
using ShiftsTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftsTrackerLibrary.Data
{
    public class SqlData : IDatabaseData
    {
        private ISqlDataAccess _db;

        private const string connectionStringName = "SqlDB";
        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }
        public List<ShiftModel> GetAllShifts()
        {
            string sql = "select * from dbo.Shifts";
            return _db.LoadData<ShiftModel, dynamic>(sql, new { }, connectionStringName, false);
        }

        public void SaveShift(ShiftModel shift)
        {
            _db.SaveData("dbo.spShifts_InsertShift",
                         new { shift.StartDateTime, shift.EndDateTime, shift.Pay, shift.Minutes, shift.Location },
                         connectionStringName,
                         true);
        }
    }
}
