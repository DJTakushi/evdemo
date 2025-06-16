

```
dotnet  new worker -o evdemo
dotnet new gitignore
```

```
dotnet publish --os linux --arch x64 /t:PublishContainer -p ContainerRegistry=sparkplugbdemo.azurecr.io -p ContainerImageTag=0.0.00000
```