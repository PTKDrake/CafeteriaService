using CafeteriaService.Controllers;
using CafeteriaService.Models;

namespace CafeteriaService
{
    internal static class Program
    {
        public static ManagerApplication ManagerForm;
        public static OrderApplication OrderForm;
        public static CategoryController CategoryController;
        public static ItemController ItemController;
        public static RoleController RoleController;
        public static UserController UserController;
        public static CartController CartController;
        public static OrderDetailController OrderDetailController;
        public static OrderController OrderController;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            CafeteriaDbContext context = new CafeteriaDbContextFactory().CreateDbContext(new string[]{});
            ManagerForm = new ManagerApplication(context);
            OrderForm = new OrderApplication(context);
            CategoryController = new CategoryController(context);
            ItemController = new ItemController(context);
            RoleController = new RoleController(context);
            UserController = new UserController(context);
            CartController = new CartController(context);
            OrderDetailController = new OrderDetailController(context);
            OrderController = new OrderController(context);
            Seed(context);
            Application.Run(new LoginForm());
        }

        static void Seed(CafeteriaDbContext context)
        {
            try
            {
                if (context.Roles.FirstOrDefault() == null)
                {
                    Role admin = RoleController.SaveRole("admin");
                    Role staff = RoleController.SaveRole("staff");
                    User ptkdrake = UserController.SaveUser("ptkdrake", "123@123", admin);
                    User rach = UserController.SaveUser("rach", "123456", staff);
                    Category coffee = CategoryController.SaveCategory("coffee");
                    Category tea = CategoryController.SaveCategory("tea");
                    Category smoothie = CategoryController.SaveCategory("smoothie");
                    Item it1 = ItemController.SaveItem("Latte", coffee, 25000, "", 20, @"D:\Learn\CafeteriaService\resources\item_images\Latte.jpg");
                    Item it2 = ItemController.SaveItem("Cappuccino", coffee, 25000, "", 20, @"D:\Learn\CafeteriaService\resources\item_images\Cappuccino.jpg");
                    Item it3 = ItemController.SaveItem("Espresso", coffee, 18000, "", 20, @"D:\Learn\CafeteriaService\resources\item_images\Espresso.png");
                    Item it4 = ItemController.SaveItem("Lychee", tea, 25000, "", 20, @"D:\Learn\CafeteriaService\resources\item_images\Lychee.jpg");
                    Item it5 = ItemController.SaveItem("Grapefruit", smoothie, 28000, "", 20, @"D:\Learn\CafeteriaService\resources\item_images\Grapefruit.jpg");
                    Item it6 = ItemController.SaveItem("Avocado", smoothie, 28000, "", 20, @"D:\Learn\CafeteriaService\resources\item_images\Avocado.jpg");
                    Item it7 = ItemController.SaveItem("Green Tea", tea, 28000, "", 20, @"D:\Learn\CafeteriaService\resources\item_images\Green_Tea.webp");
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}