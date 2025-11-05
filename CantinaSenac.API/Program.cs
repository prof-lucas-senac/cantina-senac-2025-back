using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("/feedbacks");
var alunosGroup = app.MapGroup("/alunos");

feedbackGroup.MapGet("", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
    return Results.Ok(feedbacks);
});

feedbackGroup.MapPost("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().PostarFeedback(feedback);
    return Results.Ok("Feedback criado com sucesso.");
});

feedbackGroup.MapPut("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
    return "Feedback atualizado com sucesso.";
});

feedbackGroup.MapDelete("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().ExcluirFeedback(feedback);
    return Results.Ok("Feedback excluído com sucesso.");
});

alunosGroup.MapGet("", () =>
{
    List<Aluno> alunos;
    alunos = new AlunoController().ListarAlunos();
    return Results.Ok(alunos);
});

alunosGroup.MapPost("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().Adicionar(aluno);
    return Results.Ok("Aluno criado com sucesso.");
});

alunosGroup.MapPut("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AtualizarAluno(aluno);
    return "Aluno atualizado com sucesso.";
});

alunosGroup.MapDelete("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().ExcluirAluno(aluno);
    return Results.Ok("Aluno excluído com sucesso.");
});

app.Run();
