using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorkflowCaptureWinFormsDemo
{
    class CentrifugationDiagramShape : WorkflowCaptureDiagramShape
    {
        [JsonProperty("Operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RadForm1.OperationType Operation => RadForm1.OperationType.Centrifugation;

        [JsonProperty("Container")]
        public string Container { get; set; }
        [JsonProperty("Acceleration")]
        public string Acceleration { get; set; }
        [JsonProperty("Duration")]
        public string Duration { get; set; }
        public string Comments { get; set; }

        public CentrifugationDiagramShape()
        {
            base.Text = "Centrifugation";
            base.Font = new Font("Arial", 12, FontStyle.Bold);
            base.Shape = new RoundRectShape();
            base.BackColor = Color.FromArgb(255,204,0);
            base.ForeColor = /*(i % 2 == 0) ? Color.White :*/ Color.Black;
            base.DrawBorder = true;
            base.Content = "Centrifugation";
            base.BorderThickness = new Padding(3, 3, 3, 3);
            base.Position = new Telerik.Windows.Diagrams.Core.Point(200, 100);
            base.Size = new Size(200, 100);
            base.ToolTipText = $"{Operation} Operation";
            base.SerializeChildren = true;
            base.SerializeElement = true;
            base.SerializeProperties = true;

            PopulateValues();
        }

        RadTextBox textboxContainer = new RadTextBox();
        RadTextBox textboxAcceleration = new RadTextBox();
        RadTextBox textboxDuration = new RadTextBox();

        private void PopulateValues()
        {
            textboxContainer.Text = Container;
            textboxAcceleration.Text = Acceleration;
            textboxDuration.Text = Duration;
        }
        public override RadPageViewPage BuildRadPageViewPage()
        {
            var page = new RadPageViewPage();
            page.Text = Operation.ToString();

            //Container
            RadLabel labelContainer = new RadLabel();
            labelContainer.Text = "Container: ";
            labelContainer.Location = new Point(10, 10);
            page.Controls.Add(labelContainer);

            textboxContainer.Width = 140;
            textboxContainer.Location = new Point(110, 10);
            page.Controls.Add(textboxContainer);

            //Acceleration
            RadLabel labelAcceleration = new RadLabel();
            labelAcceleration.Text = "Acceleration: ";
            labelAcceleration.Location = new Point(10, 40);
            page.Controls.Add(labelAcceleration);

            textboxAcceleration.Width = 140;
            textboxAcceleration.Location = new Point(110, 40);
            page.Controls.Add(textboxAcceleration);

            //Duration
            RadLabel labelDuration = new RadLabel();
            labelDuration.Text = "Duration: ";
            labelDuration.Location = new Point(10, 70);
            page.Controls.Add(labelDuration);

            textboxDuration.Width = 140;
            textboxDuration.Location = new Point(110, 70);
            page.Controls.Add(textboxDuration);

            //save
            RadButton buttonSaveCentrifugation = new RadButton();
            buttonSaveCentrifugation.Text = "Save";
            buttonSaveCentrifugation.Width = 50;
            buttonSaveCentrifugation.Location = new Point(200, 100);
            buttonSaveCentrifugation.Click += SaveButton_Click;
            page.Controls.Add(buttonSaveCentrifugation);

            return page;
        }

        RadTextBox textboxComments = new RadTextBox();
        public override RadPageViewPage RadPageViewCommentsPage()
        {
            var page = new RadPageViewPage();
            page.Text = "Comments";

            textboxComments.Location = new Point(10, 10);
            textboxComments.Height = 100;
            textboxComments.Width = 240;
            textboxComments.Multiline = true;
            page.Controls.Add(textboxComments);

            //save
            RadButton buttonSaveComments = new RadButton();
            buttonSaveComments.Text = "Save";
            buttonSaveComments.Width = 50;
            buttonSaveComments.Location = new Point(200, 120);
            buttonSaveComments.Click += ButtonSaveComments_Click; ;
            page.Controls.Add(buttonSaveComments);

            return page;
        }

        private void ButtonSaveComments_Click(object sender, EventArgs e)
        {
            Comments = textboxComments.Text;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Container = textboxContainer.Text;
            Acceleration = textboxAcceleration.Text;
            Duration = textboxDuration.Text;
        }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
