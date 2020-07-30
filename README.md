# DotNet.DynamicInjector

Dynamic dependency injector for external project DLLs

Select multiple rows in a listview with xamarin.forms.

Dynamically reference external dlls without the need to add them to the project. Leave your project with low dependency and allowing specific dlls according to your business rule or database parameters.

###### This is the component, works on .NET Core and.NET Framework

**Info**

|Code Quality|Build|Nuget|Contributors|
| ------------------- | ------------------- | ------------------- | ------------------- |
|[![Codacy Badge](https://api.codacy.com/project/badge/Grade/48ba43fa1c744c5790a1c9faa2a43995)](https://app.codacy.com/manual/TBertuzzi/DotNetDynamicInjector?utm_source=github.com&utm_medium=referral&utm_content=TBertuzzi/DotNetDynamicInjector&utm_campaign=Badge_Grade_Dashboard)|![Build](https://github.com/TBertuzzi/DotNetDynamicInjector/workflows/Build/badge.svg)|[![NuGet](https://buildstats.info/nuget/DotNetDynamicInjector)](https://www.nuget.org/packages/DotNetDynamicInjector/)|[![GitHub contributors](https://img.shields.io/github/contributors/TBertuzzi/DotNetDynamicInjector.svg)](https://github.com/TBertuzzi/DotNetDynamicInjector/graphs/contributors)|


**Platform Support**

DotNet.DynamicInjector is a .NET Standard 2.0 library.

**Using DynamicInjector**


**The dlls that should be referenced by default must be in the compiled project folder**

Use the service configuration in the startup of your ASP.NET core project

```csharp

services.RegisterDynamicDependencies(ioCConfiguration);

```

IoCConfiguration contains the configuration of your dependency injection. It is possible to specify only the namespaces you want to reference, ignoring others in the project


```csharp

var ioCConfiguration = new IoCConfiguration()
{
   AllowedInterfaceNamespaces = 
       new List<string> {"Mynamespance1", "Mynamespance2"}
};

```

IoCRole configures the dll and type of dependency you want to automatically inject

```csharp

var role = new IoCRole
 {
     Dll = "MyProject.dll", //DLL name
     Implementation = "My Implementation", // Implementation name, can be used for a control if you use several projects and wanted to separate them
     Priority = 1, // Priority that the dll should be loaded
     LifeTime = LifeTime.SCOPED, // Lifetime of your addiction injection
    Name = "My client business rule x" //Dependency name. It is used only for identification
  };
            
    ioCConfiguration.Roles.Add(role);

```


Samples coming soon ..