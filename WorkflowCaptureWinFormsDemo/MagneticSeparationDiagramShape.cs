using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorkflowCaptureWinFormsDemo
{
    class MagneticSeparationDiagramShape : WorkflowCaptureDiagramShape
    {
        [JsonProperty("Operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RadForm1.OperationType Operation => RadForm1.OperationType.MagneticSeparation;
        [JsonProperty("Container")]
        public string Container { get; set; }
        [JsonProperty("Collect")]
        public string Collect { get; set; }
        [JsonProperty("Release")]
        public string Release { get; set; }
        [JsonProperty("Mix")]
        public string Mix { get; set; }
        public string Comments { get; set; }


        public MagneticSeparationDiagramShape()
        {
            base.Text = "MagneticSeparation";
            base.Font = new Font("Arial", 12, FontStyle.Bold);
            base.Shape = new RoundRectShape();
            base.BackColor = Color.FromArgb(234, 82, 151);
            base.ForeColor = /*(i % 2 == 0) ? Color.White :*/ Color.Black;
            base.DrawBorder = true;
            base.Content = "MagneticSeparation";
            base.BorderThickness = new Padding(3, 3, 3, 3);
            base.Position = new Telerik.Windows.Diagrams.Core.Point(200, 100);
            base.Size = new Size(200, 100);
            base.ToolTipText = $"{Operation} Operation";

            PopulateValue();

        }

        private void PopulateValue()
        {
            textboxContainer.Text = Container;
            textboxCollect.Text = Collect;
            textboxRelease.Text = Release;
            textboxMix.Text = Mix;
        }


        RadTextBox textboxContainer = new RadTextBox();
        RadTextBox textboxRelease = new RadTextBox();
        RadTextBox textboxCollect = new RadTextBox();
        RadTextBox textboxMix = new RadTextBox();

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

            //Collect
            RadLabel labelCollect = new RadLabel();
            labelCollect.Text = "Collect: ";
            labelCollect.Location = new Point(10, 40);
            page.Controls.Add(labelCollect);

            textboxCollect.Width = 140;
            textboxCollect.Location = new Point(110, 40);
            page.Controls.Add(textboxCollect);

            //Release
            RadLabel labelDuration = new RadLabel();
            labelDuration.Text = "Release: ";
            labelDuration.Location = new Point(10, 70);
            page.Controls.Add(labelDuration);

            textboxRelease.Width = 140;
            textboxRelease.Location = new Point(110, 70);
            page.Controls.Add(textboxRelease);

            //Mix
            RadLabel labelMix = new RadLabel();
            labelMix.Text = "Mix: ";
            labelMix.Location = new Point(10, 100);
            page.Controls.Add(labelMix);

            textboxMix.Width = 140;
            textboxMix.Location = new Point(110, 100);
            page.Controls.Add(textboxMix);


            //save
            RadButton buttonSaveMagneticSeparation = new RadButton();
            buttonSaveMagneticSeparation.Text = "Save";
            buttonSaveMagneticSeparation.Width = 50;
            buttonSaveMagneticSeparation.Location = new Point(200, 130);
            buttonSaveMagneticSeparation.Click += ButtonSaveMagneticSeparation_Click;
            page.Controls.Add(buttonSaveMagneticSeparation);

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
        private void ButtonSaveMagneticSeparation_Click(object sender, EventArgs e)
        {
            Container = textboxContainer.Text;
            Release = textboxRelease.Text;
            Mix = textboxMix.Text;
            Collect = textboxCollect.Text;
        }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
