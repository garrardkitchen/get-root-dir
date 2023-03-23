Navigate into app folder:

```
cd src\app
```

Download package dependencies:

```powershell
dotnet restore
````

build + run:

```powershell
dotnet run -c release
```

```powershell
dotnet run -c debug
```

Sample output:

![](2023-03-23-08-05-04.png)

cd up a level:

```powershell
cd ..
dotnet run --project .\app\app.csproj
```

Sample output:

![](2023-03-23-08-09-06.png)

```powershell
dotnet run --project .\app\app.csproj "$PWD\\..\\data\\"
```

Sample output:

![](2023-03-23-08-22-36.png)
