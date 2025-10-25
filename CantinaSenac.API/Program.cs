using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("/feedbacks");

//===============//
app.MapGet("", () =>
{
    List<FeedBack> feedbacks;
    feedbacks = new FeedBackController().ListarTodosFeedBacks();
    return Results.Ok(feedbacks);
});
//===============//
app.MapPost("", ([FromBody]FeedBack feedback) =>
{
    new FeedBackController().AdicionarFeedBack(feedback);
    return Results.Ok("Feedback cadastrado com sucesso!");
});
//===============//
app.MapPut("", ([FromBody] FeedBack feedback) =>
{
    new FeedBackController().AlterarFeedBack(feedback);
    return Results.Ok("Feedback alterado com sucesso!");
});
//===============//
app.MapDelete("", ([FromBody] FeedBack feedback) =>
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
//===============//
//===============//

var alunoGroup = app.MapGroup("/alunos");

app.MapGet("", () =>
{
    List<Aluno> alunos;
    alunos = new AlunoController().ListarTodosAlunos();
    return Results.Ok(alunos);
});
//===============//
app.MapPost("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AdicionarAluno(aluno);
    return Results.Ok("Aluno cadastrado com sucesso!");
});
//===============//
app.MapPut("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AlterarAluno(aluno);
    return Results.Ok("Aluno alterado com sucesso!");
});
//===============//
app.MapDelete("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().ExcluirAluno(aluno);
    return Results.Ok("Aluno excluído com sucesso!");
});
//===============//
app.Run();
