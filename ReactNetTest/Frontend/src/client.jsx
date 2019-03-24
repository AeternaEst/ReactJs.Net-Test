import React from 'react';
import ReactDOM from 'react-dom';
import BlogPost from './components/blogpost';

/* Add Components manually here*/
//const helloWorld = document.getElementById("helloworld");
//if (helloWorld) {
//    console.log("Hydrating helloworld");
//    ReactDOM.hydrate(<HelloWorld/>, helloWorld);
//}

//const blogpostComponent = document.querySelector("div[data-react-component=blogpost]");
//const blogpostContainer = blogpostComponent.querySelector("#blogpost");
//const blogpostScript = blogpostComponent.querySelector("script");
//if (blogpostComponent && blogpostContainer && blogpostScript) {
//    console.log("Hydrating blogpost");
//    const blogpostData = blogpostScript.innerText;
//    const blogpostProps = JSON.parse(blogpostData);
//    ReactDOM.hydrate(<BlogPost {...blogpostProps}/>, blogpostContainer);
//}

/* Automatically add components */
const components = document.querySelectorAll("div[data-react-component]");
components.forEach(component => {
    const componentId = component.getAttribute("data-react-component");
    console.log(`Found component: ${componentId}`);
    const componentContainer = component.querySelector(`#${componentId}`);
    const componentScript = component.querySelector("script");
    if (componentContainer && componentScript) {
        console.log(`Hydrating: ${componentId}`);
        const componentData = componentScript.innerText;
        const componentProps = JSON.parse(componentData);
        import(`./components/${componentId}`).then(foo => {
            console.log(foo.default);
            console.log(componentProps);
            console.log(componentContainer);
            const t = React.createElement(foo.default, { ...componentProps });
            ReactDOM.hydrate(t, componentContainer);
        });        
    } else {
        console.log(`Unable to load container or script for component: ${componentId}`);
    }
});