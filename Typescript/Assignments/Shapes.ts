class Shapes {
    area(a: number, b: number): number
    area(a: number): number
    area(a: number, b?: number): number {
        if (b !== undefined) return a * b
        return Math.PI * a * a
    }

    triangle(base: number, height: number): number {
        return 0.5 * base * height
    }
}

let s = new Shapes()
console.log("Rectangle:", s.area(10, 5))
console.log("Square:", s.area(4, 4))
console.log("Circle:", s.area(3))
console.log("Triangle:", s.triangle(6, 8))