dotnet publish -c Release -r osx-x64 --self-contained true -p:PublishSingleFile=true
dotnet publish -c Release -r osx-arm64 --self-contained true -p:PublishSingleFile=true
dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true