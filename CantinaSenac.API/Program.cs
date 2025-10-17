using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "https://campo-minado.com/");
app.MapGet("/verdade", () => "Ta deveno");
app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks = FeedbackController.ListarFeedback();
    return feedbacks;
});
app.MapPost("/feedbacks", ([FromBody] Feedback feedback) =>
{
    FeedbackController.AdicionarFeedback(feedback);
});
app.MapDelete("/feedbacks", ([FromBody] Feedback feedback) =>
{
    FeedbackController.RemoverFeedback(feedback);
});
app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    FeedbackController.EditarFeedback(feedback);
});

app.Run();
