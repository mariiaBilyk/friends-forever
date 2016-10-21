using System.Web.Http;

namespace FriendsForever.API.Controllers
{
    [Authorize]
    public class FriendForeverController : ApiController
    {
        public IHttpActionResult Get () {
            return Ok();
        }
    }
}
