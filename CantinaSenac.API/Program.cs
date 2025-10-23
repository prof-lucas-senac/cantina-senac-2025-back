using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "olá bb");
app.MapGet("/motivacional", () => "Tem boleto pra pagar.");

app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    feedbacks = new FeedbackController().Listar();
    return Results.Ok(feedbacks);
}
);
app.MapPost("/feedbacks", ([FromBody] Feedback feedback) =>
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

app.MapPut("/feedbacks", ([FromBody] Feedback feedback) =>
{
    new FeedbackController().AtualizarFeedback(feedback, feedback.Descricao);
    return Results.Ok(feedback);
});

app.MapDelete("/feedbacks", ([FromBody] Feedback feedback) =>
{
    {
        try
        {
            if (feedback.UsuarioId != 1)
            {
                return Results.Forbid();
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

app.Run();
