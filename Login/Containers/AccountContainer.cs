using Login.Classes;

namespace Login.Containers;

public class AccountContainer
{
    public List<Account> _accounts;
        
    public IReadOnlyCollection<Account> GetAccounts()
    { 
        return _accounts;
    }

    public Account CreateAccount(Account account)
    {
        throw new NotImplementedException();
    }

    public IList<Account> GetAllAccounts()
    {
        throw new NotImplementedException();
    }

    public Account UpdateAccount(Account account)
    {
        throw new NotImplementedException();
    }

    public string DeleteAccount(Account account)
    {
        throw new NotImplementedException();
    }
}