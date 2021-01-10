using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobin
{
    public class RoundRobin
    {
        Queue<tientrinh> tientrinhf = new Queue<tientrinh>();
        List<tientrinh> tam = new List<tientrinh>();
        public int quanTum = -1;
        public List<tientrinh> Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        public Queue<tientrinh> Tientrinhf
        {
            get { return tientrinhf; }
            set { tientrinhf = value; }
        }
        public void add(string ten1, int tgden1, int tgxuly1)
        {
            tientrinh a = new tientrinh(ten1, tgden1, tgxuly1);
            tam.Add(a);
        }
        void them()
        {
            tam = tam.OrderBy(t => t.ThoiGianDen).ToList();
            for (int i = 0; i < tam.Count; i++)
                tientrinhf.Enqueue(tam[i]);
        }
        public List<tientrinh> xuLy(int timeSlice)
        {
            tientrinhf.Clear();
            them();
            if (tientrinhf.Count == 0)
                return null;
            Queue<tientrinh> tam = new Queue<tientrinh>();
            List<tientrinh> gant = new List<tientrinh>();
            int c = 0;

            tientrinh a = tientrinhf.Peek();
            if (timeSlice >= a.ThoiGianXuLy)
                gant.Add(new tientrinh(a.TenTienTrinh, a.ThoiGianDen, a.ThoiGianDen, a.ThoiGianDen + a.ThoiGianXuLy));
            else
            {
                gant.Add(new tientrinh(a.TenTienTrinh, a.ThoiGianDen, a.ThoiGianDen, timeSlice + a.ThoiGianDen));
                c = 1;
            }
            tientrinh x;
            x = tientrinhf.Dequeue();
            while (tientrinhf.Count != 0 && tientrinhf.Peek().ThoiGianDen < gant[gant.Count - 1].ThoiGianXuLy)
            {
                tientrinh y;
                y = tientrinhf.Dequeue();
                tam.Enqueue(y);
            }
            if (c == 1)
                tam.Enqueue(new tientrinh(x.TenTienTrinh, timeSlice, x.ThoiGianDen, x.ThoiGianXuLy - timeSlice));
            while (tam.Count != 0)
            {
                c = 0;
                if (timeSlice >= tam.Peek().ThoiGianXuLy)
                    gant.Add(new tientrinh(tam.Peek().TenTienTrinh, gant[gant.Count - 1].ThoiGianXuLy, tam.Peek().ThoiGianDen, tam.Peek().ThoiGianXuLy + gant[gant.Count - 1].ThoiGianXuLy));
                else
                {
                    gant.Add(new tientrinh(tam.Peek().TenTienTrinh, gant[gant.Count - 1].ThoiGianXuLy, tam.Peek().ThoiGianDen, timeSlice + gant[gant.Count - 1].ThoiGianXuLy));
                    c = 1;
                }
                while (tientrinhf.Count != 0 && tientrinhf.Peek().ThoiGianDen < gant[gant.Count - 1].ThoiGianXuLy)
                {
                    tientrinh y = tientrinhf.Dequeue();
                    tam.Enqueue(y);
                }
                tientrinh t = tam.Dequeue();
                if (c == 1)
                    tam.Enqueue(new tientrinh(t.TenTienTrinh, timeSlice, t.ThoiGianDen, t.ThoiGianXuLy - timeSlice));

            }
            return gant;
        }
        private tientrinh tinhThoiGianHT(int timeSlice, tientrinh x)
        {
            tientrinh max = new tientrinh();           
            List<tientrinh> gant = xuLy(timeSlice);
            for (int i = 0; i < gant.Count; i++)
                if (gant[i].TenTienTrinh.Equals(x.TenTienTrinh) == true)
                    max = gant[i];
            max.ThoiGianXuLy -= max.ThoiGianDen;
            return max;
        }
        public float tinhThoiGianHTTB(int timeSlice)
        {
            int dem = 0;
            int tong = 0;
            for (int i = 0; i < tam.Count; i++)
            {
                dem++;
                tong += tinhThoiGianHT(timeSlice, tam[i]).ThoiGianXuLy;
            }
            return tong / (float)dem;
        }
        List<tientrinh> thoigian = new List<tientrinh>();
        public List<tientrinh> tinhThoiGianHTTB1(int timeSlice)
        {
            thoigian.Clear();
            for (int i = 0; i < tam.Count; i++)
            {
                thoigian.Add(tinhThoiGianHT(timeSlice, tam[i]));
            }
            return thoigian;
        }
        private int tinhThoiGianCho(int timeSlice, tientrinh x)
        {
            tientrinh q = new tientrinh();
            List<tientrinh> gant = xuLy(timeSlice);
            int vt = -1;
            for (int i = 0; i < gant.Count; i++)
                if (x.TenTienTrinh.Equals(gant[i].TenTienTrinh) == true)
                {
                    vt = i;
                    q = gant[i]; break;
                }
            int tongCho = q.ThoiGianCho - q.ThoiGianDen;
            for (int i = vt; i < gant.Count; i++)
                if (x.TenTienTrinh.Equals(gant[i].TenTienTrinh) == true)
                    for (int t = i + 1; t < gant.Count; t++)
                        if (x.TenTienTrinh.Equals(gant[t].TenTienTrinh) == true)
                        { tongCho += gant[t].ThoiGianCho - gant[i].ThoiGianXuLy; break; }
            return tongCho;
        }
        public float tinhThoiGianChoTB(int timeSlice)
        {
            int dem = 0;
            int tong = 0;
            List<tientrinh> gant = xuLy(timeSlice);
            for (int p = 0; p < tam.Count; p++)
            {
                dem++;

                tong += tinhThoiGianCho(timeSlice, tam[p]);
            }
            return tong / (float)dem;
        }
        public List<tientrinh> thoigianhtcho(int timeSlice)
        {
            thoigian = tinhThoiGianHTTB1(timeSlice);
            List<tientrinh> gant = xuLy(timeSlice);
            for (int p = 0; p < tam.Count; p++)
            {
                for (int g = 0; g < thoigian.Count; g++)
                    if (thoigian[g].TenTienTrinh.Equals(tam[p].TenTienTrinh) == true)
                    { thoigian[g].ThoiGianCho = tinhThoiGianCho(timeSlice, tam[p]); break; }
            }
            return thoigian;
        }
    }
}
