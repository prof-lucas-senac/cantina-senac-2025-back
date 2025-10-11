var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hey Man!");

app.MapGet("/feedbacks", () =>
{
    List<Feedback> feedbacks;
    Console.Clear();
    System.Console.WriteLine("Cantina SENAC");
    System.Console.WriteLine("Lista de Feedbacks:");
    feedbacks = new FeedbackController().ListarFeedbacks();
    
});

app.Run();
