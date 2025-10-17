using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "olá mundo!");

app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbacksController().MostrarFeedbacks();
    return feedbacks;
});

app.MapPost("/feedbacks", ([FromBody]Feedback feedback) =>
{
    new FeedbacksController().AdicionarFeedback(feedback);
    return "feedback adicionado com sucesso";
});

app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbacksController().AtualizarFeedback(feedback);
    return "feedback atualizado com sucesso";
});
app.Run();
