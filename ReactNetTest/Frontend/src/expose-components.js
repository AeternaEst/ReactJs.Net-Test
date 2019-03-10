import React from 'react';
import ReactDOM from 'react-dom';
import ReactDOMServer from 'react-dom/server';

import HelloWorld from './components/helloworld';
import BlogPost from './components/blogpost';

global.React = React;
global.ReactDOM = ReactDOM;
global.ReactDOMServer = ReactDOMServer;

global.HelloWorld = HelloWorld;
global.BlogPost = BlogPost;
