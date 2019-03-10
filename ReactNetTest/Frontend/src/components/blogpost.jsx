import React from "react";
import Comment from "./comment";
import Loader from "./loader"

class BlogPost extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            isLoading: true,
            comments: []
        };
    }

    componentDidMount() {
        const xhr = new XMLHttpRequest();
        xhr.open('get', '/blogpost/getcomments', true);
        xhr.onload = () => {
            const data = JSON.parse(xhr.responseText);
            this.setState({
                isLoading: false,
                comments: data
            });
        };
        xhr.send();
    }

    render() {
        return (<div className="blogpost">
                    <h2>{this.props.title}</h2>
                    <span>{this.props.subject} - {this.props.date}</span>
                    <p>{this.props.text}</p>
                    <div className="comments">
                        {this.state.isLoading
                            ? <Loader/>
                    : this.state.comments.map((value, index) => (
                                    (<div key={index}>
                                         <Comment name={value.name} date={value.date} text={value.text}/>
                                     </div>)
                                )
                            )}
                    </div>
                </div>);
    }
}

export default BlogPost
