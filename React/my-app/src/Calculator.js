import React from 'react';

class Calculator extends React.Component {

    constructor(props) {
        super(props);

        console.log("Calculator constructor.");
    }

    componentDidMount() {
    }

    calculateSumOfNumbers() {
        alert("Lasketaan summaa!");
    }

    render() {
        return (
            <div>
                <h1>Calculator</h1>
                <p><input type="text" /></p>
                <p><input type="text" /></p>
                <p><button onClick={this.calculateSumOfNumbers}>Calculate sum</button></p>
            </div>);
    }
}

export default Calculator;
