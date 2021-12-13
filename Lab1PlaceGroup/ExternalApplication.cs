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
            PushButtonData button = new PushButtonData("Button1", "Place Family", path, "Lab1PlaceGroup.PlaceFamily");
            PushButtonData button2 = new PushButtonData("Button2", "Place Line Element", path, "Lab1PlaceGroup.PlaceLineElement");
            PushButtonData button3 = new PushButtonData("Button3", "Plan View", path, "Lab1PlaceGroup.PlanView");
            PushButtonData button4 = new PushButtonData("Button4", "Change Location", path, "Lab1PlaceGroup.ChangeLocation");
            PushButtonData button5 = new PushButtonData("Button5", "Collect Window", path, "Lab1PlaceGroup.ChangeWindow");
            PushButtonData button6 = new PushButtonData("Button6", "Get ElementId", path, "Lab1PlaceGroup.GetElementId");
            PushButtonData button7 = new PushButtonData("Button7", "Get Parameter", path, "Lab1PlaceGroup.GetParameter");
            PushButtonData button8 = new PushButtonData("Button8", "Place Loop Element", path, "Lab1PlaceGroup.PlaceLoopElement");
            PushButtonData button9 = new PushButtonData("Button9", "Plan View", path, "Lab1PlaceGroup.PlanView");
            PushButtonData button10 = new PushButtonData("Button10", "Project Ray", path, "Lab1PlaceGroup.ProjectRay");
            PushButtonData button11 = new PushButtonData("Button11", "Select Geometry", path, "Lab1PlaceGroup.SelectGeometry");
            PushButtonData button12 = new PushButtonData("Button12", "Set Parameter", path, "Lab1PlaceGroup.SetParameter");
            PushButtonData button13 = new PushButtonData("Button13", "Tagging Items", path, "Lab1PlaceGroup.TaggingItems");
            PushButtonData button14 = new PushButtonData("Button14", "View Filter", path, "Lab1PlaceGroup.ViewFilter");



            RibbonPanel panel = application.CreateRibbonPanel("My Native Revit Plugins", "Commands");

            //Add button image
            Uri imagePath = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\desk.png");
            BitmapImage image = new BitmapImage(imagePath);
            PushButton pushButton = panel.AddItem(button) as PushButton;
            pushButton.LargeImage = image;


            //Add button2 image
            Uri imagePath2 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\line.png");
            BitmapImage image2 = new BitmapImage(imagePath2);
            PushButton pushButton2 = panel.AddItem(button2) as PushButton;
            pushButton2.LargeImage = image2;


            //Add button3 image
            Uri imagePath3 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\plan.png");
            BitmapImage image3 = new BitmapImage(imagePath3);
            PushButton pushButton3 = panel.AddItem(button3) as PushButton;
            pushButton3.LargeImage = image3;

            //Add button4 image
            Uri imagePath4 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\location.png");
            BitmapImage image4 = new BitmapImage(imagePath4);
            PushButton pushButton4 = panel.AddItem(button4) as PushButton;
            pushButton4.LargeImage = image4;

            //Add button5 image
            Uri imagePath5 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\window.png");
            BitmapImage image5 = new BitmapImage(imagePath5);
            PushButton pushButton5 = panel.AddItem(button5) as PushButton;
            pushButton5.LargeImage = image5;

            //Add button6 image
            Uri imagePath6 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\id.png");
            BitmapImage image6 = new BitmapImage(imagePath6);
            PushButton pushButton6 = panel.AddItem(button6) as PushButton;
            pushButton6.LargeImage = image6;

            //Add button7 image
            Uri imagePath7 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\param.png");
            BitmapImage image7 = new BitmapImage(imagePath7);
            PushButton pushButton7 = panel.AddItem(button7) as PushButton;
            pushButton7.LargeImage = image7;

            //Add button8 image
            Uri imagePath8 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\loop.png");
            BitmapImage image8 = new BitmapImage(imagePath8);
            PushButton pushButton8 = panel.AddItem(button8) as PushButton;
            pushButton8.LargeImage = image8;

            //Add button9 image
            Uri imagePath9 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\planv.png");
            BitmapImage image9 = new BitmapImage(imagePath2);
            PushButton pushButton9 = panel.AddItem(button9) as PushButton;
            pushButton9.LargeImage = image9;

            //Add button10 image
            Uri imagePath10 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\ray.png");
            BitmapImage image10 = new BitmapImage(imagePath10);
            PushButton pushButton10 = panel.AddItem(button10) as PushButton;
            pushButton10.LargeImage = image10;

            //Add button11 image
            Uri imagePath11 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\geom.png");
            BitmapImage image11 = new BitmapImage(imagePath11);
            PushButton pushButton11 = panel.AddItem(button11) as PushButton;
            pushButton11.LargeImage = image11;

            //Add button12 image
            Uri imagePath12 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\parameter.png");
            BitmapImage image12 = new BitmapImage(imagePath12);
            PushButton pushButton12 = panel.AddItem(button12) as PushButton;
            pushButton12.LargeImage = image12;

            //Add button13 image
            Uri imagePath13 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\tag.png");
            BitmapImage image13 = new BitmapImage(imagePath13);
            PushButton pushButton13 = panel.AddItem(button13) as PushButton;
            pushButton13.LargeImage = image13;

            //Add button14 image
            Uri imagePath14 = new Uri(@"C:\Users\Sahil\source\repos\Lab1PlaceGroup\img\filt.png");
            BitmapImage image14 = new BitmapImage(imagePath14);
            PushButton pushButton14 = panel.AddItem(button14) as PushButton;
            pushButton14.LargeImage = image14;


            return Result.Succeeded;  
        }
    }
}
