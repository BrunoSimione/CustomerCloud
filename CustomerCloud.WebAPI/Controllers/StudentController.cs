using CustomerCloud.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CustomerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/customercloud/v1")]
    public class StudentController : ApiController
    {
      
        [HttpGet]
        [Route("student/{id}")]
        [ResponseType(typeof(Student))]
        [CustomAuthorization]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new Student() { FirstName = "Bruno", LastName = "Smith" });
        }

        [HttpPost]
        [Route("student")]
        [CustomAuthorization]
        public HttpResponseMessage Post([FromBody] Student student)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPut]
        [Route("student")]
        [CustomAuthorization]
        public HttpResponseMessage Put([FromBody] Student student)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        [Route("student/{id}")]
        [CustomAuthorization]
        public HttpResponseMessage Delete(Guid id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        
    }
}
