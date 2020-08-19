class Greeter {
    greeting: string;

    constructor(message: string) {
        this.greeting = message;
    }

    greet() {
        return "Hello, " + this.greeting;
    }
}

let greeter = new Greeter("world");


function printSum(a, b) {
    console.log(a + b);
}

var customer = {
    first: "Antti",
    last: "Asiakas",
    email: "antti.asiakas@firma.fi"
};

let luku: number = 123;

console.log(customer.first);
printSum(1, 2);
