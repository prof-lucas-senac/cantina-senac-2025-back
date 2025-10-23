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
    return Results.Ok(feedbacks);
});

app.MapPost("/feedbacks", ([FromBody] Feedback feedback) =>
{

    new FeedbackController().PostarFeedback(feedback);
    return Results.Ok("Feedback criado com sucesso");

});

app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
     return Results.Ok("Feedback alterado com sucesso");
});

app.MapDelete("/feedbacks", ([FromBody] Feedback feedback) =>
{
     if(feedback.UsuarioId == 1)
    {
         new FeedbackController().ExcluirFeedback(feedback);

    return Results.Ok("Feedback excluído com sucesso");
    }
   else
    {
        return Results.Forbid();
    }

});

app.Run();


