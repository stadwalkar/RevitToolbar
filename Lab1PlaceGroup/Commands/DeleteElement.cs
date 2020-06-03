using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Autodesk.Revit.ApplicationServices;

using Autodesk.Revit.Attributes;

using Autodesk.Revit.DB;

using Autodesk.Revit.UI;

using Autodesk.Revit.UI.Selection;

namespace Lab1PlaceGroup

{
    [TransactionAttribute(TransactionMode.Manual)]
    public class DeleteElement : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Get UIDocument
            UIDocument uidoc = commandData.Application.ActiveUIDocument;

            //Get Document 
            Document doc = uidoc.Document;

            try
            {
                //Pick Object 
                Reference pickObj = uidoc.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType.Element);

                //Display Element ID

                if (pickObj != null)
                {
                    using(Transaction trans = new Transaction(doc, "Delete Element"))
                    {
                        trans.Start();
                        doc.Delete(pickObj.ElementId);

                        TaskDialog tDialog = new TaskDialog("Delete Element");
                        tDialog.MainContent = "Are you sure you want to delete the element?";
                        tDialog.CommonButtons = TaskDialogCommonButtons.Ok | TaskDialogCommonButtons.Cancel;

                        if(tDialog.Show() == TaskDialogResult.Ok)
                        {
                            trans.Commit();
                            TaskDialog.Show("Delete", pickObj.ElementId.ToString() + " deleted");
                        }
                        
                        else
                        {
                            trans.RollBack();
                            TaskDialog.Show("Delete", pickObj.ElementId.ToString() + " not deleted");

                        }
                    }
                }
                return Result.Succeeded;
            }

             catch (Exception e)
            {
                message = e.Message;
                return Result.Failed;
            }

        }
    }
}
