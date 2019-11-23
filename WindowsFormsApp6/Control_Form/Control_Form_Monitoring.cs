using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Control_Form
{
    public partial class Control_Form_Monitoring : UserControl
    {
        Control_Form_LOT lot;

        public string line;
        public string lot_id;
        public string model_name;
        public string amount;
        public string ea_ing;
        public string ea_finish;
        public string ing_speed;
        public string finish_speed;
        public string notfail;
        public string fail;

        public Control_Form_Monitoring(Control_Form_LOT lo)
        {
            lot = lo;
            InitializeComponent();
        }
        public Control_Form_Monitoring()
        {
            InitializeComponent();
        }

        private void Control_Form_Monitoring_Load(object sender, EventArgs e)
        {
            monitor1 = new Form_monitoring(this);
            monitor2 = new Form_monitoring(this);

            this.Controls.Add(grid_monitoring);
            grid_monitoring.ColumnCount = 5;
            grid_monitoring.Columns[0].Name = "생산라인";
            grid_monitoring.Columns[1].Name = "제품 Id";
            grid_monitoring.Columns[2].Name = "상태";
            grid_monitoring.Columns[3].Name = "작업지시명";
            grid_monitoring.Columns[4].Name = "상세정보";

            grid_monitoring.Rows.Add();
            grid_monitoring.Rows.Add();
            grid_monitoring[0, 0].Value = "L#1";
            grid_monitoring[0, 1].Value = "L#2";
            grid_monitoring[0, 2].Value = "L#3";
            grid_monitoring[2, 0].Value = "대기중";
            grid_monitoring[2, 1].Value = "대기중";
            grid_monitoring[2, 2].Value = "대기중";






        }
        Form_monitoring monitor1;
        Form_monitoring monitor2;
        Form_monitoring monitor3;
        private void grid_monitoring_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(grid_monitoring.CurrentRow.Cells[0].Value.ToString() == "L#1")
            {
                if (monitor1.IsDisposed)
                {
                    monitor1 = new Form_monitoring(this);
                    monitor1.index = 1;
                    monitor1.Show();
                }
                else
                {
                    monitor1.index = 1;
                    monitor1.Show();
                }

                
            }
            else if(grid_monitoring.CurrentRow.Cells[0].Value.ToString() == "L#2")
            {
                if (monitor2.IsDisposed)
                {
                    monitor2 = new Form_monitoring(this);
                    monitor2.index = 2;
                    monitor2.Show();
                }
                else
                {
                    monitor2.index = 2;
                    monitor2.Show();
                }
            }
            else if (grid_monitoring.CurrentRow.Cells[0].Value.ToString() == "L#3")
            {
                monitor2.Show();
                /*if (monitor3.IsDisposed)
                {
                    monitor3 = new Form_monitoring(this);
                    monitor3.index = 3;
                    monitor3.Show();
                }
                else
                {
                    monitor3.index = 3;
                    monitor3.Show();
                }*/
            }
        }

    }
}
