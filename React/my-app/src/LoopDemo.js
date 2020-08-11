import React from 'react';

class LoopDemo extends React.Component {
    render() {
        let luvut = [];
        for (let index = 1; index < 10; index++) {

            let colorStyle = null;
            if (index % 2 === 0) {
                colorStyle = { color: "red" };
            }

            luvut.push(<li style={colorStyle}>{index}</li>);
        }

        return <ul>{luvut}</ul>;
    }
}

export default LoopDemo;
