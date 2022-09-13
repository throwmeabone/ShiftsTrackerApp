using ShiftsTrackerLibrary.Models;

namespace ShiftsTrackerLibrary.Data
{
    public interface IDatabaseData
    {
        List<ShiftModel> GetAllShifts();
        void SaveShift(ShiftModel shift);
    }
}