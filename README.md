### appsettings.Development.json

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "Default": "Server=testbed-mssql;Database=skd;uid=sa;Password=DevDevDude119#;Connection Timeout=30"
  },
  "AppTitle": "Development App"
}
```

### local dev

```bash

docker run -d \
    -p 9301:1433 \
    -e ACCEPT_EULA=1 \
    -e MSSQL_SA_PASSWORD="DevDevDude119#" \
    --cap-add=SYS_PTRACE \
    -v mssql_volume:/var/opt/mssql \
    --name testbed-mssql \
    mcr.microsoft.com/azure-sql-edge
```

connection string

```
Server=testbed-mssql;Database=skd;uid=sa;Password=DevDevDude119#;Connection Timeout=30
```
