using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Nhom6_BTL
{
    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public UpdateWindow()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=nghi_dinh;Integrated Security=True");
        private void accept_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN SỬA KHÔNG? ", "SỬA DỮ LIỆU", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    
                        SqlCommand cmd = new SqlCommand("UPDATE nghi_dinh SET NOIDUNGDIEU = @NOIDUNGDIEU, NOIDUNGKHOAN = @NOIDUNGKHOAN, MUCPHATTREN = @MUCPHATTREN, MUCPHATDUOI = @MUCPHATDUOI WHERE DIEU = @DIEU AND KHOAN = @KHOAN" , con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("DIEU", dieu_txt.Text);
                        cmd.Parameters.AddWithValue("NOIDUNGDIEU", nd_dieu_txt.Text);
                        cmd.Parameters.AddWithValue("KHOAN", khoan_txt.Text);
                        cmd.Parameters.AddWithValue("NOIDUNGKHOAN", nd_khoan_txt.Text);
                        cmd.Parameters.AddWithValue("MUCPHATTREN", phat_tren_txt.Text);
                        cmd.Parameters.AddWithValue("MUCPHATDUOI", phat_duoi_txt.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        loadGird();
                        MessageBox.Show("SỬA THÀNH CÔNG", "ĐÃ LƯU", MessageBoxButton.OK, MessageBoxImage.Information);
                        clearData();
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                con.Close();

            }
            this.Close();
        }
        public void loadGird()
        {
            SqlCommand cmd = new SqlCommand("select * from nghi_dinh", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
        }
        public void clearData()
        {
            dieu_txt.Clear();
            nd_dieu_txt.Clear();
            khoan_txt.Clear();
            nd_khoan_txt.Clear();
            phat_tren_txt.Clear();
            phat_duoi_txt.Clear();
        }
    }
}
