using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using CafeteriaService.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ReaLTaiizor.Forms;
using SixLabors.ImageSharp.Formats.Png;
using Image = SixLabors.ImageSharp.Image;
using System.Windows.Forms;

namespace CafeteriaService
{
    public partial class OrderApplication : MaterialForm
    {
        private readonly CafeteriaDbContext _context;
        private Cart? cart = null;

        public OrderApplication(CafeteriaDbContext context)
        {
            InitializeComponent();
            _context = context;
            cart = new Cart();
        }

        private void OrderApplication_Load(object sender, EventArgs e)
        {
            _context.ChangeTracker.StateChanged += OnChange;
            _context.ChangeTracker.Tracked += OnChange;
            UpdateCategoryList();
            UpdateItemList();
            categorySelect.SelectedIndex = 0;
            itemListView.GridLines = true;
            itemListView.BorderStyle = BorderStyle.FixedSingle;
            cartListView.GridLines = true;
            cartListView.BorderStyle = BorderStyle.FixedSingle;
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
        }

        private void UpdateCategoryList()
        {
            categorySelect.Items.Clear();
            categorySelect.Items.Add("(Select Category)");
            categorySelect.Items.AddRange((from c in _context.Categories select c.Name).ToArray());
        }

        public void UpdateItemList(Category? category = null)
        {
            itemListView.Items.Clear();
            IEnumerable<Item> items = _context.Items;
            if (category != null)
            {
                items = category.Items;
            }

            foreach (Item item in items)
            {
                var i = new ListViewItem(new[] { item.Id.ToString(), item.Name, item.Price.ToString() });
                itemListView.Items.Add(i);
            }
        }

        public void UpdateCartItemList()
        {
            cartListView.Items.Clear();
            cart ??= new Cart();
            IEnumerable<CartItem> items = cart.CartItems;
            checkOut.Enabled = items.Any();
            foreach (CartItem item in items)
            {
                var i = new ListViewItem(new[]
                    { item.Item.Id.ToString(), item.Item.Name, item.Item.Price.ToString(), item.Amount.ToString() });
                cartListView.Items.Add(i);
            }
        }

        private void categorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItemList(Program.CategoryController.GetCategory(categorySelect.SelectedItem.ToString()));
        }

        private void itemListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem listViewItem = e.Item;
            Item? item = null;
            if (listViewItem.SubItems[0].Text.Length > 0)
                item = Program.ItemController.GetItem(Convert.ToInt32(listViewItem.SubItems[0].Text));
            if (item != null)
            {
                if (item.InStock <= 0)
                {
                    MessageBox.Show("Xin lỗi quý khách, sản phẩm này hiện đang tạm hết!", "Hết sản phẩm",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                itemName.Text = item.Name;
                itemId.Text = item.Id.ToString();
                itemPrice.Text = Convert.ToString(item.Price);
                itemQuantity.Value = 1;
                itemQuantity.Maximum = item.InStock;
                if (item.ImagePath != null)
                {
                    using (Image image = Image.Load(item.ImagePath))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            image.Save(memoryStream, PngFormat.Instance);
                            itemPicture.Image = System.Drawing.Image.FromStream(memoryStream);
                        }
                    }
                }
            }

            itemListView.SelectedIndices.Clear();
            ChangeItemEdit(item != null);
        }

        private void cartListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem listViewItem = e.Item;
            Item? item = null;
            if (listViewItem.SubItems[0].Text.Length > 0)
                item = Program.ItemController.GetItem(Convert.ToInt32(listViewItem.SubItems[0].Text));
            if (item != null)
            {
                if (item.InStock <= 0)
                {
                    MessageBox.Show("Xin lỗi quý khách, sản phẩm này hiện đang tạm hết!", "Hết sản phẩm",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                itemName.Text = item.Name;
                itemId.Text = item.Id.ToString();
                itemPrice.Text = Convert.ToString(item.Price);
                itemQuantity.Value = Convert.ToInt32(listViewItem.SubItems[3].Text);
                itemQuantity.Maximum = item.InStock;
                if (item.ImagePath != null)
                {
                    using (Image image = Image.Load(item.ImagePath))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            image.Save(memoryStream, PngFormat.Instance);
                            itemPicture.Image = System.Drawing.Image.FromStream(memoryStream);
                        }
                    }
                }
            }

            cartListView.SelectedIndices.Clear();
            ChangeItemEdit(item != null, true);
        }

        private void itemSave_Click(object sender, EventArgs e)
        {
            Item? item = null;
            if (itemId.Text.Length > 0) item = Program.ItemController.GetItem(Convert.ToInt32(itemId.Text));
            if (item != null)
            {
                cart ??= new Cart();
                cart.SetCart(item, Convert.ToInt32(itemQuantity.Value));
                UpdateCartItemList();
                ChangeItemEdit(false);
            }
        }

        private void itemCancel_Click(object sender, EventArgs e)
        {
            ChangeItemEdit(false);
        }

        private void ChangeItemEdit(bool mode, bool isInCart = false)
        {
            itemRemove.Enabled = mode && isInCart;
            if (!mode)
            {
                itemName.Text = "";
                itemPrice.Text = "";
                itemId.Text = "";
                itemPicture.Image = null;
            }

            itemQuantity.Enabled = mode;
            itemSave.Enabled = mode;
            itemCancel.Enabled = mode;
        }

        private void itemRemove_Click(object sender, EventArgs e)
        {
            Item? item = null;
            if (itemId.Text.Length > 0) item = Program.ItemController.GetItem(Convert.ToInt32(itemId.Text));
            if (item != null)
            {
                cart ??= new Cart();
                cart.RemoveFromCart(item);
                UpdateCartItemList();
                ChangeItemEdit(false);
            }
        }

        private void itemQuantity_ValueChanged(object sender, EventArgs e)
        {
            Item? item = null;
            if (itemId.Text.Length > 0) item = Program.ItemController.GetItem(Convert.ToInt32(itemId.Text));
            if (item != null)
            {
                itemPrice.Text = (item.Price * itemQuantity.Value).ToString();
            }
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            ChargeOrder();
        }

        private bool ChargeOrder()
        {
            DialogResult result = MessageBox.Show($"Bạn có muốn thanh toán hóa đơn với số tiền: {cart.TotalPrice}?",
                "Thanh toán hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Order order = Program.OrderController.CreateOrder(cart.TotalPrice);
                foreach (CartItem cartItem in cart.CartItems)
                {
                    cartItem.Item.InStock -= cartItem.Amount;
                    order.OrderLines.Add(Program.OrderDetailController.CreateOrderDetail(order, cartItem.Item, cartItem.Amount));
                }

                _context.SaveChanges();

                orderIdLabel.Text = $"#{order.Id}";
                orderIdLabel.Left = (this.Width - orderIdLabel.Width) / 2;
                orderId.Text = order.Id.ToString();
                cart.CartItems.Clear();
                UpdateCartItemList();
                OrderTabControl.SelectedTab = CheckOutTab;
                return true;
            }

            return false;
        }

        private void OrderTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderTabControl.SelectedTab.Equals(CheckOutTab))
            {
                if(orderId.Text.Length == 0)
                {
                    OrderTabControl.SelectedTab = PlaceOrderTab;
                    PlaceOrderTab.Show();
                }
            }
            else
            {
                orderId.Text = "";
            }
        }

        private void orderNew_Click(object sender, EventArgs e)
        {
            orderId.Text = "";
            OrderTabControl.SelectedTab = PlaceOrderTab;
        }
    }
}