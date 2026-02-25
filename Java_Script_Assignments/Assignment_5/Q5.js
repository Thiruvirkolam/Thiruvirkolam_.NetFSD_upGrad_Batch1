class Employee {
    constructor(name, salary) {
        this.name = name;
        this.salary = salary;
    }

    getDetails() {
        return `${this.name} earns ₹${this.salary}`;
    }
}

class Manager extends Employee {
    constructor(name, salary, bonus) {
        super(name, salary);
        this.bonus = bonus;
    }

    getTotalSalary() {
        return this.salary + this.bonus;
    }
}

class Director extends Manager {
    constructor(name, salary, bonus, stockOptions) {
        super(name, salary, bonus);
        this.stockOptions = stockOptions;
    }

    getFullCompensation() {
        return this.getTotalSalary() + this.stockOptions;
    }
}

let emp = new Employee("Rahul", 50000);
let mgr = new Manager("Arjun", 80000, 20000);
let dir = new Director("Vikram", 150000, 50000, 100000);

console.log(emp.getDetails());
console.log("Manager Total Salary:", mgr.getTotalSalary());
console.log("Director Full Compensation:", dir.getFullCompensation());