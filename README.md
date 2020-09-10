![WindowsFormsAero logo](https://raw.githubusercontent.com/LorenzCK/WindowsFormsAero/master/icon/WindowsFormsAero-128.png)

# WindowsFormsAero

WindowsFormsAero is a *Windows Forms* library that provides native controls with many of the modern features introduced with Windows Vista and more recent Windows versions.
Many controls—such as buttons, command buttons, and textboxes—support the functional and stylistic features introduced with “Aero”.
For instance shield icons, cue banners, and so on.

WindowsFormsAero was started by [Marco Minerva](https://github.com/marcominerva) in January 2007 and was initially hosted on [Codeplex](http://windowsformsaero.codeplex.com).

The WindowsFormsAero icon has been kindly provided by&nbsp;[Enner&nbsp;Pérez](https://github.com/ennerperez).

## Download

[![NuGet](https://img.shields.io/nuget/v/Windows-Forms-Aero.svg)](https://www.nuget.org/packages/Windows-Forms-Aero)

Get the latest version through NuGet:

```
Install-Package Windows-Forms-Aero
```

## Version history

### 4.0.0

 * .NET Core 3.0 and 3.1 support.
    * The NuGet package now builds libraries for .NET Framework 4.0, 4.5, 4.6.1 and 4.8 and .NET Core 3.0 and 3.1 via the new csproj file format.
    * The `ContextMenu` class was removed from .NET Core 3.1 and above, as a result, directives have been put into place so that the 4.x branches continue to behave as they previously did while the .NET Core branches remove the fallback property.  To migrate to .NET Core make sure your app uses the `ContextMenuStrip` and not the `ContextMenu`.
    * The assemblies bundled support different versions of Windows.  The 4.0 and 4.5 assemblies support legacy OS's and even the 4.8 assembly supports back to Windows 7 SP1.  The .NET Core 3.0 assembly supports back to Windows 7 SP1 but the .NET Core 3.1 assembly only goes back to Windows 8.1.  Windows 10 support is segmented by it's release.  Refer to https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31 for more specific info of .NET Core support on Windows 10.
* A second showcase project has been added for WinForms on .NET Core.

### 3.1.1

* Fixed [bug with TaskDialog APIs on x64](https://github.com/LorenzCK/WindowsFormsAero/issues/5) (thanks Piotr Zięzio).
* Added icon (thanks Enner Pérez).
* [Added Source Link](https://github.com/LorenzCK/WindowsFormsAero/issues/6) (thanks MagicAndre1981).

### 3.1

* Add support for additional DWM window attributes (`DWMWA_CLOAKED` and `DWMWA_FREEZE_REPRESENTATION`).
* Add support for public Virtual Desktop APIs (Windows&nbsp;10).

### 3.0.1

* Add simple `StoreAppHelper.IsRunningAsStoreApp()` helper to check whether a program is running as a packaged Windows Store app.
* Add .NET&nbsp;4.0 support.
* Add XML documentation to NuGet.

### 3.0

First release after migration to GitHub.
* Breaking changes from v2.*.
* Major code refactoring and clean up.
* Minor memory leaks fixed.
* Progress bars now correctly change state.

## Contributors

* [Marco Minerva](https://github.com/marcominerva)
* [Lorenz Cuno Klopfenstein](https://github.com/lorenzck)
* [Julie Koubová](https://github.com/juliekoubova)
* [Blake Pell](https:github.com/blakepell)
* multippt
* Nicholas Kwan
* [Enner Pérez](https://github.com/ennerperez)
* [Piotr Zięzio](https://github.com/pziezio)
* [MagicAndre1981](https://github.com/MagicAndre1981)
