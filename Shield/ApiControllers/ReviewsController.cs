namespace Shield.Web.ApiControllers
{
    using System.Web.Http;
    using Core.Models.Monster;
    using Service.Data;

    public class ReviewsController : ApiController
    {
        private readonly IReviewService reviewService;
        //TODO Wire up a dependency injector
        public ReviewsController()
        {
            reviewService = new ReviewService();
        }

        public IHttpActionResult Get()
        {
            return Ok(new Review());
        }

        //TODO basic error handling
        public IHttpActionResult Post(Review review)
        {
            reviewService.SaveReview(review);
            return Ok(review);
        }
    }
}
