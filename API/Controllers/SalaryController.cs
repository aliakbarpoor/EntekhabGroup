using AutoMapper;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("{datatype}/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOvertimePolicyService _ovetimePolicyService;

        public SalaryController(IMapper mapper, IOvertimePolicyService ovetimePolicyService)
        {
            _mapper = mapper;
            _ovetimePolicyService = ovetimePolicyService;
        }


        [HttpGet("add")]
        public string Add(string datatype)
        {
            //var p = _ovetimePolicyService.FactoryMethod(5000000, 2000000, 40);

            //var r = p.CalcurlatorA();

            return datatype;
        }


        //// GET: api/<SalaryController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<SalaryController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<SalaryController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<SalaryController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<SalaryController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
