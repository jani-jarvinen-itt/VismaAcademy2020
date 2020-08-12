import React from 'react';

class LifecycleDemo extends React.Component {

    constructor(props) {
        super(props);
        console.log("constructor()");
    }

    componentDidMount() {
        console.log("componentDidMount()");

        fetch('https://jsonplaceholder.typicode.com/todos/1')
            .then(response => response.json())
            .then(json => {
                console.log("Fetch-kutsu on valmis.");
                console.log(json);
            });

        console.log("componentDidMount() -- fetch-kutsu tehty");
    }

    render() {
        console.log("render()");
        return (
            <div>
                <h1>Tämä on LifecycleDemo-komponentti</h1>
                <p></p>
            </div>);
    }
}

export default LifecycleDemo;
