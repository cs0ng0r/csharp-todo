var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddOpenApi();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseHttpsRedirection();



List<Todo> todos = [
    new (1, "Create a new project", true),
    new (2, "Add some endpoints", false),
    new (3, "Run the app", false)
];

// GET /todos
app.MapGet("todos", () => todos);

// GET /todos/1
app.MapGet("todos/{id}", (int id) => todos.Find(x => x.Id == id));

app.Run();
record Todo(int Id, string Title, bool Completed);

