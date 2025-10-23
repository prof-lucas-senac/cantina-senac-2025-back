using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Endpoint que retorne uma frase motivacional
app.MapGet("/motivacional", () => "Tem boleto pra pagar.");

app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
    return Results.Ok(feedbacks);
});

app.MapPost("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().PostarFeedback(feedback);
    return Results.Ok("Feedback criado com sucesso.");
});

app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
    return "Feedback atualizado com sucesso.";
});

app.MapDelete("/feedbacks", ([FromBody] Feedback feedback) =>
{
    
    new FeedbackController().ExcluirFeedback(feedback);
    return Results.Ok("Feedback excluído com sucesso.");
});

app.Run();
