using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.Results;
using System.Web.WebPages;

namespace web_api.Filter
{
    public class BasicAuthenticationAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 检查用户是否有该Action执行的操作权限
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {

            bool isRquired = false;

            try
            {
                //获取刚才在webconfig中的添加的权限开关
                isRquired = WebConfigurationManager.AppSettings["WebApiAuthFlag"].ToString().AsBool();
            }
            catch (Exception ex)
            {
                //抛出异常
            }

            //如果开启...
            if (isRquired)
            {
                bool isLogin = false;

                //CookieHeaderValue cookie = actionContext.Request.Headers.GetCookies("login_key").FirstOrDefault();
                //if (cookie != null)
                //{
                //    var key = cookie["login_key"].Value;

                //}
                ////如果已经登录，则跳过验证
                //else
                //{
                //    actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                //}

                if (isLogin)
                {
                    base.OnActionExecuting(actionContext);
                   
                }
                else
                {
                    //如果请求Header不包含ticket，则判断是否是匿名调用
                    var attr = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().OfType<AllowAnonymousAttribute>();
                    bool isAnonymous = attr.Any(a => a is AllowAnonymousAttribute);

                    //是匿名用户，则继续执行；非匿名用户，抛出“未授权访问”信息 ( 抛出401 )
                    if (isAnonymous)
                        base.OnActionExecuting(actionContext);
                    else
                        actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                }
            }
        }
 
    }
}