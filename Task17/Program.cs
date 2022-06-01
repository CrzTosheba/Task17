
static void main(string[] args)
{

}
public class Account
{
    // тип учетной записи
    public string Type { get; set; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }
}

public interface ICalculateInterest
{
    void Calc(Account acc);
}

