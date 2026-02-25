let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];

// 1️. Remove duplicates
let unique = [...new Set(numbers)];
console.log("Unique:", unique);

// 2️. Second largest
let sorted = [...unique].sort((a, b) => b - a);
console.log("Second Largest:", sorted[1]);

// 3️. Frequency
let freq = numbers.reduce((acc, num) => {
  acc[num] = (acc[num] || 0) + 1;
  return acc;
}, {});
console.log("Frequency:", freq);

// 4️. First non-repeating
let firstNonRepeat = numbers.find(num => freq[num] === 1);
console.log("First Non-Repeating:", firstNonRepeat);

// 5️. Rotate by 2
let rotated = numbers.slice(2).concat(numbers.slice(0,2));
console.log("Rotated:", rotated);

// 6️. Flatten nested array
let nested = [1,2,[3,4,[5]]];
let flat = nested.flat(Infinity);
console.log("Flattened:", flat);

// 7. Missing number
let arr = [1,2,3,5,6];
let missing = [];
for(let i = 1; i <= 6; i++){
  if(!arr.includes(i)) missing.push(i);
}
console.log("Missing:", missing);