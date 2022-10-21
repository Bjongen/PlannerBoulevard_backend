using Login.Dtos;
using Scheduling.Classes;
using Scheduling.Dtos;
using Worked.Classes;
using Worked.Dtos;

namespace Login.Classes;

public class Account
{
    public int AccountId { get; set; }
    public string Name { get; set; }
    public string EmployeeCode { get; set; }
    public string Password { get; set; }
    public IList<Planning> Plannings { get; set; }
    public IList<WorkedHours> WorkedHours { get; set; }

    public Account(int accountId, string name, string employeeCode, string password)
    {
        AccountId = accountId;
        Name = name;
        EmployeeCode = employeeCode;
        Password = password;
    }

    public Account(string name, string employeeCode, string password)
    {
        Name = name;
        EmployeeCode = employeeCode;
        Password = password;
    }

    public Account(IList<Planning> plannings)
    {
        Plannings = plannings;
    }

    public Account(IList<WorkedHours> workedHours)
    {
        WorkedHours = workedHours;
    }
    public Account(AccountDto accountDto)
    {
        AccountId = accountDto.AccountId;
        Name = accountDto.Name;
        EmployeeCode = accountDto.EmployeeCode;
        Password = accountDto.Password;
    }

    public AccountDto ToDto()
    {
        List<PlanningDto> dtos = new List<PlanningDto>();
        List<WorkedHoursDto> hoursDtos = new List<WorkedHoursDto>();
        foreach (var plan in Plannings)
        {
            dtos.Add(plan.ToDto());
        }
        foreach (var hour in WorkedHours)
        {
            hoursDtos.Add((hour.ToDto()));
        }
        return new AccountDto
        {
             
            AccountId = AccountId,
            Name = Name,
            EmployeeCode = EmployeeCode,
            Password = Password,
            PlanningDtos = dtos,
            WorkedHoursDtos = hoursDtos
        };
    }
}