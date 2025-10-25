using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("/feedbacks");
var AlunoGroup = app.MapGroup("/alunos");


app.MapGet("/", () => "Hello World!");

// Endpoint que retorne uma frase motivacional
app.MapGet("/motivacional", () => "Tem boleto pra pagar.");

feedbackGroup.MapGet("", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
    return Results.Ok(feedbacks);
});

feedbackGroup.MapPost("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().PostarFeedback(feedback);
    return Results.Ok("Feedback adicionado com sucesso!");
});

feedbackGroup.MapDelete("", ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId != 1)
    {
        return Results.Json(new { erro = "Usuário não autorizado para excluir este feedback." }, statusCode: 401);
    }
    new FeedbackController().ExcluirFeedback(feedback);
    return Results.Ok("Feedback excluido com sucesso! ");

});

feedbackGroup.MapPut("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
    return Results.Ok("Feedback atualizado com sucesso! ");
});

// -------------------REQUISIÇÃO DE ALUNOS------------------------

AlunoGroup.MapGet("", () =>
{
    List<Aluno> alunos;
    alunos = new AlunoController().ListarAluno();
    return Results.Ok(alunos);
});

AlunoGroup.MapPost("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AdicionarAluno(aluno);
    return Results.Ok("aluno adicionado com sucesso!");
});

AlunoGroup.MapDelete("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().ExcluirAluno(aluno);
    return Results.Ok("aluno excluido com sucesso! ");

});

AlunoGroup.MapPut("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AtualizarAluno(aluno);
    return Results.Ok("aluno atualizado com sucesso! ");
});



app.Run();
