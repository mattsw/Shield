namespace Shield.Web.ApiControllers
{
    using System.Data.Entity.Infrastructure;
    using System.Web.Http;
    using Core.Models.Monster;
    using Service.Data;

    public class RatingsController : ApiController
    {
        private IRatingService ratingService;

        public RatingsController(IRatingService ratingService)
        {
            this.ratingService = ratingService;
        }

        public IHttpActionResult Get()
        {
            return Ok(new Rating());
        }

        public IHttpActionResult Post(Rating rating)
        {
            try
            {
                ratingService.SaveRating(rating);
                return Ok();
            }
            catch (DbUpdateException)
            {
                return BadRequest("Unable to upload user rating.");
            }
        }
    }
}
