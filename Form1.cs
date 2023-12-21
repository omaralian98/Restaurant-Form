using System.Diagnostics;

namespace Restaurant_Form;

public partial class Form1 : Form
{
    private const string CONNECTION_STRING = "DATA SOURCE=localhost:1521/XEPDB1;PERSIST SECURITY INFO=True;USER ID=admin;Password=admin";
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        AddToTables();
        if (!Seeded())
        {
            Add.Visible = false;
            Edit.Visible = false;
            Delete.Visible = false;
            More.Visible = false;
        }
    }

    private void SeedData_Click(object sender, EventArgs e)
    {
        if (!(Tables.Items.Count > 1))
        {
            MessageBox.Show("There are no Tables to be seeded", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (Seeded()) MessageBox.Show("The tables are already seeded", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
        try
        {
            Restaurant_Management.Program.SeedData();
            MessageBox.Show("The tables have been seeded with initial data", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Add.Visible = true;
            Edit.Visible = true;
            Delete.Visible = true;
            More.Visible = true;
        }
        catch (Exception ex)
        {

        }
        Tables_SelectedIndexChanged(new object(), new EventArgs());
    }

    private void CreateTable_Click(object sender, EventArgs e)
    {
        Thread.Sleep(2000);
        Thread thread = new(new ThreadStart(() =>
        {
            Database.CreateTables(Restaurant_Management.Program.GetConnection());
            Tables.Items.Clear();
            AddToTables();
            MessageBox.Show("The tables have been Created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }));
        thread.Start();
    }

    private static bool Seeded()
    {
        var test = Restaurant_Management.Program.GetIEmployee();
        try
        {
            return test.GetAll().Any();
        }
        catch
        {
            return false;
        }
    }

    private void AddToTables()
    {
        using var con = Restaurant_Management.Program.GetConnection();
        con.Open();
        using var cmd = new OracleCommand("SELECT table_name FROM user_tables", con);
        var reader = cmd.ExecuteReader();
        Tables.Items.Add("No Table is Selected");
        Tables.SelectedIndex = 0;
        if (reader.HasRows)
        {
            while (reader.Read()) Tables.Items.Add(reader["table_name"].ToString() ?? "");
        }
    }

    private void Tables_SelectedIndexChanged(object sender, EventArgs e)
    {
        string name = Tables.Items[Tables.SelectedIndex]?.ToString() ?? "";
        switch (name)
        {
            case "Category":
                ViewCategory();
                Records.Text = $"{name} Records";
                break;
            case "Employee":
                ViewEmployee();
                Records.Text = $"{name} Records";
                break;
            case "Employee_WorkDay":
                ViewEmployee_WorkDay();
                Records.Text = $"{name} Records";
                break;
            case "Ingredient":
                ViewIngredient();
                Records.Text = $"{name} Records";
                break;
            case "Item":
                ViewItem();
                Records.Text = $"{name} Records";
                break;
            case "Item_Ingredient":
                ViewItemIngredient();
                Records.Text = $"{name} Records";
                break;
            case "Order":
                ViewOrder();
                Records.Text = $"{name} Records";
                break;
            case "Order_Item":
                ViewOrder_Item();
                Records.Text = $"{name} Records";
                break;
            case "Receipt":
                ViewReceipt();
                Records.Text = $"{name} Records";
                break;
            case "Section":
                ViewSection();
                Records.Text = $"{name} Records";
                break;
            case "Supplier":
                ViewSupplier();
                Records.Text = $"{name} Records";
                break;
            case "Supplier_Ingredient":
                ViewSupplier_Ingredient();
                Records.Text = $"{name} Records";
                break;
            case "Table":
                ViewTable();
                Records.Text = $"{name} Records";
                break;
            default:
                DataViewer.DataSource = null;
                Records.Text = $"No Table Records";
                break;
        }
    }

    private void Add_Click(object sender, EventArgs e)
    {
        if (Tables.SelectedIndex == 0) MessageBox.Show("Select a table first", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            string name = Tables.Items[Tables.SelectedIndex]?.ToString() ?? "";
            var res = Interaction.InputBox($"Enter the information of {name} Table\nSeparate the data with a comma (,)\nDon't include the Id!!!", $"Add new {name}", "Example,*****,Test");
            try
            {
                Map(res, "Add");
            }
            catch
            {
                MessageBox.Show($"Couldn't add the new {name}", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tables_SelectedIndexChanged(new object(), new EventArgs());
        }
    }

    private void Delete_Click(object sender, EventArgs e)
    {
        if (Tables.SelectedIndex == 0) MessageBox.Show("Select a table first", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            var res = Interaction.InputBox($"Enter the Id", $"Delete", "43");
            try
            {
                Map(res, "Delete");
            }
            catch
            {
                MessageBox.Show($"Couldn't remove the required Entity", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tables_SelectedIndexChanged(new object(), new EventArgs());
        }

    }

    private void Edit_Click(object sender, EventArgs e)
    {
        if (Tables.SelectedIndex == 0) MessageBox.Show("Select a table first", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            string name = Tables.Items[Tables.SelectedIndex]?.ToString() ?? "";
            var res = Interaction.InputBox($"Enter the information of {name} Table\nSeparate the data with a comma (,)\nDon't forget to include the Id!!!", $"Edit new {name}", "1,Example,*****,Test");
            try
            {
                Map(res, "Edit");
            }
            catch
            {
                MessageBox.Show($"Couldn't Edit the required Entity", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tables_SelectedIndexChanged(new object(), new EventArgs());
        }
    }

    private void ViewEmployee()
    {
        var category = Restaurant_Management.Program.GetIEmployee();
        List<Employee> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Employee>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewCategory()
    {
        var category = Restaurant_Management.Program.GetICategory();
        List<Category> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Category>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewIngredient()
    {
        var category = Restaurant_Management.Program.GetIIngredient();
        List<Ingredient> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Ingredient>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewItem()
    {
        var category = Restaurant_Management.Program.GetIItem();
        List<Item> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Item>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewItemIngredient()
    {
        var category = Restaurant_Management.Program.GetIItem_Ingredient();
        List<Item_Ingredient> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Item_Ingredient>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewOrder()
    {
        var category = Restaurant_Management.Program.GetIOrder();
        List<Order> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Order>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewOrder_Item()
    {
        var category = Restaurant_Management.Program.GetIOrder_Item();
        List<Order_Item> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Order_Item>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewReceipt()
    {
        var category = Restaurant_Management.Program.GetIReceipt();
        List<Receipt> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Receipt>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewSection()
    {
        var category = Restaurant_Management.Program.GetISection();
        List<Section> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Section>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewEmployee_WorkDay()
    {
        var category = Restaurant_Management.Program.GetIEmployee_WorkDay();
        List<Employee_WorkDay> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Employee_WorkDay>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewSupplier()
    {
        var category = Restaurant_Management.Program.GetISupplier();
        List<Supplier> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Supplier>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewSupplier_Ingredient()
    {
        var category = Restaurant_Management.Program.GetISupplier_Ingredient();
        List<Supplier_Ingredient> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Supplier_Ingredient>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }

    private void ViewTable()
    {
        var category = Restaurant_Management.Program.GetITable();
        List<Table> result = category.GetAll().ToList();
        result = [.. result.OrderBy(x => x.Id)];
        var bindingList = new BindingList<Table>(result);
        var source = new BindingSource(bindingList, null);
        DataViewer.DataSource = source;
    }


    private void Map(string res, string mode)
    {
        switch (Tables.Items[Tables.SelectedIndex])
        {
            case "Category":
                MapCategory(res, mode);
                break;
            case "Employee":
                MapEmployee(res, mode);
                break;
            case "Employee_WorkDay":
                MapEmployee_WorkDay(res, mode);
                break;
            case "Ingredient":
                MapIngredient(res, mode);
                break;
            case "Item":
                MapItem(res, mode);
                break;
            case "Item_Ingredient":
                MapItem_Ingredient(res, mode);
                break;
            case "Order":
                MapOrder(res, mode);
                break;
            case "Order_Item":
                MapOrder_Item(res, mode);
                break;
            case "Receipt":
                MapReceipt(res, mode);
                break;
            case "Section":
                MapSection(res, mode);
                break;
            case "Supplier":
                MapSupplier(res, mode);
                break;
            case "Supplier_Ingredient":
                MapSupplier_Ingredient(res, mode);
                break;
            case "Table":
                MapTable(res, mode);
                break;
        }
    }
    private static void MapEntity<T, F>(string res, string mode, F repository, T? entity) where F : ICrud<T>
    {
        if (entity is null)
        {
            if (!repository.Remove(int.Parse(res)))
            {
                throw new Exception();
            }
            return;
        }
        bool result = mode == "Add" ? repository.Add(entity) : repository.Update(entity);
        if (!result) throw new Exception();
    }

    private static void MapEmployee(string res, string mode)
    {
        string[] list = res.Split(',');
        Employee? entity = null;
        if (mode == "Add")
        {
            entity = new Employee
            {
                ManagerId = int.Parse(list[0]),
                FirstName = list[1],
                LastName = list[2],
                PhoneNumber = list[3],
                Address = list[4],
                SalaryPerHour = Convert.ToDecimal(list[5]),
                SectionId = int.Parse(list[6])
            };
        }
        else if (mode == "Edit")
        {
            entity = new Employee
            {
                Id = int.Parse(list[0]),
                ManagerId = int.Parse(list[1]),
                FirstName = list[2],
                LastName = list[3],
                PhoneNumber = list[4],
                Address = list[5],
                SalaryPerHour = Convert.ToDecimal(list[6]),
                SectionId = int.Parse(list[7])
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetIEmployee(), entity);
    }

    private static void MapEmployee_WorkDay(string res, string mode)
    {
        string[] list = res.Split(',');
        Employee_WorkDay? entity = null;
        if (mode == "Add")
        {
            entity = new Employee_WorkDay
            {
                Date = Convert.ToDateTime(list[0]),
                Starts = Convert.ToDateTime(list[1]),
                Ends = Convert.ToDateTime(list[2]),
                WorkingHours = int.Parse(list[3]),
                Note = list[4],
                Employee_Id = int.Parse(list[5])
            };
        }
        else if (mode == "Edit")
        {
            entity = new Employee_WorkDay
            {
                Id = int.Parse(list[0]),
                Date = Convert.ToDateTime(list[1]),
                Starts = Convert.ToDateTime(list[2]),
                Ends = Convert.ToDateTime(list[3]),
                WorkingHours = int.Parse(list[4]),
                Note = list[5],
                Employee_Id = int.Parse(list[6])
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetIEmployee_WorkDay(), entity);
    }

    private static void MapCategory(string res, string mode)
    {
        string[] list = res.Split(',');
        Category? entity = null;
        if (mode == "Add")
        {
            entity = new Category
            {
                Name = list[0]
            };
        }
        else if (mode == "Edit")
        {
            entity = new Category
            {
                Id = int.Parse(list[0]),
                Name = list[1]
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetICategory(), entity);
    }

    private static void MapSupplier(string res, string mode)
    {
        string[] list = res.Split(',');
        Supplier? entity = null;
        if (mode == "Add")
        {
            entity = new Supplier
            {
                Full_Name = list[0],
                Phone_Number = list[1]
            };
        }
        else if (mode == "Edit")
        {
            entity = new Supplier
            {
                Id = int.Parse(list[0]),
                Full_Name = list[1],
                Phone_Number = list[2]
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetISupplier(), entity);
    }

    private static void MapIngredient(string res, string mode)
    {
        string[] list = res.Split(',');
        Ingredient? entity = null;
        if (mode == "Add")
        {
            entity = new Ingredient
            {
                Name = list[0],
                Quantity = Convert.ToDecimal(list[1])
            };
        }
        else if (mode == "Edit")
        {
            entity = new Ingredient
            {
                Id = int.Parse(list[0]),
                Name = list[1],
                Quantity = Convert.ToDecimal(list[2])
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetIIngredient(), entity);
    }

    private static void MapItem_Ingredient(string res, string mode)
    {
        string[] list = res.Split(',');
        Item_Ingredient? entity = null;
        if (mode == "Add")
        {
            entity = new Item_Ingredient
            {
                Item_Id = int.Parse(list[0]),
                Ingredient_Id = int.Parse(list[1])
            };
        }
        else if (mode == "Edit")
        {
            entity = new Item_Ingredient
            {
                Id = int.Parse(list[0]),
                Item_Id = int.Parse(list[1]),
                Ingredient_Id = int.Parse(list[2])
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetIItem_Ingredient(), entity);
    }

    private static void MapSupplier_Ingredient(string res, string mode)
    {
        string[] list = res.Split(',');
        Supplier_Ingredient? entity = null;
        if (mode == "Add")
        {
            entity = new Supplier_Ingredient
            {
                Ingredient_Id = int.Parse(list[0]),
                Supplier_Id = int.Parse(list[1]),
                Date = Convert.ToDateTime(list[2]),
                Quantity = int.Parse(list[3]),
                Price = Convert.ToDecimal(list[4])
            };
        }
        else if (mode == "Edit")
        {
            entity = new Supplier_Ingredient
            {
                Id = int.Parse(list[0]),
                Ingredient_Id = int.Parse(list[1]),
                Supplier_Id = int.Parse(list[2]),
                Date = Convert.ToDateTime(list[3]),
                Quantity = int.Parse(list[4]),
                Price = Convert.ToDecimal(list[5])
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetISupplier_Ingredient(), entity);
    }

    private static void MapSection(string res, string mode)
    {
        string[] list = res.Split(',');
        Section? entity = null;
        if (mode == "Add")
        {
            entity = new Section
            {
                Name = list[0]
            };
        }
        else if (mode == "Edit")
        {
            entity = new Section
            {
                Id = int.Parse(list[0]),
                Name = list[1]
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetISection(), entity);
    }

    private static void MapItem(string res, string mode)
    {
        string[] list = res.Split(',');
        Item? entity = null;
        if (mode == "Add")
        {
            entity = new Item
            {
                Title = list[0],
                Description = list[1],
                Price = Convert.ToDecimal(list[2]),
                Added = Convert.ToDateTime(list[3]),
                Rating = Convert.ToDecimal(list[4]),
                Category_Id = int.Parse(list[5])
            };
        }
        else if (mode == "Edit")
        {
            entity = new Item
            {
                Id = int.Parse(list[0]),
                Title = list[1],
                Description = list[2],
                Price = Convert.ToDecimal(list[3]),
                Added = Convert.ToDateTime(list[4]),
                Rating = Convert.ToDecimal(list[5]),
                Category_Id = int.Parse(list[6])
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetIItem(), entity);
    }

    private static void MapOrder(string res, string mode)
    {
        string[] list = res.Split(',');
        Order? entity = null;
        if (mode == "Add")
        {
            entity = new Order
            {
                Date = Convert.ToDateTime(list[0]),
                Price = Convert.ToDecimal(list[1]),
                Employee_Id = int.Parse(list[2]),
                Table_Id = int.Parse(list[3]),
                Receipt_Id = string.IsNullOrEmpty(list[4]) ? (int?)null : int.Parse(list[4])
            };
        }
        else if (mode == "Edit")
        {
            entity = new Order
            {
                Id = int.Parse(list[0]),
                Date = Convert.ToDateTime(list[1]),
                Price = Convert.ToDecimal(list[2]),
                Employee_Id = int.Parse(list[3]),
                Table_Id = int.Parse(list[4]),
                Receipt_Id = string.IsNullOrEmpty(list[5]) ? (int?)null : int.Parse(list[5])
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetIOrder(), entity);
    }

    private static void MapOrder_Item(string res, string mode)
    {
        string[] list = res.Split(',');
        Order_Item? entity = null;
        if (mode == "Add")
        {
            entity = new Order_Item
            {
                Quantity = int.Parse(list[0]),
                UnitPrice = Convert.ToDecimal(list[1]),
                Order_Id = int.Parse(list[2]),
                Item_Id = int.Parse(list[3])
            };
        }
        else if (mode == "Edit")
        {
            entity = new Order_Item
            {
                Id = int.Parse(list[0]),
                Quantity = int.Parse(list[1]),
                UnitPrice = Convert.ToDecimal(list[2]),
                Order_Id = int.Parse(list[3]),
                Item_Id = int.Parse(list[4])
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetIOrder_Item(), entity);
    }

    private static void MapTable(string res, string mode)
    {
        string[] list = res.Split(',');
        Table? entity = null;
        if (mode == "Add")
        {
            entity = new Table
            {
                Number = int.Parse(list[0]),
                Status = list[1]
            };
        }
        else if (mode == "Edit")
        {
            entity = new Table
            {
                Id = int.Parse(list[0]),
                Number = int.Parse(list[1]),
                Status = list[2]
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetITable(), entity);
    }

    private static void MapReceipt(string res, string mode)
    {
        string[] list = res.Split(',');
        Receipt? entity = null;
        if (mode == "Add")
        {
            entity = new Receipt
            {
                Date = Convert.ToDateTime(list[0]),
                Sub_Total = Convert.ToDecimal(list[1]),
                Taxes = Convert.ToDecimal(list[2]),
                Discount = Convert.ToDecimal(list[3]),
                Total = Convert.ToDecimal(list[4]),
                Table_Id = int.Parse(list[5])
            };
        }
        else if (mode == "Edit")
        {
            entity = new Receipt
            {
                Id = int.Parse(list[0]),
                Date = Convert.ToDateTime(list[1]),
                Sub_Total = Convert.ToDecimal(list[2]),
                Taxes = Convert.ToDecimal(list[3]),
                Discount = Convert.ToDecimal(list[4]),
                Total = Convert.ToDecimal(list[5]),
                Table_Id = int.Parse(list[6])
            };
        }
        MapEntity(res, mode, Restaurant_Management.Program.GetIReceipt(), entity);
    }

    private static BindingList<Supplier> GetSupplierWithHighestPayment(int year = 2023)
    {

        var sup = Restaurant_Management.Program.GetISupplier();
        var supplier = sup.GetSupplierWithHighestPaymentForYear(year);
        return supplier is null ? new BindingList<Supplier>() :
            new BindingList<Supplier>([supplier]);
    }

    private static BindingList<Order> GetAllByEmployeeAndYear(int Id, int year = 2022)
    {
        var ord = Restaurant_Management.Program.GetIOrder();
        return new BindingList<Order>(ord.GetAllByEmployeeAndYear(Id, year).ToList());
    }

    private void More_Click(object sender, EventArgs e)
    {
        More.Visible = false;
        HighestPaymentSupplier.Visible = true;
        EmployeeOrders.Visible = true;
        Less.Visible = true;
    }

    private void Less_Click(object sender, EventArgs e)
    {
        Less.Visible = false;
        HighestPaymentSupplier.Visible = false;
        EmployeeOrders.Visible = false;
        More.Visible = true;
    }

    private void HighestPaymentSupplier_Click(object sender, EventArgs e)
    {
        var res = Interaction.InputBox($"Enter the year it's optional", $"Get The supplier with the highest payment", "2023");
        try
        {
            int year = int.Parse(res);
            Tables.SelectedIndex = Tables.Items.IndexOf("Supplier");
            DataViewer.DataSource = GetSupplierWithHighestPayment(year);
        }
        catch
        {
            DataViewer.DataSource = GetSupplierWithHighestPayment();
        }
    }

    private void EmployeeOrders_Click(object sender, EventArgs e)
    {
        try
        {
            int Id = 0;
            int year = 2022;
            var res = Interaction.InputBox($"Enter the Id of the Employee and the year separated by a comma(,) but it's optional", $"Get Orders of Employee", "13,2022");
            try
            {
                if (res.Contains(','))
                {
                    var top = res.Split(',');
                    Id = int.Parse(top[0]);
                    year = int.Parse(top[1]);
                }
                else
                {
                    Id = int.Parse(res);
                }
            }
            catch
            {
                MessageBox.Show($"Couldn't Find the required Employee", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tables.SelectedIndex = Tables.Items.IndexOf("Order");
            DataViewer.DataSource = GetAllByEmployeeAndYear(Id, year);
        }
        catch { }
    }

    private void Info_Click(object sender, EventArgs e)
    {
        Process.Start(new ProcessStartInfo { FileName = @"https://github.com/omaralian98/Restaurant-Form", UseShellExecute = true });
    }
}