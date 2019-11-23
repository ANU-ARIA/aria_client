using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp6.Control_Form
{
    public partial class Control_Form_User : UserControl
    {
        public Control_Form_User()
        {
            InitializeComponent();
        }

        private void btn_move_user_create_update_Click(object sender, EventArgs e)
        {
            Form_User f_user = new Form_User();
            f_user.Show();
        }

        private void btn_user_select_Click(object sender, EventArgs e)
        {
            grid_user_select.Rows.Clear();

            string user_id_list = "";
            int user_int;
            string user_info_list = text_user_select.Text;
            if(text_user_select.Text == "") // 선택검색 & 전체검색
            {
                user_id_list = "0";
                user_int = 0;
            }
            else
            {
                user_id_list = "1";
                user_int = 1;
            }

            Set.Users users = new Set.Users();
            user_info_list = users.req_user_select(user_id_list, user_info_list); // users 클래스의 req_user_select 함수 호출

                if(user_info_list == "이상한값")
                {
                    MessageBox.Show("값을 잘못 입력하셨습니다.");
                }
                else if (user_int == 0)
                {

                    string[] user_info_list_division = user_info_list.Split(new char[] { ',' });

                    string[] user_all_info_list_division = user_info_list.Split(new char[] { '\n' });

                    int w = 0; // , 기준 나뉘어진 요소들의 갯수

                    for (int j = 1; j < user_all_info_list_division.Length; j++)
                    {
                        grid_user_select.Rows.Add();
                    }

                    for (int j = 0; j < user_all_info_list_division.Length; j++)
                    {
                        for (int h = 0; h < 6; h++)
                        {
                            grid_user_select[h, j].Value = user_info_list_division[w];
                            w++;
                        }
                    }
                }
                else if (user_int == 1)
                {
                    string[] user_info_list_division = user_info_list.Split(new char[] { ',' });
                    for (int h = 0; h < 6; h++)
                    {
                        {
                            grid_user_select[h, 0].Value = user_info_list_division[h];
                        }
                    }
                }


                else
                {
                    MessageBox.Show("잘못된 값입니다!");
                }
            }

        
        private void grid_user_select_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Control_Form_User_Load(object sender, EventArgs e)
        {
            this.Controls.Add(grid_user_select);

            grid_user_select.ColumnCount = 6;

            grid_user_select.Columns[0].Name = "User Name";
            grid_user_select.Columns[1].Name = "Pass Word";
            grid_user_select.Columns[2].Name = "Level";
            grid_user_select.Columns[3].Name = "E-Mail";
            grid_user_select.Columns[4].Name = "First Name";
            grid_user_select.Columns[5].Name = "Last Name";
        }

        private void grid_user_select_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
