using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "wow");

//Endpoint que retorne uma frase motivacional
app.MapGet("/motivacional", () => "Lembre-se, é por você, não pelos outros");

app.MapGet("/feedbacks", () =>
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

app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
    return "Feedback atualizado com sucesso";
});

app.Run();


