using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Diagrams.Core;
using Telerik.WinForms.Diagram;
using Newtonsoft.Json.Converters;
using Formatting = Newtonsoft.Json.Formatting;

namespace WorkflowCaptureWinFormsDemo
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public Dictionary<string, Container> Containers { get; set; } = new Dictionary<string, Container>();
        public RadForm1()
        {
            InitializeComponent();

            radDiagram1.Serialized += RadDiagram1_Serialized;


            settingsPane = radDiagram1.DiagramElement.SettingsPane;
            settingsPane.RadPageView.Pages.Clear();
            radDiagram1.PreviewAdditionalContentActivated += RadDiagram1_PreviewAdditionalContentActivated;
        }

        private void RadDiagram1_Serialized(object sender, Telerik.WinControls.UI.Diagrams.RoutedEventArgs e)
        {
            //SerializeWithJson(sender);
        }


        private static RadDiagramSettingsPane settingsPane;
        public static RadDiagramSettingsPane GetSettingsPane()
        {
            return settingsPane;
        }
        private void RadDiagram1_AdditionalContentActivated(object sender, Telerik.WinControls.UI.Diagrams.AdditionalContentActivatedEventArgs e)
        {
            RadMessageBox.SetThemeName("office2013LightTheme1");
            RadMessageBox.Show("Workflow export successful", "Export Workflow");
            //MessageBox.Show("AdditionalContentActivated event triggered");
        }

        private void RadDiagram1_PreviewAdditionalContentActivated(object sender, Telerik.WinControls.UI.Diagrams.AdditionalContentActivatedEventArgs e)
        {
            var index = ((RadDiagramElement)sender).SelectedIndex;

            var shapeSettingsPage = ((WorkflowCaptureDiagramShape)radDiagram1.Items[index]).BuildRadPageViewPage();
            var shapeCommentsPage = ((WorkflowCaptureDiagramShape)radDiagram1.Items[index]).RadPageViewCommentsPage();

            radDiagram1.DiagramElement.SettingsPane.RadPageView.Pages.Clear();
            radDiagram1.DiagramElement.SettingsPane.RadPageView.Pages.Add(shapeSettingsPage);
            radDiagram1.DiagramElement.SettingsPane.RadPageView.Pages.Add(shapeCommentsPage);
        }

        private void SettingsPane_Click(object sender, EventArgs e)
        {
            MessageBox.Show("testing...");
        }

        private RadPageViewPage BuildRadPageViewPage(string operationType)
        {
            var page = new RadPageViewPage();
            page.Text = operationType.ToString();
            switch (operationType)
            {
                case "Pipette":
                    RadTextBox textBox = new RadTextBox();
                    textBox.Text = "Pipette text box";
                    page.Controls.Add(textBox);
                    break;
                case "Incubation":
                    RadTextBox textBox1 = new RadTextBox();
                    textBox1.Text = "Incubation text box";
                    page.Controls.Add(textBox1);
                    break;
                case "Centrifugation":
                    RadTextBox textBox2 = new RadTextBox();
                    textBox2.Text = "Centrifugation text box";
                    page.Controls.Add(textBox2);
                    break;
                case "Magnetic Separation":
                    RadTextBox textBox3 = new RadTextBox();
                    textBox3.Text = "Magnetic Separation text box";
                    page.Controls.Add(textBox3);
                    break;
            }
            return page;
        }

        //private void BuildToolboxItems()
        //{
        //    radDiagramToolbox1.Items.Clear();

        //    CreateToolboxGroups();

        //    var itemPipette = new DiagramListViewDataItem() { Key = "Pipette", };
        //    itemPipette.Shape = new RoundRectShape(10);
        //    itemPipette.Group = this.radDiagramToolbox1.Groups[0];
        //    this.radDiagramToolbox1.Items.Add(itemPipette);

        //    var itemIncubate = new DiagramListViewDataItem() { Key = "Incubate", };
        //    itemIncubate.Shape = new RoundRectShape(10);
        //    itemIncubate.Group = this.radDiagramToolbox1.Groups[0];
        //    this.radDiagramToolbox1.Items.Add(itemIncubate);

        //    var itemCentrifugation = new DiagramListViewDataItem() { Key = "Centrifugation", };
        //    itemCentrifugation.Shape = new RoundRectShape(10);
        //    itemCentrifugation.Group = this.radDiagramToolbox1.Groups[0];
        //    this.radDiagramToolbox1.Items.Add(itemCentrifugation);

        //    var itemMagneticSeparation = new DiagramListViewDataItem() { Key = "Magnetic \r\n Separation", };
        //    itemMagneticSeparation.Shape = new RoundRectShape(10);
        //    itemMagneticSeparation.Group = this.radDiagramToolbox1.Groups[0];
        //    this.radDiagramToolbox1.Items.Add(itemMagneticSeparation);


        //}

        //private void CreateToolboxGroups()
        //{
        //    this.radDiagramToolbox1.Groups.Clear();

        //    var operationGroup = new ListViewDataItemGroup();
        //    operationGroup.Text = "Operations";

        //    this.radDiagramToolbox1.Groups.Add(operationGroup);
        //}

        public enum OperationType
        {
            [Description("Pipette")]
            Pipette,
            [Description("Incubation")]
            Incubation,
            [Description("Centrifugation")]
            Centrifugation,
            [Description("Magnetic Separation")]
            MagneticSeparation
        }

        Dictionary<OperationType, Color> operationColors = new Dictionary<OperationType, Color>()
        {
            { OperationType.Pipette, Color.FromArgb(11, 187, 239) },
            { OperationType.Incubation, Color.FromArgb(149, 193, 31) },
            { OperationType.Centrifugation, Color.FromArgb(255, 204, 0) },
            { OperationType.MagneticSeparation, Color.FromArgb(234, 82, 151) },
        };

        private void CreateDiagramShape(OperationType operationType)
        {
            var shape = default(RadDiagramShape);

            switch (operationType)
            {
                case OperationType.Pipette:
                    shape = new PipetteDiagramShape();
                    break;
                case OperationType.Centrifugation:
                    shape = new CentrifugationDiagramShape();
                    break;
                case OperationType.Incubation:
                    shape = new IncubationDiagramShape();
                    break;
                case OperationType.MagneticSeparation:
                    shape = new MagneticSeparationDiagramShape();
                    break;
            }

            radDiagram1.AddShape(shape);
        }

        private void radPanel1_Click(object sender, EventArgs e)
        {
            CreateDiagramShape(OperationType.Pipette);
        }

        private void radPanel2_Click(object sender, EventArgs e)
        {
            CreateDiagramShape(OperationType.Incubation);
        }

        private void radPanel3_Click(object sender, EventArgs e)
        {
            CreateDiagramShape(OperationType.Centrifugation);
        }

        private void radPanel4_Click(object sender, EventArgs e)
        {
            CreateDiagramShape(OperationType.MagneticSeparation);
        }

        private string GetDescription(OperationType enumerationValue)
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return enumerationValue.ToString();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000;
                return cp;
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(radDiagram1.Items.Count.ToString());
        }

        private void radDiagram1_ConnectionManipulationStarted(object sender, Telerik.Windows.Diagrams.Core.ManipulationEventArgs e)
        {
            var i = 0;
        }

        private void radDiagram1_ConnectionManipulationCompleted(object sender, Telerik.Windows.Diagrams.Core.ManipulationEventArgs e)
        {
            var i = 0;
        }

        private void radDiagram1_ItemsChanged(object sender, Telerik.WinControls.UI.Diagrams.DiagramItemsChangedEventArgs e)
        {
            var connections = ((RadDiagramElement) sender).Connections;

            foreach (var connection in connections)
            {
                ((RadDiagramConnection) connection).TargetCapType = CapType.Arrow1;
            }

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            //JsonSerializerSettings settings = new JsonSerializerSettings
            //{
            //    ContractResolver = new CamelCasePropertyNamesContractResolver(),
            //    Formatting = Formatting.Indented,
            //    NullValueHandling = NullValueHandling.Include,
            //    MissingMemberHandling = MissingMemberHandling.Ignore,
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //};
            //settings.Converters.Add(new StringEnumConverter());
            //var serializedDiagram = default(string);
            //foreach (var item in radDiagram1.Items)
            //{
            //    Type tempType = item.GetType();

               
            //    if (item is WorkflowCaptureDiagramShape)
            //    {
            //        if (item is PipetteDiagramShape)
            //        {
            //            serializedDiagram = JsonConvert.SerializeObject(((PipetteDiagramShape)item), settings);
            //        }
            //        else if (item is CentrifugationDiagramShape)
            //        {
            //            serializedDiagram += JsonConvert.SerializeObject(((CentrifugationDiagramShape) item), settings);
            //        }
            //    }
            //}

            //using (var sw = new StreamWriter(new FileStream(@"C:\temp.txt", FileMode.Create)))
            //{
            //    sw.Write(serializedDiagram);
            //    sw.Flush();
            //}

            //SerializeWithJson(sender);
            SerializeCustomShape();
            RadMessageBox.SetThemeName("office2013LightTheme1");
            RadMessageBox.Show("Workflow export successful", "Export Workflow");

        }

        private void SerializeCustomShape()
        {
            var inputFileNameAndPath = textboxFile.Text;

            var serializedDiagram = default(string);
            foreach (var item in radDiagram1.Items)
            {
                if (item is PipetteDiagramShape)
                {
                    serializedDiagram += ((PipetteDiagramShape)item).GetJson();
                }
                else if (item is IncubationDiagramShape)
                {
                    serializedDiagram += ((IncubationDiagramShape)item).GetJson();
                }
                else if (item is MagneticSeparationDiagramShape)
                {
                    serializedDiagram += ((MagneticSeparationDiagramShape)item).GetJson();
                }
                else if (item is CentrifugationDiagramShape)
                {
                     serializedDiagram += ((CentrifugationDiagramShape)item).GetJson();
                }
            }
            using (var sw = new StreamWriter(new FileStream(inputFileNameAndPath, FileMode.Create)))
            {
                sw.Write(serializedDiagram);
                sw.Flush();
            }
        }
        private void SerializeWithJson(object sender)
        {
            var inputFileNameAndPath = textboxFile.Text;
            var fileInfo = new FileInfo(inputFileNameAndPath);
            var inputFileNameAndPathNoExtension = new FileInfo(inputFileNameAndPath).Name.Replace(fileInfo.Extension, "");

            var xmlPath = inputFileNameAndPath.Replace(fileInfo.Extension, ".xml");
            radDiagram1.SaveToFile(xmlPath);

            var doc = new XmlDocument();
            doc.Load(xmlPath);

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            
            var serializedDiagram = default(string);
            serializedDiagram = JsonConvert.SerializeXmlNode(doc);
            //serializedDiagram = JsonConvert.SerializeObject(radDiagram1, settings);
            //foreach (var item in radDiagram1.Items)
            //{
            //    Type tempType = item.GetType();


            //    if (item is WorkflowCaptureDiagramShape)
            //    {
            //        if (item is PipetteDiagramShape)
            //        {
            //            serializedDiagram = JsonConvert.SerializeObject(((PipetteDiagramShape)item), settings);
            //        }
            //        else if (item is CentrifugationDiagramShape)
            //        {
            //            serializedDiagram += JsonConvert.SerializeObject(((CentrifugationDiagramShape)item), settings);
            //        }
            //    }
            //}

            using (var sw = new StreamWriter(new FileStream(inputFileNameAndPath, FileMode.Create)))
            {
                sw.Write(serializedDiagram);
                sw.Flush();
            }

            File.Delete(xmlPath);
        }

        private void radButton2_Click_1(object sender, EventArgs e)
        {
            var aContainer = (Containers.ContainsKey(textboxId.Text)) ? Containers[textboxId.Text] : new Container();

            aContainer.Discard = checkDiscard.Checked;
            aContainer.Id = textboxId.Text;
            aContainer.Name = textboxName.Text;
            aContainer.New = textboxNew.Text;
            aContainer.Store = textboxStore.Text;

            Containers[textboxId.Text] = aContainer;

            PopulateContainerDropDown();
        }

        private void PopulateContainerDropDown()
        {
            dropdownContainers.Items.Clear();
            foreach (var item in Containers.Values)
            {
                var aContainer = new RadMenuItem(item.Name);
                dropdownContainers.Items.Add(aContainer);
            }
        }
    }
}
