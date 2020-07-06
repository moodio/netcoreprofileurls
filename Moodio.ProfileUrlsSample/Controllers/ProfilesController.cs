using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moodio.ProfileUrlsSample.Controllers
{
    [ApiController]
    [Route("{profile:regex(^[[@]]{{1}}[[0-9a-zA-Z]]+$)}")]
    public class ProfilesController : ControllerBase
    {

        [HttpGet()]
        public IActionResult GetProfile([FromRoute]string profile)
        {
            return new JsonResult(new { ProfileName = profile.Substring(1) });
        }
    }
}
