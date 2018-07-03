import React from "react"
import { render } from "react-dom"
import axois from "axios"

function getObject() {
    return axois.get<{ f1: any, f2: any }>("/api/date/getObject")
}

function sendObject(obj) {
    return axois.post("/api/date/sendObject", obj)
}

class App extends React.Component {

    constructor(props) {
        super(props);

        getObject().then(rs => {
            console.log(rs);
            const f1 = new Date(rs.data.f1);
            console.log(f1);
        });
    }

    componentDidCatch(error, info) {
        console.log(error)
    }

    sendData = (e) => {
        sendObject({
            f1: new Date(),
            f2: "Hello"
        }).then(data => {
            console.log(data.data);
        });
    }

    render() {
        return (
            <div>
                <h1>Hello, world!</h1>
                <button onClick={this.sendData}>Send</button>
            </div>
        )
    }
}

var el = document.getElementById("root");

render(<App />, el);