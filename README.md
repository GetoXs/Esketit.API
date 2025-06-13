# Esketit.API

Esketit.API is a strongly typed client library for accessing the Esketit API.

[![GitHub Actions Status](https://github.com/GetoXs/Esketit.API/workflows/Build%20&%20Test/badge.svg)](https://github.com/GetoXs/Esketit.API/actions)
[![NuGet](https://img.shields.io/nuget/dt/Esketit.API.svg)](https://www.nuget.org/packages/Esketit.API) 
[![NuGet](https://img.shields.io/nuget/vpre/Esketit.API.svg)](https://www.nuget.org/packages/Esketit.API)
[![license](https://img.shields.io/github/license/GetoXs/Esketit.API.svg)](https://github.com/GetoXs/Esketit.API/blob/master/LICENSE.txt)


## Features

* Response data is mapped to strongly typed models
* Support for most of the Esketit functionallity
* Possibility to execute custom API calls (in case of Esketit new functionallities)
* Initialization via username/password
* Open source so you can audit security mechanizms

## Supported Frameworks
The library is targeting `.NET 8.0` for optimal compatibility

## Install the library

### Nuget (.NET CLI)
[![NuGet version](https://img.shields.io/nuget/v/Esketit.API.svg?style=for-the-badge)](https://www.nuget.org/packages/Esketit.API)  [![Nuget downloads](https://img.shields.io/nuget/dt/Esketit.API.svg?style=for-the-badge)](https://www.nuget.org/packages/Esketit.API)

	dotnet add package Esketit.API

### NuGet (Install-Package)

	Install-Package Esketit.API

### Download release
[![GitHub Release](https://img.shields.io/github/v/release/GetoXs/Esketit.API?style=for-the-badge&label=GitHub)](https://github.com/GetoXs/Esketit.API/releases)

The NuGet package files are added along side the source with the latest GitHub release which can found [here](https://github.com/GetoXs/Esketit.API/releases).

## How to use

### Quick start

```csharp
// Get my balance
var client = new EsketitClient();
await client.InitializeUsingEmailAsync(new()
{
	email = "EsketitEmail",
	password = "EsketitPassword"
});
var balance = await client.GetAccountSummaryAsync(new() { currencyCode = "EUR" });
```

## Support the project
Any support is greatly appreciated.