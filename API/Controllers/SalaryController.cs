using API.DTOs;
using API.Enums;
using API.Services;
using AutoMapper;
using Domain.DTOs;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("{format}/[controller]")]
    [ApiController]
    [FormatFilter]
    public class SalaryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISalaryService _salaryService;

        public SalaryController(IMapper mapper, ISalaryService salaryService)
        {
            _mapper = mapper;
            _salaryService = salaryService;
        }



        [HttpPost("Add")]
        public async Task<IActionResult> Get([FromBody] AddRequestDto addRequest)
        {


            var salaryDto = await _salaryService.Add(addRequest.Data, addRequest.OverTimeCalculator);


            return Ok(salaryDto);

        }





        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get( int id)
        {

        var salary=  await  _salaryService.Get(id);

            return Ok(salary);

        }

        [HttpGet("get-range/{id}")]
        public async Task<IActionResult> GetRange([FromQuery] int id, string start,string end)
        {

            return Ok();

        }


        [HttpPut("update")]
        public async Task<IActionResult> Update()
        {

            return Ok(new string[] { "value1", "value2" });

        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Dete()
        {

            return Ok(new string[] { "value1", "value2" });

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
