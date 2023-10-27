using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RoutingExample.Models
{
    public class CustomConstraint : IRouteConstraint
    {
        public static IEnumerable<int> cityIds = Enumerable.Range(1, 81);
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return cityIds.Contains(Convert.ToInt32(values[routeKey]));
        }
    }
}
