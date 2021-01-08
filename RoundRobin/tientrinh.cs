using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobin
{
    public class tientrinh
    {
        private string tenTienTrinh;

        public string TenTienTrinh
        {
            get { return tenTienTrinh; }
            set { tenTienTrinh = value; }
        }
        private int thoiGianDen;

        public int ThoiGianDen
        {
            get { return thoiGianDen; }
            set { thoiGianDen = value; }
        }
        private int thoiGianXuLy;

        public int ThoiGianXuLy
        {
            get { return thoiGianXuLy; }
            set { thoiGianXuLy = value; }
        }
        private int thoiGianCho;

        public int ThoiGianCho
        {
            get { return thoiGianCho; }
            set { thoiGianCho = value; }
        }
        public tientrinh()
        { }
        public tientrinh(string ten, int tgden, int tgxuly)
        {
            this.TenTienTrinh = ten;
            this.ThoiGianDen = tgden;
            this.ThoiGianXuLy = tgxuly;
        }
        public tientrinh(string ten, int tgcho, int tgden, int tgxuly)
        {
            this.TenTienTrinh = ten;
            this.ThoiGianDen = tgden;
            this.ThoiGianXuLy = tgxuly;
            this.ThoiGianCho = tgcho;
        }

    }
}
