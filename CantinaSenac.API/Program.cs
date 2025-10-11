var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "https://campo-minado.com/");
app.MapGet("/verdade", () => "Ta deveno");
app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks = FeedbackController.ListarFeedback();
    return feedbacks;
});
app.Run();
