﻿using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;

namespace GuiFlix_API.Helpers
{
    public static class HttpContextExtensions
    {
        public static bool CheckRole(this HttpContext httpContext, string role)
        {
            return httpContext.User.Claims.Where(c => c.Type == ClaimTypes.Role && c.Value == role).Count() > 0;
        }
        public static bool CheckId(this HttpContext httpContext, int id)
        {
            return httpContext.User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).FirstOrDefault()?.Value == id.ToString();
        }
    }
}
