using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
    
namespace OrderProccesing_Yudin_
{
    public partial class Form1 : Form
    {
        private DataBase _dataBase;
        Orders _orders;
        private string _xmlPath = "xmlData.xml";
        private string _foundDataPath = "foundData.txt";

        public Form1()
        {
            InitializeComponent();
            _dataBase = new DataBase();
            _orders = new Orders();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_foundDataPath))
            {
                File.Create(_foundDataPath).Close();
            }
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
                _dataBase.ShowDataByAttribute(listView1,searchBox.Text, _foundDataPath);
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

        private void SerializeXML(Orders orders)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Orders));

            using (FileStream fileStream = new FileStream(_xmlPath, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream,orders);
            }
        }

        private Orders DeseriacliezeXml()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Orders));

            using (FileStream fileStream = new FileStream(_xmlPath, FileMode.OpenOrCreate))
            {
                return (Orders)xmlSerializer.Deserialize(fileStream);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists(_xmlPath))
                File.Delete(_xmlPath);
            _orders.OrdersList = _dataBase.Orders;
            SerializeXML(_orders);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists(_xmlPath))
            {
                DialogResult result = MessageBox.Show(
                    "При загрузке данных, не сохраненные данные удаляются!\nПродолжить?",
                    "ВНИМАНИЕ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );

                if (result == DialogResult.Yes)
                {
                    listView1.Items.Clear();
                    Orders orders = DeseriacliezeXml();
                    _dataBase.SetOrders(orders.OrdersList);
                    _dataBase.ShowData(listView1);
                }
            }
            else
            {
                MessageBox.Show("Ничего не сохраннено");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Удалить все сохраненные данные?",
                "ВНИМАНИЕ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );

            if (result == DialogResult.Yes)
            {
                File.Delete(_xmlPath);
            }
        }
    }

    [Serializable]
    public class DataBase
    {
        private List<Order> _orders;

        public List<Order> Orders => _orders;
        public int CountOrders => _orders.Count;

        public DataBase()
        {
            _orders = new List<Order>();
        }
        
        public void SetOrders(List<Order> orders)
        {
            _orders = orders;
        }

        public Order GetOrderByIndex(int index)
        {
            return _orders[index - 1];
        }

        public void RemoveOrderAt(int index)
        {
            foreach (Order order in _orders)
            {
                if (order._id == index)
                {
                    _orders.Remove(order);
  
                    return;
                }
            }

            MessageBox.Show("Id не найден");
        }

        public List<ListViewItem> GetItemsByAttribute(string attribute, string path)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            string data = null;

            for (int i = 0; i < _orders.Count; i++)
            {
                if (_orders[i]._id.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._fullName.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._department.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._countMaterials.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._inStock.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._normHour.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._phoneNumber.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._priceMaterials.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._responsible.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._consumableMaterials.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._equipments.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i]._wageRate.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
            }

            File.WriteAllText(path,data);
            return items;
        }

        public string AddData(Order order)
        {
            string data = $"{order._id} " +
                $"{order._fullName} " +
                $"{order._department} " +
                $"{order._phoneNumber} " +
                $"{order._normHour} " +
                $"{order._wageRate} " +
                $"{order._responsible} " +
                $"{order._equipments} " +
                $"{order._consumableMaterials} " +
                $"{order._countMaterials} " +
                $"{order._priceMaterials} " +
                $"{order._inStock}\n";
            return data;
        }

        public void AddOrder(string fullName, string department, string phoneNumber, int normHour, int wageRate, string responsible, int priceMaterials,int countMaterials, string inStock, string equipment, string material)
        {
            _orders.Add(new Order(CountOrders + 1,fullName,department,phoneNumber,normHour,wageRate,responsible,equipment,material,priceMaterials,countMaterials,inStock));
        }

        public ListViewItem GetDataByIndex(int index)
        {
            ListViewItem items = null;

            items = new ListViewItem(new string[]{
                _orders[index]._id.ToString(),
                _orders[index]._fullName,
                _orders[index]._department,
                _orders[index]._phoneNumber,
                _orders[index]._normHour.ToString(),
                _orders[index]._wageRate.ToString(),
                _orders[index]._responsible,
                _orders[index]._equipments,
                _orders[index]._consumableMaterials,
                _orders[index]._countMaterials.ToString(),
                _orders[index]._priceMaterials.ToString(),
                _orders[index]._inStock
            });

            return items;
        }

        public void ShowDataByAttribute(ListView listView, string attribute, string path)
        {
            List<ListViewItem> listViewItems = GetItemsByAttribute(attribute,path);
            string data = null;

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
            ListViewItem itemsViewItem = null;

            foreach (Order order in _orders)
            {
                itemsViewItem = new ListViewItem(new string[] {
                       order._id.ToString(),
                       order._fullName,
                       order._department,
                       order._phoneNumber,
                       order._normHour.ToString(),
                       order._wageRate.ToString(),
                       order._responsible,
                       order._equipments,
                       order._consumableMaterials,
                       order._countMaterials.ToString(),
                       order._priceMaterials.ToString(),
                       order._inStock
                });
                listView.Items.Add(itemsViewItem);
            }
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
