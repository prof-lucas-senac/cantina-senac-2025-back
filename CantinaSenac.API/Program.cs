var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "the worldo");

app.MapGet("/feedbacks",() =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().
    ListarFeedbacks();
    return feedbacks;
});

app.Run();
