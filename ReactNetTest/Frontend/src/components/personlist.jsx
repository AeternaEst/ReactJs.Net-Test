import React from "react";
import PersonDetails from './persondetails';
import Loader from './loader';

const fakePeopleList = [
    { name: "Nicholas", age: 29, id: 1 },
    { name: "Nicholas Lind", age: 29, id: 2 },
    { name: "Nicholas Lindboe", age: 29, id: 3 }
];

class PersonList extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            isLoading: true,
            persons: []
        }
        this.deletePerson.bind(this);
    }

    componentDidMount() {
        window.setTimeout(() => {
            this.setState({
                persons: fakePeopleList,
                isLoading: false
            });
        }, 3000);        
    }

    deletePerson(id) {
        const currentList = this.state.persons;
        const index = currentList.findIndex(person => person.id === id);
        currentList.splice(index, 1);
        this.setState({
            persons: currentList
        });
    } 

    render() {
        console.log(this.state.persons);
        return (
            <div className="person-list">
                {
                    this.state.isLoading ?
                        <Loader /> :
                        this.state.persons.map((person, index) => (
                            <div key={index}>
                                <PersonDetails name={person.name} age={person.age} id={person.id} buttonDeleteClick={() => this.deletePerson(person.id)}/> 
                            </div>)
                        )
                }
            </div>    
        )
    }
}

export default PersonList;