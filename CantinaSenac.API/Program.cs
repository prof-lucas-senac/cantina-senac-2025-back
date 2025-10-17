using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.MapGet("/motivacional", () => "Tem boleto pra pagar, mas também tem almoço pra saborear!");

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
