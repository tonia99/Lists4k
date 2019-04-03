using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Laba1FP.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get(List<int> firstArray, List<int> secondArray)
        {
            var result = string.Empty;
            if (!firstArray.Any())
            {
                return new ContentResult
                {
                    Content = result,
                    ContentType = "text/plain",
                    StatusCode = 200
                };
            }

            if (!secondArray.Any())
            {
                firstArray.ForEach(x => result += x.ToString());
                return new ContentResult
                {
                    Content = result,
                    ContentType = "text/plain",
                    StatusCode = 200
                };
            }

            var elements = firstArray.Where(x => Enumerable.Count(secondArray.Where(y => y == x)) == 2)
                .Distinct()
                .ToList();

            
            elements.ForEach(x => firstArray.RemoveAll(y => y == x));
            firstArray.ForEach(x => result += x.ToString());
            
            

            
            
            return new ContentResult
            {
                Content = result,
                ContentType = "text/plain",
                StatusCode = 200
            };
           
        }
        

    }
}