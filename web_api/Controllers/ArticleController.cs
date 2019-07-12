using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_api.Controllers
{
    public class ArticleController : ApiController
    {



        //[HttpGet]
        //public IHttpActionResult GetPageRow(int limit, int offset)
        //{
        //    //var lstRes = new List<Product>();

        //    ////实际项目中，通过后台取到集合赋值给lstRes变量。这里只是测试。
        //    //lstRes.Add(new Product() { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });
        //    //lstRes.Add(new Product() { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });

        //    //var oData = new { total = lstRes.Count, rows = lstRes.Skip(offset).Take(limit).ToList() };
        //    //return new PageResult(oData, Request);
        //}
    }

}
