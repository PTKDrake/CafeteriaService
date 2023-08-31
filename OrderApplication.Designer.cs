using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderApplication));
            OrderTabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            PlaceOrderTab = new TabPage();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            itemListView = new ReaLTaiizor.Controls.MaterialListView();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            cartListView = new ReaLTaiizor.Controls.MaterialListView();
            ID = new ColumnHeader();
            Item = new ColumnHeader();
            Price = new ColumnHeader();
            Quantity = new ColumnHeader();
            groupBox1 = new GroupBox();
            itemPicture = new PictureBox();
            itemCancel = new ReaLTaiizor.Controls.MaterialButton();
            itemSave = new ReaLTaiizor.Controls.MaterialButton();
            itemQuantity = new NumericUpDown();
            itemId = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            itemName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            itemPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            itemSearch = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            checkOut = new ReaLTaiizor.Controls.MaterialButton();
            itemRemove = new ReaLTaiizor.Controls.MaterialButton();
            categorySelect = new ReaLTaiizor.Controls.MaterialComboBox();
            CheckOutTab = new TabPage();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            orderIdLabel = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            iconList = new ImageList(components);
            orderId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            orderNew = new ReaLTaiizor.Controls.MaterialButton();
            OrderTabControl.SuspendLayout();
            PlaceOrderTab.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemQuantity).BeginInit();
            CheckOutTab.SuspendLayout();
            SuspendLayout();
            // 
            // OrderTabControl
            // 
            OrderTabControl.Controls.Add(PlaceOrderTab);
            OrderTabControl.Controls.Add(CheckOutTab);
            OrderTabControl.Depth = 0;
            OrderTabControl.Dock = DockStyle.Fill;
            OrderTabControl.ImageList = iconList;
            OrderTabControl.Location = new Point(3, 64);
            OrderTabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            OrderTabControl.Multiline = true;
            OrderTabControl.Name = "OrderTabControl";
            OrderTabControl.SelectedIndex = 0;
            OrderTabControl.Size = new Size(1123, 592);
            OrderTabControl.TabIndex = 0;
            OrderTabControl.SelectedIndexChanged += OrderTabControl_SelectedIndexChanged;
            // 
            // PlaceOrderTab
            // 
            PlaceOrderTab.BackColor = Color.White;
            PlaceOrderTab.Controls.Add(materialLabel4);
            PlaceOrderTab.Controls.Add(materialLabel1);
            PlaceOrderTab.Controls.Add(itemListView);
            PlaceOrderTab.Controls.Add(cartListView);
            PlaceOrderTab.Controls.Add(groupBox1);
            PlaceOrderTab.Controls.Add(itemSearch);
            PlaceOrderTab.Controls.Add(checkOut);
            PlaceOrderTab.Controls.Add(itemRemove);
            PlaceOrderTab.Controls.Add(categorySelect);
            PlaceOrderTab.ImageKey = "place_order.png";
            PlaceOrderTab.Location = new Point(4, 24);
            PlaceOrderTab.Name = "PlaceOrderTab";
            PlaceOrderTab.Padding = new Padding(3);
            PlaceOrderTab.Size = new Size(1115, 564);
            PlaceOrderTab.TabIndex = 0;
            PlaceOrderTab.Text = "PlaceOrder";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(29, 111);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(67, 19);
            materialLabel4.TabIndex = 13;
            materialLabel4.Text = "Tìm kiếm";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(29, 15);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(74, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Danh mục";
            // 
            // itemListView
            // 
            itemListView.Activation = ItemActivation.OneClick;
            itemListView.AutoSizeTable = false;
            itemListView.BackColor = Color.FromArgb(255, 255, 255);
            itemListView.BorderStyle = BorderStyle.None;
            itemListView.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
            itemListView.Depth = 0;
            itemListView.FullRowSelect = true;
            itemListView.Location = new Point(29, 243);
            itemListView.MinimumSize = new Size(200, 100);
            itemListView.MouseLocation = new Point(-1, -1);
            itemListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemListView.MultiSelect = false;
            itemListView.Name = "itemListView";
            itemListView.OwnerDraw = true;
            itemListView.Size = new Size(326, 254);
            itemListView.TabIndex = 12;
            itemListView.UseCompatibleStateImageBehavior = false;
            itemListView.View = View.Details;
            itemListView.ItemSelectionChanged += itemListView_ItemSelectionChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Món";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Giá";
            columnHeader2.Width = 100;
            // 
            // cartListView
            // 
            cartListView.Activation = ItemActivation.OneClick;
            cartListView.AutoSizeTable = false;
            cartListView.BackColor = Color.FromArgb(255, 255, 255);
            cartListView.BorderStyle = BorderStyle.None;
            cartListView.Columns.AddRange(new ColumnHeader[] { ID, Item, Price, Quantity });
            cartListView.Depth = 0;
            cartListView.FullRowSelect = true;
            cartListView.Location = new Point(401, 352);
            cartListView.MinimumSize = new Size(200, 100);
            cartListView.MouseLocation = new Point(-1, -1);
            cartListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cartListView.MultiSelect = false;
            cartListView.Name = "cartListView";
            cartListView.OwnerDraw = true;
            cartListView.Size = new Size(587, 145);
            cartListView.TabIndex = 11;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.View = View.Details;
            cartListView.ItemSelectionChanged += cartListView_ItemSelectionChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Item
            // 
            Item.Text = "Món";
            Item.Width = 200;
            // 
            // Price
            // 
            Price.Text = "Giá";
            Price.Width = 120;
            // 
            // Quantity
            // 
            Quantity.Text = "Số lượng";
            Quantity.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(itemPicture);
            groupBox1.Controls.Add(itemCancel);
            groupBox1.Controls.Add(itemSave);
            groupBox1.Controls.Add(itemQuantity);
            groupBox1.Controls.Add(itemId);
            groupBox1.Controls.Add(itemName);
            groupBox1.Controls.Add(itemPrice);
            groupBox1.Controls.Add(materialLabel3);
            groupBox1.Controls.Add(materialLabel5);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Location = new Point(401, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 313);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // itemPicture
            // 
            itemPicture.BorderStyle = BorderStyle.FixedSingle;
            itemPicture.Location = new Point(352, 46);
            itemPicture.Name = "itemPicture";
            itemPicture.Size = new Size(220, 220);
            itemPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            itemPicture.TabIndex = 33;
            itemPicture.TabStop = false;
            // 
            // itemCancel
            // 
            itemCancel.AutoSize = false;
            itemCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            itemCancel.Depth = 0;
            itemCancel.Enabled = false;
            itemCancel.HighEmphasis = true;
            itemCancel.Icon = null;
            itemCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            itemCancel.Location = new Point(186, 237);
            itemCancel.Margin = new Padding(4, 6, 4, 6);
            itemCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            itemCancel.Name = "itemCancel";
            itemCancel.NoAccentTextColor = Color.Empty;
            itemCancel.Size = new Size(136, 36);
            itemCancel.TabIndex = 32;
            itemCancel.Text = "Hủy";
            itemCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            itemCancel.UseAccentColor = false;
            itemCancel.UseVisualStyleBackColor = true;
            itemCancel.Click += itemCancel_Click;
            // 
            // itemSave
            // 
            itemSave.AutoSize = false;
            itemSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            itemSave.Depth = 0;
            itemSave.Enabled = false;
            itemSave.HighEmphasis = true;
            itemSave.Icon = null;
            itemSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            itemSave.Location = new Point(35, 237);
            itemSave.Margin = new Padding(4, 6, 4, 6);
            itemSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            itemSave.Name = "itemSave";
            itemSave.NoAccentTextColor = Color.Empty;
            itemSave.Size = new Size(136, 36);
            itemSave.TabIndex = 32;
            itemSave.Text = "Đồng ý";
            itemSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            itemSave.UseAccentColor = false;
            itemSave.UseVisualStyleBackColor = true;
            itemSave.Click += itemSave_Click;
            // 
            // itemQuantity
            // 
            itemQuantity.Enabled = false;
            itemQuantity.Location = new Point(35, 154);
            itemQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            itemQuantity.Name = "itemQuantity";
            itemQuantity.Size = new Size(136, 23);
            itemQuantity.TabIndex = 31;
            itemQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            itemQuantity.ValueChanged += itemQuantity_ValueChanged;
            // 
            // itemId
            // 
            itemId.AllowPromptAsInput = true;
            itemId.AnimateReadOnly = false;
            itemId.AsciiOnly = false;
            itemId.BackgroundImageLayout = ImageLayout.None;
            itemId.BeepOnError = false;
            itemId.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            itemId.Depth = 0;
            itemId.Enabled = false;
            itemId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            itemId.HidePromptOnLeave = false;
            itemId.HideSelection = true;
            itemId.InsertKeyMode = InsertKeyMode.Default;
            itemId.LeadingIcon = null;
            itemId.Location = new Point(6, 30);
            itemId.Mask = "";
            itemId.MaxLength = 32767;
            itemId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemId.Name = "itemId";
            itemId.PasswordChar = '\0';
            itemId.PrefixSuffixText = null;
            itemId.PromptChar = '_';
            itemId.ReadOnly = true;
            itemId.RejectInputOnFirstFailure = false;
            itemId.ResetOnPrompt = true;
            itemId.ResetOnSpace = true;
            itemId.RightToLeft = RightToLeft.No;
            itemId.SelectedText = "";
            itemId.SelectionLength = 0;
            itemId.SelectionStart = 0;
            itemId.ShortcutsEnabled = true;
            itemId.Size = new Size(23, 36);
            itemId.SkipLiterals = true;
            itemId.TabIndex = 29;
            itemId.TabStop = false;
            itemId.TextAlign = HorizontalAlignment.Left;
            itemId.TextMaskFormat = MaskFormat.IncludeLiterals;
            itemId.TrailingIcon = null;
            itemId.UseSystemPasswordChar = false;
            itemId.UseTallSize = false;
            itemId.ValidatingType = null;
            itemId.Visible = false;
            // 
            // itemName
            // 
            itemName.AllowPromptAsInput = true;
            itemName.AnimateReadOnly = false;
            itemName.AsciiOnly = false;
            itemName.BackgroundImageLayout = ImageLayout.None;
            itemName.BeepOnError = false;
            itemName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            itemName.Depth = 0;
            itemName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            itemName.HidePromptOnLeave = false;
            itemName.HideSelection = true;
            itemName.InsertKeyMode = InsertKeyMode.Default;
            itemName.LeadingIcon = null;
            itemName.Location = new Point(35, 70);
            itemName.Mask = "";
            itemName.MaxLength = 32767;
            itemName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemName.Name = "itemName";
            itemName.PasswordChar = '\0';
            itemName.PrefixSuffixText = null;
            itemName.PromptChar = '_';
            itemName.ReadOnly = true;
            itemName.RejectInputOnFirstFailure = false;
            itemName.ResetOnPrompt = true;
            itemName.ResetOnSpace = true;
            itemName.RightToLeft = RightToLeft.No;
            itemName.SelectedText = "";
            itemName.SelectionLength = 0;
            itemName.SelectionStart = 0;
            itemName.ShortcutsEnabled = true;
            itemName.Size = new Size(136, 36);
            itemName.SkipLiterals = true;
            itemName.TabIndex = 29;
            itemName.TabStop = false;
            itemName.TextAlign = HorizontalAlignment.Left;
            itemName.TextMaskFormat = MaskFormat.IncludeLiterals;
            itemName.TrailingIcon = null;
            itemName.UseSystemPasswordChar = false;
            itemName.UseTallSize = false;
            itemName.ValidatingType = null;
            // 
            // itemPrice
            // 
            itemPrice.AllowPromptAsInput = true;
            itemPrice.AnimateReadOnly = false;
            itemPrice.AsciiOnly = false;
            itemPrice.BackgroundImageLayout = ImageLayout.None;
            itemPrice.BeepOnError = false;
            itemPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            itemPrice.Depth = 0;
            itemPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            itemPrice.HidePromptOnLeave = false;
            itemPrice.HideSelection = true;
            itemPrice.InsertKeyMode = InsertKeyMode.Default;
            itemPrice.LeadingIcon = null;
            itemPrice.Location = new Point(186, 70);
            itemPrice.Mask = "";
            itemPrice.MaxLength = 32767;
            itemPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            itemPrice.Name = "itemPrice";
            itemPrice.PasswordChar = '\0';
            itemPrice.PrefixSuffixText = null;
            itemPrice.PromptChar = '_';
            itemPrice.ReadOnly = true;
            itemPrice.RejectInputOnFirstFailure = false;
            itemPrice.ResetOnPrompt = true;
            itemPrice.ResetOnSpace = true;
            itemPrice.RightToLeft = RightToLeft.No;
            itemPrice.SelectedText = "";
            itemPrice.SelectionLength = 0;
            itemPrice.SelectionStart = 0;
            itemPrice.ShortcutsEnabled = true;
            itemPrice.Size = new Size(136, 36);
            itemPrice.SkipLiterals = true;
            itemPrice.TabIndex = 29;
            itemPrice.TabStop = false;
            itemPrice.TextAlign = HorizontalAlignment.Left;
            itemPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            itemPrice.TrailingIcon = null;
            itemPrice.UseSystemPasswordChar = false;
            itemPrice.UseTallSize = false;
            itemPrice.ValidatingType = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel3.Location = new Point(35, 109);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(96, 29);
            materialLabel3.TabIndex = 24;
            materialLabel3.Text = "Số lượng";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel5.Location = new Point(186, 30);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(36, 29);
            materialLabel5.TabIndex = 23;
            materialLabel5.Text = "Giá";
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
            materialLabel2.Size = new Size(49, 29);
            materialLabel2.TabIndex = 23;
            materialLabel2.Text = "Món";
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
            itemSearch.Location = new Point(29, 142);
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
            itemSearch.Size = new Size(326, 48);
            itemSearch.TabIndex = 7;
            itemSearch.TabStop = false;
            itemSearch.TextAlign = HorizontalAlignment.Left;
            itemSearch.TrailingIcon = null;
            itemSearch.UseSystemPasswordChar = false;
            // 
            // checkOut
            // 
            checkOut.AutoSize = false;
            checkOut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            checkOut.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            checkOut.Depth = 0;
            checkOut.Enabled = false;
            checkOut.HighEmphasis = true;
            checkOut.Icon = null;
            checkOut.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            checkOut.Location = new Point(830, 519);
            checkOut.Margin = new Padding(4, 6, 4, 6);
            checkOut.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            checkOut.Name = "checkOut";
            checkOut.NoAccentTextColor = Color.Empty;
            checkOut.Size = new Size(158, 36);
            checkOut.TabIndex = 6;
            checkOut.Text = "Thanh toán";
            checkOut.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            checkOut.UseAccentColor = false;
            checkOut.UseVisualStyleBackColor = true;
            checkOut.Click += checkOut_Click;
            // 
            // itemRemove
            // 
            itemRemove.AutoSize = false;
            itemRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemRemove.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            itemRemove.Depth = 0;
            itemRemove.HighEmphasis = true;
            itemRemove.Icon = null;
            itemRemove.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            itemRemove.Location = new Point(401, 519);
            itemRemove.Margin = new Padding(4, 6, 4, 6);
            itemRemove.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            itemRemove.Name = "itemRemove";
            itemRemove.NoAccentTextColor = Color.Empty;
            itemRemove.Size = new Size(158, 36);
            itemRemove.TabIndex = 5;
            itemRemove.Text = "Xóa";
            itemRemove.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            itemRemove.UseAccentColor = false;
            itemRemove.UseVisualStyleBackColor = true;
            itemRemove.Click += itemRemove_Click;
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
            categorySelect.Location = new Point(29, 48);
            categorySelect.MaxDropDownItems = 4;
            categorySelect.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            categorySelect.Name = "categorySelect";
            categorySelect.Size = new Size(326, 49);
            categorySelect.StartIndex = 0;
            categorySelect.TabIndex = 2;
            categorySelect.SelectedIndexChanged += categorySelect_SelectedIndexChanged;
            // 
            // CheckOutTab
            // 
            CheckOutTab.Controls.Add(orderNew);
            CheckOutTab.Controls.Add(orderId);
            CheckOutTab.Controls.Add(materialLabel7);
            CheckOutTab.Controls.Add(orderIdLabel);
            CheckOutTab.Controls.Add(materialLabel6);
            CheckOutTab.ImageKey = "checkout.png";
            CheckOutTab.Location = new Point(4, 24);
            CheckOutTab.Name = "CheckOutTab";
            CheckOutTab.Padding = new Padding(3);
            CheckOutTab.Size = new Size(1115, 564);
            CheckOutTab.TabIndex = 1;
            CheckOutTab.Text = "CheckOut";
            CheckOutTab.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel7.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel7.Location = new Point(490, 185);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(134, 29);
            materialLabel7.TabIndex = 0;
            materialLabel7.Text = "Mã hóa đơn:";
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Depth = 0;
            orderIdLabel.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            orderIdLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            orderIdLabel.Location = new Point(463, 253);
            orderIdLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new Size(189, 41);
            orderIdLabel.TabIndex = 0;
            orderIdLabel.Text = "Mã hóa đơn:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H3;
            materialLabel6.Location = new Point(300, 60);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(514, 58);
            materialLabel6.TabIndex = 0;
            materialLabel6.Text = "Thanh toán thành công!\r\n";
            materialLabel6.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconList
            // 
            iconList.ColorDepth = ColorDepth.Depth8Bit;
            iconList.ImageStream = (ImageListStreamer)resources.GetObject("iconList.ImageStream");
            iconList.TransparentColor = Color.Transparent;
            iconList.Images.SetKeyName(0, "checkout.png");
            iconList.Images.SetKeyName(1, "place_order.png");
            // 
            // orderId
            // 
            orderId.AnimateReadOnly = false;
            orderId.AutoCompleteMode = AutoCompleteMode.None;
            orderId.AutoCompleteSource = AutoCompleteSource.None;
            orderId.BackgroundImageLayout = ImageLayout.None;
            orderId.CharacterCasing = CharacterCasing.Normal;
            orderId.Depth = 0;
            orderId.Enabled = false;
            orderId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            orderId.HideSelection = true;
            orderId.LeadingIcon = null;
            orderId.Location = new Point(432, 354);
            orderId.MaxLength = 32767;
            orderId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            orderId.Name = "orderId";
            orderId.PasswordChar = '\0';
            orderId.PrefixSuffixText = null;
            orderId.ReadOnly = false;
            orderId.RightToLeft = RightToLeft.No;
            orderId.SelectedText = "";
            orderId.SelectionLength = 0;
            orderId.SelectionStart = 0;
            orderId.ShortcutsEnabled = true;
            orderId.Size = new Size(250, 48);
            orderId.TabIndex = 1;
            orderId.TabStop = false;
            orderId.TextAlign = HorizontalAlignment.Left;
            orderId.TrailingIcon = null;
            orderId.UseSystemPasswordChar = false;
            orderId.Visible = false;
            // 
            // orderNew
            // 
            orderNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            orderNew.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            orderNew.Depth = 0;
            orderNew.HighEmphasis = true;
            orderNew.Icon = null;
            orderNew.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            orderNew.Location = new Point(478, 440);
            orderNew.Margin = new Padding(4, 6, 4, 6);
            orderNew.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            orderNew.Name = "orderNew";
            orderNew.NoAccentTextColor = Color.Empty;
            orderNew.Size = new Size(131, 36);
            orderNew.TabIndex = 2;
            orderNew.Text = "Tạo order mới";
            orderNew.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            orderNew.UseAccentColor = false;
            orderNew.UseVisualStyleBackColor = true;
            orderNew.Click += orderNew_Click;
            // 
            // OrderApplication
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1129, 659);
            Controls.Add(OrderTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = OrderTabControl;
            MinimumSize = new Size(300, 200);
            Name = "OrderApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CafeteriaService";
            Load += OrderApplication_Load;
            OrderTabControl.ResumeLayout(false);
            PlaceOrderTab.ResumeLayout(false);
            PlaceOrderTab.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemQuantity).EndInit();
            CheckOutTab.ResumeLayout(false);
            CheckOutTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl OrderTabControl;
        private TabPage PlaceOrderTab;
        private TabPage CheckOutTab;
        private ReaLTaiizor.Controls.MaterialComboBox categorySelect;
        private ReaLTaiizor.Controls.MaterialButton checkOut;
        private ReaLTaiizor.Controls.MaterialButton itemRemove;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit itemSearch;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialButton itemSave;
        private NumericUpDown itemQuantity;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox itemPrice;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialListView cartListView;
        private ColumnHeader ID;
        private ColumnHeader Item;
        private ColumnHeader Price;
        private ColumnHeader Quantity;
        private PictureBox itemPicture;
        private ReaLTaiizor.Controls.MaterialListView itemListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ImageList iconList;
        private ColumnHeader columnHeader3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox itemId;
        private ReaLTaiizor.Controls.MaterialButton itemCancel;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox itemName;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialLabel orderIdLabel;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ReaLTaiizor.Controls.MaterialButton orderNew;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit orderId;
    }
}