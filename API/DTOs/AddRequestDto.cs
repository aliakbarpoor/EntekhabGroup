using Domain.DTOs;

namespace API.DTOs
{
    public class AddRequestDto
    {
        public SalaryDto Data { get; set; } = new();


        public string OverTimeCalculator { get; set; } = string.Empty;


    }
}
