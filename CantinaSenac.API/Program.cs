var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "olá mundo!");

app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbacksController().MostrarFeedbacks();
    return feedbacks;
});

app.Run();
