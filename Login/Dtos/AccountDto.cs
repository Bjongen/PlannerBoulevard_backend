using Scheduling.Dtos;
using Worked.Dtos;

namespace Login.Dtos;

public struct AccountDto
{
    public int AccountId { get; set; }
    public string Name { get; set; }
    public string EmployeeCode { get; set; }
    public string Password { get; set; }
}