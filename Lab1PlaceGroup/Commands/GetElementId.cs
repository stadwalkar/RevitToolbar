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
    public class GetElementId : IExternalCommand
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

                //Retrieve 
                ElementId eleId = pickObj.ElementId;
                Element ele = doc.GetElement(eleId);
                
                //Get Element Type
                ElementId eTypeId = ele.GetTypeId();
                ElementType eType = doc.GetElement(eTypeId) as ElementType;


                if (pickObj != null)
                {
                    TaskDialog.Show("Element Classification", eleId.ToString() + Environment.NewLine
                        + "Category: " + ele.Category.Name + Environment.NewLine
                        + "Instance: " + ele.Name + Environment.NewLine
                        + "Symbol: " + eType.Name + Environment.NewLine
                        + "Family: " + eType.FamilyName);
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