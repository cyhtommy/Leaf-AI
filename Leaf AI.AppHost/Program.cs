var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Leaf_AI_ApiService>("apiservice");

builder.AddProject<Projects.Leaf_AI_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
