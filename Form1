using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizzon3REnergySysPDFtoXML
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            UInt64 k1 = Convert.ToUInt64(Math.Ceiling(Math.Floor(Math.Pow(3, DateTime.Now.Day)) / DateTime.Now.Month) + DateTime.Now.Year);
            UInt64 k2 = Convert.ToUInt64(Math.Ceiling(Math.Floor(Math.Pow(2, DateTime.Now.Day)) / DateTime.Now.Month) + DateTime.Now.Year);
            UInt64 kf = k1 + k2;
            int t = 0;
        }

        private void GerarDados_Click(object sender, EventArgs e)
        {
            var OF = new System.Windows.Forms.OpenFileDialog();
            if (OF.ShowDialog() == DialogResult.OK)
            {
                var Zt = System.IO.Path.GetTempFileName() + ".txt";
                var process = Process.Start(@"C:\Horizzon\Helper\poppler\pdftotext.exe", "-layout \"" + OF.FileName + "\" " + Zt);
                process.WaitForExit();
                Process.Start(Zt);
            }
        }

        private void btnExtrair_Click(object sender, EventArgs e)
        {
            var OF = new System.Windows.Forms.OpenFileDialog();
            if (OF.ShowDialog() == DialogResult.OK)
            {
                var Zt = System.IO.Path.GetTempFileName() + ".txt";
                var process = Process.Start(@"C:\Horizzon\Helper\poppler\pdftotext.exe", "-layout \"" + OF.FileName + "\" " + Zt);
                process.WaitForExit();
                var Str = System.IO.File.ReadAllText(Zt, Encoding.UTF8);
                var MRC = "MRC: " + Regex.Match(Str, @"\sMRC:\s+([0-9\.\,]+)", RegexOptions.Multiline).Groups[1].Value;
                var MMRC = "MMRC: " + Regex.Match(Str, @"\sMMRC:\s+([0-9\.\,]+)", RegexOptions.Multiline).Groups[1].Value;
                var MRO = "MRO: " + Regex.Match(Str, @"\sMRO:\s+([0-9\.\,]+)", RegexOptions.Multiline).Groups[1].Value;

                var Mz = MRC + "\n" + MMRC + "\n" + MRO + "\n";
                MessageBox.Show(Mz);
            }
        }

        private void btnGerarXML_Click(object sender, EventArgs e)
        {
            var Str = System.IO.File.ReadAllText(@"C:\Horizzon\003_35156290_20220803012427_10742.xml", System.Text.Encoding.UTF8);
            Str = Str.Replace("03/08/2022 01:03:27", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            var Zt = System.IO.Path.GetTempFileName() + ".xml";
            System.IO.File.WriteAllText(Zt, Str);
            Process.Start(Zt);
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            for (int i = 0; i < files.Length; i++)
            {
                //System.Windows.Forms.MessageBox.Show(files[i]);
                Peroa.GenPeroa(files[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Alarme = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.AlarmeEmBranco.txt");
            Alarme = Alarme.Replace("PHCOMPVAZAO", txtCompVazao.Text);
            Alarme = Alarme.Replace("PHCODINSTALACAO", txtCodInstalacao.Text);

            var Dg = new System.Windows.Forms.FolderBrowserDialog();
            if (Dg.ShowDialog() == DialogResult.OK)
            {
                var DataAtual = monthCalendar1.SelectionStart;
                var DataAtualStr = DataAtual.ToString("yyyyMMdd");
                while (1 == 1)
                {
                    System.IO.File.WriteAllText(Dg.SelectedPath + "/004_" + comboBox1.SelectedItem.ToString().Substring(0, 8) + "_" + DataAtual.ToString("yyyyMMddHHmmss") + ".xml", Alarme, System.Text.Encoding.UTF8);
                    if (DataAtualStr != monthCalendar1.SelectionEnd.ToString("yyyyMMdd"))
                    {
                        DataAtual = DataAtual.AddDays(1);
                        DataAtualStr = DataAtual.ToString("yyyyMMdd");
                    }
                    else
                    {
                        break;
                    }
                }
                System.Windows.Forms.MessageBox.Show("Arquivos gerados com sucesso!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Peroa.GenPeroa(@"C:\Users\Thiago\Downloads\OneDrive_2022-08-16\XML Report Manager\Peroa\PDF Produção\08.08\08-08-alarmes-emed03.pdf");
            //Peroa.GenPeroa(@"C:\Users\Thiago\Downloads\OneDrive_2022-08-16\XML Report Manager\Peroa\PDF Produção\08.08\08-08-audittrail-emed02-03-05.pdf");

            string Alarmes = "";
            string Eventos = "";

            var DF = new System.Windows.Forms.OpenFileDialog();
            DF.Multiselect = true;
            DF.Filter = "PDF|*.pdf";
            if (DF.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < DF.FileNames.Count(); i++)
                {
                    Peroa.GenPeroa(DF.FileNames[i]);
                    var Tz = System.IO.File.ReadAllText(DF.FileNames[i] + ".xml");
                    Alarmes += Regex.Match(Tz, "<LISTA_ALARMES>(.*?)</LISTA_ALARMES>", RegexOptions.Singleline | RegexOptions.Multiline).Groups[1].Value.Trim();
                    Eventos += Regex.Match(Tz, "<LISTA_EVENTOS>(.*?)</LISTA_EVENTOS>", RegexOptions.Singleline | RegexOptions.Multiline).Groups[1].Value.Trim();
                }
                var FinalCT = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.AlarmeEmBranco.txt");

                var Tmp = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.AlarmeFull.txt");
                Tmp = Tmp.Replace("PHALARMES", Alarmes.Trim());
                Tmp = Tmp.Replace("PHEVENTOS", Eventos.Trim());
                Tmp = Tmp.Replace("PHCOMPVAZAO", "");
                Tmp = Tmp.Replace("PHCODINSTALACAO", "");

                System.IO.File.WriteAllText(DF.FileNames[0] + "_combinado.xml", Tmp, System.Text.Encoding.UTF8);
            }
        }

        private void btnEstimado_Click(object sender, EventArgs e)
        {
            var Dg = new System.Windows.Forms.FolderBrowserDialog();
            if (Dg.ShowDialog() == DialogResult.OK)
            {
                var DataAtual = monthCalendar1.SelectionStart;
                var DataAtualStr = DataAtual.ToString("yyyyMMdd");
                while (1 == 1)
                {
                    var Estm = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.Estimado.txt");
                    Estm = Estm.Replace("PHNUMSERIE", txtAG.Text);
                    Estm = Estm.Replace("PHCODINST", txtInstalacao.Text);
                    Estm = Estm.Replace("PHDATAINI", DataAtual.AddDays(-1).ToString("dd/MM/yyyy HH:mm:ss"));
                    Estm = Estm.Replace("PHDATAFIM", DataAtual.ToString("dd/MM/yyyy HH:mm:ss"));
                    Estm = Estm.Replace("PHVOLUME", String.Format("{0:0.00000}", Convert.ToDouble(txtProducao.Text)));

                    System.IO.File.WriteAllText(Dg.SelectedPath + "/002_" + comboBox1.SelectedItem.ToString().Substring(0,8) + "_" + DataAtual.AddDays(-1).ToString("yyyyMMddHHmmss") + "_" + txtInstalacao.Text + ".xml", Estm, System.Text.Encoding.UTF8);
                    if (DataAtualStr != monthCalendar1.SelectionEnd.ToString("yyyyMMdd"))
                    {
                        DataAtual = DataAtual.AddDays(1);
                        DataAtualStr = DataAtual.ToString("yyyyMMdd");
                    }
                    else
                    {
                        break;
                    }
                }
                System.Windows.Forms.MessageBox.Show("Arquivos gerados com sucesso!");
            }
        }

        public static string DataShifPoco(string val)
        {
            var rf1 = Regex.Match(val, @"([0-9]{2})/([A-z]{3})/([0-9]{4})\s([0-9]{2}):([0-9]{2}):([0-9]{2})", RegexOptions.Multiline);
            return rf1.Groups[3].Value + "-" + Peroa.MonthToNumberUS(rf1.Groups[2].Value) + "-" + rf1.Groups[1].Value + " " + rf1.Groups[4].Value + ":" + rf1.Groups[5].Value + ":" + rf1.Groups[6].Value;
        }
        private void btnFicha_Click(object sender, EventArgs e)
        {
            var OF = new System.Windows.Forms.OpenFileDialog();
            if (OF.ShowDialog() == DialogResult.OK)
            {
                var Zt = System.IO.Path.GetTempFileName() + ".txt";
                var process = Process.Start(@"C:\Horizzon\Helper\poppler\pdftotext.exe", "-layout \"" + OF.FileName + "\" " + Zt);
                process.WaitForExit();
                var Str = System.IO.File.ReadAllText(Zt, Encoding.UTF8);

                var PotOleo = Regex.Match(Str, @"^\sPotencial de\s+produção:\s+([0-9]+\.[0-9]+)", RegexOptions.Multiline).Groups[1].Value;
                var PotGas = Regex.Match(Str, @"^\s\s\s+Potencial de\s+([0-9]+\.[0-9]+)\s+m³/dia\s+Produção\s+([0-9]+\.[0-9]+)\s+m³/dia", RegexOptions.Multiline).Groups[1].Value;
                var PotAgua = Regex.Match(Str, @"Tot\.\s+Qm:\s+[0-9\,\.]+\s+kg\s+([0-9\.]+)", RegexOptions.Singleline | RegexOptions.Multiline).Groups[1].Value;
                var IDPoco = "TPT-PER1-" + Regex.Match(Str, @"ID do poço:\s+(.*?)$", RegexOptions.Multiline).Groups[1].Value.Trim() + Regex.Match(Str, "Número do Relatório: ([0-9]+)", RegexOptions.Multiline).Groups[1].Value.Trim();
                var IData = Regex.Match(Str, @"Fechamento:\s+\[.+\]\s([0-9]{2}/[A-z]{3}/[0-9]{4}\s[0-9]{2}:[0-9]{2}:[0-9]{2})", RegexOptions.Multiline).Groups[1].Value;

                Double PortOleoD = Double.Parse(PotOleo.Replace('.', ','));
                Double PotGasD = Double.Parse(PotGas.Replace('.', ','));
                Double PotAguaD = Double.Parse(PotAgua.Replace('.', ','));

                var Historico = PotOleo + "\n" + PotGas + "\n" + PotAgua;
                System.IO.File.WriteAllText("Historico\\" + IDPoco + ".txt", Historico);

                var Pcx = "";
                if (OF.FileName.Contains("ESS-77")) {
                    Pcx = "342710040000";
                } else if(OF.FileName.Contains("ESS-82")) {
                    Pcx = "342710041100";
                } else if (OF.FileName.Contains("ESS-89")) {
                    Pcx = "342710048600";
                } else if (OF.FileName.Contains("7-PER-1-ESS")) {
                    Pcx = "34271022384";
                } else if (OF.FileName.Contains("7-PER-2-ESS")) {
                    Pcx = "34271022693";
                } else if (OF.FileName.Contains("6-BRSA-475-ESS")) {
                    Pcx = "34271022149";
                } else if (OF.FileName.Contains("7-CAN-1D-ESS")) {
                    Pcx = "34271023081";
                }

                var DPa = DateTime.Parse(DataShifPoco(IData));

            var Ficha = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.TesteDePocoA42.txt");
                Ficha = Ficha.Replace("PHPOCO", Pcx);
                Ficha = Ficha.Replace("PHDATA", DPa.ToString("dd/MM/yyyy HH:mm:ss"));
                Ficha = Ficha.Replace("PHOLEO", String.Format("{0:0.00000}", PortOleoD));
                Ficha = Ficha.Replace("PHGAS", String.Format("{0:0.00000}", PotGasD));
                Ficha = Ficha.Replace("PHAGUA", String.Format("{0:0.00000}", PotAguaD));
                Ficha = Ficha.Replace("PHRELATORIO", IDPoco);
                Ficha = Ficha.Replace("PHVALIDO", Convert.ToString(cbxValido.SelectedItem));
                Ficha = Ficha.Replace("PHTIPO", "T");

                var DZ = DataShifPoco(IData);
                DateTime DY = DateTime.Parse(DZ);
                var ArqOut = System.IO.Path.GetDirectoryName(OF.FileName) + "\\042_" + comboBox1.SelectedItem.ToString().Substring(0, 8) + "_" + DY.ToString("yyyyMMddHHmmss") + ".xml";
                System.IO.File.WriteAllText(ArqOut, Ficha);

            }
        }

        private void btnBSW_Click(object sender, EventArgs e)
        {
            var Dg = new System.Windows.Forms.FolderBrowserDialog();
            if (Dg.ShowDialog() == DialogResult.OK)
            {
                var DataAtual = monthCalendar1.SelectionStart;
                var DataAtualStr = DataAtual.ToString("yyyyMMdd");
                while (1 == 1)
                {
                    var Estm = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.BSW.txt");
                    Estm = Estm.Replace("PHDATA", DataAtual.ToString("dd/MM/yyyy HH:mm:ss"));
                    Estm = Estm.Replace("PHBSW", txtBSW.Text);

                    System.IO.File.WriteAllText(Dg.SelectedPath + "/040_" + comboBox1.SelectedItem.ToString().Substring(0, 8) + "_" + DataAtual.ToString("yyyyMMddHHmmss") + "_" + txtInstalacao.Text + ".xml", Estm, System.Text.Encoding.UTF8);
                    if (DataAtualStr != monthCalendar1.SelectionEnd.ToString("yyyyMMdd"))
                    {
                        DataAtual = DataAtual.AddDays(1);
                        DataAtualStr = DataAtual.ToString("yyyyMMdd");
                    }
                    else
                    {
                        break;
                    }
                }
                System.Windows.Forms.MessageBox.Show("Arquivos gerados com sucesso!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbxReconcavo.Items.Add("EST-3138.09-PILOTO");
            CbxReconcavo.Items.Add("EST-3138.00-CONS_UDM");
            CbxReconcavo.Items.Add("EST-3138.12-PILOTO");
            CbxReconcavo.Items.Add("EST-3152.00-CONS_UDM");
            CbxReconcavo.Items.Add("EST-3138.03-QUEIMA");
            CbxReconcavo.Items.Add("EST-3138.05-QUEIMA");
            CbxReconcavo.Items.Add("EST-3138.04-QUEIMA");
            CbxReconcavo.Items.Add("EST-3157.01-PILOTO");
            CbxReconcavo.Items.Add("EST310202-EST_CX10");
            CbxReconcavo.Items.Add("EST310202-EST_FERR");
            CbxReconcavo.Items.Add("EST3102.02-EST_LM6");
            CbxReconcavo.Items.Add("EST310202-EST_MUI8");
            CbxReconcavo.Items.Add("EST310202-EST_PIT6");
            CbxReconcavo.Items.Add("EST310202-EST_PIT8");
            CbxReconcavo.Items.Add("EST310202-PILOTO");
            CbxReconcavo.Items.Add("EST310202-PURGA1");
            CbxReconcavo.Items.Add("EST310202-PURGA2");
            CbxReconcavo.Items.Add("EST310202-QUEIMA");

            CbxPeroa.Items.Add("EST-CON-PER-01");
            CbxPeroa.Items.Add("EST-EXP-PER-01");

            cbxPocoAbre.Items.Add("1-ESS-77-ESS");
            cbxPocoAbre.Items.Add("3-ESS-82-ESS");
            cbxPocoAbre.Items.Add("4-ESS-89A-ESS");
            cbxPocoAbre.Items.Add("6-BRSA-475-ESS");
            cbxPocoAbre.Items.Add("7-PER-1-ESS");
            cbxPocoAbre.Items.Add("7-PER-2-ESS");
            cbxPocoAbre.Items.Add("7-CAN-1D-ESS");
        }

        private void CbxReconcavo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)CbxReconcavo.SelectedItem == "EST-3138.09-PILOTO")
            {
                txtAG.Text = "EST-3138.09-PILOTO";
                txtInstalacao.Text = "10605";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST-3138.00-CONS_UDM")
            {
                txtAG.Text = "EST-3138.00-CONS_UDM";
                txtInstalacao.Text = "10135";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST-3138.12-PILOTO")
            {
                txtAG.Text = "EST-3138.12-PILOTO";
                txtInstalacao.Text = "10135";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST-3152.00-CONS_UDM")
            {
                txtAG.Text = "EST-3152.00-CONS_UDM";
                txtInstalacao.Text = "10742";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST-3138.03-QUEIMA")
            {
                txtAG.Text = "EST-3138.03-QUEIMA";
                txtInstalacao.Text = "10129";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST-3138.05-QUEIMA")
            {
                txtAG.Text = "EST-3138.05-QUEIMA";
                txtInstalacao.Text = "10128";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST-3138.04-QUEIMA")
            {
                txtAG.Text = "EST-3138.04-QUEIMA";
                txtInstalacao.Text = "10133";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST-3157.01-PILOTO")
            {
                txtAG.Text = "EST-3157.01-PILOTO";
                txtInstalacao.Text = "10550";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST310202-EST_CX10")
            {
                txtAG.Text = "EST310202-EST_CX10";
                txtInstalacao.Text = "10616";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST310202-EST_FERR")
            {
                txtAG.Text = "EST310202-EST_FERR";
                txtInstalacao.Text = "10616";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST3102.02-EST_LM6")
            {
                txtAG.Text = "EST3102.02-EST_LM6";
                txtInstalacao.Text = "10616";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST310202-EST_MUI8")
            {
                txtAG.Text = "EST310202-EST_MUI8";
                txtInstalacao.Text = "10616";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST310202-EST_PIT6")
            {
                txtAG.Text = "EST310202-EST_PIT6";
                txtInstalacao.Text = "10616";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST310202-EST_PIT8")
            {
                txtAG.Text = "EST310202-EST_PIT8";
                txtInstalacao.Text = "10616";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST310202-PILOTO")
            {
                txtAG.Text = "EST310202-PILOTO";
                txtInstalacao.Text = "10616";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST310202-PURGA1")
            {
                txtAG.Text = "EST310202-PURGA1";
                txtInstalacao.Text = "10616";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST310202-PURGA2")
            {
                txtAG.Text = "EST310202-PURGA2";
                txtInstalacao.Text = "10616";
            }

            if ((string)CbxReconcavo.SelectedItem == "EST310202-QUEIMA")
            {
                txtAG.Text = "EST310202-QUEIMA";
                txtInstalacao.Text = "10616";
            }
        }

        private void btnEstimadoReconcavo_Click(object sender, EventArgs e)
        {

        }

        private void CbxPeroa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)CbxPeroa.SelectedItem == "EST-CON-PER-01")
            {
                txtAG.Text = "EST-CON-PER-01";
                txtInstalacao.Text = "10318";
                txtProducao.Text = "2248";
            }

            if ((string)CbxPeroa.SelectedItem == "EST-EXP-PER-01")
            {
                txtAG.Text = "EST-EXP-PER-01";
                txtInstalacao.Text = "10265";
                txtProducao.Text = "0";
            }

        }

        private void btnAbertura_Click(object sender, EventArgs e)
        {
            try
            {
                var Rst = System.IO.File.ReadAllLines("Historico\\" + cbxPocoAbre.SelectedValue + ".txt");
                var PotOleo = Rst[0].Trim();
                var PotGas = Rst[1].Trim();
                var PotAgua = Rst[2].Trim();

                var CodPocoX = "";
                if (cbxPocoAbre.SelectedItem.ToString() == "1-ESS-77-ESS") {
                    CodPocoX = "242710040000";
                } else if (cbxPocoAbre.SelectedItem.ToString() == "3-ESS-82-ESS") {
                    CodPocoX = "242710041100";
                } else if (cbxPocoAbre.SelectedItem.ToString() == "4-ESS-89A-ESS") {
                    CodPocoX = "242710048600";
                } else if (cbxPocoAbre.SelectedItem.ToString() == "6-BRSA-475-ESS") {
                    CodPocoX = "242710022149";
                } else if (cbxPocoAbre.SelectedItem.ToString() == "7-PER-1-ESS") {
                    CodPocoX = "242710022384";
                } else if (cbxPocoAbre.SelectedItem.ToString() == "7-PER-2-ESS") {
                    CodPocoX = "242710022693";
                } else if (cbxPocoAbre.SelectedItem.ToString() == "7-CAN-1D-ESS") {
                    CodPocoX = "242710023081";
                }

                var Ficha = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.TesteDePocoA42.txt");
                Ficha = Ficha.Replace("PHPOCO", CodPocoX);
                Ficha = Ficha.Replace("PHDATA", txtPocoDataX.Text);
                Ficha = Ficha.Replace("PHOLEO", String.Format("{0:0.00000}", Convert.ToDouble(PotOleo)));
                Ficha = Ficha.Replace("PHGAS", String.Format("{0:0.00000}", Convert.ToDouble(PotGas)));
                Ficha = Ficha.Replace("PHAGUA", String.Format("{0:0.00000}", Convert.ToDouble(PotAgua)));
                Ficha = Ficha.Replace("PHRELATORIO", cbxPocoAbre.SelectedItem.ToString());
                Ficha = Ficha.Replace("PHVALIDO", Convert.ToString(cbxValido.SelectedItem));
                Ficha = Ficha.Replace("PHTIPO", "A");

                var OFd = new System.Windows.Forms.SaveFileDialog();
                OFd.Filter = "XML|*.xml";
                if (OFd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(System.IO.Path.GetDirectoryName(OFd.FileName) + @"\002_" + comboBox1.SelectedItem.ToString().Substring(0, 8) + "_" + txtPocoDataX.Text.Replace("-", "").Replace(":","").Replace(" ", "") + ".xml", Ficha);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnFechamento_Click(object sender, EventArgs e)
        {
            try
            {
                var PotOleo = "0";
                var PotGas = "0";
                var PotAgua = "0";

                var CodPocoX = "";
                if (cbxPocoAbre.SelectedItem.ToString() == "1-ESS-77-ESS")
                {
                    CodPocoX = "242710040000";
                }
                else if (cbxPocoAbre.SelectedItem.ToString() == "3-ESS-82-ESS")
                {
                    CodPocoX = "242710041100";
                }
                else if (cbxPocoAbre.SelectedItem.ToString() == "4-ESS-89A-ESS")
                {
                    CodPocoX = "242710048600";
                }
                else if (cbxPocoAbre.SelectedItem.ToString() == "6-BRSA-475-ESS")
                {
                    CodPocoX = "242710022149";
                }
                else if (cbxPocoAbre.SelectedItem.ToString() == "7-PER-1-ESS")
                {
                    CodPocoX = "242710022384";
                }
                else if (cbxPocoAbre.SelectedItem.ToString() == "7-PER-2-ESS")
                {
                    CodPocoX = "242710022693";
                }
                else if (cbxPocoAbre.SelectedItem.ToString() == "7-CAN-1D-ESS")
                {
                    CodPocoX = "242710023081";
                }

                var Ficha = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.TesteDePocoA42.txt");
                Ficha = Ficha.Replace("PHPOCO", CodPocoX);
                Ficha = Ficha.Replace("PHDATA", txtPocoDataX.Text);
                Ficha = Ficha.Replace("PHOLEO", String.Format("{0:0.00000}", Convert.ToDouble(PotOleo)));
                Ficha = Ficha.Replace("PHGAS", String.Format("{0:0.00000}", Convert.ToDouble(PotGas)));
                Ficha = Ficha.Replace("PHAGUA", String.Format("{0:0.00000}", Convert.ToDouble(PotAgua)));
                Ficha = Ficha.Replace("PHRELATORIO", cbxPocoAbre.SelectedItem.ToString());
                Ficha = Ficha.Replace("PHVALIDO", Convert.ToString(cbxValido.SelectedItem));
                Ficha = Ficha.Replace("PHTIPO", "A");

                var OFd = new System.Windows.Forms.SaveFileDialog();
                OFd.Filter = "XML|*.xml";
                if (OFd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(System.IO.Path.GetDirectoryName(OFd.FileName) + @"\002_" + comboBox1.SelectedItem.ToString().Substring(0, 8) + "_" + txtPocoDataX.Text.Replace("-", "").Replace(":", "").Replace(" ", "") + ".xml", Ficha);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnXSS_Click(object sender, EventArgs e) {
            var OF = new System.Windows.Forms.OpenFileDialog();
            OF.Filter = "Excel|*.xlsx";
            if (OF.ShowDialog() == DialogResult.OK) {
                var Ficha = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.TesteDePocoA42.txt");

                var Arquivos = System.IO.File.Open(OF.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                var DR = ExcelDataReader.ExcelReaderFactory.CreateReader(Arquivos);
                DR.Read();
                while (DR.Read()) {
                    if (DR[0] == null) {
                        break;
                    }
                    var COD_CADASTRO_POCO = DR[0].ToString();
                    var IND_TIPO_TESTE = DR[1].ToString();
                    DateTime DHA_TESTE = Convert.ToDateTime(DR[2]);
                    DateTime DHA_APLICACAO = Convert.ToDateTime(DR[3]);
                    var IND_VALIDO = DR[4].ToString();
                    Double MED_POTENCIAL_OLEO = Convert.ToDouble(DR[5].ToString());
                    Double MED_POTENCIAL_GAS = Convert.ToDouble(DR[6].ToString());
                    Double MED_POTENCIAL_AGUA = Convert.ToDouble(DR[7].ToString());
                    var NOM_RELATORIO = DR[8].ToString();

                    var FX = Ficha;
                    FX = FX.Replace("PHPOCO", COD_CADASTRO_POCO);
                    FX = FX.Replace("PHTIPO", IND_TIPO_TESTE);
                    FX = FX.Replace("PHDATA", DHA_TESTE.ToString("dd/MM/yyyy HH:mm:ss"));
                    FX = FX.Replace("PHVALIDO", IND_VALIDO);
                    FX = FX.Replace("PHOLEO", String.Format("{0:0.00000}", MED_POTENCIAL_OLEO));
                    FX = FX.Replace("PHGAS", String.Format("{0:0.00000}", MED_POTENCIAL_GAS));
                    FX = FX.Replace("PHAGUA", String.Format("{0:0.00000}", MED_POTENCIAL_AGUA));
                    FX = FX.Replace("PHRELATORIO", NOM_RELATORIO);

                    var ArqOut = System.IO.Path.GetDirectoryName(OF.FileName) + "\\042_" + comboBox1.SelectedItem.ToString().Substring(0, 8) + "_" + DHA_TESTE.ToString("yyyyMMddHHmmss") +  ".xml";
                    System.IO.File.WriteAllText(ArqOut, FX);
                }
                DR.Close();
                Arquivos.Close();

                System.Windows.Forms.MessageBox.Show("Ok");
            }
        }
    }
}
