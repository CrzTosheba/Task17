
class PaymentCalc : ICalculateInterest
{
    public void Calc(Account account)
    {
        account.Interest = account.Balance * 0.5;
    }
}
