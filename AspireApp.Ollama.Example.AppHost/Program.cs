using AspireApp.Ollama.Example.AppHost.Extensions;

var builder = DistributedApplication.CreateBuilder(args);

var chat = builder.AddOllamaChatModel("llama3.2:1b");

var apiService = builder.AddProject<Projects.AspireApp_Ollama_Example_ApiService>("apiservice")
                         .WithReference(chat)
                         .WaitFor(chat);

builder.Build().Run();
