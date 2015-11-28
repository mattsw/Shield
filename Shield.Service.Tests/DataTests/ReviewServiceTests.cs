namespace Shield.Service.Tests.DataTests
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Core.Enums;
    using Core.Models.Monster;
    using Data;
    using DataAccess.Contexts;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class ReviewServiceTests
    {
        [TestFixture]
        public class SaveReview
        {
            [Test]
            public void ValidReview_ShouldBeSavedToDatabase()
            {
                var mockReviewContext = new Mock<ReviewContext>();
                var mockReviewSet = new Mock<DbSet<Review>>();
                mockReviewContext.Setup(context => context.Reviews).Returns(mockReviewSet.Object);
                var reviewService = new ReviewService(mockReviewContext.Object);
                
                reviewService.SaveReview(new Review()
                {
                    Comments = new List<string>() { "test", "data"},
                    IdentityId = 111,
                    MonsterIdentity = new Identity()
                    {
                        Abilities = new List<Ability>(),
                        Attribute = ElementalAttribute.Dark,
                        IdentityId = 113,
                        Name = "TestObject",
                        Type = "Test"
                    },
                    ReviewId = 1
                });

                mockReviewSet.Verify(set => set.Add(It.IsAny<Review>()), Times.Once);
            }
        }
    }
}
