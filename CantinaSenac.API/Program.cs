using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("/feedbacks");
var alunosGroup = app.MapGroup("/alunos");

alunosGroup.MapGet("", () =>
{
    List<Aluno> alunos;
    alunos = new AlunoController().ListarAlunos();
    return Results.Ok(alunos);
});

alunosGroup.MapPost("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().PostarAluno(aluno);
    return Results.Ok("Aluno adicionado com sucesso");
});

alunosGroup.MapPut("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AtualizarAlunos(aluno);
    return Results.Ok("ALuno atualizado com sucesso");
});

alunosGroup.MapDelete("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().ExcluirAluno(aluno);
    return Results.Ok("Aluno excluído com sucesso");
});



feedbackGroup.MapGet("", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
    return Results.Ok(feedbacks);
});

feedbackGroup.MapPost("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().PostarFeedback(feedback);
    return Results.Ok("Feedback adicionado com sucesso");
});

feedbackGroup.MapPut("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
    return Results.Ok("Feedback atualizado com sucesso");
});

feedbackGroup.MapDelete("", ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId != 1)
    {
        return Results.Forbid();
    }
        new FeedbackController().ExcluirFeedback(feedback);
        return Results.Ok("Feedback excluído com sucesso");
});
app.Run();
