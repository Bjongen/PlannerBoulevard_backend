using Scheduling.Dtos;

namespace Scheduling.Interfaces;

public interface IPlanningDal
{
    public List<PlanningDto> GetAll();
    public PlanningDto GetById(int planningId);
    public List<PlanningDto> GetAllFromThisWeek(int weeknumber);
    public List<PlanningDto> GetAllFromWorkerThisWeek(int accountId, int weeknumber);
    public void CreatePlanning(PlanningDto planningDto, int accountId);
    public void UpdatePlanning(PlanningDto planningDto, int accountId);
    public void DeletePlanning(int planningId);
    
}