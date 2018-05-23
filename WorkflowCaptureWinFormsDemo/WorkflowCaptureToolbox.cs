using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace WorkflowCaptureWinFormsDemo
{
    public class WorkflowCaptureToolbox : RadDiagramToolbox
    {
        protected override RadDiagramShape CreateDiagramShape(PreviewDragStartEventArgs e)
        {
           
            var sourceItem = e.DragInstance as DiagramListViewVisualItem;
            var dataItem = sourceItem?.Data as DiagramListViewDataItem;

            var shape = default(WorkflowCaptureDiagramShape);

            switch (dataItem.Key)
            {
                case "Pipette":
                    shape = new PipetteDiagramShape();
                    break;
                case "Incubation":
                    shape = new IncubationDiagramShape();
                    break;
                case "Centrifugation":
                    shape = new CentrifugationDiagramShape();
                    break;
                case "Magnetic\r\nSeparation":
                    shape = new MagneticSeparationDiagramShape();
                    break;
            }

            return shape;
        }

        

    }
}
