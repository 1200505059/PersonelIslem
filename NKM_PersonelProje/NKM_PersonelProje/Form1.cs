using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKM_PersonelProje
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;
            textBox1.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtşehir.Text = "";
            txtmaaş.Text = "";
            txtgörev.Text = "";
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtsoyad.Text != "" && txtgörev.Text != "" && txtşehir.Text != "" && txtmaaş.Text != "")
            { 
                EntityPersonel ent = new EntityPersonel();
                ent.Ad = txtad.Text;
                ent.Soyad = txtsoyad.Text;
                ent.Gorev = txtgörev.Text;
                ent.Sehir = txtşehir.Text;
                ent.Odeme = int.Parse(txtmaaş.Text);

                LogicPersonel.LLPersonelEkle(ent);

                List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
                dataGridView1.DataSource = Perlist;
                textBox1.Text = "";
                txtad.Text = "";
                txtsoyad.Text = "";
                txtşehir.Text = "";
                txtmaaş.Text = "";
                txtgörev.Text = "";
            }
        }


        
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtsoyad.Text != "" && txtgörev.Text != "" && txtşehir.Text != "" && txtmaaş.Text != "")
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = Convert.ToInt32(textBox1.Text);
                LogicPersonel.LLPersonelSil(ent.Id);

                textBox1.Text = "";
                txtad.Text = "";
                txtsoyad.Text = "";
                txtşehir.Text = "";
                txtmaaş.Text = "";
                txtgörev.Text = "";
            }
        }




        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Gorev = txtgörev.Text;
            ent.Sehir = txtşehir.Text;
            ent.Odeme = int.Parse(txtmaaş.Text);

            LogicPersonel.LLPersonelGuncelle(ent);
        }


    }
}
