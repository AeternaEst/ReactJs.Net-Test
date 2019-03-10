using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ReactNetTest.Models.Json
{
    public class JsonResult : ActionResult
    {
        public object Data { get; set; }

        public JsonResult(object Data)
        {
            this.Data = Data;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            HttpResponseBase response = context.HttpContext.Response;

            var serializedObject = JsonConvert.SerializeObject(Data);

            response.Write(serializedObject);
        }
    }
}