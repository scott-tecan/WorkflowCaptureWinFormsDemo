using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Telerik.WinControls.UI;

namespace WorkflowCaptureWinFormsDemo
{
    [JsonObject(MemberSerialization.OptIn)]
    abstract class WorkflowCaptureDiagramShape : RadDiagramShape
    {
        public virtual WorkflowCaptureForm.OperationType Operation { get; }

        public abstract RadPageViewPage BuildRadPageViewPage();

        public abstract RadPageViewPage RadPageViewCommentsPage();

        public abstract string GetJson();

        public virtual bool ShouldSerialize()
        {
            // don't serialize the Manager property if an employee is their own manager
            return false;
        }

    }
}
