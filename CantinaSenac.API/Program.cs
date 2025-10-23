using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "https://campo-minado.com/");
app.MapGet("/verdade", () => "Ta deveno");
app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks = FeedbackController.ListarFeedback();
    return Results.Ok(feedbacks);
});
app.MapPost("/feedbacks", ([FromBody] Feedback feedback) =>
{
    FeedbackController.AdicionarFeedback(feedback);
    return Results.Ok("Fededback criado com sucesso");
});
app.MapDelete("/feedbacks", ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId != 1)
    {
        return Results.Forbid();
    }
    else
    {
        FeedbackController.RemoverFeedback(feedback);
        return Results.Ok("Fededback deletado com sucesso");
    }
});
app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    FeedbackController.EditarFeedback(feedback);
    return Results.Ok("Fededback editado com sucesso");

});

app.Run();
