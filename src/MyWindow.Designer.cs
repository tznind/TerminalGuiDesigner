//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YourNamespace {
    using System;
    using Terminal.Gui;
    
    
    public partial class MyWindow : Terminal.Gui.Window {
        
        private Terminal.Gui.GraphView graphview1;
        
        private Terminal.Gui.TableView tableview1;
        
        private void InitializeComponent() {
            this.Text = "";
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.TextAlignment = TextAlignment.Centered;
            this.Title = "Welcome to Demo";
            this.graphview1 = new Terminal.Gui.GraphView();
            this.graphview1.Data = "graphview1";
            this.graphview1.Text = "";
            this.graphview1.Width = 60;
            this.graphview1.Height = 10;
            this.graphview1.X = 4;
            this.graphview1.Y = 1;
            this.graphview1.TextAlignment = TextAlignment.Left;
            this.graphview1.GraphColor = Terminal.Gui.Attribute.Make(Color.Black,Color.White);
            this.graphview1.AxisX.Visible = true;
            this.graphview1.AxisX.Increment = 1F;
            this.graphview1.AxisX.ShowLabelsEvery = 5u;
            this.graphview1.AxisX.Minimum = null;
            this.graphview1.AxisY.Visible = true;
            this.graphview1.AxisY.Increment = 0.1F;
            this.graphview1.AxisY.ShowLabelsEvery = 1u;
            this.graphview1.AxisY.Minimum = null;
            this.Add(this.graphview1);
            this.tableview1 = new Terminal.Gui.TableView();
            this.tableview1.Data = "tableview1";
            this.tableview1.Text = "";
            this.tableview1.Width = 50;
            this.tableview1.Height = 5;
            this.tableview1.X = 6;
            this.tableview1.Y = 12;
            this.tableview1.TextAlignment = TextAlignment.Left;
            this.tableview1.Style.AlwaysShowHeaders = false;
            this.tableview1.Style.ExpandLastColumn = true;
            this.tableview1.Style.InvertSelectedCellFirstCharacter = false;
            this.tableview1.Style.ShowHorizontalHeaderOverline = true;
            this.tableview1.Style.ShowHorizontalHeaderUnderline = true;
            this.tableview1.Style.ShowVerticalCellLines = true;
            this.tableview1.Style.ShowVerticalHeaderLines = true;
            System.Data.DataTable tableview1Table;
            tableview1Table = new System.Data.DataTable();
            System.Data.DataColumn tableview1TableCol0;
            tableview1TableCol0 = new System.Data.DataColumn();
            tableview1TableCol0.ColumnName = "Column 0";
            tableview1Table.Columns.Add(tableview1TableCol0);
            System.Data.DataColumn tableview1TableCol1;
            tableview1TableCol1 = new System.Data.DataColumn();
            tableview1TableCol1.ColumnName = "Column 1";
            tableview1Table.Columns.Add(tableview1TableCol1);
            System.Data.DataColumn tableview1TableCol2;
            tableview1TableCol2 = new System.Data.DataColumn();
            tableview1TableCol2.ColumnName = "Column 2";
            tableview1Table.Columns.Add(tableview1TableCol2);
            System.Data.DataColumn tableview1TableCol3;
            tableview1TableCol3 = new System.Data.DataColumn();
            tableview1TableCol3.ColumnName = "Column 3";
            tableview1Table.Columns.Add(tableview1TableCol3);
            this.tableview1.Table = tableview1Table;
            this.Add(this.tableview1);
        }
    }
}
