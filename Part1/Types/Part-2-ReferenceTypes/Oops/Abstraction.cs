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

    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }
    }

    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }
    }

    public class GiftCardAccount : BankAccount
    {
        public GiftCardAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
            
        }
    }
}