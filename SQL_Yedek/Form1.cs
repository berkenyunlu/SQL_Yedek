using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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

namespace SQL_Yedek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string FileName { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {

            string Name = "SQL_Backup" + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".sql";
            FileName = Dizinler.Yedek + Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder("Data Source=" + txtSunucu.Text + ";Initial Catalog=" + txtDatabase.Text + ";MultipleActiveResultSets=True;App=EntityFramework;User ID=" + txtUser.Text + ";Password=" + txtSifre.Text + "");
                var baglanti = new ServerConnection(builder.DataSource, builder.UserID, builder.Password);
                Server svr = new Server(baglanti);
                Microsoft.SqlServer.Management.Smo.Database dbs = svr.Databases[builder.InitialCatalog];
                ScriptingOptions options = new ScriptingOptions
                {
                    ScriptData = true,
                    ScriptDrops = false,
                    FileName = FileName,
                    EnforceScriptingOptions = true,
                    ScriptSchema = true,
                    IncludeHeaders = true,
                    AppendToFile = true,
                    Indexes = true,
                    ScriptDataCompression = true,
                    WithDependencies = true
                };
                foreach (Table tbl in dbs.Tables)
                {
                    tbl.EnumScript(options);
                }

                MessageBox.Show(DateTime.Now.ToShortDateString() + " Yedek alma işlemi tamamlandı", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata","Bir hata oluştu. İşlem gerçekleştirilemedi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
