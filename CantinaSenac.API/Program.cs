using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
//===============//
app.MapGet("/feedbacks", () =>
{
    List<FeedBack> feedbacks;
    feedbacks = new FeedBackController().ListarTodosFeedBacks();
    return feedbacks;
});
//===============//
app.MapPost("/feedbacks", ([FromBody]FeedBack feedback) =>
{
    new FeedBackController().AdicionarFeedBack(feedback);
    return "Feedback adicionado com sucesso!";
});
//===============//
app.MapPut("/feedbacks", ([FromBody] FeedBack feedback) =>
{
    new FeedBackController().AlterarFeedBack(feedback);
    return "Feedback alterado com sucesso!";
});
//===============//
app.MapDelete("/feedbacks", ([FromBody] FeedBack feedback) =>
{
    new FeedBackController().ExcluirFeedBack(feedback);
    return "Feedback removido com sucesso!";
});
//===============//
app.Run();
