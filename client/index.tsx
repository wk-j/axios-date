import React from "react"
import { render } from "react-dom"
import axois from "axios"

function getObject() {
    return axois.get<{ f1: any, f2: any }>("/api/date/getObject")
}

class App extends React.Component {

    constructor(props) {
        super(props);

        getObject().then(rs => {
            const f1 = new Date(rs.data.f1);
            console.log(f1);
        });
    }

    componentDidCatch(error, info) {
        console.log(error)
    }

    render() {
        return (
            <h1>Hello, world!</h1>
        )
    }
}

var el = document.getElementById("root");

render(<App />, el);