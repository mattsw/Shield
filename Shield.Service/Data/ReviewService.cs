namespace Shield.Service.Data
{
    using Core.Models.Monster;
    using DataAccess.Contexts;
    using System;

    public interface IReviewService
    {
        void SaveReview(Review review);
    }

    public class ReviewService : IReviewService
    {
        private readonly ReviewContext reviewContext;

        //TODO Wire up dependency injector
        public ReviewService()
        {
            this.reviewContext = new ReviewContext();
        }

        public ReviewService(ReviewContext reviewContext)
        {
            this.reviewContext = reviewContext;
        }

        public void SaveReview(Review review)
        {
            reviewContext.Reviews.Add(review);
        }
    }
}
