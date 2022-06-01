
public static class Calculator
{
    public static Dictionary<string, ICalculateInterest> AccTypes = new Dictionary<string, ICalculateInterest>
    {
        ["Обычный"] = new StandartCalc(),
        ["Зарплатный"] = new PaymentCalc(),
    };

    // Метод для расчета процентной ставки
    public static void CalculateInterest(Account account)
    {
        if(AccTypes.ContainsKey(account.Type))
            AccTypes[account.Type].Calc(account);
    }
}