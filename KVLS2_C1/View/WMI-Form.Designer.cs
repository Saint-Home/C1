
namespace KVLS2_C1
{
    partial class WMI_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wmiComboBox = new System.Windows.Forms.ComboBox();
            this.wmiLabel = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // wmiComboBox
            // 
            this.wmiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wmiComboBox.FormattingEnabled = true;
            this.wmiComboBox.Location = new System.Drawing.Point(108, 17);
            this.wmiComboBox.Name = "wmiComboBox";
            this.wmiComboBox.Size = new System.Drawing.Size(350, 20);
            this.wmiComboBox.TabIndex = 4;
            // 
            // wmiLabel
            // 
            this.wmiLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wmiLabel.Location = new System.Drawing.Point(27, 17);
            this.wmiLabel.Name = "wmiLabel";
            this.wmiLabel.Size = new System.Drawing.Size(50, 24);
            this.wmiLabel.TabIndex = 3;
            this.wmiLabel.Text = "WMI :";
            this.wmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.valueColumnHeader});
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(30, 70);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(949, 444);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 180;
            // 
            // valueColumnHeader
            // 
            this.valueColumnHeader.Text = "Value";
            this.valueColumnHeader.Width = 300;
            // 
            // WMI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 543);
            this.Controls.Add(this.wmiComboBox);
            this.Controls.Add(this.wmiLabel);
            this.Controls.Add(this.listView);
            this.Name = "WMI_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMI_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox wmiComboBox;
        private System.Windows.Forms.Label wmiLabel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader valueColumnHeader;
    }
}