let books = [
  { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
  { id: 2, title: "React Guide", price: 650, stock: 5 },
  { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
  { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];

// 1. Display all book titles
console.log("Titles:");
console.log(books.map(book => book.title));

// 2. Total inventory value
let totalValue = books.reduce((total, book) =>
  total + (book.price * book.stock), 0);
console.log("Total Inventory Value:", totalValue);

// 3. Books above
console.log("Books above 500:");
console.log(books.filter(book => book.price > 500));

// 4. Increase price
books = books.map(book => ({
  ...book,
  price: Math.round(book.price * 1.05)
}));
console.log("After 5% increase:", books);

// 5. Sort by price
books.sort((a, b) => a.price - b.price);
console.log("Sorted by price:", books);

// 6. Remove book by ID
books = books.filter(book => book.id !== 2);
console.log("After removing ID 2:", books);

// 7. Check out of stock
console.log("Any out of stock?",
  books.some(book => book.stock === 0));