using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;

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
    return Results.Ok("Feedback adicionado com sucesso!");
});

app.MapDelete("/feedbacks", ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId != 1)
    {
        return Results.Json(new { erro = "Usuário não autorizado para excluir este feedback." }, statusCode: 401);
    }
    new FeedbackController().ExcluirFeedback(feedback);
    return Results.Ok("Feedback excluido com sucesso! ");

});

app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
    return Results.Ok("Feedback atualizado com sucesso! ");
});


app.Run();
