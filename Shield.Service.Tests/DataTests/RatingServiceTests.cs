namespace Shield.Service.Tests.DataTests
{
    using System.Data.Entity;
    using Core.Models.Monster;
    using Data;
    using DataAccess.Contexts;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class RatingServiceTests
    {
        [Test]
        public void ValidRating_ShouldBeSavedToDatabase()
        {
            var mockReviewContext = new Mock<ReviewContext>();
            var mockRatingSet = new Mock<DbSet<Rating>>();
            mockReviewContext.Setup(context => context.Ratings).Returns(mockRatingSet.Object);
            var reviewService = new RatingService(mockReviewContext.Object);

            reviewService.SaveRating(new Rating
            {
                ArenaDefense = 5,
                ArenaOffense = 5,
                Dungeon = 5,
                GuildDefense = 5,
                GuildOffense = 5,
                IdentityId = 0,
                Identity = new Identity(),
                RatingId = 0,
                TowerOfAscension = 5
            });

            mockRatingSet.Verify(set => set.Add(It.IsAny<Rating>()), Times.Once);
        }
    }
}
