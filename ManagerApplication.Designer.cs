using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

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
            categoryCancel = new ReaLTaiizor.Controls.MaterialButton();
            categoryRemove = new ReaLTaiizor.Controls.MaterialButton();
            categorySave = new ReaLTaiizor.Controls.MaterialButton();
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
            itemRemove = new ReaLTaiizor.Controls.MaterialButton();
            itemSelectImage = new ReaLTaiizor.Controls.MaterialButton();
            itemCancel = new ReaLTaiizor.Controls.MaterialButton();
            itemSave = new ReaLTaiizor.Controls.MaterialButton();
            categorySelect = new ReaLTaiizor.Controls.MaterialComboBox();
            itemSearch = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            itemNameInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            itemImages = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            itemQuantityInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            itemPriceInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            itemIdInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel10 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel9 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            itemListView = new ReaLTaiizor.Controls.MaterialListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            historyPage = new TabPage();
            orderHistoryListView = new ReaLTaiizor.Controls.MaterialListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            tabImageList = new ImageList(components);
            openImage = new OpenFileDialog();
            openOrderForm = new ReaLTaiizor.Controls.MaterialButton();
            StockItems.SuspendLayout();
            homePage.SuspendLayout();
            CategoriesPage.SuspendLayout();
            StockItemsPage.SuspendLayout();
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
            StockItems.Size = new Size(1123, 592);
            StockItems.TabIndex = 0;
            // 
            // homePage
            // 
            homePage.BackColor = Color.White;
            homePage.Controls.Add(openOrderForm);
            homePage.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            homePage.ImageKey = "Home";
            homePage.Location = new Point(4, 30);
            homePage.Name = "homePage";
            homePage.Size = new Size(1115, 558);
            homePage.TabIndex = 0;
            homePage.Text = "Home";
            // 
            // CategoriesPage
            // 
            CategoriesPage.Controls.Add(categoryCancel);
            CategoriesPage.Controls.Add(categoryRemove);
            CategoriesPage.Controls.Add(categorySave);
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
            CategoriesPage.Size = new Size(1115, 558);
            CategoriesPage.TabIndex = 1;
            CategoriesPage.Text = "Categories";
            CategoriesPage.UseVisualStyleBackColor = true;
            // 
            // categoryCancel
            // 
            categoryCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            categoryCancel.BackColor = Color.Transparent;
            categoryCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            categoryCancel.Depth = 0;
            categoryCancel.HighEmphasis = true;
            categoryCancel.Icon = null;
            categoryCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            categoryCancel.Location = new Point(399, 210);
            categoryCancel.Margin = new Padding(4, 6, 4, 6);
            categoryCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            categoryCancel.Name = "categoryCancel";
            categoryCancel.NoAccentTextColor = Color.Empty;
            categoryCancel.Size = new Size(64, 36);
            categoryCancel.TabIndex = 5;
            categoryCancel.Text = "Hủy";
            categoryCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            categoryCancel.UseAccentColor = false;
            categoryCancel.UseVisualStyleBackColor = false;
            categoryCancel.Click += CategoryInputReset;
            // 
            // categoryRemove
            // 
            categoryRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            categoryRemove.BackColor = Color.Transparent;
            categoryRemove.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            categoryRemove.Depth = 0;
            categoryRemove.Enabled = false;
            categoryRemove.HighEmphasis = true;
            categoryRemove.Icon = null;
            categoryRemove.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            categoryRemove.Location = new Point(399, 126);
            categoryRemove.Margin = new Padding(4, 6, 4, 6);
            categoryRemove.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            categoryRemove.Name = "categoryRemove";
            categoryRemove.NoAccentTextColor = Color.Empty;
            categoryRemove.Size = new Size(64, 36);
            categoryRemove.TabIndex = 5;
            categoryRemove.Text = "Xóa";
            categoryRemove.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            categoryRemove.UseAccentColor = false;
            categoryRemove.UseVisualStyleBackColor = false;
            categoryRemove.Click += categoryRemove_Click;
            // 
            // categorySave
            // 
            categorySave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            categorySave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            categorySave.Depth = 0;
            categorySave.HighEmphasis = true;
            categorySave.Icon = null;
            categorySave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            categorySave.Location = new Point(399, 44);
            categorySave.Margin = new Padding(4, 6, 4, 6);
            categorySave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            categorySave.Name = "categorySave";
            categorySave.NoAccentTextColor = Color.Empty;
            categorySave.Size = new Size(64, 36);
            categorySave.TabIndex = 5;
            categorySave.Text = "Lưu";
            categorySave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            categorySave.UseAccentColor = false;
            categorySave.UseVisualStyleBackColor = true;
            categorySave.Click += categorySave_Click;
            // 
            // categoryDescriptionInput
            // 
            categoryDescriptionInput.AnimateReadOnly = false;
            categoryDescriptionInput.BackgroundImageLayout = ImageLayout.None;
            categoryDescriptionInput.CharacterCasing = CharacterCasing.Normal;
            categoryDescriptionInput.Depth = 0;
            categoryDescriptionInput.HideSelection = true;
            categoryDescriptionInput.Location = new Point(28, 187);
            categoryDescriptionInput.MaxLength = 100;
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
            categoryIdInput.ReadOnly = true;
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
            categoryIdInput.TextChanged += categoryIdInput_TextChanged;
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
            categoryNameInput.MaxLength = 50;
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
            categoriesListView.AutoSizeTable = false;
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
            categoriesListView.Size = new Size(956, 231);
            categoriesListView.TabIndex = 1;
            categoriesListView.UseCompatibleStateImageBehavior = false;
            categoriesListView.View = View.Details;
            categoriesListView.ItemSelectionChanged += categoriesListView_ItemSelectionChanged;
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
            StockItemsPage.Controls.Add(itemRemove);
            StockItemsPage.Controls.Add(itemSelectImage);
            StockItemsPage.Controls.Add(itemCancel);
            StockItemsPage.Controls.Add(itemSave);
            StockItemsPage.Controls.Add(categorySelect);
            StockItemsPage.Controls.Add(itemSearch);
            StockItemsPage.Controls.Add(itemNameInput);
            StockItemsPage.Controls.Add(materialLabel8);
            StockItemsPage.Controls.Add(materialLabel6);
            StockItemsPage.Controls.Add(materialLabel1);
            StockItemsPage.Controls.Add(itemImages);
            StockItemsPage.Controls.Add(itemQuantityInput);
            StockItemsPage.Controls.Add(itemPriceInput);
            StockItemsPage.Controls.Add(itemIdInput);
            StockItemsPage.Controls.Add(materialLabel10);
            StockItemsPage.Controls.Add(materialLabel9);
            StockItemsPage.Controls.Add(materialLabel7);
            StockItemsPage.Controls.Add(materialLabel5);
            StockItemsPage.Controls.Add(itemListView);
            StockItemsPage.ImageKey = "stock.png";
            StockItemsPage.Location = new Point(4, 30);
            StockItemsPage.Name = "StockItemsPage";
            StockItemsPage.Padding = new Padding(3);
            StockItemsPage.Size = new Size(1115, 558);
            StockItemsPage.TabIndex = 2;
            StockItemsPage.Text = "Stock Items";
            StockItemsPage.UseVisualStyleBackColor = true;
            // 
            // itemRemove
            // 
            itemRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemRemove.BackColor = Color.Transparent;
            itemRemove.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            itemRemove.Depth = 0;
            itemRemove.Enabled = false;
            itemRemove.HighEmphasis = true;
            itemRemove.Icon = null;
            itemRemove.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            itemRemove.Location = new Point(740, 143);
            itemRemove.Margin = new Padding(4, 6, 4, 6);
            itemRemove.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            itemRemove.Name = "itemRemove";
            itemRemove.NoAccentTextColor = Color.Empty;
            itemRemove.Size = new Size(64, 36);
            itemRemove.TabIndex = 9;
            itemRemove.Text = "Xóa";
            itemRemove.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            itemRemove.UseAccentColor = false;
            itemRemove.UseVisualStyleBackColor = false;
            // 
            // itemSelectImage
            // 
            itemSelectImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemSelectImage.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            itemSelectImage.Depth = 0;
            itemSelectImage.HighEmphasis = true;
            itemSelectImage.Icon = null;
            itemSelectImage.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            itemSelectImage.Location = new Point(340, 192);
            itemSelectImage.Margin = new Padding(4, 6, 4, 6);
            itemSelectImage.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            itemSelectImage.Name = "itemSelectImage";
            itemSelectImage.NoAccentTextColor = Color.Empty;
            itemSelectImage.Size = new Size(97, 36);
            itemSelectImage.TabIndex = 10;
            itemSelectImage.Text = "Chọn ảnh";
            itemSelectImage.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            itemSelectImage.UseAccentColor = false;
            itemSelectImage.UseVisualStyleBackColor = true;
            itemSelectImage.Click += itemSelectImage_Click;
            // 
            // itemCancel
            // 
            itemCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            itemCancel.Depth = 0;
            itemCancel.HighEmphasis = true;
            itemCancel.Icon = null;
            itemCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            itemCancel.Location = new Point(835, 143);
            itemCancel.Margin = new Padding(4, 6, 4, 6);
            itemCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            itemCancel.Name = "itemCancel";
            itemCancel.NoAccentTextColor = Color.Empty;
            itemCancel.Size = new Size(64, 36);
            itemCancel.TabIndex = 10;
            itemCancel.Text = "Hủy";
            itemCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            itemCancel.UseAccentColor = false;
            itemCancel.UseVisualStyleBackColor = true;
            itemCancel.Click += ItemInputReset;
            // 
            // itemSave
            // 
            itemSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            itemSave.Depth = 0;
            itemSave.HighEmphasis = true;
            itemSave.Icon = null;
            itemSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            itemSave.Location = new Point(649, 143);
            itemSave.Margin = new Padding(4, 6, 4, 6);
            itemSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            itemSave.Name = "itemSave";
            itemSave.NoAccentTextColor = Color.Empty;
            itemSave.Size = new Size(64, 36);
            itemSave.TabIndex = 10;
            itemSave.Text = "Lưu";
            itemSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            itemSave.UseAccentColor = false;
            itemSave.UseVisualStyleBackColor = true;
            itemSave.Click += itemSave_Click;
            // 
            // categorySelect
            // 
            categorySelect.AutoResize = false;
            categorySelect.BackColor = Color.FromArgb(255, 255, 255);
            categorySelect.Depth = 0;
            categorySelect.DrawMode = DrawMode.OwnerDrawVariable;
            categorySelect.DropDownHeight = 174;
            categorySelect.DropDownStyle = ComboBoxStyle.DropDownList;
            categorySelect.DropDownWidth = 121;
            categorySelect.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            categorySelect.ForeColor = Color.FromArgb(222, 0, 0, 0);
            categorySelect.FormattingEnabled = true;
            categorySelect.IntegralHeight = false;
            categorySelect.ItemHeight = 43;
            categorySelect.Location = new Point(28, 223);
            categorySelect.MaxDropDownItems = 4;
            categorySelect.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            categorySelect.Name = "categorySelect";
            categorySelect.Size = new Size(250, 49);
            categorySelect.StartIndex = 0;
            categorySelect.TabIndex = 7;
            categorySelect.SelectedIndexChanged += categorySelect_SelectedIndexChanged;
            // 
            // itemSearch
            // 
            itemSearch.AnimateReadOnly = false;
            itemSearch.AutoCompleteMode = AutoCompleteMode.None;
            itemSearch.AutoCompleteSource = AutoCompleteSource.None;
            itemSearch.BackgroundImageLayout = ImageLayout.None;
            itemSearch.CharacterCasing = CharacterCasing.Normal;
            itemSearch.Depth = 0;
            itemSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            itemSearch.HideSelection = true;
            itemSearch.LeadingIcon = null;
            itemSearch.Location = new Point(649, 273);
            itemSearch.MaxLength = 32767;
            itemSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemSearch.Name = "itemSearch";
            itemSearch.PasswordChar = '\0';
            itemSearch.PrefixSuffixText = null;
            itemSearch.ReadOnly = false;
            itemSearch.RightToLeft = RightToLeft.No;
            itemSearch.SelectedText = "";
            itemSearch.SelectionLength = 0;
            itemSearch.SelectionStart = 0;
            itemSearch.ShortcutsEnabled = true;
            itemSearch.Size = new Size(250, 36);
            itemSearch.TabIndex = 6;
            itemSearch.TabStop = false;
            itemSearch.TextAlign = HorizontalAlignment.Left;
            itemSearch.TrailingIcon = null;
            itemSearch.UseSystemPasswordChar = false;
            itemSearch.UseTallSize = false;
            itemSearch.TextChanged += itemSearch_TextChanged;
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
            itemNameInput.MaxLength = 50;
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
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(649, 242);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(67, 19);
            materialLabel8.TabIndex = 5;
            materialLabel8.Text = "Tìm kiếm";
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
            // itemImages
            // 
            itemImages.AnimateReadOnly = false;
            itemImages.AutoCompleteMode = AutoCompleteMode.None;
            itemImages.AutoCompleteSource = AutoCompleteSource.None;
            itemImages.BackgroundImageLayout = ImageLayout.None;
            itemImages.CharacterCasing = CharacterCasing.Normal;
            itemImages.Depth = 0;
            itemImages.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            itemImages.HideSelection = true;
            itemImages.LeadingIcon = null;
            itemImages.Location = new Point(340, 131);
            itemImages.MaxLength = 32767;
            itemImages.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemImages.Name = "itemImages";
            itemImages.PasswordChar = '\0';
            itemImages.PrefixSuffixText = null;
            itemImages.ReadOnly = false;
            itemImages.RightToLeft = RightToLeft.No;
            itemImages.SelectedText = "";
            itemImages.SelectionLength = 0;
            itemImages.SelectionStart = 0;
            itemImages.ShortcutsEnabled = true;
            itemImages.Size = new Size(250, 48);
            itemImages.TabIndex = 6;
            itemImages.TabStop = false;
            itemImages.TextAlign = HorizontalAlignment.Left;
            itemImages.TrailingIcon = null;
            itemImages.UseSystemPasswordChar = false;
            // 
            // itemQuantityInput
            // 
            itemQuantityInput.AnimateReadOnly = false;
            itemQuantityInput.AutoCompleteMode = AutoCompleteMode.None;
            itemQuantityInput.AutoCompleteSource = AutoCompleteSource.None;
            itemQuantityInput.BackgroundImageLayout = ImageLayout.None;
            itemQuantityInput.CharacterCasing = CharacterCasing.Normal;
            itemQuantityInput.Depth = 0;
            itemQuantityInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            itemQuantityInput.HideSelection = true;
            itemQuantityInput.LeadingIcon = null;
            itemQuantityInput.Location = new Point(649, 41);
            itemQuantityInput.MaxLength = 32767;
            itemQuantityInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemQuantityInput.Name = "itemQuantityInput";
            itemQuantityInput.PasswordChar = '\0';
            itemQuantityInput.PrefixSuffixText = null;
            itemQuantityInput.ReadOnly = false;
            itemQuantityInput.RightToLeft = RightToLeft.No;
            itemQuantityInput.SelectedText = "";
            itemQuantityInput.SelectionLength = 0;
            itemQuantityInput.SelectionStart = 0;
            itemQuantityInput.ShortcutsEnabled = true;
            itemQuantityInput.Size = new Size(250, 48);
            itemQuantityInput.TabIndex = 6;
            itemQuantityInput.TabStop = false;
            itemQuantityInput.TextAlign = HorizontalAlignment.Left;
            itemQuantityInput.TrailingIcon = null;
            itemQuantityInput.UseSystemPasswordChar = false;
            // 
            // itemPriceInput
            // 
            itemPriceInput.AnimateReadOnly = false;
            itemPriceInput.AutoCompleteMode = AutoCompleteMode.None;
            itemPriceInput.AutoCompleteSource = AutoCompleteSource.None;
            itemPriceInput.BackgroundImageLayout = ImageLayout.None;
            itemPriceInput.CharacterCasing = CharacterCasing.Normal;
            itemPriceInput.Depth = 0;
            itemPriceInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            itemPriceInput.HideSelection = true;
            itemPriceInput.LeadingIcon = null;
            itemPriceInput.Location = new Point(340, 41);
            itemPriceInput.MaxLength = 32767;
            itemPriceInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemPriceInput.Name = "itemPriceInput";
            itemPriceInput.PasswordChar = '\0';
            itemPriceInput.PrefixSuffixText = null;
            itemPriceInput.ReadOnly = false;
            itemPriceInput.RightToLeft = RightToLeft.No;
            itemPriceInput.SelectedText = "";
            itemPriceInput.SelectionLength = 0;
            itemPriceInput.SelectionStart = 0;
            itemPriceInput.ShortcutsEnabled = true;
            itemPriceInput.Size = new Size(250, 48);
            itemPriceInput.TabIndex = 6;
            itemPriceInput.TabStop = false;
            itemPriceInput.TextAlign = HorizontalAlignment.Left;
            itemPriceInput.TrailingIcon = null;
            itemPriceInput.UseSystemPasswordChar = false;
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
            itemIdInput.ReadOnly = true;
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
            itemIdInput.Click += itemIdInput_Click;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(649, 10);
            materialLabel10.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(65, 19);
            materialLabel10.TabIndex = 5;
            materialLabel10.Text = "Số lượng";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(340, 10);
            materialLabel9.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(25, 19);
            materialLabel9.TabIndex = 5;
            materialLabel9.Text = "Giá";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(340, 100);
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
            // itemListView
            // 
            itemListView.Activation = ItemActivation.OneClick;
            itemListView.AllowColumnReorder = true;
            itemListView.AutoSizeTable = false;
            itemListView.BackColor = Color.FromArgb(255, 255, 255);
            itemListView.BorderStyle = BorderStyle.None;
            itemListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader7, columnHeader8, columnHeader12, columnHeader6 });
            itemListView.Depth = 0;
            itemListView.FullRowSelect = true;
            itemListView.Location = new Point(28, 329);
            itemListView.MinimumSize = new Size(200, 100);
            itemListView.MouseLocation = new Point(-1, -1);
            itemListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemListView.Name = "itemListView";
            itemListView.OwnerDraw = true;
            itemListView.Size = new Size(958, 100);
            itemListView.TabIndex = 2;
            itemListView.UseCompatibleStateImageBehavior = false;
            itemListView.View = View.Details;
            itemListView.ItemSelectionChanged += itemListView_ItemSelectionChanged;
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
            // columnHeader8
            // 
            columnHeader8.Text = "Giá";
            columnHeader8.Width = 110;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Số lượng";
            columnHeader12.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Hình ảnh";
            columnHeader6.Width = 200;
            // 
            // historyPage
            // 
            historyPage.Controls.Add(orderHistoryListView);
            historyPage.ImageKey = "history.png";
            historyPage.Location = new Point(4, 30);
            historyPage.Name = "historyPage";
            historyPage.Padding = new Padding(3);
            historyPage.Size = new Size(1115, 558);
            historyPage.TabIndex = 3;
            historyPage.Text = "History";
            historyPage.UseVisualStyleBackColor = true;
            // 
            // orderHistoryListView
            // 
            orderHistoryListView.AutoSizeTable = false;
            orderHistoryListView.BackColor = Color.FromArgb(255, 255, 255);
            orderHistoryListView.BorderStyle = BorderStyle.None;
            orderHistoryListView.CheckBoxes = true;
            orderHistoryListView.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader13, columnHeader14, columnHeader15, columnHeader11 });
            orderHistoryListView.Depth = 0;
            orderHistoryListView.FullRowSelect = true;
            orderHistoryListView.Location = new Point(46, 26);
            orderHistoryListView.MinimumSize = new Size(200, 100);
            orderHistoryListView.MouseLocation = new Point(-1, -1);
            orderHistoryListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            orderHistoryListView.MultiSelect = false;
            orderHistoryListView.Name = "orderHistoryListView";
            orderHistoryListView.OwnerDraw = true;
            orderHistoryListView.ShowGroups = false;
            orderHistoryListView.Size = new Size(1023, 507);
            orderHistoryListView.TabIndex = 0;
            orderHistoryListView.UseCompatibleStateImageBehavior = false;
            orderHistoryListView.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "ID";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Time";
            columnHeader10.Width = 220;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "TotalPrice";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Paid";
            columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Change";
            columnHeader15.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Infomation";
            columnHeader11.Width = 440;
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
            // openImage
            // 
            openImage.DefaultExt = "jpg";
            openImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp";
            openImage.InitialDirectory = "C:\\";
            openImage.Multiselect = true;
            openImage.RestoreDirectory = true;
            openImage.SupportMultiDottedExtensions = true;
            openImage.Title = "Chọn ảnh";
            // 
            // openOrderForm
            // 
            openOrderForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openOrderForm.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            openOrderForm.Depth = 0;
            openOrderForm.HighEmphasis = true;
            openOrderForm.Icon = null;
            openOrderForm.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            openOrderForm.Location = new Point(478, 261);
            openOrderForm.Margin = new Padding(4, 6, 4, 6);
            openOrderForm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            openOrderForm.Name = "openOrderForm";
            openOrderForm.NoAccentTextColor = Color.Empty;
            openOrderForm.Size = new Size(158, 36);
            openOrderForm.TabIndex = 0;
            openOrderForm.Text = "Mở Order Form";
            openOrderForm.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            openOrderForm.UseAccentColor = false;
            openOrderForm.UseVisualStyleBackColor = true;
            openOrderForm.Click += openOrderForm_Click;
            // 
            // ManagerApplication
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1129, 659);
            Controls.Add(StockItems);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = StockItems;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(300, 200);
            Name = "ManagerApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CafeteriaService";
            TransparencyKey = Color.Fuchsia;
            Load += ManagerApplication_Load;
            Resize += ManagerApplication_Resize;
            StockItems.ResumeLayout(false);
            homePage.ResumeLayout(false);
            homePage.PerformLayout();
            CategoriesPage.ResumeLayout(false);
            CategoriesPage.PerformLayout();
            StockItemsPage.ResumeLayout(false);
            StockItemsPage.PerformLayout();
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
        private ReaLTaiizor.Controls.MaterialButton categoryRemove;
        private ReaLTaiizor.Controls.MaterialButton categorySave;
        private TabPage StockItemsPage;
        private ReaLTaiizor.Controls.MaterialListView itemListView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ColumnHeader columnHeader7;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit itemIdInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit itemNameInput;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton itemRemove;
        private ReaLTaiizor.Controls.MaterialButton itemSave;
        private ReaLTaiizor.Controls.MaterialComboBox categorySelect;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ColumnHeader columnHeader8;
        private TabPage historyPage;
        private ReaLTaiizor.Controls.MaterialListView orderHistoryListView;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit itemImages;
        private OpenFileDialog openImage;
        private ReaLTaiizor.Controls.MaterialButton categoryCancel;
        private ReaLTaiizor.Controls.MaterialButton itemSelectImage;
        private ReaLTaiizor.Controls.MaterialButton itemCancel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit itemSearch;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit itemQuantityInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit itemPriceInput;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel10;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel9;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ReaLTaiizor.Controls.MaterialButton openOrderForm;
    }
}