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
            fullNameBox.Text = _order._fullName;
            departmentBox.Text = _order._department;
            phoneNumberMaskBox.Text = _order._phoneNumber;
            normHourNumeric.Value = _order._normHour;
            wageRateNumeric.Value = _order._wageRate;
            responsibleBox.Text = _order._responsible;
            necessaryEquipmentBox.Text = _order._equipments;
            conumableMaterialsBox.Text = _order._consumableMaterials;
            countMaterialsNumeric.Value = _order._countMaterials;
            priceMaterialsNumeric.Value = _order._priceMaterials;
            avaliabilityComboBox.Text = _order._inStock;
        }
    }
}
