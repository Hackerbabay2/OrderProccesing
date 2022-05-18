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

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public int NormHour { get; set; }
        public int WageRate { get; set; }
        public string Responsible { get; set; }
        public int PriceMaterials { get; set; }
        public string InStock { get; set; }
        public int CountMaterials { get; set; }
        public string Equipments { get; set; }
        public string ConsumableMaterials { get; set; }

        public Order() { }

        public Order(int id, string fullName, string department, string phoneNumber, int normHour, int wageRate, string responsible, string equipments, string materials, int priceMaterials, int countMaterials, string inStock)
        {
            Id = id;
            Equipments = equipments;
            ConsumableMaterials = materials;
            FullName = fullName;
            Department = department;
            PhoneNumber = phoneNumber;
            NormHour = normHour;
            WageRate = wageRate;
            Responsible = responsible;
            PriceMaterials = priceMaterials;
            CountMaterials = countMaterials;
            InStock = inStock;
        }

        public void SetData(string fullName, string department, string phoneNumber, int normHour, int wageRate, string responsible, string equipments, string materials, int priceMaterials, int countMaterials, string inStock)
        {
            Equipments = equipments;
            ConsumableMaterials = materials;
            FullName = fullName;
            Department = department;
            PhoneNumber = phoneNumber;
            NormHour = normHour;
            WageRate = wageRate;
            Responsible = responsible;
            PriceMaterials = priceMaterials;
            CountMaterials = countMaterials;
            InStock = inStock;
        }
    }
}
