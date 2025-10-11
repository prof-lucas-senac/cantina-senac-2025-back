var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "olá bb");
app.MapGet("/feedbacks",() =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().Listar();
}
);

app.Run();
