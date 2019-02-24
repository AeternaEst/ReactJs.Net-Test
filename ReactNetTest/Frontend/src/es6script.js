
class Hello {
    constructor(name) {
        this.name = name;
    }

    greeting() {
        const greeting = `Hello ${this.name}, nice to meet you`;
        console.log(greeting);
    }
}

const hello = new Hello("Nicholas");
hello.greeting();