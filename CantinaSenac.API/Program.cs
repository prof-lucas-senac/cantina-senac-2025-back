using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("/feedbacks");

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

app.MapGet("/alunos", () =>
{
    List<Aluno> alunos;
    alunos = new AlunoController().ListarAlunos();
    return Results.Ok(alunos);
});

app.MapPost("/alunos", ([FromBody] Aluno aluno) =>
{
    new AlunoController().Adicionar(aluno);
    return Results.Ok("Aluno criado com sucesso.");
});

app.MapPut("/alunos", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AtualizarAluno(aluno);
    return "Aluno atualizado com sucesso.";
});

app.MapDelete("/alunos", ([FromBody] Aluno aluno) =>
{
    new AlunoController().ExcluirAluno(aluno);
    return Results.Ok("Aluno excluído com sucesso.");
});

app.Run();
