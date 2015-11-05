namespace Shield.Service
{
    using Autofac;
    using Data;

    public class AutofacRegistar : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ReviewService>().As<IReviewService>();
        }
    }
}
