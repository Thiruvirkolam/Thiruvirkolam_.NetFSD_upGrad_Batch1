class BankAccount {
    name: string
    accNo: number
    type: string
    balance: number

    constructor(name: string, accNo: number, type: string, balance: number) {
        this.name = name
        this.accNo = accNo
        this.type = type
        this.balance = balance
    }

    deposit(amount: number): void {
        this.balance += amount
    }

    withdraw(amount: number): void {
        if (amount <= this.balance) {
            this.balance -= amount
        } else {
            console.log("Insufficient balance")
        }
    }

    display(): void {
        console.log(this.name, this.balance)
    }
}

let acc = new BankAccount("Ashwin", 12345, "Savings", 5000)
acc.deposit(1000)
acc.withdraw(2000)
acc.display()