var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/feedbacks", () =>
{
    List<FeedBack> feedbacks;
    feedbacks = new FeedBackController().ListarTodosFeedBacks();
    return feedbacks;
});

app.Run();
