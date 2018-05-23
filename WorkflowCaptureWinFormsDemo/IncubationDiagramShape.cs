using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorkflowCaptureWinFormsDemo
{
    class IncubationDiagramShape : WorkflowCaptureDiagramShape
    {
        [JsonProperty("Operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WorkflowCaptureForm.OperationType Operation => WorkflowCaptureForm.OperationType.Incubation;
        [JsonProperty("Container")]
        public string Container { get; set; }
        [JsonProperty("Where")]
        public string Where { get; set; }
        [JsonProperty("Duration")]
        public string Duration { get; set; }
        [JsonProperty("Shaking")]
        public bool Shaking { get; set; }
        [JsonProperty("CO2 Percent")]
        public decimal Co2Percent { get; set; }
        public string Comments { get; set; }

        public IncubationDiagramShape()
        {
            base.Text = "Incubation";
            base.Font = new Font("Arial", 12, FontStyle.Bold);
            base.Shape = new RoundRectShape();
            base.BackColor = Color.FromArgb(149, 193, 31);
            base.ForeColor = /*(i % 2 == 0) ? Color.White :*/ Color.Black;
            base.DrawBorder = true;
            base.Content = "Incubation";
            base.BorderThickness = new Padding(3, 3, 3, 3);
            base.Position = new Telerik.Windows.Diagrams.Core.Point(200, 100);
            base.Size = new Size(200, 100);
            base.ToolTipText = $"{Operation} Operation";

            PopulateValues();

        }

        private void PopulateValues()
        {
            //textboxContainer.Text = Container;
            textboxDuration.Text = Duration;
            textboxWhere.Text = Where;
            textboxCo2Percent.Text = Co2Percent.ToString("G");
            checkShake.Checked = Shaking;
        }

        RadDropDownList dropdownContainer = new RadDropDownList();
        RadTextBox textboxWhere = new RadTextBox();
        RadTextBox textboxDuration = new RadTextBox();
        RadTextBox textboxShaking = new RadTextBox();
        RadTextBox textboxCo2Percent = new RadTextBox();
        RadCheckBox checkShake = new RadCheckBox();

        public override RadPageViewPage BuildRadPageViewPage()
        {
            var page = new RadPageViewPage();
            page.Text = Operation.ToString();

            //Container
            RadLabel labelContainer = new RadLabel();
            labelContainer.Text = "Container: ";
            labelContainer.Location = new Point(10, 10);
            page.Controls.Add(labelContainer);

            foreach (var item in WorkflowCaptureForm.Containers)
            {
                dropdownContainer.Items.Add(new RadListDataItem(item.Value.Name, item.Value.Id));
            }

            dropdownContainer.Width = 140;
            dropdownContainer.Location = new Point(110, 10);
            page.Controls.Add(dropdownContainer);

            //Where
            RadLabel labelWhere = new RadLabel();
            labelWhere.Text = "Where: ";
            labelWhere.Location = new Point(10, 40);
            page.Controls.Add(labelWhere);

            textboxWhere.Width = 140;
            textboxWhere.Location = new Point(110, 40);
            page.Controls.Add(textboxWhere);

            //Duration
            RadLabel labelDuration = new RadLabel();
            labelDuration.Text = "Duration: ";
            labelDuration.Location = new Point(10, 70);
            page.Controls.Add(labelDuration);

            textboxDuration.Width = 140;
            textboxDuration.Location = new Point(110, 70);
            page.Controls.Add(textboxDuration);

            //Co2Percent
            RadLabel labelCo2Percent = new RadLabel();
            labelCo2Percent.Text = "CO2 Percent: ";
            labelCo2Percent.Location = new Point(10, 100);
            page.Controls.Add(labelCo2Percent);

            textboxCo2Percent.Width = 140;
            textboxCo2Percent.Location = new Point(110, 100);
            page.Controls.Add(textboxCo2Percent);

            //Shake
            RadLabel labelShake = new RadLabel();
            labelShake.Text = "Shake? ";
            labelShake.Location = new Point(10, 130);
            page.Controls.Add(labelShake);

            checkShake.Location = new Point(110, 130);
            page.Controls.Add(checkShake);

            //save
            RadButton buttonSaveIncubation = new RadButton();
            buttonSaveIncubation.Text = "Save";
            buttonSaveIncubation.Width = 50;
            buttonSaveIncubation.Location = new Point(200, 160);
            buttonSaveIncubation.Click += ButtonSaveIncubation_Click; ;
            page.Controls.Add(buttonSaveIncubation);

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
            RadMessageBox.Show("Incubation comments saved.");

        }
        private void ButtonSaveIncubation_Click(object sender, EventArgs e)
        {
            //Container = textboxContainer.Text;
            Where = textboxWhere.Text;
            Duration = textboxDuration.Text;
            Co2Percent = decimal.Parse(textboxCo2Percent.Text);
            Shaking = checkShake.Checked;
            RadMessageBox.Show("Incubation parameters saved.");

        }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
