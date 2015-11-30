namespace Shield.Web.ApiControllers
{
    using System.Data.Entity.Infrastructure;
    using System.Web.Http;
    using Core.Models.Monster;
    using Service.Data;

    public class ReviewsController : ApiController
    {
        private readonly IReviewService reviewService;
        //TODO Wire up a dependency injector
        public ReviewsController(IReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        public IHttpActionResult Get()
        {
            return Ok(new Review());
        }

        //TODO basic error handling
        public IHttpActionResult Post(Review review)
        {
            try
            {
                reviewService.SaveReview(review);
                return Ok(review);
            }
            catch (DbUpdateException)
            {
                return BadRequest("Unable to upload user review.");
            }
        }
    }
}
