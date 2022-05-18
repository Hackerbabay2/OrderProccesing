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
            Order order = _dataBase.GetOrderById((int)idNumeric.Value);

            if (order != null)
            {
                Redactor redactor = new Redactor(order);
                redactor.Show();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            _dataBase.RemoveOrderAt((int)idNumeric.Value);
        }

        private void SerializeXML(Orders orders, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Orders));

            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream,orders);
            }
        }

        private Orders DeseriacliezeXml(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Orders));

            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                return (Orders)xmlSerializer.Deserialize(fileStream);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".xml (*.xml*)|*.xml*";
            saveFileDialog.ShowDialog();

            if (!saveFileDialog.FileName.EndsWith(".xml"))
                saveFileDialog.FileName += ".xml";

            File.Delete(saveFileDialog.FileName);
            _orders.OrdersList = _dataBase.Orders;
            SerializeXML(_orders, saveFileDialog.FileName);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = ".xml (*.xml*)|*.xml*";
            openFileDialog.ShowDialog();

            try
            {
                if (openFileDialog.FileName.EndsWith(".xml"))
                {
                    _orders = DeseriacliezeXml(openFileDialog.FileName);
                    _dataBase.SetOrders(_orders.OrdersList);
                    _dataBase.ShowData(listView1);
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.ToString());
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

        public Order GetOrderById(int index)
        {
            foreach (Order order in _orders)
            {
                if (order.Id == index)
                {
                    return order;
                }
            }

            return null;
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

        public List<ListViewItem> GetItemsByAttribute(string attribute, string path)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            string data = null;

            for (int i = 0; i < _orders.Count; i++)
            {
                if (_orders[i].Id.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].FullName.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].Department.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].CountMaterials.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].InStock.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].NormHour.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].PhoneNumber.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].PriceMaterials.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].Responsible.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].ConsumableMaterials.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].Equipments.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_orders[i]);
                }
                else if (_orders[i].WageRate.ToString() == attribute)
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
            string data = $"{order.Id} " +
                $"{order.FullName} " +
                $"{order.Department} " +
                $"{order.PhoneNumber} " +
                $"{order.NormHour} " +
                $"{order.WageRate} " +
                $"{order.Responsible} " +
                $"{order.Equipments} " +
                $"{order.ConsumableMaterials} " +
                $"{order.CountMaterials} " +
                $"{order.PriceMaterials} " +
                $"{order.InStock}\n";
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
                _orders[index].Id.ToString(),
                _orders[index].FullName,
                _orders[index].Department,
                _orders[index].PhoneNumber,
                _orders[index].NormHour.ToString(),
                _orders[index].WageRate.ToString(),
                _orders[index].Responsible,
                _orders[index].Equipments,
                _orders[index].ConsumableMaterials,
                _orders[index].CountMaterials.ToString(),
                _orders[index].PriceMaterials.ToString(),
                _orders[index].InStock
            });

            return items;
        }

        public void ShowDataByAttribute(ListView listView, string attribute, string path)
        {
            List<ListViewItem> listViewItems = GetItemsByAttribute(attribute,path);

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
                       order.Id.ToString(),
                       order.FullName,
                       order.Department,
                       order.PhoneNumber,
                       order.NormHour.ToString(),
                       order.WageRate.ToString(),
                       order.Responsible,
                       order.Equipments,
                       order.ConsumableMaterials,
                       order.CountMaterials.ToString(),
                       order.PriceMaterials.ToString(),
                       order.InStock
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
