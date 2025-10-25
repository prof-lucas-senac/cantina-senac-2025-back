using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("");
Feedback feedback = new Feedback();


var alunosGroup = app.MapGroup("");




feedbackGroup.MapGet("", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
    return Results.Ok(feedbacks);
});

feedbackGroup.MapPost("", ([FromBody] Feedback feedback) =>
{

    new FeedbackController().PostarFeedback(feedback);
    
    return Results.Ok(feedback);

});

feedbackGroup.MapPut("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
    return Results.Ok(feedback);
});

feedbackGroup.MapDelete("",  ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId != 1)
    {
       return Results.Forbid();
    }
    new FeedbackController().ExcluirFeedback(feedback);
    return Results.Ok();
});


alunosGroup.MapGet("/alunos", () =>
{
   
   var alunos = new AlunoController().ListarAlunos();
    return Results.Ok(alunos);
});

alunosGroup.MapPost("/alunos", ([FromBody] Aluno aluno) =>
{
    if (aluno == null)
        return Results.BadRequest();

    new AlunoController().AdicionarAluno(aluno);
    return Results.Ok(aluno);
});


alunosGroup.MapDelete("/alunos/{id:int}", (int id) =>
{
    var controller = new AlunoController();
    var aluno = controller.ListarPorId(id);

    if (aluno == null)
        return Results.NotFound(new { message = "Aluno não encontrado" });

    controller.ExcluirAluno(aluno);
    return Results.Ok(new { message = "Aluno excluído com sucesso" });
});


alunosGroup.MapPut("/alunos", ([FromBody] Aluno aluno) =>
{
    new AlunoController().Atualizar(aluno);
    return Results.Ok(aluno);
});

app.Run();
