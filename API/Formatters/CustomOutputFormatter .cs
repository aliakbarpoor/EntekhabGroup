using Domain.DTOs;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System;
using System.Text;
using System.Threading.Tasks;

namespace API.Formatters
{
    public class CustomOutputFormatter : TextOutputFormatter
    {
        public CustomOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/cu-for"));

            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }

        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            IServiceProvider serviceProvider = context.HttpContext.RequestServices;
            var response = context.HttpContext.Response;

            var buffer = new StringBuilder();
            if (context.Object is IEnumerable<SalaryDto>)
            {
                foreach (var salary in context.Object as IEnumerable<SalaryDto>)
                {
                    FormatData(buffer, salary);
                }
            }
            else
            {
                var salary = context.Object as SalaryDto;
                FormatData(buffer, salary);
            }
            return response.WriteAsync(buffer.ToString());
        }

        private static void FormatData(StringBuilder buffer, SalaryDto salary)
        {
            buffer.Append("FirstName/LastName/BasicSalary/Allowance/Transportation/Date");
            buffer.AppendLine();
            buffer.AppendFormat($"{salary.FullName}/{salary.BasicSalary}/{salary.Allowance}/{salary.Transportation}/{salary.Date}");
        }


        protected override bool CanWriteType(Type type)
        {
            if (typeof(SalaryDto).IsAssignableFrom(type)
                || typeof(IEnumerable<SalaryDto>).IsAssignableFrom(type))
            {
                return base.CanWriteType(type);
            }
            return false;
        }

    }
}
