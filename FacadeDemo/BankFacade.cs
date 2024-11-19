using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    public class BankFacade //Client directly calls this method so that they won't have to interact with the complex sub systems(This acts like a mask to encapsulate the complex details)
    {
        private readonly AccountService accountService = new AccountService();//readonly has to be used in case of fixed dependencies because once these are initialized their value shouldn't be reassigned
        private readonly LoanService loanService = new LoanService();
        private readonly CustomerService customerService = new CustomerService();

        public bool ApplyLoan( int AccountId, int CustomerId )
        {
            Console.WriteLine("Loan Application Processing");
            if (accountService.CheckBalance(AccountId) && loanService.IsEligible(AccountId) && customerService.VerifyCustomer(CustomerId))
            {
                Console.WriteLine("Loan Approved!!");
                return true;
            }
            else
            {
                Console.WriteLine("Your Application is rejected!!");
                return false;
            }
        }
    }
}
