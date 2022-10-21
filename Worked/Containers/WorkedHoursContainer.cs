using Worked.Classes;

namespace Worked.Containers;

public class WorkedHoursContainers
{
    public List<WorkedHours> _workedHours;

    public IReadOnlyCollection<WorkedHours> GetAll()
    {
        return _workedHours;
    }

    public WorkedHours CreateWorkedHours(WorkedHours workedHours)
    {
        throw new NotImplementedException();
    }

    public IList<WorkedHours> GetAllWorkedHours()
    {
        throw new NotImplementedException();
    }

    public WorkedHours UpdateWorkedHours(WorkedHours workedHours)
    {
        throw new NotImplementedException();
    }

    public string DeleteWorkedHours(WorkedHours workedHours)
    {
        throw new NotImplementedException();
    }
}