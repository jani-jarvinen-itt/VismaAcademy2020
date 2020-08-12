import React from 'react';

class LifecycleDemo extends React.Component {

    constructor(props) {
        super(props);
        console.log("constructor()");

        this.state = { todoTitle: "" };
        console.log("constructor() -- tila alustettu");
    }

    componentDidMount() {
        console.log("componentDidMount()");

        fetch('https://jsonplaceholder.typicode.com/todos/1')
            .then(response => response.json())
            .then(json => {
                console.log("Fetch-kutsu on valmis.");
                console.log(json);

                this.setState({ todoTitle: json.title });
                console.log("SetState()-metodia kutsuttu.");
            });

        console.log("componentDidMount() -- fetch-kutsu tehty");
    }

    render() {
        console.log("render()");
        return (
            <div>
                <h1>Tämä on LifecycleDemo-komponentti</h1>
                <p>{this.state.todoTitle}</p>
            </div>);
    }
}

export default LifecycleDemo;
