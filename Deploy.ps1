$Copy = "bin", "wwwroot", "*.csproj";

Copy-Item $args[0] -Destination $args[1] -Recurse -Include $Copy -Force;
