import React from 'react';
import ReactDOM from 'react-dom';
import ReactDOMServer from 'react-dom/server';

import HelloWorld from './components/helloworld';
import BlogPost from './components/blogpost';
import PersonOverview from './components/personoverview';
import PersonList from './components/personlist';
import PersonDetails from './components/persondetails';
import StandardButton from './components/standardbutton';

global.React = React;
global.ReactDOM = ReactDOM;
global.ReactDOMServer = ReactDOMServer;

global.HelloWorld = HelloWorld;
global.BlogPost = BlogPost;

global.PersonOverview = PersonOverview;
global.PersonList = PersonList;
global.PersonDetails = PersonDetails;
global.PersonButton = StandardButton;
