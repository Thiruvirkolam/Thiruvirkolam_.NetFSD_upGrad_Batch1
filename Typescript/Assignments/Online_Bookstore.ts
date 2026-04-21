class Book {
    isbn: number
    bookname: string
    booktitle: string
    bookauthor: string
    quantityofbooks: number
    bookprice: number

    constructor(isbn: number, name: string, title: string, author: string, qty: number, price: number) {
        this.isbn = isbn
        this.bookname = name
        this.booktitle = title
        this.bookauthor = author
        this.quantityofbooks = qty
        this.bookprice = price
    }

    calculateBill(): number {
        return this.quantityofbooks * this.bookprice
    }

    display(): void {
        console.log(this.isbn, this.bookname, this.booktitle, this.bookauthor, this.quantityofbooks, this.bookprice)
        console.log("Bill Amount:", this.calculateBill())
    }
}

let b = new Book(101, "TS Basics", "Learn TS", "John", 5, 200)
b.display()