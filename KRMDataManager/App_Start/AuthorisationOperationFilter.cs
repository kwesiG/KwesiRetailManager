﻿using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace KRMDataManager.App_Start
{
    public class AuthorisationOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if(operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                //Worth noting: I spelt authorization with an 's' and this did not work
                name = "Authorization",
                @in = "header",
                description = "access token",
                required = false,
                type = "string"
            });

        }
    }
}