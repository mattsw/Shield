namespace Shield.ApiControllers
{
    using Service.Data;
    using Core.Models.Monster;
    using System.Web.Http;
    public class ReviewsController : ApiController
    {
        private readonly IReviewService reviewService;
        //TODO Wire up a dependency injector
        public ReviewsController()
        {
            reviewService = new ReviewService();
        }

        //TODO basic error handling
        public IHttpActionResult Post(Review review)
        {
            reviewService.SaveReview(review);
            return Ok(review);
        }
    }
}
