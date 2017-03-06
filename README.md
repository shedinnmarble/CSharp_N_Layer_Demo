# C# Enterprise Application Project Structure
This is a highly scalable project structure, it enables you to customize your project in all direction.
Technologies used include:
1. .NET 4.6.1
2. ASP.NET MVC5
3. Spring framework for DI
4. Abstract Factory Design Pattern for DAL layer
5. Entity Framework 6, Database first pattern
6. Interface based programming
7. Any Database which implements the IDAL is OK
8. Log4net to save the log
# Project Dependency
Please see this graph: https://github.com/xiangdewei/CSharp_N_Layer_Demo/blob/master/Dependencies%20Graph.png
# TODO
1. Implement session module, Save session into Redis or Memcached
2. Integrate Spring AOP to monitor all the method call or permission check
3. Write Unit Test to fully test all the main methods