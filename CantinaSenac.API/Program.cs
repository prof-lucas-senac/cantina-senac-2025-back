using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("feedbacks");
var alunoGroup = app.MapGroup("alunos");

// app.MapGet("/", () => "https://campo-minado.com/");
// app.MapGet("/verdade", () => "Ta deveno");
feedbackGroup.MapGet("", () =>
{
    List<Feedback> feedbacks = FeedbackController.ListarFeedback();
    return Results.Ok(feedbacks);
});
feedbackGroup.MapPost("", ([FromBody] Feedback feedback) =>
{
    FeedbackController.AdicionarFeedback(feedback);
    return Results.Ok("Fededback criado com sucesso");
});
feedbackGroup.MapDelete("", ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId != 1)
    {
        return Results.Forbid();
    }
    else
    {
        FeedbackController.RemoverFeedback(feedback);
        return Results.Ok("Fededback deletado com sucesso");
    }
});
feedbackGroup.MapPut("", ([FromBody] Feedback feedback) =>
{
    FeedbackController.EditarFeedback(feedback);
    return Results.Ok("Fededback editado com sucesso");

});

alunoGroup.MapGet("", () =>
{
    List<Aluno> alunos = AlunoController.ListarAlunos();
    return Results.Ok(alunos);
});

alunoGroup.MapPost("", ([FromBody] Aluno aluno) =>
{
    AlunoController.Adicionar(aluno);
    return Results.Ok("Aluno criado com sucesso");
});

alunoGroup.MapDelete("", ([FromBody] Aluno aluno) =>
{
    AlunoController.Remover(aluno);
    return Results.Ok("Aluno deletado com sucesso");
});

alunoGroup.MapPut("", ([FromBody] Aluno aluno) =>
{
    AlunoController.Editar(aluno);
    return Results.Ok("Aluno editado com sucesso");
});
app.Run();
