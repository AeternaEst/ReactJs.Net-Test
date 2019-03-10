using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ReactNetTest.ReactConfig), "Configure")]

namespace ReactNetTest
{
	public static class ReactConfig
	{
		public static void Configure()
		{
            // If you want to use server-side rendering of React components, 
            // add all the necessary JavaScript files here. This includes 
            // your components as well as all of their dependencies.
            // See http://reactjs.net/ for more information. Example:
            //ReactSiteConfiguration.Configuration
            //	.AddScript("~/Scripts/First.jsx")
            //	.AddScript("~/Scripts/Second.jsx");

            // If you use an external build too (for example, Babel, Webpack,
            // Browserify or Gulp), you can improve performance by disabling 
            // ReactJS.NET's version of Babel and loading the pre-transpiled 
            // scripts. Example:
            //ReactSiteConfiguration.Configuration
            //	.SetLoadBabel(false)
            //	.AddScriptWithoutTransform("~/Scripts/bundle.server.js")

            //Can be disabled if Tutorial.jsx isen't loaded
            ReactSiteConfiguration.Configuration.SetLoadBabel(true);
            ReactSiteConfiguration.Configuration.SetLoadReact(true);

            ReactSiteConfiguration.Configuration.AddScriptWithoutTransform("~/Frontend/dist/server.bundle.js");

		    ReactSiteConfiguration.Configuration.AddScript("~/Tutorial/Tutorial.jsx");

            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
		    JsEngineSwitcher.Current.EngineFactories.AddV8();		    
        }
	}
}