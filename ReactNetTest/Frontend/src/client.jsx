import React from 'react';
import ReactDOM from 'react-dom';
import HelloWorld from './components/helloworld';

ReactDOM.hydrate(<HelloWorld />, document.getElementById("helloworld"))