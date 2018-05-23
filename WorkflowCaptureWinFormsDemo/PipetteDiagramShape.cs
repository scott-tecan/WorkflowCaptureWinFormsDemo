using System;
using System.CodeDom;
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
    class PipetteDiagramShape : WorkflowCaptureDiagramShape
    {
        [JsonProperty("Operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WorkflowCaptureForm.OperationType Operation => WorkflowCaptureForm.OperationType.Pipette;

        [JsonProperty("From")]
        public string From { get; set; }
        [JsonProperty("To")]
        public string To { get; set; }
        [JsonProperty("Aspirate Speed")]
        public string AspirateSpeed { get; set; }
        [JsonProperty("Dispense Speed")]
        public string DispenseSpeed { get; set; }
        [JsonProperty("Volume")]
        public string Volume { get; set; }

        public PipetteDiagramShape()
        {
            
            base.Text = "Pipette";
            base.Font = new Font("Arial", 12, FontStyle.Bold);
            base.Shape = new RoundRectShape();
            base.BackColor = Color.FromArgb(11,187,239);
            base.ForeColor = Color.Black;
            base.DrawBorder = true;
            base.Content = "Pipette";
            base.BorderThickness = new Padding(3, 3, 3, 3);
            base.Position = new Telerik.Windows.Diagrams.Core.Point(200, 100);
            base.Size = new Size(200, 100);
            base.ToolTipText = $"{Operation} Operation";
            base.IsEditable = true;
            base.SerializeChildren = true;
            base.SerializeElement = true;
            base.SerializeProperties = true;
            
            PopulateValues();
        }

        public string Comments { get; set; }

        private void PopulateValues()
        {
            dropdownFrom.Text = From;
            dropdownTo.Text = To;
            textboxAspirateSpeed.Text = AspirateSpeed;
            textboxDispenseSpeed.Text = DispenseSpeed;
            textboxVolume.Text = Volume;
            textboxComments.Text = Comments;
        }

        RadDropDownList dropdownFrom = new RadDropDownList();
        RadDropDownList dropdownTo = new RadDropDownList();
        RadTextBox textboxVolume = new RadTextBox();
        RadTextBox textboxAspirateSpeed = new RadTextBox();
        RadTextBox textboxDispenseSpeed = new RadTextBox();
        public override RadPageViewPage BuildRadPageViewPage()
        {

            var page = new RadPageViewPage();
            page.Text = Operation.ToString();

            foreach (var item in WorkflowCaptureForm.Containers)
            {
                dropdownFrom.Items.Add(new RadListDataItem(item.Value.Name, item.Value.Id));
                dropdownTo.Items.Add(new RadListDataItem(item.Value.Name, item.Value.Id));
            }

            //from
            RadLabel labelFrom = new RadLabel();
            labelFrom.Text = "From: ";
            labelFrom.Location = new Point(10, 10);
            page.Controls.Add(labelFrom);

            dropdownFrom.Width = 200;
            dropdownFrom.Location = new Point(50, 10);
            page.Controls.Add(dropdownFrom);

            //to
            RadLabel labelTo = new RadLabel();
            labelTo.Text = "To: ";
            labelTo.Location = new Point(10, 40);
            page.Controls.Add(labelTo);

            dropdownTo.Width = 200;
            dropdownTo.Location = new Point(50, 40);
            page.Controls.Add(dropdownTo);

            //volume
            RadLabel labelVolume = new RadLabel();
            labelVolume.Text = "Volume: ";
            labelVolume.Location = new Point(10, 70);
            page.Controls.Add(labelVolume);

            textboxVolume.Width = 140;
            textboxVolume.Location = new Point(110, 70);
            page.Controls.Add(textboxVolume);

            //aspirate speed
            RadLabel labelAspirateSpeed = new RadLabel();
            labelAspirateSpeed.Text = "Aspirate Speed: ";
            labelAspirateSpeed.Location = new Point(10, 100);
            page.Controls.Add(labelAspirateSpeed);

            textboxAspirateSpeed.Width = 140;
            textboxAspirateSpeed.Location = new Point(110, 100);
            page.Controls.Add(textboxAspirateSpeed);

            //dispense speed
            RadLabel labelDispenseSpeed = new RadLabel();
            labelDispenseSpeed.Text = "Dispense Speed: ";
            labelDispenseSpeed.Location = new Point(10, 130);
            page.Controls.Add(labelDispenseSpeed);

            textboxDispenseSpeed.Width = 140;
            textboxDispenseSpeed.Location = new Point(110, 130);
            page.Controls.Add(textboxDispenseSpeed);

            //save
            RadButton buttonSavePipette = new RadButton();
            buttonSavePipette.Text = "Save";
            buttonSavePipette.Width = 50;
            buttonSavePipette.Location = new Point(200, 160);
            buttonSavePipette.Click += ButtonSavePipette_Click;
            page.Controls.Add(buttonSavePipette);

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

            RadMessageBox.Show("Pipette comments saved.");
        }

        private void ButtonSavePipette_Click(object sender, EventArgs e)
        {
            From = dropdownFrom.Text;
            To = dropdownTo.Text;
            AspirateSpeed = textboxAspirateSpeed.Text;
            DispenseSpeed = textboxDispenseSpeed.Text;
            Volume = textboxVolume.Text;

            RadMessageBox.Show("Pipette parameters saved.");
        }

        public override string GetJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
