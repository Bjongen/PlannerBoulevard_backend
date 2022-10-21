using System;
using System.Collections;
using Scheduling.Classes;

namespace Scheduling.Containers;

public class PlanningContainer
{
    public List<Planning> _plannings;
    
    public IReadOnlyCollection<Planning> GetPlannings()
    { 
        return _plannings;
    }

    public Planning CreatePlanning(Planning planning)
    {
        throw new NotImplementedException();
    }

    public IList<Planning> GetAllPlannings()
    {
        throw new NotImplementedException();
    }

    public Planning UpdatePlanning(Planning planning)
    {
        throw new NotImplementedException();
    }

    public string DeletePlanning(Planning planning)
    {
        throw new NotImplementedException();
    }
}