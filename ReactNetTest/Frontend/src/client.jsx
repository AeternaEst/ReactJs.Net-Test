import React from 'react';
import ReactDOM from 'react-dom';
import HelloWorld from './components/helloworld';
import BlogPost from './components/blogpost';

/* Add Components here*/
const helloWorld = document.getElementById("helloworld");
if (helloWorld) {
    console.log("Hydrating helloworld");
    ReactDOM.hydrate(<HelloWorld/>, helloWorld);
}

const blogpost = document.getElementById("blogpost");
if (blogpost) {
    console.log("Hydrating blogpost");
    const blogpostData = document.getElementById("blogpostdata").innerText;
    const blogpostProps = JSON.parse(blogpostData);
    ReactDOM.hydrate(<BlogPost {...blogpostProps} />, blogpost);
}