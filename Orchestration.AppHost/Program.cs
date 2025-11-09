var builder = DistributedApplication.CreateBuilder(args);

var productService = builder.AddProject<Projects.ProductService_Api>("product-service");
var userService = builder.AddProject<Projects.UserService_Api>("user-service");

builder.Build().Run();