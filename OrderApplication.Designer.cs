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
            materialListView1 = new ReaLTaiizor.Controls.MaterialListView();
            ID = new ColumnHeader();
            Item = new ColumnHeader();
            Price = new ColumnHeader();
            Quantity = new ColumnHeader();
            Description = new ColumnHeader();
            groupBox1 = new GroupBox();
            materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            numericUpDown1 = new NumericUpDown();
            materialMaskedTextBox2 = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            materialTextBoxEdit5 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            materialListBox1 = new ReaLTaiizor.Controls.MaterialListBox();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            tabPage2 = new TabPage();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            OrderTabControl.SuspendLayout();
            PlaceOrderTab.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            PlaceOrderTab.BackColor = Color.White;
            PlaceOrderTab.Controls.Add(materialListView1);
            PlaceOrderTab.Controls.Add(groupBox1);
            PlaceOrderTab.Controls.Add(materialTextBoxEdit5);
            PlaceOrderTab.Controls.Add(materialButton2);
            PlaceOrderTab.Controls.Add(materialButton1);
            PlaceOrderTab.Controls.Add(materialComboBox1);
            PlaceOrderTab.Controls.Add(materialListBox1);
            PlaceOrderTab.Controls.Add(dungeonHeaderLabel1);
            PlaceOrderTab.Location = new Point(4, 24);
            PlaceOrderTab.Name = "PlaceOrderTab";
            PlaceOrderTab.Padding = new Padding(3);
            PlaceOrderTab.Size = new Size(1015, 564);
            PlaceOrderTab.TabIndex = 0;
            PlaceOrderTab.Text = "PlaceOrder";
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { ID, Item, Price, Quantity, Description });
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(324, 352);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(587, 145);
            materialListView1.TabIndex = 11;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Item
            // 
            Item.Text = "Name";
            Item.Width = 100;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 80;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 90;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 300;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(materialButton3);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(materialMaskedTextBox2);
            groupBox1.Controls.Add(materialLabel3);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Location = new Point(324, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 313);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton3.Location = new Point(35, 237);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(136, 36);
            materialButton3.TabIndex = 32;
            materialButton3.Text = "Submit";
            materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(35, 164);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(136, 23);
            numericUpDown1.TabIndex = 31;
            // 
            // materialMaskedTextBox2
            // 
            materialMaskedTextBox2.AllowPromptAsInput = true;
            materialMaskedTextBox2.AnimateReadOnly = false;
            materialMaskedTextBox2.AsciiOnly = false;
            materialMaskedTextBox2.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox2.BeepOnError = false;
            materialMaskedTextBox2.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.Depth = 0;
            materialMaskedTextBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox2.HidePromptOnLeave = false;
            materialMaskedTextBox2.HideSelection = true;
            materialMaskedTextBox2.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox2.LeadingIcon = null;
            materialMaskedTextBox2.Location = new Point(35, 70);
            materialMaskedTextBox2.Mask = "";
            materialMaskedTextBox2.MaxLength = 32767;
            materialMaskedTextBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            materialMaskedTextBox2.PasswordChar = '\0';
            materialMaskedTextBox2.PrefixSuffixText = null;
            materialMaskedTextBox2.PromptChar = '_';
            materialMaskedTextBox2.ReadOnly = false;
            materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            materialMaskedTextBox2.ResetOnPrompt = true;
            materialMaskedTextBox2.ResetOnSpace = true;
            materialMaskedTextBox2.RightToLeft = RightToLeft.No;
            materialMaskedTextBox2.SelectedText = "";
            materialMaskedTextBox2.SelectionLength = 0;
            materialMaskedTextBox2.SelectionStart = 0;
            materialMaskedTextBox2.ShortcutsEnabled = true;
            materialMaskedTextBox2.Size = new Size(136, 36);
            materialMaskedTextBox2.SkipLiterals = true;
            materialMaskedTextBox2.TabIndex = 29;
            materialMaskedTextBox2.TabStop = false;
            materialMaskedTextBox2.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.TrailingIcon = null;
            materialMaskedTextBox2.UseSystemPasswordChar = false;
            materialMaskedTextBox2.UseTallSize = false;
            materialMaskedTextBox2.ValidatingType = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel3.Location = new Point(35, 119);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(90, 29);
            materialLabel3.TabIndex = 24;
            materialLabel3.Text = "Quantity";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel2.Location = new Point(35, 30);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(56, 29);
            materialLabel2.TabIndex = 23;
            materialLabel2.Text = "Price";
            // 
            // materialTextBoxEdit5
            // 
            materialTextBoxEdit5.AnimateReadOnly = false;
            materialTextBoxEdit5.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit5.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit5.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit5.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit5.Depth = 0;
            materialTextBoxEdit5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit5.HideSelection = true;
            materialTextBoxEdit5.LeadingIcon = null;
            materialTextBoxEdit5.Location = new Point(29, 142);
            materialTextBoxEdit5.MaxLength = 32767;
            materialTextBoxEdit5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit5.Name = "materialTextBoxEdit5";
            materialTextBoxEdit5.PasswordChar = '\0';
            materialTextBoxEdit5.PrefixSuffixText = null;
            materialTextBoxEdit5.ReadOnly = false;
            materialTextBoxEdit5.RightToLeft = RightToLeft.No;
            materialTextBoxEdit5.SelectedText = "";
            materialTextBoxEdit5.SelectionLength = 0;
            materialTextBoxEdit5.SelectionStart = 0;
            materialTextBoxEdit5.ShortcutsEnabled = true;
            materialTextBoxEdit5.Size = new Size(235, 48);
            materialTextBoxEdit5.TabIndex = 7;
            materialTextBoxEdit5.TabStop = false;
            materialTextBoxEdit5.Text = "Search";
            materialTextBoxEdit5.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit5.TrailingIcon = null;
            materialTextBoxEdit5.UseSystemPasswordChar = false;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton2.Location = new Point(753, 519);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(158, 36);
            materialButton2.TabIndex = 6;
            materialButton2.Text = "Finish";
            materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(324, 519);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Delete";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(29, 63);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(235, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 2;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBox1.Location = new Point(28, 222);
            materialListBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(236, 329);
            materialListBox1.TabIndex = 1;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Script MT Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(6, 3);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(144, 33);
            dungeonHeaderLabel1.TabIndex = 0;
            dungeonHeaderLabel1.Text = "Place Order";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(bigLabel2);
            tabPage2.Controls.Add(bigLabel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1015, 564);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel2.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel2.Location = new Point(377, 99);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(182, 46);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "STK: 11111";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(377, 14);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(109, 46);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(328, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 203);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // OrderApplication
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
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
            PlaceOrderTab.ResumeLayout(false);
            PlaceOrderTab.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl OrderTabControl;
        private TabPage PlaceOrderTab;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialListBox materialListBox1;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit5;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private NumericUpDown numericUpDown1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialListView materialListView1;
        private ColumnHeader ID;
        private ColumnHeader Item;
        private ColumnHeader Price;
        private ColumnHeader Quantity;
        private ColumnHeader Description;
        private PictureBox pictureBox1;
    }
}