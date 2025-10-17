using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "olá bb");
app.MapGet("/motivacional", () => "Tem boleto pra pagar.");
app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().Listar();
    return feedbacks;
}
);
app.MapPost("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().PostarFeedback(feedback);
    return "Feedback cadastrado com sucesso!";
});

app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback, feedback.Descricao);
    return "Feedback atualizado com sucesso!";
});

app.Run();
