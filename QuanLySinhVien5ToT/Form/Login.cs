using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using QuanLySinhVien5ToT.BLL;
using QuanLySinhVien5ToT.DTO;

namespace QuanLySinhVien5ToT
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            //this.TrangChu = TC;
        }
        DT_QL_SV5TOT_5Entities2 db = Mydb.GetInstance();
        User_RoleBLL User_RoleBLL = new User_RoleBLL();
        LoginBLL loginBLL = new LoginBLL();
        public static List<ThongTinPQ_DTO> listPQ = new List<ThongTinPQ_DTO>();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" || txtPassword.Text == "")
            {
                if (txtUsername.Text == "")
                {
                    txtUsername.BorderColor = Color.Red;
                    txtUsername.PlaceholderText = "bạn chưa nhập username";
                    txtUsername.PlaceholderForeColor = Color.Red;
                }
                if (txtPassword.Text == "")
                {
                    txtPassword.BorderColor = Color.Red;
                    txtPassword.PlaceholderText = "bạn chưa nhập password";
                    txtPassword.PlaceholderForeColor = Color.Red;
                }
            }
            else
            {
                //string password= loginBLL.Mahoa(txtPassword.Text);
                txtPassword.Text = loginBLL.Mahoa(txtPassword.Text);
                List<UserDTO> listlogin = new List<UserDTO>();
                listlogin = loginBLL.dsuser_NV().Where(x => x.Username == txtUsername.Text.Trim() && x.Password == txtPassword.Text.Trim()).ToList();
                //USER us = User_RoleBLL.Get(x => x.Username == txtUsername.Text.Trim() && x.Password == loginBLL.Mahoa(txtPassword.Text).Trim());
                if (listlogin.Any())
                {
                    this.Hide();                                                                                           
                    listPQ = loginBLL.dsPQ(txtUsername.Text, txtPassword.Text);
                    Trang_Chu TC = new Trang_Chu();
                    TC.LoadPQ();
                    MessageBox.Show("Đăng nhập thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //TC.Refresh();
                }
                else
                {
                    List<UserDTO> listusername = loginBLL.dsuser_NV().Where(x => x.Username == txtUsername.Text.Trim()).ToList();
                    List<UserDTO> listpassword = loginBLL.dsuser_NV().Where(x => x.Password == txtPassword.Text.Trim()).ToList();
                    if (listusername.Any() || listpassword.Any())
                    {
                        if (!listusername.Any())
                        {
                            MessageBox.Show("Username của bạn đã bị sai!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        if (!listpassword.Any())
                        {
                            MessageBox.Show("PassWord của bạn đã bị sai!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //txtPassword.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username và password của bạn đã bị sai!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }
                }
            }
            
        }

        
    }
}
