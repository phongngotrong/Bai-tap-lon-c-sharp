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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Nhom6_BTL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {    
        
        public MainWindow()
        {           
            InitializeComponent();
            loadGird();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=nghi_dinh;Integrated Security=True");

        public void loadGird()
        {
            SqlCommand cmd = new SqlCommand("select * from nghi_dinh", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGird.ItemsSource = dt.DefaultView;
            cbbox.SelectedIndex = 0;
        }
       
        private void search_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                using (DataTable dt = new DataTable("nghi_dinh"))
                {
                    string query = "SELECT * FROM nghi_dinh ";
                    if (cbbox.SelectedIndex == 0 && search_txt.Text.Length > 0)
                    {
                        query += "WHERE DIEU =" + search_txt.Text;
                    }
                    else
                    {
                        if (cbbox.SelectedIndex == 1 && search_txt.Text.Length > 0)
                        {
                            query += "WHERE NOIDUNGDIEU LIKE '%" + search_txt.Text + "%'";
                        }
                        if (cbbox.SelectedIndex == 2 && search_txt.Text.Length > 0)
                        {
                            query += "WHERE KHOAN = " + search_txt.Text;
                        }
                        if (cbbox.SelectedIndex == 3 && search_txt.Text.Length > 0)
                        {
                            query += "WHERE NOIDUNGKHOAN LIKE '%" + search_txt.Text + "%'";
                        }
                        if (cbbox.SelectedIndex == 4 && search_txt.Text.Length > 0)
                        {
                            query += "WHERE MUCPHATTREN  =" + search_txt.Text;
                        }
                        if (cbbox.SelectedIndex == 5 && search_txt.Text.Length > 0)
                        {
                            query += "WHERE MUCPHATDUOI =" + search_txt.Text;
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DIEU", search_txt.Text);
                        cmd.Parameters.AddWithValue("@NOIDUNGDIEU", search_txt.Text);
                        cmd.Parameters.AddWithValue("@KHOAN", search_txt.Text);
                        cmd.Parameters.AddWithValue("@NOIDUNGKHOAN", search_txt.Text);
                        cmd.Parameters.AddWithValue("@MUCPHATTREN", search_txt.Text);
                        cmd.Parameters.AddWithValue("@MUCPHATDUOI", search_txt.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dataGird.ItemsSource = dt.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            
        }

       
        private void add_btn_Click(object sender, RoutedEventArgs e)
        {      
           AddWindow addwd = new AddWindow();
           addwd.ShowDialog();
           loadGird();
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            DeleteWindow deletewd = new DeleteWindow();
            deletewd.ShowDialog();
            loadGird();
        }

        private void update_btn_Click(object sender, RoutedEventArgs e)
        {
            UpdateWindow updatewd = new UpdateWindow();
            updatewd.ShowDialog();
            loadGird();
        }
    }
}
