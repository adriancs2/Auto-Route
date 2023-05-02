# Auto-Route

Automatically Route All Pages at Once in ASP.NET WebForms

The idea of the code behind: [https://github.com/adriancs2/Auto-Route/wiki](https://github.com/adriancs2/Auto-Route/wiki)

## How to Use This Library

First, add the Nuget package of [adriancs.AutoRoute](https://www.nuget.org/packages/adriancs.AutoRoute).

Then, add a **Global Application Class** into the project:

![](https://raw.githubusercontent.com/adriancs2/Auto-Route/main/wiki/img1.png)

Open the file:

![](https://raw.githubusercontent.com/adriancs2/Auto-Route/main/wiki/img2.png)

To route ASPX pages at specific folder:
```C#
protected void Application_Start(object sender, EventArgs e)
{
    // route all aspx pages in the project
    // scan through all folders (including folders of javascript, images, css)
    AutoRoute.RouteAllPages();

    // route all aspx pages in specific folder, including sub-folders
    AutoRoute.Route("~/pages", true);

    // route all aspx pages in specific folder, do not include pages in sub-folders
    AutoRoute.Route("~/pages", false);
}
```
