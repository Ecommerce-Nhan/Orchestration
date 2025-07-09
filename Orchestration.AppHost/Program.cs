var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedis("redis");

var gateway = builder.AddProject<Projects.APIGateway>("gateway");
var authService = builder.AddProject<Projects.AuthService>("auth-service");
var productService = builder.AddProject<Projects.ProductService_Api>("product-service");
var userService = builder.AddProject<Projects.UserService_Api>("user-service").WithReference(redis);

builder.Build().Run();