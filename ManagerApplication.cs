using System.Text;
using CafeteriaService.Models;
using HeyRed.Mime;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace CafeteriaService
{
    public partial class ManagerApplication : MaterialForm
    {
        private readonly CafeteriaDbContext _context;

        public ManagerApplication(CafeteriaDbContext context)
        {
            InitializeComponent();
            _context = context;
            MaterialSkinManager.Instance.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.DeepOrange800,
                MaterialPrimary.DeepOrange900,
                MaterialPrimary.DeepOrange500,
                MaterialAccent.LightBlue200,
                MaterialTextShade.WHITE);
        }

        private void OnChange(object sender, EntityEntryEventArgs e)
        {
            if (e.Entry.Entity is Item item)
            {
                UpdateItemList();
            }

            if (e.Entry.Entity is Category category)
            {
                UpdateCategoryList();
            }

            if (e.Entry.Entity is Order order || e.Entry.Entity is OrderDetail orderDetail)
            {
                UpdateOrderHistoryList();
            }
        }

        private void ManagerApplication_Load(object sender, EventArgs e)
        {
            _context.ChangeTracker.StateChanged += OnChange;
            _context.ChangeTracker.Tracked += OnChange;
            UpdateItemList();
            UpdateItemList();
            UpdateCategoryList();
            UpdateCategoryList();
            UpdateOrderHistoryList();
            UpdateOrderHistoryList();
            categorySelect.SelectedIndex = 0;
            categoriesListView.GridLines = true;
            categoriesListView.BorderStyle = BorderStyle.FixedSingle;
            itemListView.GridLines = true;
            itemListView.BorderStyle = BorderStyle.FixedSingle;
            orderHistoryListView.GridLines = true;
            orderHistoryListView.BorderStyle = BorderStyle.FixedSingle;
            UpdateCategoryListViewSize();
            UpdateItemListViewSize();
        }

        private void UpdateCategoryListViewSize()
        {
            categoriesListView.Width = this.Width - 150;
            categoriesListView.Height = this.Height - 100 - categoriesListView.Location.Y;
            int unit = categoriesListView.Width / 10;
            categoriesListView.Columns[0].Width = unit;
            categoriesListView.Columns[1].Width = unit * 2;
            categoriesListView.Columns[2].Width = unit * 7;
        }

        private void UpdateItemListViewSize()
        {
            itemListView.Width = this.Width - 150;
            itemListView.Height = this.Height - 100 - itemListView.Location.Y;
            int unit = itemListView.Width / 20;
            itemListView.Columns[0].Width = unit;
            itemListView.Columns[1].Width = unit * 3;
            itemListView.Columns[2].Width = unit * 3;
            itemListView.Columns[3].Width = unit * 3;
            itemListView.Columns[4].Width = unit * 3;
            itemListView.Columns[5].Width = unit * 7;
        }

        private void UpdateCategoryList()
        {
            categoriesListView.Items.Clear();
            categorySelect.Items.Clear();
            categorySelect.Items.Add("(Select Category)");
            IEnumerable<Category> categories = _context.Categories;
            foreach (Category category in categories)
            {
                categorySelect.Items.Add(category.Name);
                ListViewItem item = new ListViewItem(new string[]
                    { category.Id.ToString(), category.Name, category.Description ?? "" });
                categoriesListView.Items.Add(item);
            }
        }

        private void categorySave_Click(object sender, EventArgs e)
        {
            if (!categoryValidateInput())
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin của danh mục!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.CategoryController.SaveCategory(categoryNameInput.Text, categoryDescriptionInput.Text,
                (categoryIdInput.Text.Length > 0) ? Convert.ToInt32(categoryIdInput.Text) : null);
        }

        private bool categoryValidateInput()
        {
            if (categoryNameInput.Text.Length == 0) return false;
            return true;
        }

        private void ManagerApplication_Resize(object sender, EventArgs e)
        {
            UpdateCategoryListViewSize();
            UpdateItemListViewSize();
        }

        private void CategoryInputReset(object sender, EventArgs e)
        {
            CategoryInputReset();
        }

        private void CategoryInputReset()
        {
            categoryIdInput.Text = "";
            categoryNameInput.Text = "";
            categoryDescriptionInput.Text = "";
        }

        private void categoriesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                CategoryInputReset();
                return;
            }

            ListViewItem item = e.Item;
            categoryIdInput.Text = item.SubItems[0].Text;
            categoryNameInput.Text = item.SubItems[1].Text;
            categoryDescriptionInput.Text = item.SubItems[2].Text;
        }

        private void categoryIdInput_TextChanged(object sender, EventArgs e)
        {
            bool state = categoryIdInput.Text.Length > 0;
            categoryRemove.Enabled = state;
        }

        private void categoryRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(categoryIdInput.Text);
            Category? category = Program.CategoryController.GetCategory(id);
            if (category != null)
            {
                Program.CategoryController.RemoveCategory(category);
                CategoryInputReset();
            }
        }

        private void categorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemIdInput.Text.Length > 0) ItemInputReset();
            if (categorySelect.SelectedIndex == 0)
            {
                UpdateItemList();
                return;
            }

            Category? category =
                Program.CategoryController.GetCategory(categorySelect.Items[categorySelect.SelectedIndex].ToString());
            UpdateItemList(category);
        }

        private void UpdateItemList(Category? category = null)
        {
            IEnumerable<Item> items = _context.Items;
            if (category != null)
            {
                items = category.Items.ToList();
            }

            if (itemSearch.Text.Length > 0)
            {
                items = from i in items where i.Name.ToLower().Contains(itemSearch.Text) select i;
            }

            itemListView.Items.Clear();
            foreach (var it in items)
            {
                if (it is Item item)
                {
                    string[] data = new string[6];
                    data[0] = item.Id.ToString();
                    data[1] = item.Name;
                    data[2] = Program.CategoryController.GetCategory(item.CategoryId).Name;
                    data[3] = item.Price.ToString();
                    data[4] = item.InStock.ToString();
                    data[5] = item.ImagePath ?? "";
                    itemListView.Items.Add(new ListViewItem(data));
                }
            }
        }

        private void itemSave_Click(object sender, EventArgs e)
        {
            if (!ItemValidateInput())
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin của mục!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Category category = Program.CategoryController.GetCategory(categorySelect.SelectedItem.ToString());
            string imagePath = openImage.FileName;

            Program.ItemController.SaveItem(itemNameInput.Text, category, Convert.ToDecimal(itemPriceInput.Text), "", Convert.ToInt32(itemQuantityInput.Text), imagePath);
        }

        private bool ItemValidateInput()
        {
            if (itemNameInput.Text.Length == 0) return false;
            if (itemImages.Text.Length == 0) return false;
            if (categorySelect.SelectedIndex < 1) return false;
            return true;
        }

        private void itemListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem item = e.Item;
                categorySelect.SelectedIndex = categorySelect.Items.IndexOf(item.SubItems[2].Text);
                itemIdInput.Text = item.SubItems[0].Text;
                itemNameInput.Text = item.SubItems[1].Text;
                itemPriceInput.Text = item.SubItems[3].Text;
                itemQuantityInput.Text = item.SubItems[4].Text;
                itemImages.Text = item.SubItems[5].Text;
            }
            else ItemInputReset();
        }

        private void ItemInputReset(object sender, EventArgs e)
        {
            ItemInputReset();
        }

        private void ItemInputReset()
        {
            itemNameInput.Text = "";
            itemIdInput.Text = "";
            itemImages.Text = "";
            itemPriceInput.Text = "";
            itemQuantityInput.Text = "";
            categorySelect.SelectedIndex = 0;
        }

        private void itemIdInput_Click(object sender, EventArgs e)
        {
            itemRemove.Enabled = itemIdInput.Text.Length > 0;
        }

        private void itemSelectImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                List<string> imageList = new List<string>();
                foreach (string fileName in openImage.FileNames)
                {
                    imageList.Add(fileName);
                }

                itemImages.Text = string.Join(',', imageList);
            }
        }

        private void itemSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateItemList(Program.CategoryController.GetCategory(categorySelect.SelectedItem.ToString()));
        }

        public void UpdateOrderHistoryList()
        {
            orderHistoryListView.Items.Clear();
            foreach (Order order in _context.Orders)
            {
                StringBuilder info = new();
                foreach (OrderDetail orderDetail in (from od in _context.OrderDetails where od.Order.Equals(order) select od))
                {
                    info.AppendLine($"{orderDetail.Item.Name} x{orderDetail.Amount}");
                }
                ListViewItem item = new(new[]
                {
                    order.Id.ToString(),
                    order.UpdatedAt.ToString("hh:mm:ss dd/MM/yyyy"),
                    order.TotalPrice.ToString(),
                    order.TotalPaid.ToString(),
                    (order.TotalPaid - order.TotalPrice).ToString(),
                    info.ToString()
                });
                orderHistoryListView.Items.Add(item);
            }
        }

        private void openOrderForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.OrderForm.ShowDialog();
            this.Show();
        }
    }
}