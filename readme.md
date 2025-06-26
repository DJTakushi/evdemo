# run
##
run from root dir with:
```
dotnet run
```

# containerization
## publish
```
dotnet publish --arch x64 /t:PublishContainer
# or
dotnet publish /t:PublishContainer
# all together now

dotnet publish /t:PublishContainer && docker compose up
```


# compose
```
docker compose up
```



# publish to repo
```
dotnet publish /t:PublishContainer -p ContainerRegistry=sparkplugbdemo.azurecr.io -p ContainerImageTag=0.0.00000
```

# codebase built with
```
dotnet  new worker -o evdemo
dotnet new gitignore
```
