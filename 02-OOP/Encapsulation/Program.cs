class BankAccount
{
    // Private backing fields: Hidden from outside access
    private string _accountNumber;
    private decimal _balance;

    // Read-only property: Public can view the account number, but cannot alter it
    public string AccountNumber {
        get { return _accountNumber; }
    }

    // Encapsulated property: Public can view balance, but cannot set it directly
    public decimal Balance {
        get { return _balance; }
        private set { _balance = value; }
    }

    // Constructor
    public BankAccount(string accountNumber, decimal initialDeposit) {
        if (string.IsNullOrWhiteSpace(accountNumber))
            throw new ArgumentException("Account number cannot be empty.");

        if (initialDeposit < 0)
            throw new ArgumentException("Initial deposit cannot be negative.");

        _accountNumber = accountNumber;
        _balance = initialDeposit;
    }

    // Controlled methods: The only ways to modify the internal state
    public void Deposit(decimal amount) {
        if (amount <= 0) {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Deposited ${amount:N2}. New Balance: ${Balance:N2}");
    }

    public void Withdraw(decimal amount) {
        if (amount <= 0) {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
            return;
        }

        if (amount > Balance) {
            Console.WriteLine($"Withdrawal denied: Insufficient funds. Balance is ${Balance:N2}.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Withdrew ${amount:N2}. Remaining Balance: ${Balance:N2}");
    }
}

class Program
{
    static void Main() {
        BankAccount myAccount = new BankAccount("ACCT-092426", 500.00m);

        Console.WriteLine($"Account: {myAccount.AccountNumber}");
        Console.WriteLine($"Starting Balance: ${myAccount.Balance:N2}\n");

        // Possible operations
        myAccount.Deposit(250.00m);
        myAccount.Withdraw(100.00m);

        // Validation preventions
        myAccount.Withdraw(800.00m); // Attempt overdraft
        myAccount.Deposit(-50.00m); // Attempt negative deposit

        // Uncommenting the following lines will cause compile-time errors due to encapsulation:
        // myAccount.Balance = 1000000; // Error: The setter is private
        // myAccount._balance = 1000000; // Error: Field is private and inaccessible
    }
}
