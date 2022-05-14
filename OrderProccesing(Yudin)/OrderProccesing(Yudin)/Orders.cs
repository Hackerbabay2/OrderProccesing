using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OrderProccesing_Yudin_
{
    [Serializable]
    public class Orders
    {
        public Orders() { }

        public List<Order> OrdersList { get; set; } = new List<Order>();
    }

    [Serializable]
    public class Order
    {
        [XmlElement("ORDER")]

        public int _id { get; set; }
        public string _fullName { get; set; }
        public string _department { get; set; }
        public string _phoneNumber { get; set; }
        public int _normHour { get; set; }
        public int _wageRate { get; set; }
        public string _responsible { get; set; }
        public int _priceMaterials { get; set; }
        public string _inStock { get; set; }
        public int _countMaterials { get; set; }
        public string _equipments { get; set; }
        public string _consumableMaterials { get; set; }

        public Order() { }

        public Order(int id, string fullName, string department, string phoneNumber, int normHour, int wageRate, string responsible, string equipments, string materials, int priceMaterials, int countMaterials, string inStock)
        {
            _id = id;
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
}
