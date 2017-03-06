# C# Enterprise Application Project Structure

This is a highly scalable project structure, it enables you to customize your project in all direction.
Technologies used include:
* .NET 4.6.1
* ASP.NET MVC5
* Spring framework for DI
* Abstract Factory Design Pattern for DAL layer
* Entity Framework 6, Database first pattern
* Interface based programming
* Generic programming
* Any Database which implements the IDAL is OK
* Log4net to save the log
* T4 template engine to generate all the repeat smliar logic code. for example, IUserDal, IPersonDal, IAccountDal, the basic code are the same.

## Project Dependency

![Please see this graph](Dependencies Graph.png "Please see this graph")

## TODO

* Implement session module, Save session into Redis or Memcached
* Integrate Spring AOP to monitor all the method call or permission check
* Write Unit Test to fully test all the main methods