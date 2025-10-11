var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ctrl + r para restart quando der erro no terminal
// dotnet watch run para rodar

app.MapGet("/", () => "Hello World");

app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
    return feedbacks;
});

app.Run();
