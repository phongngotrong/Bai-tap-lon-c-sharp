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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
       
        public AddWindow() 
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=nghi_dinh;Integrated Security=True");
        public bool isValid()
        {
            if (dieu_txt.Text == String.Empty)
            {
                MessageBox.Show("CHƯA ĐIỂN ĐIỀU", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (nd_dieu_txt.Text == String.Empty)
            {
                MessageBox.Show("CHƯA ĐIỀN NỘI DUNG ĐIỀU", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (khoan_txt.Text == String.Empty)
            {
                MessageBox.Show("CHƯA ĐIỀN KHOẢN", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (nd_khoan_txt.Text == String.Empty)
            {
                MessageBox.Show("CHƯA ĐIỀN NỘI DUNG KHOẢN", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (phat_tren_txt.Text == String.Empty)
            {
                MessageBox.Show("CHƯA ĐIỀN MỨC PHẠT TRÊN", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (phat_duoi_txt.Text == String.Empty)
            {
                MessageBox.Show("CHƯA ĐIỀN MỨC PHẠT DƯỚI", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
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
        private void accept_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THÊM KHÔNG? ", "THÊM DỮ LIỆU", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    if (isValid())
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO nghi_dinh VALUES (@DIEU, @NOIDUNGDIEU, @KHOAN, @NOIDUNGKHOAN, @MUCPHATTREN, @MUCPHATDUOI)", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@DIEU", dieu_txt.Text);
                        cmd.Parameters.AddWithValue("@NOIDUNGDIEU", nd_dieu_txt.Text);
                        cmd.Parameters.AddWithValue("@KHOAN", khoan_txt.Text);
                        cmd.Parameters.AddWithValue("@NOIDUNGKHOAN", nd_khoan_txt.Text);
                        cmd.Parameters.AddWithValue("@MUCPHATTREN", phat_tren_txt.Text);
                        cmd.Parameters.AddWithValue("@MUCPHATDUOI", phat_duoi_txt.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        loadGird();
                        MessageBox.Show("THÊM THÀNH CÔNG", "ĐÃ LƯU", MessageBoxButton.OK, MessageBoxImage.Information);
                        clearData();
                    }
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
    }
}
