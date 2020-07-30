using AndcultureCode.CSharp.Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AndcultureCode.CSharp.Web.Filters {
    /// <summary>
    /// Filter for validating ModelState
    /// </summary>
    public class ValidationFilter : ActionFilterAttribute {
        /// <summary>
        /// Validates ModelState
        /// Returns 400 Response with errors if invalid
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting (ActionExecutingContext context) {
            if (context.ModelState.IsValid) {
                return;
            }

            // Return an IResult containing all validation errors
            context.Result = new BadRequestObjectResult (context.ModelState.ToResult<object> ());
        }
    }
}
