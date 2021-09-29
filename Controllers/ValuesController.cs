using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Swashbuckle.Swagger.Annotations;

namespace NetFrameworkOpenApiExample.Controllers
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Get list of values.
        /// </summary>
        /// <returns></returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<int>))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get Value.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(int))]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Add value.
        /// </summary>
        /// <param name="value"></param>
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Update value.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Delete value.
        /// </summary>
        /// <param name="id"></param>
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        public void Delete(int id)
        {
        }
    }
}
