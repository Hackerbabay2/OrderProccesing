using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderProccesing_Yudin_
{
    public partial class Form1 : Form
    {
        private DataBase _dataBase;

        public Form1()
        {
            InitializeComponent();
            _dataBase = new DataBase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            _dataBase.AddOrder(fullNameBox.Text,
                departmentBox.Text,phoneNumberMaskBox.Text,
                (int)normHourNumeric.Value,
                (int)wageRateNumeric.Value,
                responsibleBox.Text,
                (int)priceMaterialsNumeric.Value,
                (int)countMaterialsNumeric.Value,
                avaliabilityComboBox.Text,
                necessaryEquipmentBox.Text,
                conumableMaterialsBox.Text);
            _dataBase.ShowData(listView1);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView lsw = (ListView)sender;

            if (e.Column == ListViewItemComparer.SortColumn)
            {
                if (ListViewItemComparer.Order == SortOrder.Ascending)
                {
                    ListViewItemComparer.Order = SortOrder.Descending;
                }
                else
                {
                    ListViewItemComparer.Order = SortOrder.Ascending;
                }
            }
            else
            {
                ListViewItemComparer.SortColumn = e.Column;
                ListViewItemComparer.Order = SortOrder.Ascending;
            }
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (_dataBase.CountOrders > 0)
            {
                listView1.Items.Clear();
                _dataBase.ShowDataByAttribute(listView1,searchBox.Text);
            }
            else
            {
                MessageBox.Show("Нет заказов");
            }
        }

        private void buttonDataShow_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            _dataBase.ShowData(listView1);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if ((int)idNumeric.Value > 0 && _dataBase.CountOrders >= (int)idNumeric.Value)
            {
                Redactor redactor = new Redactor(_dataBase.GetOrderByIndex((int)idNumeric.Value));
                redactor.Show();
            }
            else
            {
                MessageBox.Show("Указан не существующий id");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            _dataBase.RemoveOrderAt((int)idNumeric.Value);
        }
    }

    class DataBase
    {
        private List<Order> _orders;
        private List<Order> _findOrders;

        public int CountOrders => _orders.Count;

        public DataBase()
        {
            _orders = new List<Order>();
            _findOrders = new List<Order>();
        }
        
        public Order GetOrderByIndex(int index)
        {
            return _orders[index - 1];
        }

        public void RemoveOrderAt(int index)
        {
            foreach (Order order in _orders)
            {
                if (order.Id == index)
                {
                    _orders.Remove(order);
                    return;
                }
            }

            MessageBox.Show("Id не найден");
        }

        public List<ListViewItem> GetItemsByAttribute(string attribute)
        {
            List<ListViewItem> items = new List<ListViewItem>();

            for (int i = 0; i < _orders.Count; i++)
            {
                if (_orders[i].Id.ToString() == attribute)
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].FullName.ToLower().Contains(attribute.ToLower()))
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].Department.ToLower().Contains(attribute.ToLower()))
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].CountMaterials.ToString() == attribute)
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].InStock.ToLower().Contains(attribute.ToLower()))
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].NormHour.ToString() == attribute)
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].PhoneNumber.ToLower().Contains(attribute.ToLower()))
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].PriceMaterials.ToString() == attribute)
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].Responsible.ToLower().Contains(attribute.ToLower()))
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].Materials.ToLower().Contains(attribute.ToLower()))
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].Equipments.ToLower().Contains(attribute.ToLower()))
                    items.Add(GetDataByIndex(i));
                else if (_orders[i].WageRate.ToString() == attribute)
                    items.Add(GetDataByIndex(i));
            }

            return items;
        }

        public void AddOrder(string fullName, string department, string phoneNumber, int normHour, int wageRate, string responsible, int priceMaterials,int countMaterials, string inStock, string equipment, string material)
        {
            _orders.Add(new Order(CountOrders + 1,fullName,department,phoneNumber,normHour,wageRate,responsible,equipment,material,priceMaterials,countMaterials,inStock));
        }

        public ListViewItem GetDataByIndex(int index)
        {
            ListViewItem items = null;

            items = new ListViewItem(new string[]{
                _orders[index].Id.ToString(),
                _orders[index].FullName,
                _orders[index].Department,
                _orders[index].PhoneNumber,
                _orders[index].NormHour.ToString(),
                _orders[index].WageRate.ToString(),
                _orders[index].Responsible,
                _orders[index].Equipments,
                _orders[index].Materials,
                _orders[index].CountMaterials.ToString(),
                _orders[index].PriceMaterials.ToString(),
                _orders[index].InStock
            });

            return items;
        }

        public void ShowDataByAttribute(ListView listView, string attribute)
        {
            List<ListViewItem> listViewItems = GetItemsByAttribute(attribute);

            if (listViewItems.Count != 0)
            {
                foreach (ListViewItem items in listViewItems)
                {
                    listView.Items.Add(items);
                }
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
                ShowData(listView);
            }
        }

        public void ShowData(ListView listView)
        {
            ListViewItem items = null;

            foreach (Order order in _orders)
            {
                items = new ListViewItem(new string[] {
                       order.Id.ToString(),
                       order.FullName,
                       order.Department,
                       order.PhoneNumber,
                       order.NormHour.ToString(),
                       order.WageRate.ToString(),
                       order.Responsible,
                       order.Equipments,
                       order.Materials,
                       order.CountMaterials.ToString(),
                       order.PriceMaterials.ToString(),
                       order.InStock
                });
                listView.Items.Add(items);
            }
        }
    }

    public class Order
    {
        private int _id;
        private string _fullName;
        private string _department;
        private string _phoneNumber;
        private int _normHour;
        private int _wageRate;
        private string _responsible;
        private string _equipments;
        private string _consumableMaterials;
        private int _countMaterials;
        private int _priceMaterials;
        private string _inStock;

        public int Id => _id;
        public string FullName => _fullName;
        public string Department => _department;
        public string PhoneNumber => _phoneNumber;
        public int NormHour => _normHour;
        public int WageRate => _wageRate;
        public string Responsible => _responsible;
        public int PriceMaterials => _priceMaterials;
        public string InStock => _inStock;
        public int CountMaterials => _countMaterials;
        public string Equipments => _equipments;
        public string Materials => _consumableMaterials;

        public Order(int id,string fullName,string department, string phoneNumber, int normHour, int wageRate, string responsible,string equipments, string materials, int priceMaterials,int countMaterials, string inStock)
        {
            _id = id;
            SetData(fullName,department,phoneNumber,normHour,wageRate,responsible,equipments,materials,priceMaterials,countMaterials,inStock);
        }

        public void SetData(string fullName, string department, string phoneNumber, int normHour, int wageRate, string responsible, string equipments, string materials, int priceMaterials, int countMaterials, string inStock)
        {
            _equipments = equipments;
            _consumableMaterials = materials;
            _fullName = fullName;
            _department = department;
            _phoneNumber = phoneNumber;
            _normHour = normHour;
            _wageRate = wageRate;
            _responsible = responsible;
            _priceMaterials = priceMaterials;
            _countMaterials = countMaterials;
            _inStock = inStock;
        }
    }

    class Equipment
    {
        private string _name;

        public string Name => _name;

        public Equipment(string name)
        {
            _name = name;
        }
    }

    class ConsumableMaterial
    {
        private string _name;

        public string Name => _name;

        public ConsumableMaterial(string name)
        {
            _name = name;
        }
    }
}
