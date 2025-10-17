using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// // Endpoint que retorne uma frase motivacional
// app.MapGet("/motivacional", () => "Tem boleto pra pagar.");

app.MapGet("/feedbacks", ([FromBody] Feedback feedback) =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
    return feedbacks;
});

app.MapPost("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().PostarFeedback(feedback);
    return "Feedback adicionado com sucesso";
});

app.MapPut("/feedback", ([FromBody] Feedback feedbacks) =>
{
    new FeedbackController().AtualizarFeedback(feedbacks);
    return "Feedback Atualizado com sucesso";
});

app.Run();
