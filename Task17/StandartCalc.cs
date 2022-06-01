
/// <summary>
/// расчет процентной ставки обычного аккаунта по правилам банка
/// </summary>
class StandartCalc : ICalculateInterest
{
    public void Calc(Account account)
    {
        account.Interest = account.Balance * 0.4;

        if (account.Balance < 1000)
            account.Interest -= account.Balance * 0.2;

        if (account.Balance < 50000)
            account.Interest -= account.Balance * 0.4;
    }
}
