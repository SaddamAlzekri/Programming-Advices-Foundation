using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirstApiController : ControllerBase
    {

        [HttpGet ("MyName", Name = "MyName")]
        public string GetMyName()
        {
            return "My Name is Saddam Hussein Alzekri.";
        }

        [HttpGet ("YourName", Name ="YourName")]
        public string GetYourName()
        {
            return "Your name is Salma Taha.";
        }

        [HttpGet ("Sum/{Num1}/{Num2}")]
        public int Sum2Numbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        [HttpGet ("Multi/{Num1}/{Num2}")]
        public int Multi2Numbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}
