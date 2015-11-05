namespace Shield.Web.ApiControllers
{
    using System.Web.Http;
    using Core.Models.Monster;
    using Service.Data;

    public class RatingsController : ApiController
    {
        public RatingsController(IReviewService reviewService)
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
