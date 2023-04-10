namespace API.Formatters
{
    using Domain.Entities;
    using Microsoft.AspNetCore.Mvc.Formatters;
    using Microsoft.Net.Http.Headers;
    using System;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomInputFormatter : TextInputFormatter
    {
        public CustomInputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/cu-for"));

            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }


        protected override bool CanReadType(Type type)
        {
            if (type == typeof(Salary))
            {
                return base.CanReadType(type);
            }
            return false;
        }
        public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (encoding == null)
            {
                throw new ArgumentNullException(nameof(encoding));
            }

            var request = context.HttpContext.Request;

            using (var reader = new StreamReader(request.Body, encoding))
            {
                try
                {
                    var line = await reader.ReadLineAsync();


                    var split = line.Substring(line.IndexOf("Data:") + 5).Split(new char[] { '/' });
                    var salary = new Salary()
                    {
                        Id = Convert.ToInt32(split[0]),
                        FullName = split[1],
                        BasicSalary = Convert.ToDouble( split[2]),
                        Allowance = Convert.ToDouble(split[3]),
                        Transportation = Convert.ToDouble(split[4]),
                        Date = Convert.ToDateTime( split[5])

                    };

                    return await InputFormatterResult.SuccessAsync(salary);
                }
                catch
                {
                    return await InputFormatterResult.FailureAsync();
                }
            }
        }
    }
}
