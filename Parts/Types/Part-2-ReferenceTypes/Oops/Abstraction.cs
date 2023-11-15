using CSharpClass2.Classes;

namespace CSharpClass2.Oops
{
    // Pillars of Object Oriented Programming
    // 1. Abstraction - Show only relevant and hide un-necessary details - Ex: mobile phone
    // 2. Encapsulation - Hiding the internal state and functionality of an object and only allowing access through public set of functions    
    // 3. Inheritance - Ability to create new abstractions based on existing abstractions.
    // 4. Polymorphism - Ability to implement inherited properties or methods in different ways across multiple abstractions.


    // Creating different types of accounts. 
    // 1. An interest earning account that accrues interest at the end of each month.
    // 2. A line of credit that can have a negative balance, but when there's a balance, there's an interest charge each month.
    // 3. A pre-paid gift card account that starts with a single deposit, and only can be paid off. It can be refilled once at the start of each month.

    /*
    An interest earning account:
    Will get a credit of 2% of the month-ending-balance.
    A line of credit:
    Can have a negative balance, but not be greater in absolute value than the credit limit.
    Will incur an interest charge each month where the end of month balance isn't 0.
    Will incur a fee on each withdrawal that goes over the credit limit.
    A gift card account:
    Can be refilled with a specified amount once each month, on the last day of the month.        
    */

    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {}

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.02m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }

    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {}

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                // Negate the balance to get a positive interest charge:
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }
    }

    public class GiftCardAccount : BankAccount
    {
        private readonly decimal _monthlyDeposit = 0m;
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}