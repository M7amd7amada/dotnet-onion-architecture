using Api;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddPresentation();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    // TODO: Add CORS PolicyName //
    app.UseCors();

    app.MapControllers();

    await app.RunAsync();
}