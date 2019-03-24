import React from 'react';
import PersonList from './personlist';

const PersonOverview = (props) => {
    return (<div>
        <h2>{props.overviewTitle}</h2>
        <h5>{props.overviewManchet}</h5>
        <PersonList />
    </div>)
}

export default PersonOverview;