Create new migration
```
dotnet ef migrations add <name> --project ParkingControl.Infrastructure --startup-project ParkingControl.API
```

Run migrations
```
dotnet ef database update --project ParkingControl.Infrastructure --startup-project ParkingControl.API
```
