namespace API.Formatters
{
    using API.DTOs;
    using Domain.DTOs;
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
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/custom"));

            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }


        protected override bool CanReadType(Type type)
        {
            if (type == typeof(AddRequestDto))
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

                    await reader.ReadLineAsync();
                    var headerLine = await reader.ReadLineAsync();
                    var dataline = await reader.ReadLineAsync();
                    var calculatorLine = await reader.ReadLineAsync();

                    var split = dataline.Replace("\",", string.Empty)?.Split(new char[] { '/' });

                    var calculator = calculatorLine.Substring(27, 11);

                    var salary = new SalaryDto()

                    {

                        FullName = split[0].Trim(),
                        BasicSalary = Convert.ToDouble(split[1]),
                        Allowance = Convert.ToDouble(split[2]),
                        Transportation = Convert.ToDouble(split[3]),
                        OverTime=Convert.ToInt32(split[4]),
                        Date = split[5]

                    };



                    var addRequest = new AddRequestDto()

                    {

                        Data = salary,
                        OverTimeCalculator = calculator

                    };

                    return await InputFormatterResult.SuccessAsync(addRequest);
                }
                catch
                {
                    return await InputFormatterResult.FailureAsync();
                }
            }
        }
    }
}
