using Newtonsoft.Json;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.App;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

[assembly: ExportFont("Volte Medium.otf", Alias = "Volte")]
[assembly: ExportFont("Volte Bold.otf", Alias = "VolteBold")]
[assembly: ExportFont("Volte Semibold.otf", Alias = "VolteSemiBold")]

[assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]


[assembly: ExportFont("DINOT-Regular.ttf", Alias = "DinotRegular")]
[assembly: ExportFont("DINOT-Bold.ttf", Alias = "DinotBold")]
[assembly: ExportFont("DINOT-Medium.ttf", Alias = "DinotMedium")]
[assembly: ExportFont("DINOT-Light.ttf", Alias = "DinotLight")]
[assembly: ExportFont("DINOT-Black.ttf", Alias = "DinotBlack")]


[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
[assembly: UsesPermission(Android.Manifest.Permission.ReadExternalStorage)]
//[assembly: UsesPermission(Android.Manifest.Permission.AccessCoarseLocation)]
//[assembly: UsesPermission(Android.Manifest.Permission.AccessFineLocation)]
//[assembly: UsesFeature("android.hardware.location", Required = false)]
[assembly: UsesFeature("android.hardware.location.gps", Required = false)]
//[assembly: UsesFeature("android.hardware.location.network", Required = false)]
[assembly: UsesFeature("android.hardware.camera", Required = true)]
[assembly: UsesFeature("android.hardware.camera.autofocus", Required = true)]