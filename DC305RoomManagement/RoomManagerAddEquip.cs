using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace DC305RoomManagement
{
    public partial class RoomManagerAddEquip : Form
    {
        //variables to get back to the Room Management Screen
        public int EquipId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Maxquantity { get; set; }
        public string Desc { get; set; }

        private Connection conn = new Connection();
        DataTable dtEquipments = new DataTable();//variable to hold the Equipment Information
        public RoomManagerAddEquip()
        {
            InitializeComponent();
            LoadCB();
        }
        private void LoadCB()//Method to Load Data into the ComboBox
        {
            //setting the default option
            cboxEquip.DisplayMember = "Name";            
            cboxEquip.ValueMember = "EquipId";

            
            //SELECT to get only Available Equipments
            SqlCommand cmd = new SqlCommand("SELECT Equipment.EquipId,Equipment.Name,Equipment.Description,Equipment.Quantity, COALESCE(SUM(RoomEquipment.Quantity),0) as EQuantity "
            + "FROM  Equipment LEFT JOIN RoomEquipment "
            + "ON RoomEquipment.EquipId = Equipment.EquipId "
            + "where  Equipment.Active = 1 "
            + "Group BY Equipment.EquipId, Equipment.Name, Equipment.Description, Equipment.Quantity"
            + " HAVING Equipment.Quantity > COALESCE(SUM(RoomEquipment.Quantity), 0) ", conn.OpenConn());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                dtEquipments.Load(reader);
                DataRow select = dtEquipments.NewRow();
                select["Name"] = "-Select-";
                select["EquipId"] = "0";
                dtEquipments.Rows.InsertAt(select, 0);
                cboxEquip.DataSource = dtEquipments;
                //cboxEquip.Items.Insert(0, new { Name = "-Select-", EquipId = "0" });
                //cboxEquip.SelectedIndex = 0;

            }
        }        

        //Change max value to number of available equipments
        private void CboxEquip_SelectedIndexChanged(object sender, EventArgs e)
        {            
            for (int c = 0; c < dtEquipments.Rows.Count; c++)//search in the dataTable to get the number available
            {                
                if (dtEquipments.Rows[c]["EquipID"].ToString() == cboxEquip.SelectedValue.ToString()&& cboxEquip.SelectedValue.ToString()!="0")
                    {
                    numEquip.Maximum = Convert.ToInt32(dtEquipments.Rows[c]["Quantity"].ToString()) - Convert.ToInt32(dtEquipments.Rows[c]["EQuantity"].ToString());
                    this.Maxquantity = Convert.ToInt32(numEquip.Maximum);                    
                    this.EquipId = Convert.ToInt32(cboxEquip.SelectedValue.ToString());
                    this.Name = cboxEquip.Text.ToString();
                    this.Desc = dtEquipments.Rows[c]["Description"].ToString();
                }
                    
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Quantity=Convert.ToInt32(numEquip.Value);            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.White;
        }

        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.Black;
        }

        private void BtnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.White;
        }

        private void BtnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Black;
        }
    }
}
