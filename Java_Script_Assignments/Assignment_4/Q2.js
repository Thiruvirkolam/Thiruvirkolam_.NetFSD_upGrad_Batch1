let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Meena", marks: 45 },
  { name: "Karan", marks: 30 }
];

//  Passed students 
let passed = students.filter(s => s.marks >= 40);
console.log("Passed Students:", passed);

//  Distinction students
let distinction = students.filter(s => s.marks >= 85);
console.log("Distinction Students:", distinction);

//  Class Average
let average = students.reduce((sum, s) => sum + s.marks, 0) / students.length;
console.log("Class Average:", average.toFixed(2));

//  Find Topper
let topper = students.reduce((max, s) => 
  s.marks > max.marks ? s : max
);
console.log("Topper:", topper);

// Count Failed Students
let failedCount = students.filter(s => s.marks < 40).length;
console.log("Failed Count:", failedCount);

// Convert marks to Grades
let gradedStudents = students.map(s => {
  let grade;
  
  if (s.marks >= 85) grade = "A";
  else if (s.marks >= 60) grade = "B";
  else if (s.marks >= 40) grade = "C";
  else grade = "Fail";

  return { ...s, grade };
});
console.log("Students with Grades:", gradedStudents);

// Add Rank
let ranked = [...students]
  .sort((a, b) => b.marks - a.marks)
  .map((s, index) => ({
    ...s,
    rank: index + 1
  }));

console.log("Ranked List:", ranked);

// Remove Lowest Scorer
let withoutLowest = [...students]
  .sort((a, b) => b.marks - a.marks)
  .slice(0, students.length - 1);

console.log("After Removing Lowest:", withoutLowest);

// Leaderboard 
let leaderboard = [...students]
  .sort((a, b) => b.marks - a.marks);

console.log("Leaderboard:", leaderboard);