import React from 'react';

class LifecycleDemo extends React.Component {

    constructor(props) {
        super(props);
        console.log("constructor()");

        this.state = { kellonaika: "" };
        console.log("constructor() -- tila alustettu");
    }

    componentDidMount() {
        console.log("componentDidMount()");

        fetch('https://localhost:44357/api/values/kellonaika')
            .then(response => response.json())
            .then(json => {
                console.log("Fetch-kutsu on valmis.");
                console.log(json);

                this.setState({ kellonaika: json.aika });
                console.log("SetState()-metodia kutsuttu.");
            });

        console.log("componentDidMount() -- fetch-kutsu tehty");
    }

    render() {
        console.log("render()");
        return (
            <div>
                <h1>Tämä on LifecycleDemo-komponentti</h1>
                <p>{this.state.kellonaika}</p>
            </div>);
    }
}

export default LifecycleDemo;
