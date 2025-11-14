var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedis("redis");
var identityServer = builder.AddProject<Projects.IdentityServer_Api>("identity-server");
var productService = builder.AddProject<Projects.ProductService_Api>("product-service").WithReference(redis);
var userService = builder.AddProject<Projects.UserService_Api>("user-service").WithReference(redis);
var apiGateway = builder.AddProject<Projects.APIGateway>("apigateway")
                        .WithReference(userService)
                        .WithReference(productService);

builder.Build().Run();