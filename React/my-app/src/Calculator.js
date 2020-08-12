import React from 'react';

class Calculator extends React.Component {

    constructor(props) {
        super(props);
    }

    componentDidMount() {
    }

    render() {
        return (
            <div>
                <h1>Calculator</h1>
                <p><input type="text" /></p>
                <p><input type="text" /></p>
                <p><button>Calculate sum</button></p>
            </div>);
    }
}

export default Calculator;
