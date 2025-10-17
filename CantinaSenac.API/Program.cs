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
    return feedbacks;
});

app.MapPost("/Feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().PostarFeedback(feedback);
    return "Feedback adicionado com sucesso";
});

app.MapPost( "/Feedbacks", ([FromBody]Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
    return "Feedback adicionado com sucesso";
});
app.Run();
    
