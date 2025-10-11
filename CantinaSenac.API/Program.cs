var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "wow");

//Endpoint que retorne uma frase motivacional
app.MapGet("/motivacional", () => "Lembre-se, é por você, não pelos outros");

app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
});

app.Run();

