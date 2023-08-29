namespace CafeteriaService
{
    partial class OrderApplication
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
            OrderTabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            PlaceOrderTab = new TabPage();
            tabPage2 = new TabPage();
            OrderTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // OrderTabControl
            // 
            OrderTabControl.Controls.Add(PlaceOrderTab);
            OrderTabControl.Controls.Add(tabPage2);
            OrderTabControl.Depth = 0;
            OrderTabControl.Dock = DockStyle.Fill;
            OrderTabControl.Location = new Point(3, 64);
            OrderTabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            OrderTabControl.Multiline = true;
            OrderTabControl.Name = "OrderTabControl";
            OrderTabControl.SelectedIndex = 0;
            OrderTabControl.Size = new Size(1023, 592);
            OrderTabControl.TabIndex = 0;
            // 
            // PlaceOrderTab
            // 
            PlaceOrderTab.Location = new Point(4, 24);
            PlaceOrderTab.Name = "PlaceOrderTab";
            PlaceOrderTab.Padding = new Padding(3);
            PlaceOrderTab.Size = new Size(1015, 564);
            PlaceOrderTab.TabIndex = 0;
            PlaceOrderTab.Text = "PlaceOrder";
            PlaceOrderTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1015, 564);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // OrderApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 659);
            Controls.Add(OrderTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = OrderTabControl;
            MinimumSize = new Size(300, 200);
            Name = "OrderApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CafeteriaService";
            OrderTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl OrderTabControl;
        private TabPage PlaceOrderTab;
        private TabPage tabPage2;
    }
}