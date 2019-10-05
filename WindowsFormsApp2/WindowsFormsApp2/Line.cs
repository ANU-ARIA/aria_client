using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class Line : Form
    {
        public Line()
        {
            InitializeComponent();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void Line_Load(object sender, EventArgs e)
        {

            int x = 1;
            //차트
            chart1.Series.Clear(); //default series 삭제
            Series strue = chart1.Series.Add("정상");
            strue.ChartType = SeriesChartType.Line;

            for(double k=0; k<5;k+=0.1)
            {
                
                strue.Points.AddXY(k, x);
                x += 1;
            }

            Series sfalse = chart1.Series.Add("불량");
            sfalse.ChartType = SeriesChartType.Line;

            for (double k = 0; k < 5; k += 1)
            {
                sfalse.Points.AddXY(k, x);
                x += 1;
            }
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(DataGridView);

            // DataGridView의 컬럼 갯수를 n개로 설정합니다.
            DataGridView.ColumnCount = 6;

            // DataGridView에 컬럼을 추가합니다.
            DataGridView.Columns[0].Name = "라인";
            DataGridView.Columns[1].Name = "작업상태";
            DataGridView.Columns[2].Name = "제품명";
            DataGridView.Columns[3].Name = "작업률";
            DataGridView.Columns[4].Name = "작업자 이름";
            DataGridView.Columns[5].Name = "예약 현황";
        }

        /*
         * PopulateDataGridView()
         * DataGridView에 데이터를 삽입합니다.
         */
        private void PopulateDataGridView()
        {
            // DataGridView에 삽입할 데이터를 설정합니다.
            string[] row0 = { "Line_1", "ON", "초코빵", "57%", "신수영", "" };
            string[] row1 = { "Line_2", "OFF", "", "", "", "" };
            string[] row2 = { "", "", "", "", "", "" };
            string[] row3 = { "", "", "", "", "", "" };
            string[] row4 = { "", "", "", "", "", "" };
            string[] row5 = { "", "", "", "", "", "" };

            // DataGridView에 한 줄씩 삽입합니다.
            DataGridView.Rows.Add(row0);
            DataGridView.Rows.Add(row1);
            DataGridView.Rows.Add(row2);
            DataGridView.Rows.Add(row3);
            DataGridView.Rows.Add(row4);
            DataGridView.Rows.Add(row5);


            // DataGridView에 들어갈 컬럼의 순서를 지정합니다.
            DataGridView.Columns[0].DisplayIndex = 0;
            DataGridView.Columns[1].DisplayIndex = 1;
            DataGridView.Columns[2].DisplayIndex = 2;
            DataGridView.Columns[3].DisplayIndex = 3;
            DataGridView.Columns[4].DisplayIndex = 4;
            DataGridView.Columns[5].DisplayIndex = 5;

            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Lot_direct model = new Lot_direct();
            model.ShowDialog();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
