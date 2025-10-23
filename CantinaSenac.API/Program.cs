using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "olá mundo!");

app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbacksController().MostrarFeedbacks();
    return Results.Ok(feedbacks);
});

app.MapPost("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbacksController().AdicionarFeedback(feedback);
    return Results.Ok("feedback adicionado com sucesso");
});

app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbacksController().AtualizarFeedback(feedback);
    return Results.Ok("feedback atualizado com sucesso");
});

app.MapDelete("/feedbacks", ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId == 1)
    {
        new FeedbacksController().RemoverFeedback(feedback);
        return Results.Ok("feedback deletado com sucesso");
    }
    else
    {
        return Results.Forbid();
    }

});

app.Run();
