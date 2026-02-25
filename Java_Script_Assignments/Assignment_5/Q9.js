class Product {
    constructor({ name, price, category = "General" }) {
        this.name = name;
        this.price = price;
        this.category = category;
    }

    getDetails = () => {
        const { name, price, category } = this;
        return `${name} costs ₹${price} and belongs to ${category}`;
    }

    cloneWithChanges(newValues) {
        return new Product({ ...this, ...newValues });
    }
}

let p1 = new Product({ name: "Laptop", price: 60000 });
console.log(p1.getDetails());

let p2 = p1.cloneWithChanges({ price: 55000, category: "Electronics" });
console.log(p2.getDetails());