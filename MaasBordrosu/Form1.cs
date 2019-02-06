using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasBordrosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yetkiliKullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YetkiliKullanıcı frm = new YetkiliKullanıcı();
            frm.Show();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

             double agi = 0;

             double SSKPrimİsciPayi = Convert.ToDouble(txtBrütUcret.Text) * 0.14;
             double İssizlikSigorta = Convert.ToDouble(txtBrütUcret.Text) * 0.01;
             double GVM = Convert.ToDouble(txtBrütUcret.Text) - (SSKPrimİsciPayi + İssizlikSigorta);
             double GelirVergisi = GVM * 0.15;
             double DamgaVergisi = Convert.ToDouble(txtBrütUcret.Text) * 0.00759;
             double KesintilerToplami = SSKPrimİsciPayi + İssizlikSigorta + GelirVergisi + DamgaVergisi;
             double NetÜcret = Convert.ToDouble(txtBrütUcret.Text) - KesintilerToplami;
             double OdenecekGelirVergisi = GelirVergisi - agi;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=03-13\\SQLEXPRESS;Initial Catalog=MaasBondrosu;Integrated Security=true";
            SqlCommand cmdBordro = new SqlCommand();
            cmdBordro.CommandText = "INSERT INTO Bordro(Donem,BrutUcret,SskIsciPayi,GelirVergisiMatrahi,GelirVergisi,DamgaVergisi,Agi,OdenecekGelirVergisi,KesintilerToplami,NetUcret) VALUES ('"+DtDönem.Value+"' , '"+txtBrütUcret.Text+"','"+SSKPrimİsciPayi+ "','" + GVM + "','" + GelirVergisi + "','" + DamgaVergisi + "','" + agi+ "','" + OdenecekGelirVergisi + "','" + KesintilerToplami + "','" + NetÜcret + "')";
            cmdBordro.CommandType = CommandType.Text;
            cmdBordro.Connection = cn;
            cn.Open();
           
            txtBrütUcret.Text = "";
            cn.Close();
            SqlDataAdapter daBordro = new SqlDataAdapter("SELECT * FROM Bordro",cn);
            cn.Open();
            DataSet dsBordro = new DataSet();
            daBordro.Fill(dsBordro);
            dataBordro.DataSource = dsBordro.Tables[0].DefaultView;
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=03-13\\SQLEXPRESS;Initial Catalog=MaasBondrosu;Integrated Security=true";
            SqlDataAdapter daBordro = new SqlDataAdapter("SELECT * FROM Bordro", cn);
            DataSet dsBordro = new DataSet();
            cn.Open();
            daBordro.Fill(dsBordro);
            cn.Close();
            dataBordro.DataSource = dsBordro.Tables[0].DefaultView;

            SqlDataAdapter daMedeniDurum = new SqlDataAdapter("SELECT DISTINCT MedeniDurum FROM AGI", cn);
            DataSet dsMedeniDurum = new DataSet();
            cn.Open();
            daMedeniDurum.Fill(dsMedeniDurum);
            cn.Close();
            cmbMedeniDurum.DataSource = dsMedeniDurum.Tables[0].DefaultView;
            cmbMedeniDurum.DisplayMember = "MedeniDurum";
            //cmbMedeniDurum.ValueMember = "PersonelId";

            SqlDataAdapter daEsCalısmaDurum = new SqlDataAdapter("SELECT DISTINCT EsCalismaDurum FROM AGI", cn);
            DataSet dsEsCalısmaDurum = new DataSet();
            cn.Open();
            daEsCalısmaDurum.Fill(dsEsCalısmaDurum);
            cn.Close();
            cmbEsCalısmaDurum.DataSource = dsEsCalısmaDurum.Tables[0].DefaultView;
            cmbEsCalısmaDurum.DisplayMember = "EsCalismaDurum";
        }
    }
}
