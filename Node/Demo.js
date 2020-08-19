var Greeter = /** @class */ (function () {
    function Greeter(message) {
        this.greeting = message;
    }
    Greeter.prototype.greet = function () {
        return "Hello, " + this.greeting;
    };
    return Greeter;
}());
var greeter = new Greeter("world");
function printSum(a, b) {
    console.log(a + b);
}
var customer = {
    first: "Antti",
    last: "Asiakas",
    email: "antti.asiakas@firma.fi"
};
var luku = 123;
console.log(customer.first);
printSum(1, 2);
