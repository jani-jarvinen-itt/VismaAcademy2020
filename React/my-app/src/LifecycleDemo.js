import React from 'react';

class LifecycleDemo extends React.Component {

    constructor(props) {
        super(props);
        console.log("constructor()");
    }

    componentDidMount() {
        console.log("componentDidMount()");
    }

    render() {
        console.log("render()");
        return <h1>Tämä on LifecycleDemo-komponentti</h1>;
    }
}

export default Hello2;
