namespace Shield.Web.ApiControllers
{
    using System.Web.Http;
    using Core.Models.Monster;

    public class RatingsController : ApiController
    {
        public RatingsController()
        {

        }

        public IHttpActionResult Get()
        {
            return Ok(new Rating());
        }

        public IHttpActionResult Post(Rating rating)
        {
            throw new System.NotImplementedException();
        }
    }
}
