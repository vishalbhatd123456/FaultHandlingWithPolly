
using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        //GET /api/response/100

        [Route("{id:int}")]
        [HttpGet]
        //specify theh endpoint
        public ActionResult GetAResponse(int id)
        {
            //build the randomization logic over here
            Random rand = new Random();
            var randomNumber = rand.Next(1,100);
            if(randomNumber >= id){
                //the higher the number we pass we wont enter here and it will have a success!
                Console.WriteLine("---> Failure - Generate a HTTP 500");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Console.WriteLine("--> Sucess - Generate a HTTP 200");
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}