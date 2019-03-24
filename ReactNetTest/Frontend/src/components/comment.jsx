import React from "react";

class Comment extends React.Component {
  constructor(props) {
      super(props);
    }
    render() {
      return (<div>
          <h5>{this.props.name}</h5>
          <span>{this.props.date}</span>
          <p>{this.props.text}</p>
      </div>);
  }
}

export default Comment
