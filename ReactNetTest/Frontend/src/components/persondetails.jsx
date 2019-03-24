import React from 'react';
import StandardButton from './standardbutton';

class PersonDetails extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            isSelected: false
        }
        this.select.bind(this);
    }

    select() {
        const selected = !this.state.isSelected;
        this.setState({
            isSelected: selected
        });
    }

    render() {
        return (
            <div className={this.state.isSelected ? "person-details person-details--selected" : "person-details"}>
                <p>{this.props.id}</p>
                <p>{this.props.name}</p>
                <p>{this.props.age}</p>
                <StandardButton class="background-green" onClick={() => this.select()}>{this.state.isSelected ? "Unselect" : "Select"}</StandardButton>
                <StandardButton class="background-red" onClick={this.props.buttonDeleteClick}>Remove</StandardButton>
            </div>
        )
    }
}

export default PersonDetails;