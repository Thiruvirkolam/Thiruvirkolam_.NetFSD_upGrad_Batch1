let employees = [
 { id:1, name:"Ravi", dept:"IT", salary:70000 },
 { id:2, name:"Anita", dept:"HR", salary:50000 },
 { id:3, name:"Karan", dept:"IT", salary:80000 },
 { id:4, name:"Meena", dept:"Finance", salary:60000 }
];

// Total salary expense
let totalSalary = employees.reduce((sum, e) =>
  sum + e.salary, 0);
console.log("Total Expense:", totalSalary);

//  Highest & Lowest
let highest = employees.reduce((max, e) =>
  e.salary > max.salary ? e : max);

let lowest = employees.reduce((min, e) =>
  e.salary < min.salary ? e : min);

console.log("Highest:", highest);
console.log("Lowest:", lowest);

//  Increase IT salary by 15%
employees = employees.map(e =>
  e.dept === "IT"
    ? { ...e, salary: e.salary * 1.15 }
    : e
);

//  Group by department
let grouped = employees.reduce((acc, e) => {
  acc[e.dept] = acc[e.dept] || [];
  acc[e.dept].push(e);
  return acc;
}, {});
console.log("Grouped:", grouped);

//  Department-wise average salary
let deptAvg = Object.keys(grouped).map(dept => {
  let avg = grouped[dept].reduce((sum, e) =>
    sum + e.salary, 0) / grouped[dept].length;
  return { dept, average: avg };
});
console.log("Dept Average:", deptAvg);


//  Sort by salary descending
employees.sort((a, b) => b.salary - a.salary);


// Tax deduction 
employees = employees.map(e => ({
  ...e,
  netSalary: e.salary * 0.9
}));

// Employees above average salary
let avgSalary = totalSalary / employees.length;
let aboveAvg = employees.filter(e => e.salary > avgSalary);
console.log("Above Average:", aboveAvg);

let table = employees.map(e =>
  `<tr><td>${e.name}</td><td>${e.dept}</td><td>${e.salary}</td></tr>`
).join("");

console.log("<table>" + table + "</table>");