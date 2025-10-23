using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
//===============//
app.MapGet("/feedbacks", () =>
{
    List<FeedBack> feedbacks;
    feedbacks = new FeedBackController().ListarTodosFeedBacks();
    return Results.Ok(feedbacks);
});
//===============//
app.MapPost("/feedbacks", ([FromBody]FeedBack feedback) =>
{
    new FeedBackController().AdicionarFeedBack(feedback);
    return Results.Ok("Feedback cadastrado com sucesso!");
});
//===============//
app.MapPut("/feedbacks", ([FromBody] FeedBack feedback) =>
{
    new FeedBackController().AlterarFeedBack(feedback);
    return Results.Ok("Feedback alterado com sucesso!");
});
//===============//
app.MapDelete("/feedbacks", ([FromBody] FeedBack feedback) =>
{
    if (feedback.UsuarioId != 1)
    {
        return Results.Forbid();
    }
    else
    {
        new FeedBackController().ExcluirFeedBack(feedback);
        return Results.Ok("Feedback excluído com sucesso!");
    }
});
//===============//
app.Run();
