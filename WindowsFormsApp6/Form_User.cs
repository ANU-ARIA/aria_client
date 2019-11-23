using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form_User : Form
    {
        public Form_User()
        {
            InitializeComponent();
        }

        private void btn_user_create_Click(object sender, EventArgs e)
        {
            try
            { 
            int level = Convert.ToInt32(text_user_level.Text);            
                if (level == 1 || level == 2)
                {
                    List<string> user_info = new List<string>();

                    user_info.Add(text_user_name.Text);
                    user_info.Add(text_user_password.Text);
                    user_info.Add(text_user_level.Text);
                    user_info.Add(text_user_email.Text);
                    user_info.Add(text_user_firstname.Text);
                    user_info.Add(text_user_lastname.Text);
                    Set.Users user = new Set.Users();
                    MessageBox.Show(user.req_user_update(user_info));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("1 또는 2만 입력해주세요.");
                    this.Close();
                }
            }
            catch(Exception h)
            {
                MessageBox.Show("숫자만 입력해주세요");
                this.Close();
            }

            
        }

        private void btn_model_update_Click(object sender, EventArgs e)
        {
            List<string> user_info = new List<string>();

            user_info.Add(text_user_name.Text);
            user_info.Add(text_user_password.Text);
            user_info.Add(text_user_level.Text);
            user_info.Add(text_user_email.Text);
            user_info.Add(text_user_firstname.Text);
            user_info.Add(text_user_lastname.Text);
            user_info.Add("변경");

            if(Convert.ToInt32(text_user_level.Text) == 1 || Convert.ToInt32(text_user_level.Text) == 1)
            {
                MessageBox.Show("Level에 숫자만 입력해주세요.");
                this.Close();
            }

            Set.Users user = new Set.Users();
            MessageBox.Show(user.req_user_update(user_info));
            this.Close();
        }

        private void btn_user_delete_Click(object sender, EventArgs e)
        {
            Set.Users user = new Set.Users();
            if (text_user_name.Text == "")
            {
                MessageBox.Show(user.req_user_delete("전부 삭제"));
                this.Close();
            }
            else
            {
                MessageBox.Show(user.req_user_delete(text_user_name.Text));
                this.Close();
            }
        }
    }
}
