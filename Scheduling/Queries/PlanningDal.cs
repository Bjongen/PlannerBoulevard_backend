using System.Data;
using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using Scheduling.Dtos;

namespace Scheduling.Queries;

public class PlanningDal
{
    private IDbConnection _dbConnection;

    public PlanningDal(IDbConnection dbConnecion)
    {
        _dbConnection = dbConnecion;
    }

    public IList<PlanningDto> GetAll()
    {
        var sql = "Select * From Planning;";
        try
        {
            using (_dbConnection)
            {
                return _dbConnection.Query<PlanningDto>(sql).ToList();
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public IList<PlanningDto> GetAllFromThisWeek(int weeknumber)
    {
        var sql = "Select * From Planning " +
                  "Where WeekNumber = @WeekNumber" +
                  ";";
        try
        {
            using (_dbConnection)
            {
                return _dbConnection.Query<PlanningDto>(sql, new
                {
                    weeknumber
                }).ToList();
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public IList<PlanningDto> GetAllFromWorkerThisWeek(int id, int weeknumber)
    {
        var sql = "Select * From Planning Where AccountId = @AccountId And WeekNumber = @WeekNumber";
        try
        {
            using (_dbConnection)
            {
                return _dbConnection.Query<PlanningDto>(sql, new
                {
                    id,
                    weeknumber
                }).ToList();
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}