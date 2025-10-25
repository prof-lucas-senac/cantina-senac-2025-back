using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var feedbackGroup = app.MapGroup("/feedbacks");
var alunoGroup = app.MapGroup("/alunos");


app.MapGet("/", () => "olá bb");
app.MapGet("/motivacional", () => "Tem boleto pra pagar.");

feedbackGroup.MapGet("", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().Listar();
    return Results.Ok(feedbacks);
}
);

 
feedbackGroup.MapPost("", ([FromBody] Feedback feedback) =>
{
    try
    {
        new FeedbackController().PostarFeedback(feedback);
        return Results.Ok("Feedback cadastrado com sucesso");
    }
    catch (Exception ex)
    {
        return Results.Problem("Erro ao cadastrar feedback: " + ex.Message);
    }
});


feedbackGroup.MapPut("", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback, feedback.Descricao);
    return Results.Ok(feedback);
});

feedbackGroup.MapDelete("", ([FromBody] Feedback feedback) =>
{
    {
        try
        {
            if (feedback.UsuarioId != 1)
            {
                return Results.StatusCode(403);
            }
        }
        catch (Exception ex)
        {
            return Results.Problem("Erro ao deletar feedback: " + ex.Message);
        }
        new FeedbackController().DeletarFeedback(feedback);
        return Results.Ok(feedback);

    }
});
alunoGroup.MapDelete("", ([FromBody] Aluno aluno) =>
{
    {
        try
        {
            if (aluno.Id <= 0)
            {
                return Results.StatusCode(403);
            }
        }
        catch (Exception ex)
        {
            return Results.Problem("Erro ao deletar aluno: " + ex.Message);
        }
        new AlunoController().DeletarAluno(aluno);
        return Results.Ok("Aluno deletado com sucesso");
    }
});

alunoGroup.MapGet("", () =>
{
    List<Aluno> alunos;
    alunos = new AlunoController().Listar();
    return Results.Ok(alunos);
});

alunoGroup.MapPost("", ([FromBody] Aluno aluno) =>
{
    try
    {
        new AlunoController().AdicionarAluno(aluno);
        return Results.Ok("Aluno cadastrado com sucesso");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex);
        return Results.Problem("Erro ao cadastrar aluno: " + ex.Message);
    }
});
alunoGroup.MapPut("", ([FromBody] Aluno aluno) =>
{
    new AlunoController().AtualizarAluno(aluno, aluno.NomeUsuario, aluno.Email, aluno.Senha, aluno.Status);
    return Results.Ok(aluno);
});
app.Run();
