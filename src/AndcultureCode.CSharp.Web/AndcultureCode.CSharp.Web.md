<a name='assembly'></a>
# AndcultureCode.CSharp.Web

## Contents

- [IApiEntityControllerExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions 'AndcultureCode.CSharp.Web.Extensions.IApiEntityControllerExtensions')
  - [GetDefault\`\`3(controller,id)](#M-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions-GetDefault``3-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1},System-Int64- 'AndcultureCode.CSharp.Web.Extensions.IApiEntityControllerExtensions.GetDefault``3(AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{``0,``1},System.Int64)')
  - [IndexDefault\`\`3(controller)](#M-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions-IndexDefault``3-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1}- 'AndcultureCode.CSharp.Web.Extensions.IApiEntityControllerExtensions.IndexDefault``3(AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{``0,``1})')
- [IApiEntityController\`2](#T-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController`2')
  - [Conductor](#P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Conductor 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController`2.Conductor')
  - [Logger](#P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Logger 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController`2.Logger')
  - [Mapper](#P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Mapper 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController`2.Mapper')
- [IApplicationBuilderExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions 'AndcultureCode.CSharp.Web.Extensions.IApplicationBuilderExtensions')
  - [UseCookieAuthentication(app,mode)](#M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseCookieAuthentication-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Http-SameSiteMode- 'AndcultureCode.CSharp.Web.Extensions.IApplicationBuilderExtensions.UseCookieAuthentication(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Http.SameSiteMode)')
  - [UseGlobalExceptionHandler()](#M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseGlobalExceptionHandler-Microsoft-AspNetCore-Builder-IApplicationBuilder- 'AndcultureCode.CSharp.Web.Extensions.IApplicationBuilderExtensions.UseGlobalExceptionHandler(Microsoft.AspNetCore.Builder.IApplicationBuilder)')
- [IController](#T-AndcultureCode-CSharp-Web-Interfaces-IController 'AndcultureCode.CSharp.Web.Interfaces.IController')
  - [CurrentCulture](#P-AndcultureCode-CSharp-Web-Interfaces-IController-CurrentCulture 'AndcultureCode.CSharp.Web.Interfaces.IController.CurrentCulture')
  - [Accepted\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Accepted``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Accepted``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [BadRequest(key,message,type)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest(System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType)')
  - [BadRequest\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [BadRequest\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [BadRequest\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest``1(``0,AndcultureCode.CSharp.Core.Interfaces.IError[])')
  - [BadRequest\`\`1(value,key,message,type)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType- 'AndcultureCode.CSharp.Web.Interfaces.IController.BadRequest``1(``0,System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType)')
  - [Conflict\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Conflict``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Conflict``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Conflict\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Conflict``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Conflict``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreateResult\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreateResult``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreateResult``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtAction\`\`1(actionName,routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtAction``1(System.String,System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtAction\`\`1(actionName,controllerName,routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtAction``1(System.String,System.String,System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtAction\`\`1(actionName,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtAction``1(System.String,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtRoute\`\`1(routeName,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtRoute``1(System.String,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtRoute\`\`1(routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtRoute``1(System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [CreatedAtRoute\`\`1(routeName,routeValues,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.CreatedAtRoute``1(System.String,System.Object,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Created\`\`1(value)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-``0- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(``0)')
  - [Created\`\`1(uriIdentifier,value)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-Int64,``0- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(System.Int64,``0)')
  - [Created\`\`1(uri,value)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-String,``0- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(System.String,``0)')
  - [Created\`\`1(uri,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(System.String,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Created\`\`1(uri,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-Uri,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Created``1(System.Uri,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Forbidden\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Forbidden``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Forbidden\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]- 'AndcultureCode.CSharp.Web.Interfaces.IController.Forbidden``1(``0,AndcultureCode.CSharp.Core.Interfaces.IError[])')
  - [Forbidden\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Forbidden``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [Forbidden\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-AndcultureCode-CSharp-Core-Interfaces-IError[]- 'AndcultureCode.CSharp.Web.Interfaces.IController.Forbidden``1(AndcultureCode.CSharp.Core.Interfaces.IError[])')
  - [InternalError\`\`1(value,errors,logger)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger- 'AndcultureCode.CSharp.Web.Interfaces.IController.InternalError``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError},Microsoft.Extensions.Logging.ILogger)')
  - [InternalError\`\`1(errors,logger)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger- 'AndcultureCode.CSharp.Web.Interfaces.IController.InternalError``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError},Microsoft.Extensions.Logging.ILogger)')
  - [InternalError\`\`1(key,message,type,logger)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType,Microsoft-Extensions-Logging-ILogger- 'AndcultureCode.CSharp.Web.Interfaces.IController.InternalError``1(System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType,Microsoft.Extensions.Logging.ILogger)')
  - [NotFound\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.NotFound``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [NotFound\`\`1(errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.NotFound``1(System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [NotFound\`\`1(value,key,message,type)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType- 'AndcultureCode.CSharp.Web.Interfaces.IController.NotFound``1(``0,System.String,System.String,AndcultureCode.CSharp.Core.Enumerations.ErrorType)')
  - [NotFound\`\`1()](#M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1 'AndcultureCode.CSharp.Web.Interfaces.IController.NotFound``1')
  - [Ok\`\`1(value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-Ok``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.Ok``1(``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
  - [StatusCode\`\`1(statusCode,value,errors)](#M-AndcultureCode-CSharp-Web-Interfaces-IController-StatusCode``1-System-Int32,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- 'AndcultureCode.CSharp.Web.Interfaces.IController.StatusCode``1(System.Int32,``0,System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError})')
- [IExceptionHandlerFeatureExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions 'AndcultureCode.CSharp.Web.Extensions.IExceptionHandlerFeatureExtensions')
  - [ToResult()](#M-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions-ToResult-Microsoft-AspNetCore-Diagnostics-IExceptionHandlerFeature- 'AndcultureCode.CSharp.Web.Extensions.IExceptionHandlerFeatureExtensions.ToResult(Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature)')
- [IServiceCollectionExtensions](#T-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions 'AndcultureCode.CSharp.Web.Extensions.IServiceCollectionExtensions')
  - [AddCookieAuthentication(services,config)](#M-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions-AddCookieAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfigurationRoot- 'AndcultureCode.CSharp.Web.Extensions.IServiceCollectionExtensions.AddCookieAuthentication(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfigurationRoot)')
  - [AddForwardedHeaders(services)](#M-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions-AddForwardedHeaders-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'AndcultureCode.CSharp.Web.Extensions.IServiceCollectionExtensions.AddForwardedHeaders(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [ModelStateDictionaryExtensions](#T-AndcultureCode-CSharp-Web-Extensions-ModelStateDictionaryExtensions 'AndcultureCode.CSharp.Web.Extensions.ModelStateDictionaryExtensions')
  - [ToResult\`\`1(modelState)](#M-AndcultureCode-CSharp-Web-Extensions-ModelStateDictionaryExtensions-ToResult``1-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary- 'AndcultureCode.CSharp.Web.Extensions.ModelStateDictionaryExtensions.ToResult``1(Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary)')
- [NotAllowedFilter](#T-AndcultureCode-CSharp-Web-Filters-NotAllowedFilter 'AndcultureCode.CSharp.Web.Filters.NotAllowedFilter')
  - [OnActionExecuting(context)](#M-AndcultureCode-CSharp-Web-Filters-NotAllowedFilter-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext- 'AndcultureCode.CSharp.Web.Filters.NotAllowedFilter.OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)')
- [ValidationFilter](#T-AndcultureCode-CSharp-Web-Filters-ValidationFilter 'AndcultureCode.CSharp.Web.Filters.ValidationFilter')
  - [OnActionExecuting(context)](#M-AndcultureCode-CSharp-Web-Filters-ValidationFilter-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext- 'AndcultureCode.CSharp.Web.Filters.ValidationFilter.OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)')
- [WebConfiguration](#T-AndcultureCode-CSharp-Web-Constants-WebConfiguration 'AndcultureCode.CSharp.Web.Constants.WebConfiguration')
  - [AUTHENTICATION](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION')
  - [AUTHENTICATION_BASIC](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_BASIC 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION_BASIC')
  - [AUTHENTICATION_COOKIE](#F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_COOKIE 'AndcultureCode.CSharp.Web.Constants.WebConfiguration.AUTHENTICATION_COOKIE')

<a name='T-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions'></a>
## IApiEntityControllerExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Utility functions for IApiEntityController

<a name='M-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions-GetDefault``3-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1},System-Int64-'></a>
### GetDefault\`\`3(controller,id) `method`

##### Summary

Conventional Get(long id) controller method functionality

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| controller | [AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{\`\`0,\`\`1}](#T-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1} 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{``0,``1}') |  |
| id | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TController |  |
| TEntity |  |
| TDto |  |

<a name='M-AndcultureCode-CSharp-Web-Extensions-IApiEntityControllerExtensions-IndexDefault``3-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1}-'></a>
### IndexDefault\`\`3(controller) `method`

##### Summary

Conventional Index() controller method functionality

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| controller | [AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{\`\`0,\`\`1}](#T-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController{``0,``1} 'AndcultureCode.CSharp.Web.Interfaces.IApiEntityController{``0,``1}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TController |  |
| TEntity |  |
| TDto |  |

<a name='T-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2'></a>
## IApiEntityController\`2 `type`

##### Namespace

AndcultureCode.CSharp.Web.Interfaces

##### Summary

Describes an ApiController that pertains to an Entity from the application's domain layer.

<a name='P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Conductor'></a>
### Conductor `property`

##### Summary

Associated entity's repository conductor

<a name='P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Logger'></a>
### Logger `property`

##### Summary

Controller logger

<a name='P-AndcultureCode-CSharp-Web-Interfaces-IApiEntityController`2-Mapper'></a>
### Mapper `property`

##### Summary

Data mapping instance

<a name='T-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions'></a>
## IApplicationBuilderExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Extensions for IApplicationBuilder

<a name='M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseCookieAuthentication-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Http-SameSiteMode-'></a>
### UseCookieAuthentication(app,mode) `method`

##### Summary

Configure application to use cookie authentication

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') |  |
| mode | [Microsoft.AspNetCore.Http.SameSiteMode](#T-Microsoft-AspNetCore-Http-SameSiteMode 'Microsoft.AspNetCore.Http.SameSiteMode') |  |

<a name='M-AndcultureCode-CSharp-Web-Extensions-IApplicationBuilderExtensions-UseGlobalExceptionHandler-Microsoft-AspNetCore-Builder-IApplicationBuilder-'></a>
### UseGlobalExceptionHandler() `method`

##### Summary

Configure dotnet core API to wrap unhandled exceptions in IResult
and respond with json

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Web-Interfaces-IController'></a>
## IController `type`

##### Namespace

AndcultureCode.CSharp.Web.Interfaces

##### Summary

Application controller contract

<a name='P-AndcultureCode-CSharp-Web-Interfaces-IController-CurrentCulture'></a>
### CurrentCulture `property`

##### Summary

Current request's i18n/l10n culture

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Accepted``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Accepted\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 202 Accepted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>
### BadRequest(key,message,type) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### BadRequest\`\`1(errors) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### BadRequest\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]-'></a>
### BadRequest\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [AndcultureCode.CSharp.Core.Interfaces.IError[]](#T-AndcultureCode-CSharp-Core-Interfaces-IError[] 'AndcultureCode.CSharp.Core.Interfaces.IError[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-BadRequest``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>
### BadRequest\`\`1(value,key,message,type) `method`

##### Summary

Responds with HTTP 400 Bad Request

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Conflict``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Conflict\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 409 Conflicted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Conflict``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Conflict\`\`1(errors) `method`

##### Summary

Responds with HTTP 409 Conflicted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreateResult``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreateResult\`\`1(value,errors) `method`

##### Summary

Constructs a response in the form of an IResult

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtAction\`\`1(actionName,routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtAction\`\`1(actionName,controllerName,routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| controllerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtAction``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtAction\`\`1(actionName,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtRoute\`\`1(routeName,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtRoute\`\`1(routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-CreatedAtRoute``1-System-String,System-Object,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### CreatedAtRoute\`\`1(routeName,routeValues,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| routeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| routeValues | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-``0-'></a>
### Created\`\`1(value) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-Int64,``0-'></a>
### Created\`\`1(uriIdentifier,value) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uriIdentifier | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-String,``0-'></a>
### Created\`\`1(uri,value) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-String,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Created\`\`1(uri,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Created``1-System-Uri,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Created\`\`1(uri,value,errors) `method`

##### Summary

Responds with HTTP 201 Created

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Forbidden\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-``0,AndcultureCode-CSharp-Core-Interfaces-IError[]-'></a>
### Forbidden\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [AndcultureCode.CSharp.Core.Interfaces.IError[]](#T-AndcultureCode-CSharp-Core-Interfaces-IError[] 'AndcultureCode.CSharp.Core.Interfaces.IError[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Forbidden\`\`1(errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Forbidden``1-AndcultureCode-CSharp-Core-Interfaces-IError[]-'></a>
### Forbidden\`\`1(errors) `method`

##### Summary

Responds with HTTP 403 Forbidden

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [AndcultureCode.CSharp.Core.Interfaces.IError[]](#T-AndcultureCode-CSharp-Core-Interfaces-IError[] 'AndcultureCode.CSharp.Core.Interfaces.IError[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger-'></a>
### InternalError\`\`1(value,errors,logger) `method`

##### Summary

Responds with HTTP 500 Internal Server Error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},Microsoft-Extensions-Logging-ILogger-'></a>
### InternalError\`\`1(errors,logger) `method`

##### Summary

Responds with HTTP 500 Internal Server Error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-InternalError``1-System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType,Microsoft-Extensions-Logging-ILogger-'></a>
### InternalError\`\`1(key,message,type,logger) `method`

##### Summary

Responds with HTTP 500 Internal Server Error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### NotFound\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 404 Not Found

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### NotFound\`\`1(errors) `method`

##### Summary

Responds with HTTP 404 Not Found

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1-``0,System-String,System-String,AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>
### NotFound\`\`1(value,key,message,type) `method`

##### Summary

Responds with HTTP 404 Not Found

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| type | [AndcultureCode.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType 'AndcultureCode.CSharp.Core.Enumerations.ErrorType') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-NotFound``1'></a>
### NotFound\`\`1() `method`

##### Summary

Responds with HTTP 404 Not Found

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-Ok``1-``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### Ok\`\`1(value,errors) `method`

##### Summary

Responds with HTTP 200 Ok

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-AndcultureCode-CSharp-Web-Interfaces-IController-StatusCode``1-System-Int32,``0,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>
### StatusCode\`\`1(statusCode,value,errors) `method`

##### Summary

Responds with HTTP supplied statusCode in our conventional IResult response.
Mostly to be used in a pinch or very edge case.
Ultimately we should continue to extend to offer wrapper methods around
HTTP status codes we use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| statusCode | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [\`\`0](#T-``0 '``0') |  |
| errors | [System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{AndcultureCode.CSharp.Core.Interfaces.IError}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions'></a>
## IExceptionHandlerFeatureExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Extensions for IExceptionHandlerFeature

<a name='M-AndcultureCode-CSharp-Web-Extensions-IExceptionHandlerFeatureExtensions-ToResult-Microsoft-AspNetCore-Diagnostics-IExceptionHandlerFeature-'></a>
### ToResult() `method`

##### Summary

Transform exception context feature to IResult

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions'></a>
## IServiceCollectionExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Presentation.Web layer dependency registry methods

<a name='M-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions-AddCookieAuthentication-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfigurationRoot-'></a>
### AddCookieAuthentication(services,config) `method`

##### Summary

Register cookie authentication related actors

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| config | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot 'Microsoft.Extensions.Configuration.IConfigurationRoot') |  |

<a name='M-AndcultureCode-CSharp-Web-Extensions-IServiceCollectionExtensions-AddForwardedHeaders-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddForwardedHeaders(services) `method`

##### Summary

Enables HTTP Header forwarding for proxies. This is not enabled by default when hosting out of process (i.e kestrel)

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='T-AndcultureCode-CSharp-Web-Extensions-ModelStateDictionaryExtensions'></a>
## ModelStateDictionaryExtensions `type`

##### Namespace

AndcultureCode.CSharp.Web.Extensions

##### Summary

Utility functions for ModelStateDictionary

<a name='M-AndcultureCode-CSharp-Web-Extensions-ModelStateDictionaryExtensions-ToResult``1-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary-'></a>
### ToResult\`\`1(modelState) `method`

##### Summary

Converts validation errors to the shape of an IResult

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modelState | [Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary](#T-Microsoft-AspNetCore-Mvc-ModelBinding-ModelStateDictionary 'Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-AndcultureCode-CSharp-Web-Filters-NotAllowedFilter'></a>
## NotAllowedFilter `type`

##### Namespace

AndcultureCode.CSharp.Web.Filters

##### Summary

Filter for denying access to resource
///

<a name='M-AndcultureCode-CSharp-Web-Filters-NotAllowedFilter-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext-'></a>
### OnActionExecuting(context) `method`

##### Summary

Attribute that returns a 401 result

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext](#T-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext 'Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext') |  |

<a name='T-AndcultureCode-CSharp-Web-Filters-ValidationFilter'></a>
## ValidationFilter `type`

##### Namespace

AndcultureCode.CSharp.Web.Filters

##### Summary

Filter for validating ModelState

<a name='M-AndcultureCode-CSharp-Web-Filters-ValidationFilter-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext-'></a>
### OnActionExecuting(context) `method`

##### Summary

Validates ModelState
Returns 400 Response with errors if invalid

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext](#T-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext 'Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext') |  |

<a name='T-AndcultureCode-CSharp-Web-Constants-WebConfiguration'></a>
## WebConfiguration `type`

##### Namespace

AndcultureCode.CSharp.Web.Constants

##### Summary

Identifiers used for IConfigurationRoot configured sections and values

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION'></a>
### AUTHENTICATION `constants`

##### Summary

General authentication section

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_BASIC'></a>
### AUTHENTICATION_BASIC `constants`

##### Summary

Authentication's basic subsection

<a name='F-AndcultureCode-CSharp-Web-Constants-WebConfiguration-AUTHENTICATION_COOKIE'></a>
### AUTHENTICATION_COOKIE `constants`

##### Summary

Authentication's cookies subsection
