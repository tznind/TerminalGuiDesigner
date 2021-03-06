//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TerminalGuiDesigner.UI.Windows {
    using System;
    using Terminal.Gui;
    
    
    public partial class DimEditor : Terminal.Gui.Dialog {
        
        private Terminal.Gui.RadioGroup rgDimType;
        
        private Terminal.Gui.Label lblValue;
        
        private Terminal.Gui.TextField tbValue;
        
        private Terminal.Gui.Label lblOffset;
        
        private Terminal.Gui.TextField tbOffset;
        
        private Terminal.Gui.Button btnOk;
        
        private Terminal.Gui.Button btnCancel;
        
        private void InitializeComponent() {
            this.Width = 40;
            this.Height = 9;
            this.X = Pos.Center();
            this.Y = Pos.Center();
            this.Text = "";
            this.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Title = "";
            this.rgDimType = new Terminal.Gui.RadioGroup();
            this.rgDimType.Width = 11;
            this.rgDimType.Height = 3;
            this.rgDimType.X = 1;
            this.rgDimType.Y = 1;
            this.rgDimType.Data = "rgDimType";
            this.rgDimType.Text = "";
            this.rgDimType.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.rgDimType.RadioLabels = new NStack.ustring[] {
                    "Absolute",
                    "Percent",
                    "Fill"};
            this.Add(this.rgDimType);
            this.lblValue = new Terminal.Gui.Label();
            this.lblValue.Width = 6;
            this.lblValue.Height = 1;
            this.lblValue.X = 12;
            this.lblValue.Y = 1;
            this.lblValue.Data = "lblValue";
            this.lblValue.Text = "Value:";
            this.lblValue.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.lblValue);
            this.tbValue = new Terminal.Gui.TextField();
            this.tbValue.Width = 15;
            this.tbValue.Height = 1;
            this.tbValue.X = Pos.Right(lblValue) + 2;
            this.tbValue.Y = Pos.Top(lblValue);
            this.tbValue.Data = "tbValue";
            this.tbValue.Text = "";
            this.tbValue.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.tbValue);
            this.lblOffset = new Terminal.Gui.Label();
            this.lblOffset.Width = 7;
            this.lblOffset.Height = 1;
            this.lblOffset.X = 12;
            this.lblOffset.Y = 3;
            this.lblOffset.Data = "lblOffset";
            this.lblOffset.Text = "Offset:";
            this.lblOffset.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.lblOffset);
            this.tbOffset = new Terminal.Gui.TextField();
            this.tbOffset.Width = 15;
            this.tbOffset.Height = 1;
            this.tbOffset.X = Pos.Right(lblOffset) + 1;
            this.tbOffset.Y = Pos.Top(lblOffset);
            this.tbOffset.Data = "tbOffset";
            this.tbOffset.Text = "";
            this.tbOffset.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.tbOffset);
            this.btnOk = new Terminal.Gui.Button();
            this.btnOk.Width = 8;
            this.btnOk.Height = 1;
            this.btnOk.X = 5;
            this.btnOk.Y = 5;
            this.btnOk.Data = "btnOk";
            this.btnOk.Text = "Ok";
            this.btnOk.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.btnOk.IsDefault = true;
            this.Add(this.btnOk);
            this.btnCancel = new Terminal.Gui.Button();
            this.btnCancel.Width = 10;
            this.btnCancel.Height = 1;
            this.btnCancel.X = 16;
            this.btnCancel.Y = 5;
            this.btnCancel.Data = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = Terminal.Gui.TextAlignment.Centered;
            this.btnCancel.IsDefault = false;
            this.Add(this.btnCancel);
        }
    }
}
