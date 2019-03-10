import React from "react";

class HelloWorld extends React.Component {
  constructor(props) {
      super(props);
    }
  componentDidMount() {
      window.setInterval(() => console.log("hello"), 1000);
  }
  render() {
    return (<div>Hello World</div>);
  }
}

export default HelloWorld
