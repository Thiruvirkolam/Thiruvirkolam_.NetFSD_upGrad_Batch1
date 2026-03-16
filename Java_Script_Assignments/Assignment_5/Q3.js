class Student {
    constructor(name) {
        this.name = name;
        this.marks = [];
    }

    addMark(mark) {
        this.marks.push(mark);
    }

    getAverage() {
        if (this.marks.length === 0) 
            return 0;
        let total = this.marks.reduce((sum, m) => sum + m, 0);
        return total / this.marks.length;
    }

    getGrade() {
        let avg = this.getAverage();
        if (avg >= 90) return "A";
        if (avg >= 75) return "B";
        if (avg >= 50) return "C";
        return "Fail";
    }
}