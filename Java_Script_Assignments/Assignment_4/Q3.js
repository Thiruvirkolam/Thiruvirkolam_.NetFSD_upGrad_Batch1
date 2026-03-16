let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];

//  Total cart value
let total = cart.reduce((sum, item) =>
  sum + (item.price * item.qty), 0);
console.log("Total Cart Value:", total);

//  Increase quantity 
cart = cart.map(item =>
  item.id === 2 ? { ...item, qty: item.qty + 1 } : item
);

//  Remove product
cart = cart.filter(item => item.id !== 3);

//  Apply 10% discount above ₹10,000
cart = cart.map(item =>
  item.price > 10000
    ? { ...item, price: item.price * 0.9 }
    : item
);

//  Sort by total item price
cart.sort((a, b) =>
  (a.price * a.qty) - (b.price * b.qty)
);

//  Any product > ₹50,000
console.log("Expensive item exists:",
  cart.some(item => item.price > 50000)
);

//  All items in stock?
console.log("All in stock:",
  cart.every(item => item.qty > 0)
);

// Invoice format
let invoice = cart.map(item =>
  `${item.product} x${item.qty} = ₹${item.price * item.qty}`
).join("\n");
console.log("Invoice:\n" + invoice);

// Most expensive product
let expensive = cart.reduce((max, item) =>
  item.price > max.price ? item : max
);
console.log("Most Expensive:", expensive);

// GST 
let gst = total * 0.18;
console.log("GST:", gst);