# PlotlifyCSharp

This project allows creating plotly.js HTML Exports from within C#

## Usage

```csharp
double[] x = { 1.0, 1.4, 1.5, 1.9, 2.0 };
double[] y = { 12.234, 43.122, 34.1234, 18.9122, 22.923 };

String filePath = "C:\\Users\\*****\\Downloads\\test.html";
String title = "Test1";

Plotlify.line(filePath, x, y, title);
```

## Features

- Create Scatter and line Plots in 2D
