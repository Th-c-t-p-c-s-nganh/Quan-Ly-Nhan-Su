using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmCapNhatNgayCong : Form
    {
        public frmCapNhatNgayCong()
        {
            InitializeComponent();
        }
        public int _manv;
        public string _hoten;
        public int _makycong;
        public int _ngay;
        public string nghiPhep = string.Empty;
        public string vang = string.Empty;
        public string viecRieng = string.Empty;
        public string sang = string.Empty;
        public string chieu = string.Empty;
        public string nguyenNgay = string.Empty;
        public string congTac = string.Empty;
        public int _cNgay;
        KYCONGCHITIET _kcct;
        BANGCONG_NHANVIEN_CT _bcct;
        frmBangCongChiTiet frmBCCT = (frmBangCongChiTiet)Application.OpenForms["frmBangCongChiTiet"];
        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KYCONGCHITIET();
            _bcct = new BANGCONG_NHANVIEN_CT();
            lbHoTen.Text = _hoten;
            lbID.Text = _manv.ToString();
            string nam = _makycong.ToString().Substring(0,4);
            string thang = _makycong.ToString().Substring(4);
            string ngay = _ngay.ToString();
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay);
            cldNgayCong.SetDate(_d);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                var valueChamCong = sang + chieu + nguyenNgay;
                var valueNgayNghi = nghiPhep + vang + viecRieng + congTac;
                string fieldName = "D" + _cNgay.ToString();
                var kcct = _kcct.getItem(_makycong, _manv);
                //double? tongNgayCong = kcct.NGAYCONG.Value;
                //double? tongNgayPhep = kcct.NGAYNGHI.Value;
                //double? tongNgayVang = kcct.NGHIKHONGPHEP.Value;
                //double? tongNgayLe = kcct.TONGNGAYCONG.Value;
                if (cldNgayCong.SelectionRange.Start.Year * 100 + cldNgayCong.SelectionRange.Start.Month != _makycong)
                {
                    MessageBox.Show("Không đúng kỳ công , vui lòng thực hiện lại ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Function.execQuery("UPDATE tb_KYCONGCHITIET SET " + fieldName + "='" + valueNgayNghi + "' WHERE MAKYCONG=" + _makycong + " AND MANV=" + _manv);

                tb_NHANVIEN_CHITIET bcctnv = _bcct.getItem(_makycong, _manv, cldNgayCong.SelectionRange.Start.Day - 2);


                bcctnv.KYHIEU = valueNgayNghi;

                if (cldNgayCong.SelectionStart.DayOfWeek == DayOfWeek.Tuesday) // Nếu là chủ nhật thì tăng số ngày làm chủ nhật
                {
                    if (valueChamCong == "NN")
                    {
                        bcctnv.CONGCHUNHAT = 1;
                        bcctnv.NGAYCONG = 0;
                        bcctnv.NGAYPHEP = 0;
                    }
                    else
                    {
                        bcctnv.CONGCHUNHAT = 0.5;
                    }
                }
                else
                {
                    switch (valueNgayNghi)
                    {
                        case "NP":
                            if (valueChamCong == "NN")
                            {
                                bcctnv.NGAYPHEP = 1;
                                bcctnv.NGAYCONG = 0;
                            }
                            else
                            {
                                bcctnv.NGAYPHEP = 0.5;
                                bcctnv.NGAYCONG = 0.5;
                            }
                            break;
                        case "VR":
                            if (valueChamCong == "NN")
                            {
                                bcctnv.NGAYPHEP = 1;
                                bcctnv.NGAYCONG = 0;
                            }
                            else
                            {
                                bcctnv.NGAYPHEP = 0.5;
                                bcctnv.NGAYCONG = 0.5;
                            }
                            break;
                        case "CT":
                            if (valueChamCong == "NN")
                            {
                                bcctnv.NGAYCONG = 1;
                            }
                            else
                            {
                                bcctnv.NGAYPHEP = 0.5;
                                bcctnv.NGAYCONG = 0.5;
                            }
                            break;
                        case "V":
                            if (valueChamCong == "NN")
                            {
                                bcctnv.NGAYCONG = 0;
                                bcctnv.NGAYPHEP = 1;
                            }
                            else
                            {
                                bcctnv.NGAYPHEP = 0.5;
                                bcctnv.NGAYCONG = 0.5;
                            }
                            break;
                        default:
                            break;
                    }
                }

                _bcct.Update(bcctnv);
                double tongCN = _bcct.tongNgayCongCN(_makycong, _manv);
                double tongNP = _bcct.tongNgayPhep(_makycong, _manv);
                double tongNC = _bcct.tongNgayCong(_makycong, _manv);
                kcct.NGAYNGHI = tongNP;
                kcct.CONGNGAYCHUNHAT = tongCN;
                kcct.TONGNGAYCONG = tongNC;
                _kcct.Update(kcct);
                MessageBox.Show("Cập nhật thành công !" , "Thông báo" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                frmBCCT.RefreshDataGrid();
                ////MessageBox.Show(valueNgayNghi + " "  + valueChamCong);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message , "Thông báo" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void rdNghiPhep_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNghiPhep.Checked) nghiPhep = "NP";
        }

        private void rpVang_CheckedChanged(object sender, EventArgs e)
        {
            if (rpVang.Checked) vang = "V";
        }

        private void rdViecRieng_CheckedChanged(object sender, EventArgs e)
        {
            if (rdViecRieng.Checked) viecRieng = "VR";
        }

        private void rdSang_CheckedChanged(object sender, EventArgs e)
        {
            if(rdSang.Checked) sang = "S";
        }

        private void rdChieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdChieu.Checked) chieu = "C";
        }

        private void rdNguyenNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNguyenNgay.Checked) nguyenNgay = "NN";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cldNgayCong_DateSelected(object sender, DateRangeEventArgs e)
        {
            _cNgay = cldNgayCong.SelectionRange.Start.Day - 2;
        }

        private void grpChamCong_Enter(object sender, EventArgs e)
        {

        }

        private void rdCT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCT.Checked) congTac = "CT";
        }
    }
}
