namespace Shield.ApiControllers
{
    using Core.Models.Monster;
    using System.Web.Http;

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
