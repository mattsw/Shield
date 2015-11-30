namespace Shield.Service.Data
{
    using Core.Models.Monster;
    using DataAccess.Contexts;

    public interface IReviewService
    {
        void SaveReview(Review review);
    }

    public class ReviewService : IReviewService
    {
        private readonly ReviewContext reviewContext;

        public ReviewService(ReviewContext reviewContext)
        {
            this.reviewContext = reviewContext;
        }

        public void SaveReview(Review review)
        {
            reviewContext.Reviews.Add(review);
            reviewContext.SaveChanges();
        }
    }
}
