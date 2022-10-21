using Worked.Dtos;

namespace Worked.Classes;

public class WorkedHours
{
    public int WorkedHoursId { get; set; }
    public DateTime Date { get; set; }
    public DateTime Present { get; set; }
    public DateTime Pause { get; set; }
    public DateTime Worked { get; set; }
    public int WeekNumber { get; set; }

    public WorkedHours(int workedHoursId, DateTime date, DateTime present, DateTime pause, DateTime worked,
        int weekNumber)
    {
        WorkedHoursId = workedHoursId;
        Date = date;
        Present = present;
        Pause = pause;
        Worked = worked;
        WeekNumber = weekNumber;
    }

    public WorkedHours(DateTime date, DateTime present, DateTime pause, DateTime worked, int weekNumber)
    {
        Date = date;
        Present = present;
        Pause = pause;
        Worked = worked;
        WeekNumber = weekNumber;
    }

    public WorkedHours(WorkedHoursDto workedHoursDto)
    {
        WorkedHoursId = workedHoursDto.WorkedHoursId;
        Date = workedHoursDto.Date;
        Present = workedHoursDto.Present;
        Pause = workedHoursDto.Pause;
        Worked = workedHoursDto.Worked;
        WeekNumber = workedHoursDto.WeekNumber;
    }

    public WorkedHoursDto ToDto()
    {
        return new WorkedHoursDto
        {
            WorkedHoursId = WorkedHoursId,
            Date = Date,
            Present = Present,
            Pause = Pause,
            Worked = Worked,
            WeekNumber = WeekNumber
        };
    }
}