﻿namespace AspireApp.Ollama.Example.AppHost.Extensions
{
    public static class OllamaBuilderExtensions
    {
        public static IResourceBuilder<OllamaModelResource> AddOllamaChatModel(this IDistributedApplicationBuilder builder, string model)
        {
            var ollama =
                builder.AddOllama("ollama")
               .WithDataVolume()
               .WithOpenWebUI();

            return ollama.AddModel("chat", model);
        }
    }
}
