using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validator
{
    public partial class FrmValidarDocumento : Form
    {
        public FrmValidarDocumento()
        {
            InitializeComponent();
        }

        private void FrmValidarDocumento_Load(object sender, EventArgs e)
        {
          
        }

        private void llenarData()
        {            
            dataGrid.Rows.Add("FA", "F001", "011661", "2021.09.28", "LDM, PERU", 511.00, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011663", "2021.09.28", "BOTICA ROUSS FARMA", 1015.00, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011666", "2021.09.28", "BOTICA ANY FARMA", 196.00, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011668", "2021.09.28", "NEGOCIOS GENERALES ROSYMAR E.I.R.L.", 316.00, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011671", "2021.09.28", "BOTICA ROUSS FARMA E.I.R.L.", 354.00, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011672", "2021.09.28", "LI FARMA.", 24.00, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011673", "2021.09.28", "BOTICA FAMILIA & SALUD", 28.90, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011675", "2021.09.28", "MERLIN DORADO S.A.C.", 478.40, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011677", "2021.09.29", "NILDA ELICIA LEVITA MAMANI", 451.10, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011678", "2021.09.29", "AUTOSERVICIO LA GRANJITA SAC", 60.40, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011679", "2021.09.29", "AUTOSERVICIO LA GRANJITA SAC", 1109.10, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011683", "2021.09.29", "BOTICA EKO.S FARMA", 278.60, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011690", "2021.09.29", "BOTICA MIA FARMA", 20.10, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011691", "2021.09.29", "BOTICA MIA FARMA", 87.10, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011692", "2021.09.29", "BOTICA EL PUEBLO II", 280.20, "XML", "-", "Enviar");
            dataGrid.Rows.Add("FA", "F001", "011693", "2021.09.29", "GRUPO GUICAR S.A.C.", 1185.70, "XML", "-", "Enviar");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (this.validar())
            {
                habilitar(false);
                llenarData();
            }
        }

        private void habilitar(bool enabled)
        {
            btnProcesar.Enabled = enabled;
            txtEmpresa.Enabled = enabled;
            txtfdesde.Enabled = enabled;
            txtfhasta.Enabled = enabled;

        }

        private bool validar()
        {
            bool retorno = true;
            if (this.txtEmpresa.Text == "")
            {
                MessageBox.Show("Debe seleccionar una empresa");
                return false;
            }

            return retorno;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (e.ColumnIndex)
            {
                case 6://XML
                    MessageBox.Show("Se descarga archivo XML");
                    break;
                case 8://ENVIAR SUNAT
                    MessageBox.Show("Se envio documento a SUNAT");
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            dataGrid.Refresh();
            habilitar(true);
        }
    }
}
