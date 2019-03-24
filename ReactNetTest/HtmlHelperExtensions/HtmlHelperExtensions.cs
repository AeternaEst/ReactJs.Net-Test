using Newtonsoft.Json;
using React;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using React.Web.Mvc;

namespace ReactNetTest.HtmlHelperExtensions
{
    public static class HtmlHelperExtensions
    {
        private static IReactEnvironment Environment
        {
            get
            {
                return ReactEnvironment.GetCurrentOrThrow;
            }
        }

        public static IHtmlString ReactWithModel<T>(this HtmlHelper htmlHelper, string componentName, T props, string htmlTag = null, string containerId = null, bool clientOnly = false, bool serverOnly = false, string containerClass = null, Action<Exception, string, string> exceptionHandler = null, IRenderFunctions renderFunctions = null)
        {
            try
            {
                var sb = new StringBuilder();
                containerId = componentName.ToLower();

                IReactComponent component = Environment.CreateComponent<T>(componentName, props, containerId, clientOnly, serverOnly);
                if (!string.IsNullOrEmpty(htmlTag))
                    component.ContainerTag = htmlTag;
                if (!string.IsNullOrEmpty(containerClass))
                    component.ContainerClass = containerClass;

                var originalResult = component.RenderHtml(clientOnly, serverOnly);
                var serializedModel = JsonConvert.SerializeObject(props);

                sb.Append($"<div data-react-component=\"{componentName.ToLower()}\">");
                sb.Append(originalResult);
                sb.Append($"<script>");
                sb.Append($"{serializedModel}");
                sb.Append("</script>");
                sb.Append("</div>");

                return new HtmlString(sb.ToString());
            }
            finally
            {
                Environment.ReturnEngineToPool();
            }
        }
    }
}