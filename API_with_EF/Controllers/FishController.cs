using API_with_EF.Models;
using API_with_EF.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_with_EF.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FishController : ControllerBase
    {
        FishRepository repo = new FishRepository(); 
        
        [HttpPost("spawn")]
        public Fish AddFish(string name, string classification, bool fresh, bool salt)
        {
            Fish newFish = new Fish
            {
                Name = name,
                Classification = classification,
                FreshWater = fresh,
                SaltWalter = salt
            };
            return repo.AddFish(newFish);
        }

    }
}
