using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using React;
using React.Web.Mvc;

namespace ReactNetTest.Models.React
{
    public class ReactResult<T> : ActionResult
    {
        private readonly T _model;
        private readonly string _tag;
        private readonly string _containerClass;
        private readonly string _containerId;
        private readonly string _componentName;
        private readonly bool _clientOnly;
        private readonly bool _serverOnly;

        public ReactResult(string componentName, T model, bool clientOnly = false, bool serverOnly = false,
            string containerId = null, string containerClass = null, string tag = null)
        {
            _componentName = componentName;
            _model = model;
            _containerId = containerId;
            _containerClass = containerClass;
            _tag = tag;
            _clientOnly = clientOnly;
            _serverOnly = serverOnly;
        }

        /// <summary>Gets the React environment</summary>
        private static IReactEnvironment Environment
        {
            get
            {
                return ReactEnvironment.GetCurrentOrThrow;
            }
        }

        /// <summary>
        /// This will override the layout in a normal MVC app, since the view isen't invoked.
        /// Makes more sense to use on a Sitecore website
        /// </summary>
        /// <param name="context"></param>
        public override void ExecuteResult(ControllerContext context)
        {
            try
            {
                HttpResponseBase response = context.HttpContext.Response;
                var sb = new StringBuilder();

                IReactComponent component = Environment.CreateComponent<T>(_componentName, _model, _containerId, _clientOnly, _serverOnly);
                if (!string.IsNullOrEmpty(_tag))
                    component.ContainerTag = _tag;
                if (!string.IsNullOrEmpty(_containerClass))
                    component.ContainerClass = _containerClass;

                var originalResult = component.RenderHtml(_clientOnly, _serverOnly);
                var serializedModel = JsonConvert.SerializeObject(_model);

                sb.Append($"<div data-react-component=\"{_componentName.ToLower()}\">");
                sb.Append(originalResult);
                sb.Append($"<script>");
                sb.Append(serializedModel);
                sb.Append("</script>");
                sb.Append("</div>");

                response.Write(sb.ToString());
            }
            finally
            {
                Environment.ReturnEngineToPool();
            }
        }
    }
}