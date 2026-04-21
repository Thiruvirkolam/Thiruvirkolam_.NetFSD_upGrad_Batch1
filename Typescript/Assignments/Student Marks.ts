class Student {
    rollNo: number
    studName: string
    eng: number
    maths: number
    science: number

    constructor(r: number, n: string, e: number, m: number, s: number) {
        this.rollNo = r
        this.studName = n
        this.eng = e
        this.maths = m
        this.science = s
    }

    total(): number {
        return this.eng + this.maths + this.science
    }

    percentage(): number {
        return this.total() / 3
    }

    display(): void {
        console.log(this.rollNo, this.studName)
        console.log("Total:", this.total())
        console.log("Percentage:", this.percentage())
    }
}

let st = new Student(1, "Ashwin", 85, 90, 80)
st.display()