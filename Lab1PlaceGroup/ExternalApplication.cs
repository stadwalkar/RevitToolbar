using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace Lab1PlaceGroup
{
    class ExternalApplication : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            //Create Ribbon Tab
            application.CreateRibbonTab("My Native Revit Plugins");

            string path = Assembly.GetExecutingAssembly().Location;
            PushButtonData button = new PushButtonData("Button1", "PlaceFamily", path, "Lab1PlaceGroup.PlaceFamily");

            RibbonPanel panel = application.CreateRibbonPanel("My Native Revit Plugins", "Commands");

            //Add button image
            Uri imagePath = new Uri(@"C:\Users\stadwalkar\Desktop\Ex_Files_Revit_Creating_C_Sharp_Plugins\Exercise Files\05_04\Start\desk.png");
            BitmapImage image = new BitmapImage(imagePath);

            PushButton pushButton = panel.AddItem(button) as PushButton;
            pushButton.LargeImage = image;


            return Result.Succeeded;  
        }
    }
}
