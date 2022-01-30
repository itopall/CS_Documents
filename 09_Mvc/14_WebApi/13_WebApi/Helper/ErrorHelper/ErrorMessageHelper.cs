using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace _13_WebApi.Helper.ErrorHelper
{
    public static class ErrorMessageHelper
    {
        public static List<string> FormatErrorMEssage(ModelStateDictionary modelState)
        {
            List<string> list = new List<string>();
            foreach (var item in modelState.Values)
            {
                for (int i = 0; i < item.Errors.Count; i++)
                {
                    string error = Convert.ToString(item.Errors[i].ErrorMessage);
                    list.Add(error);
                }
            }

            return list;
        }
    }
}