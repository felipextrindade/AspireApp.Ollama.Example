# Ollama LLM API Built in .NET Aspire

This is a slim POC example of a .NET Aspire API that interacts with a local Ollama model - essentially allowing you to run and call a local LLM model on your machine, or on an deployed environment.

## Prerequisites
- Install [Docker](https://hub.docker.com/)
- With Docker running on your machine, start the app
- Wait for the container with the Ollama model to start (can be seen through the Aspire Dashboard)
- Interact with the "chat" route via an HTTP client
- **Optional**: if you want to run a different model than the one currently used (llama3.2:1b), please check the [Ollama library](https://ollama.com/library) and update the "AppHost/Program.cs" to use the intended model.

   

## Example
![image](https://github.com/user-attachments/assets/78f9c348-7f8c-4e19-a5af-a6cf0ebe5966)
