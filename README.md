<div align="center">

# Currency converter tool


![App Screenshot](https://github.com/richardmogyoro/currency-converter/blob/6dd9194a3576b35f3e7a5194e8199153bd385a14/Screenshot.JPG)

</div>

---

### Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Install](#install)


# Introduction

This is a simple tool for converting currencies using live data from an API.


# Features

- Written in C# using WPF
- [Uses "Exchange Rates Data API as data source.](https://apilayer.com/marketplace/description/exchangerates_data-api#details-tab)
- Data source fetched with RestSharp then parsed with Newtonsoft.Json


# Install
``` sh
git clone git@github.com:richardmogyoro/currency-converter.git
```

After the repository is successfully cloned, you can click setup.exe inside the repository and the application should start running.

Alternate way: Open the .sln file at currency-converter/CurrencyConverter/ using Visual Studio and run the application from there.


