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

namespace WindowsFormsApp2
{
    public partial class User_set : Form
    {
        public User_set()
        {
            InitializeComponent();
        }

        private void m1_Load(object sender, EventArgs e)
        {

        }

        // 삽입
        private void insert_Click(object sender, EventArgs e)
        {

        }

        // 검색 
        private void search_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string strconn = "Server=192.168.111.226;Database=Aria;Uid=root;Pwd=1234;";
            conn = new MySqlConnection(strconn);
            conn.Open();
            string strSelect = "SELECT * FROM users;";//본인의 DB이름 
            MySqlCommand cmd = new MySqlCommand(strSelect, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            ArrayList user_all = new ArrayList(); // users 테이블의 값들이 담길 arraylist
            StringBuilder gg = new StringBuilder();
            
            while (rdr.Read())
            {
                Aria_user aria_user_data = new Aria_user();
                aria_user_data.user_id = rdr["user_id"].ToString();
                aria_user_data.pass_word = rdr["pass_word"].ToString();
                aria_user_data.level = rdr["level"].ToString();
                aria_user_data.e_mail = rdr["e_mail"].ToString();
                aria_user_data.first_name = rdr["first_name"].ToString();
                aria_user_data.last_name = rdr["last_name"].ToString();
           
                gg.Append(aria_user_data.user_id + "\t" + aria_user_data.pass_word + "\t" + aria_user_data.level + "\t" + aria_user_data.e_mail + "\t" +
                    aria_user_data.first_name + "\t" + aria_user_data.last_name + "\n");
                user_all.Add(aria_user_data);
            }
            users_box.Text = "아이디\tpw\t레벨\t\t이메일\t\t성\t이름\n" + gg.ToString();
        }

        // 삭제
        private void Delete_Click(object sender, EventArgs e)
        {

        }

        // 수정
        private void Update_Click(object sender, EventArgs e)
        {

        }
    }
}
