using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
Feedback feedback = new Feedback();

app.MapGet("/", () => "Hello World!");


app.MapGet("/motivacional", () => "Tem boleto pra pagar, mas também tem almoço pra saborear!");

app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
    return Results.Ok(feedbacks);
});

app.MapPost("/feedbacks", ([FromBody] Feedback feedback) =>
{

    new FeedbackController().PostarFeedback(feedback);
    
    return Results.Ok(feedback);

});

app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
    return Results.Ok(feedback);
});

app.MapDelete("/feedbacks",  ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId != 1)
    {
       return Results.Forbid();
    }
    new FeedbackController().ExcluirFeedback(feedback);
    return Results.Ok();
});
    

app.Run();
