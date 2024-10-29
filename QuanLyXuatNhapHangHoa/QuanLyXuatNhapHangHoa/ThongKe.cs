using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QuanLyXuatNhapHangHoa
{
    
    public partial class ThongKe : Form
    {
        bll_ThongKe bllThongKe= new bll_ThongKe();  
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            dtgThongKe.DataSource=bllThongKe.getDuLieuThongKe();

            dtgThongKe.Columns[0].Width = 120;
            dtgThongKe.Columns[1].Width = 150;
            dtgThongKe.Columns[2].Width = 160;
            dtgThongKe.Columns[3].Width = 100;
            dtgThongKe.Columns[4].Width = 160;
            dtgThongKe.Columns[5].Width = 149;

        }

        private void dtgThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
