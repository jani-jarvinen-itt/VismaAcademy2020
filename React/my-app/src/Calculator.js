import React from 'react';

class Calculator extends React.Component {

    constructor(props) {
        super(props);

        this.state = { number1: 0, number2: 0 };
        //console.log("Calculator constructor.");

        this.saveUserInput = this.saveUserInput.bind(this);
        this.saveUserInput2 = this.saveUserInput2.bind(this);
        this.calculateSumOfNumbers = this.calculateSumOfNumbers.bind(this);
    }

    componentDidMount() {
    }

    calculateSumOfNumbers() {
        const num1 = parseInt(this.state.number1);
        const num2 = parseInt(this.state.number2);
        const sum = num1 + num2;
        alert("Lasketaan summaa: " + sum);
    }

    saveUserInput(event) {
        const input = event.target.value;
        this.setState({ number1: input });
        console.log("In saveUserInput(): " + input);
    }

    saveUserInput2(event) {
        const input = event.target.value;
        this.setState({ number2: input });
        console.log("In saveUserInput2(): " + input);
    }

    render() {
        console.log("render()");
        return (
            <div>
                <h1>Calculator</h1>
                <p><input type="text" onChange={this.saveUserInput} /></p>
                <p><input type="text" onChange={this.saveUserInput2} /></p>
                <p><button onClick={this.calculateSumOfNumbers}>Calculate sum</button></p>
            </div>);
    }
}

export default Calculator;
