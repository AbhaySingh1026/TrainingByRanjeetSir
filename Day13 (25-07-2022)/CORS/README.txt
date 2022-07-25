Just learned what is CORS and what is its use case, and what is code for applying CORS in ur
web app. Their are many scenarios i have just written code for one most used scenario other u 
can study from https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-6.0

Note: Basically by using CORS u can access diff. website data. for eg. ur web app runs on a diff port/domain
and ur web api runs on diff. so if u want to consume that web api in ur web app so on functn call
web api will return data bt it will not show on ur web app & will show err of policy.
So for that u have to use CORS in ur web app to consume it.
Here is just code for how to apply CORS in ur web app, full practical for consuming api with 
help of CORE is not here.