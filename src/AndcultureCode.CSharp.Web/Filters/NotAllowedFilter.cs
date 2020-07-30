using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AndcultureCode.CSharp.Web.Filters {
    /// <summary>
    /// Filter for denying access to resource
    /// /// </summary>
    public class NotAllowedFilter : ActionFilterAttribute {
        /// <summary>
        /// Attribute that returns a 401 result
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting (ActionExecutingContext context) {
            context.Result = new UnauthorizedResult ();
        }
    }
}
