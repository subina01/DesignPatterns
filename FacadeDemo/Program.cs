namespace FacadeDemo
{
    public class Client
    {
        public static void Main(String[] args)
        {
            BankFacade bankFacade = new BankFacade();

            bool result = bankFacade.ApplyLoan(1001, 1002);
        }
    }
}
