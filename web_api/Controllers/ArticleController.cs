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



        [HttpGet, AllowAnonymous]
        public IEnumerable<tArticle> GetAllArticle()
        {
            using (xdwlEntities dbContext = new xdwlEntities())
            {
                List<tArticle> list = dbContext.tArticle.Where(u => u.ArtTyID == (int)5).ToList();
                return list;
            }
        }


        [HttpGet, AllowAnonymous]
        public IHttpActionResult GetArticle(int id)
        {
            using (xdwlEntities dbContext = new xdwlEntities())
            {
                tArticle contact = dbContext.tArticle.Find(id);

                if (contact == null)
                {
                    return NotFound();
                }
                return Ok(contact);
            }
        }
    }

}
