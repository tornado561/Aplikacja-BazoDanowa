using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VP_10_Base_Project;
namespace VP_10_Base_Project
{
  
    public partial class Form1 : Form
    {


        private ImageList imageLst;
        private Methods method = new Methods();
     
        private DataTable dt_images;
        private string jpg = ".jpg";
        


        public Form1()
        {
            InitializeComponent();
            imageLst = new ImageList();
           
            dt_images = new DataTable();
            dt_images.Columns.Add("Id", typeof(int));
            dt_images.Columns.Add("kategoria", typeof(string));
            dt_images.Columns.Add("nazwa", typeof(string));
            dt_images.Columns.Add("cena", typeof(float));
            dt_images.Columns.Add("ilosc", typeof(string));
            dt_images.Columns.Add("zdjecie", typeof(System.Drawing.Image));
            dt_images.Columns.Add("link", typeof(string));
            dt_images.Columns.Add("imageLink", typeof(string));
        }
       

        #region UI Event Handlers

        private void cmdGO_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

          
            wyniki.DataSource = dt;
            // wyniki.ColumnAdded()
            wyniki.RowHeadersVisible = false;
            // wyniki.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            wyniki.DataSource = string.Empty;
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(wyniki.Text);
        }

        #endregion

   
        private void Button1_Click(object sender, EventArgs e)
        {
   
            DataTable dt = method.szukajKategorie();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "kategoria";
            znajdzPrzedmiot.Enabled = true;
        }
        private void Button2_Click(object sender, EventArgs e)
        {

            string fileName = (exnazwa.Text+jpg);
            fileName = fileName.Replace(" ", "_");
            if (pictureBox1.Image != null)
            {


                if (exkategoria.Text == string.Empty || exnazwa.Text == string.Empty || excena.Text == string.Empty || exilosc.Text == string.Empty || link_textbox.Text == string.Empty || sciezka.Text == string.Empty)
                {
                    MessageBox.Show("Prosze uzupełnić wszystkie pola!");
                }
                else
                {
                    method.newRecord(kategoria: exkategoria.Text, nazwa: exnazwa.Text, cena: excena.Text, ilosc: exilosc.Text, fileName, link_textbox.Text);
                    wyniki.RowHeadersVisible = false;

                    if (!File.Exists("images/" + fileName))
                    {
                        pictureBox1.Image.Save("images/" + fileName);
                    }
                    else
                    {
                       // MessageBox.Show("Prosze uzupełnić wszystkie pola!");
                    }

                    ShowByCategory();

                }
            }
            else
            {
                MessageBox.Show("Prosze wybrać zdjęcie!");
            }

        }
        private void Edytuj_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(sciezka.Text);
            fileName = fileName.Replace(" ", "_");
            if (exkategoria.Text == string.Empty || exnazwa.Text == string.Empty || excena.Text == string.Empty || exilosc.Text == string.Empty || link_textbox.Text == string.Empty || sciezka.Text==string.Empty )
            {
                MessageBox.Show("Prosze uzupełnić wszystkie pola!");
            }
            else
            {
                method.updateRecord(id: int.Parse(id.Text), kategoria: exkategoria.Text, nazwa: exnazwa.Text,
                                      cena: excena.Text, ilosc: exilosc.Text, fileName, link_textbox.Text);
                wyniki.RowHeadersVisible = false;
                if (!File.Exists("images/" + fileName))
                {
                    pictureBox1.Image.Save("images/" + fileName);
                }
                MessageBox.Show("zedytowano");
                ShowByCategory();
            }
           
        }
        private void Usun_Click(object sender, EventArgs e)
        {
           if(exkategoria.Text==string.Empty || exnazwa.Text==string.Empty)
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
            }
           else
            {
                method.deleteRecord(id: int.Parse(id.Text), kategoria: exkategoria.Text, nazwa: exnazwa.Text);
                wyniki.RowHeadersVisible = false;
                MessageBox.Show("usunieto");
                // usun.Enabled = false;
                ShowByCategory();
            }
           
        }
        private void Id_TextChanged(object sender, EventArgs e)
        {
            id.Enabled = false;
        }
        private void Wyniki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {          
                DataGridViewRow row = wyniki.Rows[e.RowIndex];
                id.Text = row.Cells[0].Value.ToString();
                exkategoria.Text = row.Cells[1].Value.ToString();
                exnazwa.Text = row.Cells[2].Value.ToString();
                excena.Text = row.Cells[3].Value.ToString();
                exilosc.Text = row.Cells[4].Value.ToString();
                sciezka.Text = "images/"+row.Cells[7].Value.ToString();
                link_textbox.Text = row.Cells[6].Value.ToString();//"/images"+row.Cells[7].ToString();
                pictureBox1.Image = new Bitmap(sciezka.Text);
                edytuj.Enabled = true;
                usun.Enabled = true;
            }
        }
        private void Button2_Click_1(object sender, EventArgs e)    
        {
            ShowByCategory();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            exkategoria.Text = "";
            excena.Text = "";
            exnazwa.Text = "";
            exilosc.Text = "";
            id.Text = "";
            link_textbox.Text = "";
            sciezka.Text = "";
        }
        private void Button3_Click(object sender, EventArgs e)
        {

     

            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                sciezka.Text = open.FileName;

                //Extract Image File Name.
                string fileName = Path.GetFileName(sciezka.Text);
                string path = Path.GetFileName(open.FileName);
               
            }
        }
        private void ShowByCategory()
        {
            string kat_val = comboBox1.GetItemText(comboBox1.SelectedItem);
            DataTable dt1 = method.szukajPrzedmiot(kategoria: kat_val);
            dt_images.Clear();
            foreach (DataRow nr in dt1.Rows)
            {
                DataRow r = dt_images.NewRow();
                r[0] = nr[0];
                r[1] = nr[1];
                r[2] = nr[2];
                r[3] = nr[3];
                r[4] = nr[4];
                r[5] = System.Drawing.Image.FromFile("images/" + nr[5]);
                r[6] = nr[6];
                r[7] = nr[5];
                dt_images.Rows.Add(r);
            }
            wyniki.DataSource = dt_images;
            wyniki.Columns[0].MinimumWidth = 20;
            wyniki.Columns[1].MinimumWidth = 100;
            wyniki.Columns[2].MinimumWidth = 100;
            wyniki.Columns[3].MinimumWidth = 20;
            wyniki.Columns[4].MinimumWidth = 20;
            wyniki.Columns[5].Width = 200;
            ((DataGridViewImageColumn)wyniki.Columns[5]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            wyniki.Columns[6].Width = 100;
            wyniki.Columns[0].Visible = false;
            wyniki.Columns[7].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sciezka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
