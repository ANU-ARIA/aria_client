using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using MESComm;
using WindowsFormsApp2.User;

namespace WindowsFormsApp2
{

    public partial class User_set : Form
    {
        string                   u_sMessage = "";
        string                   u_sServerIp = "220.69.249.232";
        const int                u_nServerPort = 4000;
        private List<Aria_user>  u_listReceivedUser;
        DataTable                u_dtUser = new DataTable();
        ServerComm               server_comm = new ServerComm(true);
        Aria_user                us = new Aria_user();

        // radiobox 값
        int                      u_intCost = -1;

        //txtbox clear
        public void Txtboxuser_clear()
        {
            txtbox_user_id.Clear();
            txtbox_user_pw.Clear();
            txtbox_email.Clear();
            txtbox_first_name.Clear();
            txtbox_last_text.Clear();
        }

        public User_set()
        {
            InitializeComponent();

            u_listReceivedUser = new List<Aria_user>();

            u_dtUser.Columns.Add("아이디", typeof(string));
            u_dtUser.Columns.Add("비밀번호", typeof(string));
            u_dtUser.Columns.Add("권한", typeof(int));
            u_dtUser.Columns.Add("e-mail", typeof(string));
            u_dtUser.Columns.Add("성", typeof(string));
            u_dtUser.Columns.Add("이름", typeof(string));

            DataGridView_user_view.DataSource = u_dtUser;

        }


        private void m1_Load(object sender, EventArgs e)
        {
            ShowUserInfoToGridCtrl();
        }

        // 삽입
        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                u_dtUser.Clear();
                u_listReceivedUser.Clear();

                if (rbtn_level_0.Checked == true)       u_intCost = 0;
                else if (rbtn_lever_1.Checked == true)  u_intCost = 1;

                if (u_intCost == -1)
                {
                    MessageBox.Show("관리자, 사용자를 선택해주세요");
                    return;
                }

                // 텍스트 데이터
                us.user_id     = txtbox_user_id.Text;
                us.pass_word   = txtbox_user_pw.Text;
                us.level       = u_intCost;
                us.e_mail      = txtbox_email.Text;
                us.first_name  = txtbox_first_name.Text;
                us.last_name   = txtbox_last_text.Text;

                // 데이터를 하나의 메세지로 묶는다.
                u_sMessage = "{{#!!," + us.user_id + "," + us.pass_word + "," + us.level + "," + us.e_mail + "," + us.first_name +
                "," + us.last_name + ",#}}";

                server_comm.Connect(u_sServerIp, u_nServerPort);

                server_comm.req_user_list(ref u_listReceivedUser, u_sMessage);

                server_comm.Close();

                MessageBox.Show("값이 입력되었습니다.");

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
            }
            ShowUserInfoToGridCtrl();
        }

        // 삭제
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                u_dtUser.Clear();
                u_listReceivedUser.Clear();

                if (rbtn_level_0.Checked == true)       u_intCost = 0;
                else if (rbtn_lever_1.Checked == true)  u_intCost = 1;

                // 텍스트 데이터
                us.user_id     = txtbox_user_id.Text;
                us.pass_word   = txtbox_user_pw.Text;
                us.level       = u_intCost;
                us.e_mail      = txtbox_email.Text;
                us.first_name  = txtbox_first_name.Text;
                us.last_name   = txtbox_last_text.Text;


                // 데이터를 하나의 메세지로 묶는다.
                u_sMessage = "{{#!@," + us.user_id + "," + us.pass_word + "," + us.level + "," + us.e_mail + "," + us.first_name +
                    "," + us.last_name + ",#}}";

                server_comm.Connect(u_sServerIp, u_nServerPort);

                server_comm.req_user_list(ref u_listReceivedUser, u_sMessage);

                server_comm.Close();

                MessageBox.Show("값이 삭제되었습니다.");

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
            }
            ShowUserInfoToGridCtrl();

        }

        // 수정
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                u_dtUser.Clear();
                u_listReceivedUser.Clear();

                if (rbtn_level_0.Checked == true)       u_intCost = 0;
                else if (rbtn_lever_1.Checked == true)  u_intCost = 1;

                if (u_intCost == -1)
                {
                    MessageBox.Show("관리자, 사용자를 선택해주세요");
                    return;
                }

                // 텍스트 데이터
                us.user_id     = txtbox_user_id.Text;
                us.pass_word   = txtbox_user_pw.Text;
                us.level       = u_intCost;
                us.e_mail      = txtbox_email.Text;
                us.first_name  = txtbox_first_name.Text;
                us.last_name   = txtbox_last_text.Text;


                // 데이터를 하나의 메세지로 묶는다.
                u_sMessage = "{{#!#," + us.user_id + "," + us.pass_word + "," + us.level + "," + us.e_mail + "," + us.first_name +
                    "," + us.last_name + ",#}}";

                server_comm.Connect(u_sServerIp, u_nServerPort);

                server_comm.req_user_list(ref u_listReceivedUser, u_sMessage);

                server_comm.Close();

                MessageBox.Show("값이 수정되었습니다.");
            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
            }
        ShowUserInfoToGridCtrl();
        }

        // 검색 %
        private void search_Click(object sender, EventArgs e)
        {
            // 텍스트 데이터
            try
            {
                u_dtUser.Clear();
                u_listReceivedUser.Clear();

                us.user_id = txtbox_id_sc.Text;
                // 데이터를 하나의 메세지로 묶는다.
                u_sMessage = "{{#!%," + us.user_id + ",#}}";

                server_comm.Connect(u_sServerIp, u_nServerPort);

                server_comm.req_user_list(ref u_listReceivedUser, u_sMessage);

                server_comm.Close();

                MessageBox.Show("값이 검색되었습니다.");
            }
            catch
            {
                MessageBox.Show("총 검색.");

            }
            ShowUserInfoToGridCtrl();

        }


        public void ShowUserInfoToGridCtrl()
        {
            u_dtUser.Clear();
            u_listReceivedUser.Clear();

            u_sMessage = "{{#!$,,#}}";

            server_comm.Connect(u_sServerIp, u_nServerPort);

            server_comm.req_user_list(ref u_listReceivedUser, u_sMessage);

            server_comm.Close();

            Txtboxuser_clear();

        }

        private void User_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbox_user_id.Text     = this.DataGridView_user_view.CurrentRow.Cells[0].Value.ToString();
            txtbox_user_pw.Text     = this.DataGridView_user_view.CurrentRow.Cells[1].Value.ToString();
            txtbox_email.Text       = this.DataGridView_user_view.CurrentRow.Cells[3].Value.ToString();
            txtbox_first_name.Text  = this.DataGridView_user_view.CurrentRow.Cells[4].Value.ToString();
            txtbox_last_text.Text   = this.DataGridView_user_view.CurrentRow.Cells[5].Value.ToString();
        }

        private void User_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}