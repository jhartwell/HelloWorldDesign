Hello World Application
----

This is a demo application written to demonstrate a way to develop a solution in an extensible way.

Requirements
----

This project requires .NET Core 2.1 or later


Design
----

This solution is designed so that pieces can easily be swapped out without making code changes down stream. You
can easily change where a service is pointing to or what data is returned from the repository without having to change
the base code.


Projects:
----

HelloWorld.CommandLine -> This is the console application that uses all other projects to pull the
data and display to the command line. 

HelloWorld.CommandLine.DependencyInjection -> This project handles wiring up the dependency injection 
specifically for the command line application. It will allow components to be switched out without having
to change any other code in the actual HelloWorld.CommandLine project.

HelloWorld.CommandLine.Implementation -> This project contains the implementations of the interfaces in
the HelloWorld.Common project. These implementations are specific for the command line application

HelloWorld.CommandLine.Tests -> This project contains unit tests to test functionality of the command line implementations

HelloWorld.Common -> This project contains a collection of interfaces that can be implemented

HelloWorld.DependencyInjection -> This project contains the interface and abstract class needed in order
for ease of use in working with dependency injection


To add another platform
----
In order to add another platform you would need to create 3 projects for that platform:
    
    * Implementation -> which contains the implementations of interfaces from HellWorld.Common
    * DependencyInjection -> which wires up the dependency injection for the new project
    * Executable Project -> This project would be the executable and would reference the Implementation 
    and DependencyInjection projects
    