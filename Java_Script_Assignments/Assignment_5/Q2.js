class BankAccount {
    constructor(accountHolder, balance) {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    deposit(amount) {
        if (amount > 0) {
            this.balance += amount;
            console.log(`Rs.${amount} deposited successfully.`);
        } else {
            console.log("Deposit amount must be greater than 0.");
        }
    }
    withdraw(amount) {
        if (amount <= 0) {
            console.log("Withdrawal amount must be greater than 0.");
        } else if (amount > this.balance) {
            console.log("Insufficient balance. Withdrawal denied.");
        } else {
            this.balance -= amount;
            console.log(`Rs.${amount} withdrawn successfully.`);
        }
    }
    checkBalance() {
        console.log(`Current balance: Rs.${this.balance}`);
    }
}
let acc1 = new BankAccount("Rahul", 5000);
acc1.checkBalance(); 
acc1.deposit(2000);   
acc1.withdraw(10000);  
acc1.withdraw(3000);  
acc1.checkBalance();  