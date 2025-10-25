using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/", () => "olá mundo!");

// ====================
// Feedbacks 
// ====================

var feedbackGroup = app.MapGroup("/feedbacks");

feedbackGroup.MapGet("", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbacksController().MostrarFeedbacks();
    return Results.Ok(feedbacks);
});

feedbackGroup.MapPost("", ([FromBody] Feedback feedback) =>
{
    new FeedbacksController().AdicionarFeedback(feedback);
    return Results.Ok("feedback adicionado com sucesso");
});

feedbackGroup.MapPut("", ([FromBody] Feedback feedback) =>
{
    new FeedbacksController().AtualizarFeedback(feedback);
    return Results.Ok("feedback atualizado com sucesso");
});

feedbackGroup.MapDelete("", ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId == 1)
    {
        new FeedbacksController().RemoverFeedback(feedback);
        return Results.Ok("feedback deletado com sucesso");
    }
    else
    {
        return Results.Forbid();
    }

});

// ====================
// Aluno
// ====================

var alunoGroup = app.MapGroup("/aluno");

alunoGroup.MapGet("", () =>
{
    List<Aluno> alunos;
    alunos = new AlunoController().MostrarAlunos();
    return Results.Ok(alunos);

});

alunoGroup.MapPost("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AdicionarAluno(aluno);
    return Results.Ok("aluno adicionado com sucesso");
});

alunoGroup.MapPut("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AtualizarAlunos(aluno);
    return Results.Ok("aluno atualizado com sucesso");
});

alunoGroup.MapDelete("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().RemoverAluno(aluno);
    return Results.Ok("aluno deletado com sucesso");   

});

app.Run();
