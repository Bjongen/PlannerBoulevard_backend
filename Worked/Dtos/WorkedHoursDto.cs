namespace Worked.Dtos;

public struct WorkedHoursDto
{
    public int WorkedHoursId { get; set; }
    public DateTime Date { get; set; }
    public DateTime Present { get; set; }
    public DateTime Pause { get; set; }
    public DateTime Worked { get; set; }
    public int WeekNumber { get; set; }
}