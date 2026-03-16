class Animal {
    makeSound() {
        console.log("Animal makes sound");
    }
}

class Dog extends Animal {
    makeSound() {
        console.log("Woof");
    }
}

class Cat extends Animal {
    makeSound() {
        console.log("Meow");
    }
}

class Cow extends Animal {
    makeSound() {
        console.log("Moo");
    }
}

let animals = [new Dog(), new Cat(), new Cow()];
animals.forEach(a => a.makeSound());