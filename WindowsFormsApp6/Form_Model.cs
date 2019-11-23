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
    public partial class Form_Model : Form
    {
        public Form_Model()
        {
            InitializeComponent();
        }

        private void Form_Model_Load(object sender, EventArgs e)
        {

        }

        private void btb_model_create_Click(object sender, EventArgs e)
        {
                    List<string> model_info_list = new List<string>();

                    model_info_list.Add(text_model_id.Text);
                    model_info_list.Add(text_model_temp.Text);
                    model_info_list.Add(text_model_humidity.Text);
                    model_info_list.Add(text_model_name.Text);
                    model_info_list.Add("55");
                    Set.Model model = new Set.Model();
                    MessageBox.Show(model.req_model_update(model_info_list));
                    this.Close();


            }

        private void btn_model_update_Click(object sender, EventArgs e)
        {
            List<string> model_info_list = new List<string>();

            model_info_list.Add(text_model_id.Text);
            model_info_list.Add(text_model_temp.Text);
            model_info_list.Add(text_model_humidity.Text);
            model_info_list.Add(text_model_name.Text);
            model_info_list.Add("7");
            Set.Model model = new Set.Model();
            MessageBox.Show(model.req_model_update(model_info_list));
            this.Close();
        }
    }
    }
