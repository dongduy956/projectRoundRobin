using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobin
{
    public class SJFdocQuyen
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

        public List<tientrinh> Gant
        {
            get
            {
                return gant;
            }

            set
            {
                gant = value;
            }
        }

        Queue<tientrinh> hangdoi = new Queue<tientrinh>();
        public void add(string ten, int tgden, int tgxuLy)
        {
            tientrinh a = new tientrinh(ten, tgden, tgxuLy);
            tam.Add(a);
        }
        List<tientrinh> gant = new List<tientrinh>();
        List<tientrinh> ganTam = new List<tientrinh>();
        void them()
        {
            tam = tam.OrderBy(t => t.ThoiGianDen).ToList();
            foreach (tientrinh a in tam)
                ganTam.Add(a);
        }
        public List<tientrinh> xuLyGant()
        {          
            hangdoi.Clear();
            Gant.Clear();
            ganTam.Clear();
            if (tam.Count == 0)
                return null;
            them();
           
            Gant.Add(new tientrinh(tam[0].TenTienTrinh, tam[0].ThoiGianDen, tam[0].ThoiGianDen, tam[0].ThoiGianXuLy));
            ganTam.RemoveAt(0);
            ganTam = ganTam.OrderBy(t => t.ThoiGianXuLy).ToList();
            foreach (tientrinh b in ganTam)
                hangdoi.Enqueue(b);

            if (hangdoi.Count == 0)
                return Gant;
            tientrinh a;
            while (hangdoi.Count != 0)
            {
                a = hangdoi.Dequeue();
                Gant.Add(new tientrinh(a.TenTienTrinh, Gant[Gant.Count - 1].ThoiGianXuLy, a.ThoiGianDen, Gant[Gant.Count - 1].ThoiGianXuLy + a.ThoiGianXuLy));
            }
            return Gant;
        }
        public List<tientrinh> tinhThoiChoHT()
        {
            for (int i = 0; i < Gant.Count; i++)
            {
                Gant[i].ThoiGianCho = Gant[i].ThoiGianCho - Gant[i].ThoiGianDen;
                Gant[i].ThoiGianXuLy = Gant[i].ThoiGianXuLy - Gant[i].ThoiGianDen;
            }
            return Gant;
        }
        public float tinhTGchoTB()
        {
            int tong = 0;
            foreach (tientrinh a in Gant)
                tong += a.ThoiGianCho;
            return tong / (float)Gant.Count;
        }
        public float tinhTGHTTB()
        {
            int tong = 0;
            foreach (tientrinh a in Gant)
                tong += a.ThoiGianXuLy;
            return tong / (float)Gant.Count;
        }
    }
}

