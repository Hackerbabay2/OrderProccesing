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
    public partial class Redactor : Form
    {
        private Order _order;

        public Redactor(Order order)
        {
            _order = order;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _order.SetData(fullNameBox.Text,
                departmentBox.Text,
                phoneNumberMaskBox.Text,
                (int)normHourNumeric.Value,
                (int)wageRateNumeric.Value,
                responsibleBox.Text,
                necessaryEquipmentBox.Text,
                conumableMaterialsBox.Text,
                (int)priceMaterialsNumeric.Value,
                (int)countMaterialsNumeric.Value,
                avaliabilityComboBox.Text);

            DialogResult result = MessageBox.Show(
                "Завершить редактирование?",
                "Изменения применены",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );

            if (result == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void Redactor_Load(object sender, EventArgs e)
        {
            fullNameBox.Text = _order.FullName;
            departmentBox.Text = _order.Department;
            phoneNumberMaskBox.Text = _order.PhoneNumber;
            normHourNumeric.Value = _order.NormHour;
            wageRateNumeric.Value = _order.WageRate;
            responsibleBox.Text = _order.Responsible;
            necessaryEquipmentBox.Text = _order.Equipments;
            conumableMaterialsBox.Text = _order.Materials;
            countMaterialsNumeric.Value = _order.CountMaterials;
            priceMaterialsNumeric.Value = _order.PriceMaterials;
            avaliabilityComboBox.Text = _order.InStock;
        }
    }
}
