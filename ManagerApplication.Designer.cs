namespace CafeteriaService
{
    partial class ManagerApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerApplication));
            StockItems = new ReaLTaiizor.Controls.MaterialTabControl();
            homePage = new TabPage();
            CategoriesPage = new TabPage();
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            categoryDescriptionInput = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            categoryIdInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            categoryNameInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            categoriesListView = new ReaLTaiizor.Controls.MaterialListView();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            StockItemsPage = new TabPage();
            materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton4 = new ReaLTaiizor.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            itemNameInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            itemIdInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            categoriesFilter = new ReaLTaiizor.Controls.MaterialLabel();
            materialCheckListBox1 = new ReaLTaiizor.Controls.MaterialCheckListBox();
            materialListView1 = new ReaLTaiizor.Controls.MaterialListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            historyPage = new TabPage();
            materialListView2 = new ReaLTaiizor.Controls.MaterialListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            tabImageList = new ImageList(components);
            StockItems.SuspendLayout();
            CategoriesPage.SuspendLayout();
            StockItemsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            historyPage.SuspendLayout();
            SuspendLayout();
            // 
            // StockItems
            // 
            StockItems.Controls.Add(homePage);
            StockItems.Controls.Add(CategoriesPage);
            StockItems.Controls.Add(StockItemsPage);
            StockItems.Controls.Add(historyPage);
            StockItems.Depth = 0;
            StockItems.Dock = DockStyle.Fill;
            StockItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StockItems.ImageList = tabImageList;
            StockItems.Location = new Point(3, 64);
            StockItems.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            StockItems.Multiline = true;
            StockItems.Name = "StockItems";
            StockItems.SelectedIndex = 0;
            StockItems.Size = new Size(1023, 592);
            StockItems.TabIndex = 0;
            // 
            // homePage
            // 
            homePage.BackColor = Color.White;
            homePage.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            homePage.ImageKey = "Home";
            homePage.Location = new Point(4, 30);
            homePage.Name = "homePage";
            homePage.Size = new Size(1015, 558);
            homePage.TabIndex = 0;
            homePage.Text = "Home";
            // 
            // CategoriesPage
            // 
            CategoriesPage.Controls.Add(materialButton2);
            CategoriesPage.Controls.Add(materialButton1);
            CategoriesPage.Controls.Add(categoryDescriptionInput);
            CategoriesPage.Controls.Add(categoryIdInput);
            CategoriesPage.Controls.Add(categoryNameInput);
            CategoriesPage.Controls.Add(materialLabel3);
            CategoriesPage.Controls.Add(materialLabel4);
            CategoriesPage.Controls.Add(materialLabel2);
            CategoriesPage.Controls.Add(categoriesListView);
            CategoriesPage.ImageKey = "folders.png";
            CategoriesPage.Location = new Point(4, 30);
            CategoriesPage.Name = "CategoriesPage";
            CategoriesPage.Padding = new Padding(3);
            CategoriesPage.Size = new Size(1015, 558);
            CategoriesPage.TabIndex = 1;
            CategoriesPage.Text = "Categories";
            CategoriesPage.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.BackColor = Color.Transparent;
            materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Enabled = false;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton2.Location = new Point(399, 126);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 5;
            materialButton2.Text = "Xóa";
            materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(399, 44);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Lưu";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // categoryDescriptionInput
            // 
            categoryDescriptionInput.AnimateReadOnly = false;
            categoryDescriptionInput.BackgroundImageLayout = ImageLayout.None;
            categoryDescriptionInput.CharacterCasing = CharacterCasing.Normal;
            categoryDescriptionInput.Depth = 0;
            categoryDescriptionInput.HideSelection = true;
            categoryDescriptionInput.Location = new Point(28, 187);
            categoryDescriptionInput.MaxLength = 32767;
            categoryDescriptionInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            categoryDescriptionInput.Name = "categoryDescriptionInput";
            categoryDescriptionInput.PasswordChar = '\0';
            categoryDescriptionInput.ReadOnly = false;
            categoryDescriptionInput.ScrollBars = ScrollBars.None;
            categoryDescriptionInput.SelectedText = "";
            categoryDescriptionInput.SelectionLength = 0;
            categoryDescriptionInput.SelectionStart = 0;
            categoryDescriptionInput.ShortcutsEnabled = true;
            categoryDescriptionInput.Size = new Size(250, 100);
            categoryDescriptionInput.TabIndex = 4;
            categoryDescriptionInput.TabStop = false;
            categoryDescriptionInput.TextAlign = HorizontalAlignment.Left;
            categoryDescriptionInput.UseSystemPasswordChar = false;
            // 
            // categoryIdInput
            // 
            categoryIdInput.AnimateReadOnly = false;
            categoryIdInput.AutoCompleteMode = AutoCompleteMode.None;
            categoryIdInput.AutoCompleteSource = AutoCompleteSource.None;
            categoryIdInput.BackgroundImageLayout = ImageLayout.None;
            categoryIdInput.CharacterCasing = CharacterCasing.Normal;
            categoryIdInput.Depth = 0;
            categoryIdInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            categoryIdInput.HideSelection = true;
            categoryIdInput.LeadingIcon = null;
            categoryIdInput.Location = new Point(28, 32);
            categoryIdInput.MaxLength = 32767;
            categoryIdInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            categoryIdInput.Name = "categoryIdInput";
            categoryIdInput.PasswordChar = '\0';
            categoryIdInput.PrefixSuffixText = null;
            categoryIdInput.ReadOnly = false;
            categoryIdInput.RightToLeft = RightToLeft.No;
            categoryIdInput.SelectedText = "";
            categoryIdInput.SelectionLength = 0;
            categoryIdInput.SelectionStart = 0;
            categoryIdInput.ShortcutsEnabled = true;
            categoryIdInput.Size = new Size(250, 48);
            categoryIdInput.TabIndex = 3;
            categoryIdInput.TabStop = false;
            categoryIdInput.TextAlign = HorizontalAlignment.Left;
            categoryIdInput.TrailingIcon = null;
            categoryIdInput.UseSystemPasswordChar = false;
            // 
            // categoryNameInput
            // 
            categoryNameInput.AnimateReadOnly = false;
            categoryNameInput.AutoCompleteMode = AutoCompleteMode.None;
            categoryNameInput.AutoCompleteSource = AutoCompleteSource.None;
            categoryNameInput.BackgroundImageLayout = ImageLayout.None;
            categoryNameInput.CharacterCasing = CharacterCasing.Normal;
            categoryNameInput.Depth = 0;
            categoryNameInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            categoryNameInput.HideSelection = true;
            categoryNameInput.LeadingIcon = null;
            categoryNameInput.Location = new Point(28, 114);
            categoryNameInput.MaxLength = 32767;
            categoryNameInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            categoryNameInput.Name = "categoryNameInput";
            categoryNameInput.PasswordChar = '\0';
            categoryNameInput.PrefixSuffixText = null;
            categoryNameInput.ReadOnly = false;
            categoryNameInput.RightToLeft = RightToLeft.No;
            categoryNameInput.SelectedText = "";
            categoryNameInput.SelectionLength = 0;
            categoryNameInput.SelectionStart = 0;
            categoryNameInput.ShortcutsEnabled = true;
            categoryNameInput.Size = new Size(250, 48);
            categoryNameInput.TabIndex = 3;
            categoryNameInput.TabStop = false;
            categoryNameInput.TextAlign = HorizontalAlignment.Left;
            categoryNameInput.TrailingIcon = null;
            categoryNameInput.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(28, 165);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(42, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Mô tả";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(28, 10);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(16, 19);
            materialLabel4.TabIndex = 2;
            materialLabel4.Text = "ID";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(28, 92);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(103, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Tên danh mục";
            // 
            // categoriesListView
            // 
            categoriesListView.AllowColumnReorder = true;
            categoriesListView.AutoSizeTable = true;
            categoriesListView.BackColor = Color.FromArgb(255, 255, 255);
            categoriesListView.BorderStyle = BorderStyle.None;
            categoriesListView.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
            categoriesListView.Depth = 0;
            categoriesListView.FullRowSelect = true;
            categoriesListView.Location = new Point(28, 311);
            categoriesListView.MinimumSize = new Size(200, 100);
            categoriesListView.MouseLocation = new Point(-1, -1);
            categoriesListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            categoriesListView.Name = "categoriesListView";
            categoriesListView.OwnerDraw = true;
            categoriesListView.Scrollable = false;
            categoriesListView.Size = new Size(460, 100);
            categoriesListView.TabIndex = 1;
            categoriesListView.UseCompatibleStateImageBehavior = false;
            categoriesListView.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên danh mục";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mô tả";
            columnHeader2.Width = 200;
            // 
            // StockItemsPage
            // 
            StockItemsPage.Controls.Add(materialButton3);
            StockItemsPage.Controls.Add(materialButton4);
            StockItemsPage.Controls.Add(pictureBox1);
            StockItemsPage.Controls.Add(materialComboBox1);
            StockItemsPage.Controls.Add(itemNameInput);
            StockItemsPage.Controls.Add(materialLabel6);
            StockItemsPage.Controls.Add(materialLabel1);
            StockItemsPage.Controls.Add(itemIdInput);
            StockItemsPage.Controls.Add(materialLabel7);
            StockItemsPage.Controls.Add(materialLabel5);
            StockItemsPage.Controls.Add(categoriesFilter);
            StockItemsPage.Controls.Add(materialCheckListBox1);
            StockItemsPage.Controls.Add(materialListView1);
            StockItemsPage.ImageKey = "stock.png";
            StockItemsPage.Location = new Point(4, 30);
            StockItemsPage.Name = "StockItemsPage";
            StockItemsPage.Padding = new Padding(3);
            StockItemsPage.Size = new Size(1015, 558);
            StockItemsPage.TabIndex = 2;
            StockItemsPage.Text = "Stock Items";
            StockItemsPage.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.BackColor = Color.Transparent;
            materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.Enabled = false;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton3.Location = new Point(656, 135);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(64, 36);
            materialButton3.TabIndex = 9;
            materialButton3.Text = "Xóa";
            materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = false;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton4.Location = new Point(656, 53);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(64, 36);
            materialButton4.TabIndex = 10;
            materialButton4.Text = "Lưu";
            materialButton4.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(342, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            materialComboBox1.Location = new Point(28, 230);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(250, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 7;
            // 
            // itemNameInput
            // 
            itemNameInput.AnimateReadOnly = false;
            itemNameInput.AutoCompleteMode = AutoCompleteMode.None;
            itemNameInput.AutoCompleteSource = AutoCompleteSource.None;
            itemNameInput.BackgroundImageLayout = ImageLayout.None;
            itemNameInput.CharacterCasing = CharacterCasing.Normal;
            itemNameInput.Depth = 0;
            itemNameInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            itemNameInput.HideSelection = true;
            itemNameInput.LeadingIcon = null;
            itemNameInput.Location = new Point(28, 131);
            itemNameInput.MaxLength = 32767;
            itemNameInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemNameInput.Name = "itemNameInput";
            itemNameInput.PasswordChar = '\0';
            itemNameInput.PrefixSuffixText = null;
            itemNameInput.ReadOnly = false;
            itemNameInput.RightToLeft = RightToLeft.No;
            itemNameInput.SelectedText = "";
            itemNameInput.SelectionLength = 0;
            itemNameInput.SelectionStart = 0;
            itemNameInput.ShortcutsEnabled = true;
            itemNameInput.Size = new Size(250, 48);
            itemNameInput.TabIndex = 6;
            itemNameInput.TabStop = false;
            itemNameInput.TextAlign = HorizontalAlignment.Left;
            itemNameInput.TrailingIcon = null;
            itemNameInput.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(28, 192);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(74, 19);
            materialLabel6.TabIndex = 5;
            materialLabel6.Text = "Danh mục";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(28, 100);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(28, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Tên";
            // 
            // itemIdInput
            // 
            itemIdInput.AnimateReadOnly = false;
            itemIdInput.AutoCompleteMode = AutoCompleteMode.None;
            itemIdInput.AutoCompleteSource = AutoCompleteSource.None;
            itemIdInput.BackgroundImageLayout = ImageLayout.None;
            itemIdInput.CharacterCasing = CharacterCasing.Normal;
            itemIdInput.Depth = 0;
            itemIdInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            itemIdInput.HideSelection = true;
            itemIdInput.LeadingIcon = null;
            itemIdInput.Location = new Point(28, 41);
            itemIdInput.MaxLength = 32767;
            itemIdInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemIdInput.Name = "itemIdInput";
            itemIdInput.PasswordChar = '\0';
            itemIdInput.PrefixSuffixText = null;
            itemIdInput.ReadOnly = false;
            itemIdInput.RightToLeft = RightToLeft.No;
            itemIdInput.SelectedText = "";
            itemIdInput.SelectionLength = 0;
            itemIdInput.SelectionStart = 0;
            itemIdInput.ShortcutsEnabled = true;
            itemIdInput.Size = new Size(250, 48);
            itemIdInput.TabIndex = 6;
            itemIdInput.TabStop = false;
            itemIdInput.TextAlign = HorizontalAlignment.Left;
            itemIdInput.TrailingIcon = null;
            itemIdInput.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(342, 10);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(65, 19);
            materialLabel7.TabIndex = 5;
            materialLabel7.Text = "Hình ảnh";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(28, 10);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(16, 19);
            materialLabel5.TabIndex = 5;
            materialLabel5.Text = "ID";
            // 
            // categoriesFilter
            // 
            categoriesFilter.AutoSize = true;
            categoriesFilter.Depth = 0;
            categoriesFilter.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            categoriesFilter.Location = new Point(656, 192);
            categoriesFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            categoriesFilter.Name = "categoriesFilter";
            categoriesFilter.Size = new Size(111, 19);
            categoriesFilter.TabIndex = 4;
            categoriesFilter.Text = "Lọc(Danh mục)";
            // 
            // materialCheckListBox1
            // 
            materialCheckListBox1.AutoScroll = true;
            materialCheckListBox1.BackColor = Color.Transparent;
            materialCheckListBox1.Depth = 0;
            materialCheckListBox1.Location = new Point(656, 220);
            materialCheckListBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckListBox1.Name = "materialCheckListBox1";
            materialCheckListBox1.Size = new Size(200, 88);
            materialCheckListBox1.Striped = false;
            materialCheckListBox1.StripeDarkColor = Color.Empty;
            materialCheckListBox1.TabIndex = 3;
            // 
            // materialListView1
            // 
            materialListView1.AllowColumnReorder = true;
            materialListView1.AutoSizeTable = true;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader7, columnHeader6, columnHeader8 });
            materialListView1.Depth = 0;
            materialListView1.FullRowSelect = true;
            materialListView1.Location = new Point(28, 329);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Scrollable = false;
            materialListView1.Size = new Size(720, 100);
            materialListView1.TabIndex = 2;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tên món";
            columnHeader5.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Danh mục";
            columnHeader7.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Hình ảnh";
            columnHeader6.Width = 300;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Giá";
            // 
            // historyPage
            // 
            historyPage.Controls.Add(materialListView2);
            historyPage.ImageKey = "history.png";
            historyPage.Location = new Point(4, 30);
            historyPage.Name = "historyPage";
            historyPage.Padding = new Padding(3);
            historyPage.Size = new Size(1015, 558);
            historyPage.TabIndex = 3;
            historyPage.Text = "History";
            historyPage.UseVisualStyleBackColor = true;
            // 
            // materialListView2
            // 
            materialListView2.AutoSizeTable = true;
            materialListView2.BackColor = Color.FromArgb(255, 255, 255);
            materialListView2.BorderStyle = BorderStyle.None;
            materialListView2.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11 });
            materialListView2.Depth = 0;
            materialListView2.FullRowSelect = true;
            materialListView2.Location = new Point(28, 10);
            materialListView2.MinimumSize = new Size(200, 100);
            materialListView2.MouseLocation = new Point(-1, -1);
            materialListView2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialListView2.Name = "materialListView2";
            materialListView2.OwnerDraw = true;
            materialListView2.Scrollable = false;
            materialListView2.Size = new Size(960, 100);
            materialListView2.TabIndex = 0;
            materialListView2.UseCompatibleStateImageBehavior = false;
            materialListView2.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "ID";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Time";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Infomation";
            columnHeader11.Width = 800;
            // 
            // tabImageList
            // 
            tabImageList.ColorDepth = ColorDepth.Depth8Bit;
            tabImageList.ImageStream = (ImageListStreamer)resources.GetObject("tabImageList.ImageStream");
            tabImageList.TransparentColor = Color.Transparent;
            tabImageList.Images.SetKeyName(0, "Home");
            tabImageList.Images.SetKeyName(1, "folders.png");
            tabImageList.Images.SetKeyName(2, "history.png");
            tabImageList.Images.SetKeyName(3, "stock.png");
            // 
            // ManagerApplication
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1029, 659);
            Controls.Add(StockItems);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = StockItems;
            MinimumSize = new Size(300, 200);
            Name = "ManagerApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CafeteriaService";
            TransparencyKey = Color.Fuchsia;
            StockItems.ResumeLayout(false);
            CategoriesPage.ResumeLayout(false);
            CategoriesPage.PerformLayout();
            StockItemsPage.ResumeLayout(false);
            StockItemsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            historyPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl StockItems;
        private TabPage homePage;
        private TabPage CategoriesPage;
        private ImageList tabImageList;
        private ReaLTaiizor.Controls.MaterialListView categoriesListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit categoryDescriptionInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit categoryIdInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit categoryNameInput;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ColumnHeader columnHeader3;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private TabPage StockItemsPage;
        private ReaLTaiizor.Controls.MaterialCheckListBox materialCheckListBox1;
        private ReaLTaiizor.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialLabel categoriesFilter;
        private ColumnHeader columnHeader7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit itemIdInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit itemNameInput;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private ReaLTaiizor.Controls.MaterialButton materialButton4;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ColumnHeader columnHeader8;
        private TabPage historyPage;
        private ReaLTaiizor.Controls.MaterialListView materialListView2;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}