using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobin
{
    public class FCFS
    {
        List<tientrinh> tam = new List<tientrinh>();

        public List<tientrinh> Tam
        {
            get
            {
                return tam;
            }

            set
            {
                tam = value;
            }
        }
        Queue<tientrinh> hangdoi = new Queue<tientrinh>();
        public void add(string ten, int tgden, int tgxuLy)
        {
            tientrinh a = new tientrinh(ten, tgden, tgxuLy);
            tam.Add(a);
        }
        void them()
        {
            tam = tam.OrderBy(t => t.ThoiGianDen).ToList();
            foreach (tientrinh a in tam)
                hangdoi.Enqueue(a);
        }
        List<tientrinh> gant = new List<tientrinh>();
        public List<tientrinh> xuLyGant()
        {
            hangdoi.Clear();
            
            if (tam.Count == 0)
                return null;
            them();
            tientrinh a = hangdoi.Dequeue();
            gant.Clear();
            gant.Add(new tientrinh(a.TenTienTrinh, a.ThoiGianDen, a.ThoiGianDen, a.ThoiGianXuLy+a.ThoiGianDen));
            while (hangdoi.Count != 0)
            {
                a = hangdoi.Dequeue();
                gant.Add(new tientrinh(a.TenTienTrinh, gant[gant.Count - 1].ThoiGianXuLy, a.ThoiGianDen, gant[gant.Count - 1].ThoiGianXuLy + a.ThoiGianXuLy));
            }
            return gant;
        }
        public List<tientrinh> tinhThoiChoHT()
        {            
            for (int i = 0; i < gant.Count; i++)
            {
                gant[i].ThoiGianCho = gant[i].ThoiGianCho - gant[i].ThoiGianDen;
                gant[i].ThoiGianXuLy = gant[i].ThoiGianXuLy - gant[i].ThoiGianDen;
            }
            return gant;
        }
        public float tinhTGchoTB()
        {
            int tong = 0;
            foreach (tientrinh a in gant)
                tong += a.ThoiGianCho;
            return tong / (float)gant.Count;
        }
        public float tinhTGHTTB()
        {
            int tong = 0;
            foreach (tientrinh a in gant)
                tong += a.ThoiGianXuLy;
            return tong / (float)gant.Count;
        }
    }
}
