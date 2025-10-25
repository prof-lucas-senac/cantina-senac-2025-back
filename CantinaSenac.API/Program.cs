using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("/feedbacks");

var alunosGroup = app.MapGroup("/alunos");

app.MapGet("/", () => "wow");

//Endpoint que retorne uma frase motivacional
app.MapGet("/motivacional", () => "Lembre-se, é por você, não pelos outros");

feedbackGroup.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().ListarFeedbacks();
    return Results.Ok(feedbacks);
});

feedbackGroup.MapPost("", ([FromBody] Feedback feedback) =>
{

    new FeedbackController().PostarFeedback(feedback);
    return Results.Ok("Feedback criado com sucesso");

});

feedbackGroup.MapPut("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback);
     return Results.Ok("Feedback alterado com sucesso");
});

feedbackGroup.MapDelete("", ([FromBody] Feedback feedback) =>
{
    if (feedback.UsuarioId == 1)
    {
        new FeedbackController().ExcluirFeedback(feedback);

        return Results.Ok("Feedback excluído com sucesso");
    }
    else
    {
        return Results.Unauthorized();
    }

});


alunosGroup.MapGet("", () =>
{
    var alunos = new AlunoController().ListarAlunos();
    return Results.Ok(alunos);
});

 alunosGroup.MapPost("", ([FromBody] Aluno aluno) =>
 {

     new AlunoController().CadastrarAluno(aluno);
    return Results.Ok("Aluno criado com sucesso");

 });

 alunosGroup.MapPut("", ([FromBody] Aluno aluno) =>
 {
     new AlunoController().AtualizarAluno(aluno);
    return Results.Ok("Aluno alterado com sucesso");
 });

 alunosGroup.MapDelete("", ([FromBody] Aluno aluno) =>
 {
     new AlunoController().ExcluirAluno(aluno);
         return Results.Ok("Aluno excluído com sucesso");

 });






app.Run();


