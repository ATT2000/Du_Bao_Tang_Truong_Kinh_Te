using System;
using System.Collections.Generic;
using System.Text;


   public class class_Ham_Xay_Dung
    {
        private bool Kiem_tra_tung_so(char so)
        {
            if (char.IsNumber(so))
                return true;
            return false;
        }
        public bool Kiem_tra_chuoi_so(string chuoi_so)
        {

            int i;
            for (i = 0; i < chuoi_so.Length; i++)
            {
                if (!Kiem_tra_tung_so(chuoi_so[i]))
                    return false;

            }
            return true;
        }
        public string NgayThangNam()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
        public int Nam_Hien_Tai()
        {
            return DateTime.Now.Year;
        }
        public string Dinh_Dang_Lai_Ngay_Cap_Nhat(string ngay)
        {
            string ThangNgayNam = "";

            string[] mang = ngay.Split(new char[] { '/' });
            ThangNgayNam = mang[1] + "/" + mang[0] + "/" + mang[2];
            return ThangNgayNam;


        }
        public string Hien_Thi_Ngay_Thang_Nam(string ngay)
        {
            string ThangNgayNam = "";

            string[] mang = ngay.Split(new char[] { '/' });
            string[] a = mang[2].Split(new char[] { ' ' });
            ThangNgayNam = mang[1] + "/" + mang[0] + "/" + a[0];
            return ThangNgayNam;


        }
        public string Lay_Ngay_Thang_Nam_Hien_Tai_Cap_Ma_So()
        {
            return DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString().Remove(0, 2);

        }
        public  string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ","đ", "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị","ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ","ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a","d","e","e","e","e","e","e","e","e","e","e","e","i","i","i","i","i","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","u","u","u","u","u","u","u","u","u","u","u","y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            text = text.Replace(' ', '-').ToLower();
            text = text.Replace(':', '-');
            text = text.Replace(',', '-');
            text = text.Replace('.', '-');
            text = text.Replace(';', '-');
            return text;
        }
        public string NonUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ", "đ", "é", "è", "ẻ", "ẽ", "ẹ", "ê", "ế", "ề", "ể", "ễ", "ệ", "í", "ì", "ỉ", "ĩ", "ị", "ó", "ò", "ỏ", "õ", "ọ", "ô", "ố", "ồ", "ổ", "ỗ", "ộ", "ơ", "ớ", "ờ", "ở", "ỡ", "ợ", "ú", "ù", "ủ", "ũ", "ụ", "ư", "ứ", "ừ", "ử", "ữ", "ự", "ý", "ỳ", "ỷ", "ỹ", "ỵ", };
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "d", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "e", "i", "i", "i", "i", "i", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "u", "y", "y", "y", "y", "y", };
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        public string Cat_khoang_trang(string chuoi)
        {
            chuoi = chuoi.Trim();  
            string text = "";
            chuoi.Replace("   ", " ");
            chuoi.Replace("  ", " ");
            string[] mang = chuoi.Split(' ');
            for (int i = 0; i < mang.Length; i++)
                text = text + mang[i];
            return text;
        }
        public string EN_PASS(string chuoi)
        {
            string encrypt = "";
            chuoi = chuoi.ToUpper().Trim();
            char[] mang_chu = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z', 'W' };
            int cd = chuoi.Length;
            int vitri = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                for (int j = 0; j < mang_chu.Length; j++)
                {
                    if (mang_chu[j] == chuoi[i])
                    {
                        vitri = j;
                        j = mang_chu.Length;
                    }
                }
                int vt=(vitri+cd)%36;
                encrypt = encrypt + mang_chu[vt].ToString();
            }
            return encrypt;
        }
    }

