namespace Shield.Service.Data
{
    using Core.Models.Monster;
    using DataAccess.Contexts;

    public interface IRatingService
    {
        void SaveRating(Rating ratingToSave);
    }

    public class RatingService : IRatingService
    {
        private ReviewContext reviewContext;

        public RatingService(ReviewContext reviewContext)
        {
            this.reviewContext = reviewContext;
        }

        public void SaveRating(Rating ratingToSave)
        {
            reviewContext.Ratings.Add(ratingToSave);
            reviewContext.SaveChanges();
        }
    }
}
