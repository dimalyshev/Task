# ABOUT 

Solution contains project for figures squares calculator library

## Build

To build run:
`dotnet publish -c Release -o app SquareCalculator\SquareCalculator.csproj`

## Package

To create package run:
`dotnet pack -c Release SquareCalculator\SquareCalculator.csproj -o app`

## Publish to NuGet repository

To publish to server:
`dotnet nuget push -k API_KEY app/SquareCalculator.x.y.z.nuget`

## Tests

To run tests:
`dotnet test`