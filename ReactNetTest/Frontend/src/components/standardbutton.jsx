import React from 'react';

const StandardButton = (props) => {
    return (
        <button className={props.class} onClick={props.onClick}>{props.children}</button>  
    );
}

export default StandardButton;