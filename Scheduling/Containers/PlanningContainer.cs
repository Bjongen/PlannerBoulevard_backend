using System;
using System.Collections;
using Scheduling.Classes;
using Scheduling.Dtos;
using Scheduling.Interfaces;

namespace Scheduling.Containers;

public class PlanningContainer
{
    public List<Planning> _plannings;
    private IPlanningDal _planningDal;

    public PlanningContainer(IPlanningDal planningDal)
    {
        _plannings = new List<Planning>();
        _planningDal = planningDal;
    }
    public IReadOnlyCollection<Planning> GetPlannings()
    { 
        return _plannings;
    }
    
    public IList<PlanningDto> GetAllPlannings()
    {
        return _planningDal.GetAll();
    }

    public PlanningDto GetById(int planningId)
    {
        return _planningDal.GetById(planningId);
    }

    public List<PlanningDto> GetAllFromThisWeek(int weekNumber)
    {
        return _planningDal.GetAllFromThisWeek(weekNumber);
    }

    public List<PlanningDto> GetAllFromWorkerThisWeek(int accountId, int weekNumber)
    {
        return _planningDal.GetAllFromWorkerThisWeek(accountId, weekNumber);
    }
    public int CreatePlanning(PlanningDto planningDto, int accountId)
    {
        _planningDal.CreatePlanning(planningDto, accountId);
        return 1;
    }
    
    public void UpdatePlanning(PlanningDto planningDto, int accountId)
    {
        _planningDal.UpdatePlanning(planningDto, accountId);
    }

    public void DeletePlanning(int planningId)
    {
        _planningDal.DeletePlanning(planningId);
    }
}