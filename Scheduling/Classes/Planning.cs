using Scheduling.Dtos;

namespace Scheduling.Classes;

public class Planning
{
    public int PlanningId { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
    public string DayOfWeek { get; set; }
    public int WeekNumber { get; set; }

    public Planning(int planningId, DateTime date, DateTime time, string dayOfWeek, int weekNumber)
    {
        PlanningId = planningId;
        Date = date;
        Time = time;
        DayOfWeek = dayOfWeek;
        WeekNumber = weekNumber;
    }

    public Planning(DateTime date, DateTime time, string dayOfWeek, int weekNumber)
    {
        Date = date;
        Time = time;
        DayOfWeek = dayOfWeek;
        WeekNumber = weekNumber;
    }

    public Planning(PlanningDto planningDto)
    {
        PlanningId = planningDto.PlanningId;
        Date = planningDto.Date;
        Time = planningDto.Time;
        DayOfWeek = planningDto.DayOfWeek;
        WeekNumber = planningDto.WeekNumber;
    }

    public PlanningDto ToDto()
    {
        return new PlanningDto
        {
            PlanningId = PlanningId,
            Date = Date,
            Time = Time,
            DayOfWeek = DayOfWeek,
            WeekNumber = WeekNumber
        };
    } 
}