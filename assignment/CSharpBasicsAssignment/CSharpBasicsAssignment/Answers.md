# Part G — Short Answers

### 1. Paste your .csproj contents and confirm each of the four properties mentioned in Part A is present.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

**Confirmation of the 4 properties:**

- `<OutputType>Exe</OutputType>`: Specifies that the project compiles into an executable console application.
- `<TargetFramework>net8.0</TargetFramework>`: Specifies the target .NET runtime version (e.g., .NET 8.0).
- `<ImplicitUsings>enable</ImplicitUsings>`: Automatically imports standard global namespaces (like System) to reduce manual `using` statements.
- `<Nullable>enable</Nullable>`: Enables C# nullable reference types checks to catch null reference issues at compile-time.

---

### 2. Do #region / #endregion change the compiled output? Why might you still use them?

No, they do not affect the compiled binary or output at all. The compiler ignores them completely.

We use them solely in the IDE/code editor to group and collapse large sections of related code, which makes reading and navigating large files much cleaner and easier.

---

### 3. When would you reach for `///` XML doc comments instead of a plain `//`?

We use `///` XML comments for public methods, classes, and APIs that other developers (or we ourselves) will consume. They show up directly in Visual Studio / VS Code IntelliSense tooltips with parameters and return value descriptions.

Plain `//` comments are just for private, internal implementation details inside the method body that don't need to appear in tooltips.

---

### 4. Why does C# have no true global variables, and what's the closest equivalent?

C# is purely object-oriented, so every piece of data and logic must belong inside a type (class or struct) to prevent naming collisions and enforce encapsulation.

The closest equivalent in C# is a `public static` field inside a `static class` (e.g., `public static class AppGlobals { public static int Value = 10; }`), which can be accessed from anywhere in the application.
