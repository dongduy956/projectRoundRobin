using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RoundRobin
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        RoundRobin a = new RoundRobin();
        FCFS b = new FCFS();
        SJFdocQuyen sjf = new SJFdocQuyen();
        private void btnadd_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                int tgden = int.Parse(txtgden.Text);
            }
            catch
            {
                check = false;
                MessageBox.Show("Lỗi nhập thời gian đến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                int tgxuly = int.Parse(txBtgxuly.Text);
            }
            catch
            {
                check = false;
                MessageBox.Show("Lỗi thời gian xử lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (check == true)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = txBTen.Text;
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txtgden.Text });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txBtgxuly.Text });
                lwinput.Items.Add(item1);
                a.add(txBTen.Text, int.Parse(txtgden.Text), int.Parse(txBtgxuly.Text));
                b.add(txBTen.Text, int.Parse(txtgden.Text), int.Parse(txBtgxuly.Text));
                sjf.add(txBTen.Text, int.Parse(txtgden.Text), int.Parse(txBtgxuly.Text));
                txBquarium.Enabled = true;
                txBTen.Text = txtgden.Text = txBtgxuly.Text = "";
            }
        }

        private void txBTen_TextChanged(object sender, EventArgs e)
        {
            if (txBTen.Text == "")
                btnadd.Enabled = false;
            if (txtgden.Text != "" && txBTen.Text != "" && txBtgxuly.Text != "")
                btnadd.Enabled = true;
        }

        private void txtgden_TextChanged(object sender, EventArgs e)
        {
            if (txtgden.Text == "")
                btnadd.Enabled = false;
            if (txtgden.Text != "" && txBTen.Text != "" && txBtgxuly.Text != "")
                btnadd.Enabled = true;
        }

        private void txBtgxuly_TextChanged(object sender, EventArgs e)
        {
            if (txBtgxuly.Text == "")
                btnadd.Enabled = false;
            if (txtgden.Text != "" && txBTen.Text != "" && txBtgxuly.Text != "")
                btnadd.Enabled = true;
        }
        List<tientrinh> gantRoundRobin = new List<tientrinh>();
        List<tientrinh> outPutRR = new List<tientrinh>();

        private void btnaddtg_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                int tgden = int.Parse(txBquarium.Text);
            }
            catch
            {
                check = false;
                MessageBox.Show("Lỗi nhập thời gian đến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (check == true)
            {
                a.quanTum = int.Parse(txBquarium.Text);
                btnGant.Enabled = BTSUMIT.Enabled = true;
            }
        }

        private void txBquarium_TextChanged(object sender, EventArgs e)
        {
            if (txBquarium.Text != "")
                btnaddtg.Enabled = true;
            else
                btnaddtg.Enabled = false;
        }
        void veGant(List<tientrinh> gant)
        {            
            groupBox4.Text = "GANT";
            groupBox4.Visible = true;
            int x = 16;
            Label lb1 = new Label();
            lb1.Text = gant[0].ThoiGianCho.ToString();
            lb1.Size = new System.Drawing.Size(36, 20);
            lb1.Location = new Point(10, 48);
            groupBox4.Controls.Add(lb1);
            Random rnd = new Random();
            for (int i = 0; i < gant.Count; i++)
            {
                Button btn = new Button();
                btn.AutoSize = true;
                Color rand = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                btn.BackColor = rand;
                btn.Text = gant[i].TenTienTrinh;
                btn.Size = new System.Drawing.Size(36, 20);
                btn.Location = new Point(x, 22);
                x += btn.Size.Width - 1;
                Label lb = new Label();
                lb.Text = gant[i].ThoiGianXuLy.ToString();
                lb.Size = new System.Drawing.Size(36, 20);
                lb.Location = new Point(btn.Location.X + 27, 48);
                groupBox4.Controls.Add(btn);
                groupBox4.Controls.Add(lb);
            }
        }
        void output(List<tientrinh> output)
        {           
            listView1.View = View.Details;
            for (int i = 0; i < output.Count; i++)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = output[i].TenTienTrinh;
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = output[i].ThoiGianCho.ToString() });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = output[i].ThoiGianXuLy.ToString() });
                listView1.Items.Add(item1);
            }
        }
        void tinhThoiGian(float tgcho,float tght)
        {
            tghttb.Text = tght.ToString();
            lbtgchotb.Text = tgcho.ToString();

        }
        private void BTSUMIT_Click(object sender, EventArgs e)
        {
            if (a.quanTum == -1 || a.xuLy(a.quanTum) == null)
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //output roundRobin
                output(a.thoigianhtcho(a.quanTum));
                // biểu đồ gantRoundRobin
                veGant(a.xuLy(a.quanTum));
                //thời gian chờ thời gian hoàn tất trung bình roundrobin
                tinhThoiGian(a.tinhThoiGianChoTB(a.quanTum), a.tinhThoiGianHTTB(a.quanTum));
            }
        }
        List<tientrinh> ktra(List<tientrinh> Tam,string name)
        {
           
            for (int i = 0; i < Tam.Count; i++)
                if (name.Equals(Tam[i].TenTienTrinh) == true)
                {
                    Tam.RemoveAt(i);
                    break;
                }
            return Tam;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lwinput.SelectedItems)
            {
                string name = item.Text;
                lwinput.Items.Remove(item);
                a.Tam = ktra(a.Tam,name);
                b.Tam = ktra(b.Tam,name);
                sjf.Tam = ktra(sjf.Tam,name);
            }
               listView1.Items.Clear();
            groupBox4.Controls.Clear();
            lbtgchotb.Text = tghttb.Text = "";
            groupBox4.Text = "";
            groupBox4.Visible = false;
        }
        List<tientrinh> gantFCFS = new List<tientrinh>();
    
        private void button1_Click(object sender, EventArgs e)
        {            
            if (b.xuLyGant() == null)
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //biểu đồ gant fcfs
                veGant(b.xuLyGant());
                //output
                output(b.tinhThoiChoHT());
                //tính thời gian hoàn thành và chờ trung bình
                tinhThoiGian(b.tinhTGchoTB(), b.tinhTGHTTB());
            }
        }

        private void btnGant_Click(object sender, EventArgs e)
        {

            List<tientrinh> l = sjf.xuLyGant();
            if (l == null)
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //biểu đồ gant fcfs
                veGant(l);
                //output
                output(sjf.tinhThoiChoHT());
                //tính thời gian hoàn thành và chờ trung bình
                tinhThoiGian(sjf.tinhTGchoTB(), sjf.tinhTGHTTB());
            }
        }
    }
}
