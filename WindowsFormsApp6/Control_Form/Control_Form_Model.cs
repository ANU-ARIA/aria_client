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
    public partial class Control_Form_Model : UserControl
    {
        public Control_Form_Model()
        {
            InitializeComponent();
        }

        private void btn_move_model_create_update_Click(object sender, EventArgs e)
        {
            Form_Model f_model = new Form_Model();
            f_model.Show();
        }

        private void btn_model_select_Click(object sender, EventArgs e)
        {
            grid_model_select.Rows.Clear();

            string model_id_list = "";
            int model_int;
            string model_info_list = text_model_select.Text;
            if (text_model_select.Text == "") // 전체검색 & 선택검색
            {
                model_id_list = "0"; 
                model_int = 0;
            }
            else
            {
                model_id_list = "1";
                model_int = 1;
            }

            Set.Model model = new Set.Model();
            model_info_list = model.req_model_select(model_id_list, model_info_list); // model클래스의 req_model_select 클래스 호출

            try
            {
                if (model_info_list == "이상한값")
                {
                    MessageBox.Show("값을 잘못 입력하셨습니다.");
                }
                else if (model_int == 0)
                {

                    string[] model_info_list_division = model_info_list.Split(new char[] { ',' });

                    string[] model_all_info_list_division = model_info_list.Split(new char[] { '\n' });

                    int w = 0; // , 기준 나뉘어진 요소들의 갯수

                    for (int j = 1; j < model_all_info_list_division.Length; j++)
                    {
                        grid_model_select.Rows.Add();
                    }

                    for (int j = 0; j < model_all_info_list_division.Length; j++)
                    {
                        for (int h = 0; h < 4; h++)
                        {
                            grid_model_select[h, j].Value = model_info_list_division[w];
                            w++;
                        }
                    }
                }
                else if (model_int == 1)
                {
                    string[] user_info_list_division = model_info_list.Split(new char[] { ',' });
                    for (int h = 0; h < 4; h++)
                    {
                        {
                            grid_model_select[h, 0].Value = user_info_list_division[h];
                        }
                    }
                }


                else
                {
                    MessageBox.Show("잘못된 값입니다!");
                }
            }
            catch (Exception h)
            {
                MessageBox.Show("잘못입력했습니다");
            }
        }

        private void Control_Form_Model_Load(object sender, EventArgs e)
        {
            this.Controls.Add(grid_model_select);

            grid_model_select.ColumnCount = 4;

            grid_model_select.Columns[0].Name = "모델 Id";
            grid_model_select.Columns[1].Name = "모델 Temp";
            grid_model_select.Columns[2].Name = "모델 Humidity";
            grid_model_select.Columns[3].Name = "모델 Name";
        }

        private void btn_model_delete_Click(object sender, EventArgs e)
        {
            string delete = text_model_select.Text;
            Set.Model model = new Set.Model();
            MessageBox.Show(model.req_model_delete(delete));
        }
    }
}
