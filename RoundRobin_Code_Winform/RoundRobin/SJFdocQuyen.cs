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
        public void add(string ten, int tgden, int tgxuLy)
        {
            tientrinh a = new tientrinh(ten, tgden, tgxuLy);
            tam.Add(a);
        }
        List<tientrinh> gant = new List<tientrinh>();
        Queue<tientrinh> ganTam = new Queue<tientrinh>();
        void them()
        {
            tam = tam.OrderBy(t => t.ThoiGianDen).ToList();
            foreach (tientrinh a in tam)
                ganTam.Enqueue(a);
        }
        public List<tientrinh> xuLyGant()
        {            
            Gant.Clear();
            ganTam.Clear();
            if (tam.Count == 0)
                return null;
            them();
            tientrinh a = ganTam.Dequeue();
            Gant.Add(new tientrinh(a.TenTienTrinh, a.ThoiGianDen, a.ThoiGianDen, a.ThoiGianXuLy + a.ThoiGianDen));            
            if (ganTam.Count == 0)
                return Gant;    
            List<tientrinh> hangdoiTam = new List<tientrinh>();
            hangdoiTam.Clear();
            while (ganTam.Count != 0 && ganTam.Peek().ThoiGianDen <= gant[gant.Count - 1].ThoiGianXuLy)
                hangdoiTam.Add(ganTam.Dequeue());
            hangdoiTam = hangdoiTam.OrderBy(t => t.ThoiGianXuLy).ToList();
            while (hangdoiTam.Count != 0)
            {           
                Gant.Add(new tientrinh(hangdoiTam[0].TenTienTrinh, Gant[Gant.Count - 1].ThoiGianXuLy, hangdoiTam[0].ThoiGianDen, Gant[Gant.Count - 1].ThoiGianXuLy + hangdoiTam[0].ThoiGianXuLy));
                hangdoiTam.RemoveAt(0);
                while (ganTam.Count != 0 && ganTam.Peek().ThoiGianDen <= gant[gant.Count - 1].ThoiGianXuLy)
                    hangdoiTam.Add(ganTam.Dequeue());
                hangdoiTam = hangdoiTam.OrderBy(t => t.ThoiGianXuLy).ToList();
            }
            return Gant;
        }
        public List<tientrinh> tinhThoiChoHT()
        {
            gant = xuLyGant();
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

