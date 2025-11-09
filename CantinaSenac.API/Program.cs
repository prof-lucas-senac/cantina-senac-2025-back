using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("/feedbacks");

//===============//
feedbackGroup.MapGet("/", () =>
{
    List<FeedBack> feedbacks;
    feedbacks = new FeedBackController().ListarTodosFeedBacks();
    return Results.Ok(feedbacks);
});
//===============//
feedbackGroup.MapPost("/", ([FromBody] FeedBack feedback) =>
{
    new FeedBackController().AdicionarFeedBack(feedback);
    return Results.Ok("Feedback cadastrado com sucesso!");
});
//===============//
feedbackGroup.MapPut("/", ([FromBody] FeedBack feedback) =>
{
    new FeedBackController().AlterarFeedBack(feedback);
    return Results.Ok("Feedback alterado com sucesso!");
});
//===============//
feedbackGroup.MapDelete("/", ([FromBody] FeedBack feedback) =>
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

alunoGroup.MapGet("", () =>
{
    List<Aluno> alunos;
    alunos = new AlunoController().ListarTodosAlunos();
    return Results.Ok(alunos);
});
//===============//
alunoGroup.MapPost("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AdicionarAluno(aluno);
    return Results.Ok("Aluno cadastrado com sucesso!");
});
//===============//
alunoGroup.MapPut("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AlterarAluno(aluno);
    return Results.Ok("Aluno alterado com sucesso!");
});
//===============//
alunoGroup.MapDelete("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().ExcluirAluno(aluno);
    return Results.Ok("Aluno excluído com sucesso!");
});
//===============//
app.MapGet("/", () => "API rodando 🚀");
app.Run();
