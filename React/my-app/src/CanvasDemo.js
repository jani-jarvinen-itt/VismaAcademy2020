import React from 'react';

class CanvasDemo extends React.Component {

    constructor(props) {
        super(props);

        this.myCanvas = React.createRef();
        this.drawRectangle = this.drawRectangle.bind(this);
    }

    componentDidMount() {

        const canvas = this.myCanvas.current;
        const ctx = canvas.getContext('2d');

        ctx.fillStyle = 'green';
        ctx.fillRect(10, 10, 150, 100);
    }

    drawRectangle() {

        const canvas = this.myCanvas.current;
        const ctx = canvas.getContext('2d');

        ctx.fillStyle = 'black';
        ctx.fillRect(25, 25, 100, 100);
        ctx.clearRect(45, 45, 60, 60);
        ctx.strokeRect(50, 50, 50, 50);
    }

    render() {

        return (
            <div>
                <canvas width="400" height="300" ref={this.myCanvas}></canvas>
                <p><button onClick={this.drawRectangle}>Draw</button></p>
            </div>
        );
    }
}

export default CanvasDemo;
