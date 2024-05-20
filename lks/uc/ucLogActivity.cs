using lks.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks.uc
{
    public partial class ucLogActivity : UserControl
    {
        public ucLogActivity()
        {
            InitializeComponent();
        }

        private void ucLogActivity_Load(object sender, EventArgs e)
        {
            dpExp.Value = DateTime.Now;
            getData();
        }

        private void getData()
        {
            string sql = $"SELECT * FROM log INNER JOIN [user] ON log.user_id = [user].id WHERE waktu between '{dpExp.Value.ToString("yyyy-MM-dd")}' AND '{dpExp.Value.ToString("yyyy-MM-dd")} 23:59:59' ORDER BY log.id DESC";
            DataTable dt = Connect.getData(sql);
            Console.WriteLine(dt.Rows.Count);
            dgLog.DataSource = dt;
            dgLog.Columns[0].Visible = false;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
