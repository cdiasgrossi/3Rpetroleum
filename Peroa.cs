using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Horizzon3REnergySysPDFtoXML {
    public class Peroa {
        public static void GenPeroa(string pdf) {
            if (pdf.ToLower().EndsWith(".pdf")) {
                var Zt = System.IO.Path.GetTempFileName() + ".txt";
                var Zt3 = "\"" + Zt + "\"";
                var process = Process.Start(@"C:\Horizzon\Helper\poppler\pdftotext.exe", "-layout \"" + pdf + "\" " + Zt3);
                process.WaitForExit();
                var pdfTxt = System.IO.File.ReadAllText(Zt, Encoding.UTF8);

                string Tmp = "";

                // _____________________________________________________________________________________________________________________________________________________________________________

                if (pdf.ToLower().Contains("qtr-emed01")) {
                    Tmp = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.Peroa-EMED01.txt");

                    // DADOS BÁSICOS
                    
                    var NUM_SERIE_ELEMENTO_PRIMARIO = "0";
                    var COD_INSTALACAO = "0";
                    var COD_TAG_PONTO_MEDICAO = "0";
                                        
                    Tmp = Tmp.Replace("NUM_SERIE_ELEMENTO_PRIMARIO", NUM_SERIE_ELEMENTO_PRIMARIO);
                    Tmp = Tmp.Replace("COD_INSTALACAO", COD_INSTALACAO);
                    Tmp = Tmp.Replace("COD_TAG_PONTO_MEDICAO", COD_TAG_PONTO_MEDICAO);

                                        
                    // CONFIGURAÇÕES DO CV ---------------------------------------------------------------------------------------------------------------------------------------------------

                    var NUM_SERIE_CV = "0";
                    var VERSAO_SOFTWARE = "0";
                    var DENSIDADE_RELATIVA = Regex.Match(pdfTxt, @"\s25\s+-\s+Densidade Relativa\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    
                    Tmp = Tmp.Replace("NUM_SERIE_CV", NUM_SERIE_CV);
                    Tmp = Tmp.Replace("DENSIDADE_RELATIVA", DENSIDADE_RELATIVA);
                    Tmp = Tmp.Replace("VERSAO_SOFTWARE", VERSAO_SOFTWARE);

                    // Data e Hora da Coleta (AGORA)
                    Tmp = Tmp.Replace("PH_DATA", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    
                    
                    // ELEMENTO PRIMÁRIO ----------------------------------------------------------------------------------------------------------------------------------------------------

                    var ICE_METER_FACTOR_1 = "0";
                    var ICE_METER_FACTOR_2 = "0";
                    var ICE_METER_FACTOR_3 = "0";
                    var ICE_METER_FACTOR_4 = "0";
                    var ICE_METER_FACTOR_5 = "0";
                    var ICE_METER_FACTOR_6 = "0";
                    var ICE_METER_FACTOR_7 = "0";
                    var ICE_METER_FACTOR_8 = "0";
                    var ICE_METER_FACTOR_9 = "0";
                    var ICE_METER_FACTOR_10 = "0";
                    var ICE_METER_FACTOR_11 = "0";
                    var ICE_METER_FACTOR_12 = "0";
                    var ICE_METER_FACTOR_13 = "0";
                    var ICE_METER_FACTOR_14 = "0";
                    var ICE_METER_FACTOR_15 = "0";
                    
                    var QTD_PULSOS_METER_FACTOR_1 = "0";
                    var QTD_PULSOS_METER_FACTOR_2 = "0";
                    var QTD_PULSOS_METER_FACTOR_3 = "0";
                    var QTD_PULSOS_METER_FACTOR_4 = "0";
                    var QTD_PULSOS_METER_FACTOR_5 = "0";
                    var QTD_PULSOS_METER_FACTOR_6 = "0";
                    var QTD_PULSOS_METER_FACTOR_7 = "0";
                    var QTD_PULSOS_METER_FACTOR_8 = "0";
                    var QTD_PULSOS_METER_FACTOR_9 = "0";
                    var QTD_PULSOS_METER_FACTOR_10 = "0";
                    var QTD_PULSOS_METER_FACTOR_11 = "0";
                    var QTD_PULSOS_METER_FACTOR_12 = "0";
                    var QTD_PULSOS_METER_FACTOR_13 = "0";
                    var QTD_PULSOS_METER_FACTOR_14 = "0";
                    var QTD_PULSOS_METER_FACTOR_15 = "0";
                    
                    var ICE_K_FACTOR_1 = "0";
                    var ICE_K_FACTOR_2 = "0";
                    var ICE_K_FACTOR_3 = "0";
                    var ICE_K_FACTOR_4 = "0";
                    var ICE_K_FACTOR_5 = "0";
                    var ICE_K_FACTOR_6 = "0";
                    var ICE_K_FACTOR_7 = "0";
                    var ICE_K_FACTOR_8 = "0";
                    var ICE_K_FACTOR_9 = "0";
                    var ICE_K_FACTOR_10 = "0";
                    var ICE_K_FACTOR_11 = "0";
                    var ICE_K_FACTOR_12 = "0";
                    var ICE_K_FACTOR_13 = "0";
                    var ICE_K_FACTOR_14 = "0";
                    var ICE_K_FACTOR_15 = "0";
                                        
                    var QTD_PULSOS_K_FACTOR_1 = "0";
                    var QTD_PULSOS_K_FACTOR_2 = "0";
                    var QTD_PULSOS_K_FACTOR_3 = "0";
                    var QTD_PULSOS_K_FACTOR_4 = "0";
                    var QTD_PULSOS_K_FACTOR_5 = "0";
                    var QTD_PULSOS_K_FACTOR_6 = "0";
                    var QTD_PULSOS_K_FACTOR_7 = "0";
                    var QTD_PULSOS_K_FACTOR_8 = "0";
                    var QTD_PULSOS_K_FACTOR_9 = "0";
                    var QTD_PULSOS_K_FACTOR_10 = "0";
                    var QTD_PULSOS_K_FACTOR_11 = "0";
                    var QTD_PULSOS_K_FACTOR_12 = "0";
                    var QTD_PULSOS_K_FACTOR_13 = "0";
                    var QTD_PULSOS_K_FACTOR_14 = "0";
                    var QTD_PULSOS_K_FACTOR_15 = "0";
                    
                    var ICE_CUTOFF = "0";
                    var ICE_LIMITE_SPRR_ALARME = "0";
                    var ICE_LIMITE_INFRR_ALARME = "0";
                    
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_1", ICE_METER_FACTOR_1);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_2", ICE_METER_FACTOR_2);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_3", ICE_METER_FACTOR_3);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_4", ICE_METER_FACTOR_4);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_5", ICE_METER_FACTOR_5);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_6", ICE_METER_FACTOR_6);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_7", ICE_METER_FACTOR_7);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_8", ICE_METER_FACTOR_8);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_9", ICE_METER_FACTOR_9);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_10", ICE_METER_FACTOR_10);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_11", ICE_METER_FACTOR_11);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_12", ICE_METER_FACTOR_12);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_13", ICE_METER_FACTOR_13);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_14", ICE_METER_FACTOR_14);
                    Tmp = Tmp.Replace("ICE_METER_FACTOR_15", ICE_METER_FACTOR_15);

                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_1", QTD_PULSOS_METER_FACTOR_1);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_2", QTD_PULSOS_METER_FACTOR_2);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_3", QTD_PULSOS_METER_FACTOR_3);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_4", QTD_PULSOS_METER_FACTOR_4);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_5", QTD_PULSOS_METER_FACTOR_5);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_6", QTD_PULSOS_METER_FACTOR_6);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_7", QTD_PULSOS_METER_FACTOR_7);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_8", QTD_PULSOS_METER_FACTOR_8);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_9", QTD_PULSOS_METER_FACTOR_9);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_10", QTD_PULSOS_METER_FACTOR_10);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_11", QTD_PULSOS_METER_FACTOR_11);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_12", QTD_PULSOS_METER_FACTOR_12);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_13", QTD_PULSOS_METER_FACTOR_13);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_14", QTD_PULSOS_METER_FACTOR_14);
                    Tmp = Tmp.Replace("QTD_PULSOS_METER_FACTOR_15", QTD_PULSOS_METER_FACTOR_15);

                    Tmp = Tmp.Replace("ICE_K_FACTOR_1", ICE_K_FACTOR_1);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_2", ICE_K_FACTOR_2);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_3", ICE_K_FACTOR_3);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_4", ICE_K_FACTOR_4);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_5", ICE_K_FACTOR_5);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_6", ICE_K_FACTOR_6);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_7", ICE_K_FACTOR_7);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_8", ICE_K_FACTOR_8);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_9", ICE_K_FACTOR_9);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_10", ICE_K_FACTOR_10);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_11", ICE_K_FACTOR_11);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_12", ICE_K_FACTOR_12);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_13", ICE_K_FACTOR_13);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_14", ICE_K_FACTOR_14);
                    Tmp = Tmp.Replace("ICE_K_FACTOR_15", ICE_K_FACTOR_15);

                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_1", QTD_PULSOS_K_FACTOR_1);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_2", QTD_PULSOS_K_FACTOR_2);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_3", QTD_PULSOS_K_FACTOR_3);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_4", QTD_PULSOS_K_FACTOR_4);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_5", QTD_PULSOS_K_FACTOR_5);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_6", QTD_PULSOS_K_FACTOR_6);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_7", QTD_PULSOS_K_FACTOR_7);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_8", QTD_PULSOS_K_FACTOR_8);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_9", QTD_PULSOS_K_FACTOR_9);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_10", QTD_PULSOS_K_FACTOR_10);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_11", QTD_PULSOS_K_FACTOR_11);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_12", QTD_PULSOS_K_FACTOR_12);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_13", QTD_PULSOS_K_FACTOR_13);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_14", QTD_PULSOS_K_FACTOR_14);
                    Tmp = Tmp.Replace("QTD_PULSOS_K_FACTOR_15", QTD_PULSOS_K_FACTOR_15);

                    Tmp = Tmp.Replace("ICE_CUTOFF", ICE_CUTOFF);
                    Tmp = Tmp.Replace("ICE_LIMITE_SPRR_ALARME", ICE_LIMITE_SPRR_ALARME);
                    Tmp = Tmp.Replace("ICE_LIMITE_INFRR_ALARME", ICE_LIMITE_INFRR_ALARME);
                    

                    // INSTRUMENTO DE PRESSÃO --------------------------------------
                    var NUM_SERIE_PRESSAO = "0";
                    var MED_PRSO_LIMITE_SPRR_ALRME = "0";
                    var MED_PRSO_LMTE_INFRR_ALRME = "0";
                    var MED_PRSO_ADOTADA_FALHA = "0";

                    Tmp = Tmp.Replace("NUM_SERIE_PRESSAO", NUM_SERIE_PRESSAO);
                    Tmp = Tmp.Replace("MED_PRSO_LIMITE_SPRR_ALRME", MED_PRSO_LIMITE_SPRR_ALRME);
                    Tmp = Tmp.Replace("MED_PRSO_LMTE_INFRR_ALRME", MED_PRSO_LMTE_INFRR_ALRME);
                    Tmp = Tmp.Replace("MED_PRSO_ADOTADA_FALHA", MED_PRSO_ADOTADA_FALHA);
                    

                    // INSTRUMENTO DE TEMPERATURA --------------------------------------
                    var NUM_SERIE_TEMP = "0";
                    var MED_TMPTA_SPRR_ALARME = "0";
                    var MED_TMPTA_INFRR_ALRME = "0";
                    var MED_TMPTA_ADTTA_FALHA = "0";

                    Tmp = Tmp.Replace("NUM_SERIE_TEMP", NUM_SERIE_TEMP);
                    Tmp = Tmp.Replace("MED_TMPTA_SPRR_ALARME", MED_TMPTA_SPRR_ALARME);
                    Tmp = Tmp.Replace("MED_TMPTA_INFRR_ALRME", MED_TMPTA_INFRR_ALRME);
                    Tmp = Tmp.Replace("MED_TMPTA_ADTTA_FALHA", MED_TMPTA_ADTTA_FALHA);
                    

                    // PRODUÇÃO -------------------------------------------------------

                    // Data e hora de abertura
                    var AberturaD = Regex.Match(pdfTxt, "Data e hora de abertura:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[1].Value;
                    var AberturaM = MonthToNumber(Regex.Match(pdfTxt, "Data e hora de abertura:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[2].Value);
                    var AberturaA = Regex.Match(pdfTxt, "Data e hora de abertura:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[3].Value;
                    Tmp = Tmp.Replace("PH_DHA_INICIO", AberturaD + "/" + AberturaM + "/" + AberturaA + " 00:00:00");
                    
                    // Data e hora de fechamento
                    var FechamentoD = Regex.Match(pdfTxt, "Data e hora de fechamento:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[1].Value;
                    var FechamentoM = MonthToNumber(Regex.Match(pdfTxt, "Data e hora de fechamento:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[2].Value);
                    var FechamentoA = Regex.Match(pdfTxt, "Data e hora de fechamento:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[3].Value;
                    Tmp = Tmp.Replace("PH_DHA_FIM", FechamentoD + "/" + FechamentoM + "/" + FechamentoA + " 00:00:00");                    

                    // Densidade Relativa
                    var DWA = Regex.Match(pdfTxt, @"\sDWA:\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_DWA", DWA);

                    // Correção BSW
                    var SWV = Regex.Match(pdfTxt, @"\sSWV\s+=\s+GSV\s+\-\s+NSV:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_SWV", SWV);
                    
                    // Correção Pressão do Líquido
                    var CPL = Regex.Match(pdfTxt, @"\sCPL:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_CPL", CPL);
                    
                    // Correção Temperatura do Líquido
                    var CTL = Regex.Match(pdfTxt, @"\sCTL:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_CTL", CTL);
                    
                    // Pressão Estática
                    var PWA = Regex.Match(pdfTxt, @"\sPWA:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_PWA", PWA);
                    
                    // Temperatura do Fluido
                    var TWA = Regex.Match(pdfTxt, @"\sTWA:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_TWA", TWA);

                    //Volumes
                    var GSV = Regex.Match(pdfTxt, @"\sGSV\s+=\s+\(IV\s+x\s+CCF\):\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    var NSV = Regex.Match(pdfTxt, @"\sNSV\s+=\s+\(GSV\s+\*\s+CSW\):\s+([0-9z,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    var MRC = Regex.Match(pdfTxt, @"\s+MRC:\s+([0-9\,\.]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value.Replace(".", "");
                    var MRO = Regex.Match(pdfTxt, @"\s+MRO:\s+([0-9\,\.]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value.Replace(".", "");

                    Tmp = Tmp.Replace("PH_GSV", GSV);
                    Tmp = Tmp.Replace("PH_NSV", NSV);
                    Tmp = Tmp.Replace("PH_TTLZO_FIM_PRDO", MRC);
                    Tmp = Tmp.Replace("PH_TTLZO_INCO_PRDO", MRO);

                    System.IO.File.WriteAllText(pdf + ".xml", Tmp);

                // _____________________________________________________________________________________________________________________________________________________________________________

                } else if (pdf.ToLower().Contains("qtr-emed02")) {
                    
                    Tmp = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.Peroa-EMED02.txt");
                    
                    // DADOS BÁSICOS
                    
                    var NUM_SERIE_ELEMENTO_PRIMARIO = "0";
                    var COD_INSTALACAO = "0";
                    var COD_TAG_PONTO_MEDICAO = "0";
                                        
                    Tmp = Tmp.Replace("NUM_SERIE_ELEMENTO_PRIMARIO", NUM_SERIE_ELEMENTO_PRIMARIO);
                    Tmp = Tmp.Replace("COD_INSTALACAO", COD_INSTALACAO);
                    Tmp = Tmp.Replace("COD_TAG_PONTO_MEDICAO", COD_TAG_PONTO_MEDICAO);

                    
                    // CONFIGURAÇÕES DO CV --------------------------------------------

                    var NUM_SERIE_CV = "0";
                    var VERSAO_SOFTWARE = "0";
                    var NORMA_UTILIZADA_CALCULO = Regex.Match(pdfTxt, @"\sNormas:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    var DENSIDADE_RELATIVA = Regex.Match(pdfTxt, @"\s25\s+-\s+Densidade Relativa\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    
                    Tmp = Tmp.Replace("NUM_SERIE_CV", NUM_SERIE_CV);
                    Tmp = Tmp.Replace("VERSAO_SOFTWARE", VERSAO_SOFTWARE);
                    Tmp = Tmp.Replace("DENSIDADE_RELATIVA", DENSIDADE_RELATIVA);
                    Tmp = Tmp.Replace("NORMA_UTILIZADA_CALCULO", NORMA_UTILIZADA_CALCULO);
                    
                    // Data e Hora da Coleta (AGORA)
                    Tmp = Tmp.Replace("PH_DATA", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    
                    // Cromatografias
                    var METANO = Regex.Match(pdfTxt, @"\s1\s+-\s+Metano\s+-\s+C1\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var NITROGENIO = Regex.Match(pdfTxt, @"\s2\s+-\s+Nitrogênio\s+-\s+N2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var CO2 = Regex.Match(pdfTxt, @"\s3\s+-\s+Dióxido\s+de\s+Carbono\s+-\s+CO2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var ETANO = Regex.Match(pdfTxt, @"\s4\s+-\s+Etano\s+-\s+C2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var PROPANO = Regex.Match(pdfTxt, @"\s5\s+-\s+Propano\s+-\s+C3\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var AGUA = Regex.Match(pdfTxt, @"\s6\s+-\s+Água\s+-\s+H2O\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var H2S = Regex.Match(pdfTxt, @"\s7\s+-\s+Hidrogênio\s+Sulfídrico\s+-\s+H2S\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var HIDROGENIO = Regex.Match(pdfTxt, @"\s8\s+-\s+Hidrogênio\s+-\s+H2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var CO = Regex.Match(pdfTxt, @"\s9\s+-\s+Monóxido de Carbono\s+-\s+CO\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var OXIGENIO = Regex.Match(pdfTxt, @"\s10\s+-\s+Oxigênio\s+-\s+O2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var I_BUTANO = Regex.Match(pdfTxt, @"\s11\s+-\s+i-Butano\s+-\s+iC4\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var N_BUTANO = Regex.Match(pdfTxt, @"\s12\s+-\s+n-Butano\s+-\s+nC4\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var I_PENTANO = Regex.Match(pdfTxt, @"\s13\s+-\s+i-Pentano\s+-\s+iC5\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var N_PENTANO = Regex.Match(pdfTxt, @"\s14\s+-\s+n-Pentano\s+-\s+nC5\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var HEXANO = Regex.Match(pdfTxt, @"\s15\s+-\s+n-Hexano\s+-\s+nC6\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var HEPTANO = Regex.Match(pdfTxt, @"\s16\s+-\s+n-Heptano\s+-\s+nC7\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var OCTANO = Regex.Match(pdfTxt, @"\s17\s+-\s+n-Octano\s+-\s+nC8\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var NONANO = Regex.Match(pdfTxt, @"\s18\s+-\s+n-Nonano\s+-\s+nC9\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var DECANO = Regex.Match(pdfTxt, @"\s19\s+-\s+n-Decano\s+-\s+nC10\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var HELIO = Regex.Match(pdfTxt, @"\s20\s+-\s+Hélio\s+-\s+He\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var ARGONIO = Regex.Match(pdfTxt, @"\s21\s+-\s+Argônio\s+-\s+Ar\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;

                    Tmp = Tmp.Replace("CROMATOGRAFIA_METANO", METANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_NITROGENIO", NITROGENIO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_CO2", CO2);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_ETANO", ETANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_PROPANO", PROPANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_AGUA", AGUA);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_H2S", H2S);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_HIDROGENIO", HIDROGENIO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_CO", CO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_OXIGENIO", OXIGENIO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_I_BUTANO", I_BUTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_N_BUTANO", N_BUTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_I_PENTANO", I_PENTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_N_PENTANO", N_PENTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_HEXANO", HEXANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_HEPTANO", HEPTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_OCTANO", OCTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_NONANO", NONANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_DECANO", DECANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_HELIO", HELIO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_ARGONIO", ARGONIO);


                    // ELEMENTO PRIMÁRIO ---------------------------------------------

                    var ICE_LIMITE_SPRR_ALARME = "0";
                    var ICE_LIMITE_INFRR_ALARME = "0";
                    
                    Tmp = Tmp.Replace("ICE_LIMITE_SPRR_ALARME", ICE_LIMITE_SPRR_ALARME);
                    Tmp = Tmp.Replace("ICE_LIMITE_INFRR_ALARME", ICE_LIMITE_INFRR_ALARME);
                    

                    // INSTRUMENTO DE PRESSÃO --------------------------------------
                    var NUM_SERIE_PRESSAO = "0";
                    var MED_PRSO_LIMITE_SPRR_ALRME = "0";
                    var MED_PRSO_LMTE_INFRR_ALRME = "0";
                    var MED_PRSO_ADOTADA_FALHA = "0";

                    Tmp = Tmp.Replace("NUM_SERIE_PRESSAO", NUM_SERIE_PRESSAO);
                    Tmp = Tmp.Replace("MED_PRSO_LIMITE_SPRR_ALRME", MED_PRSO_LIMITE_SPRR_ALRME);
                    Tmp = Tmp.Replace("MED_PRSO_LMTE_INFRR_ALRME", MED_PRSO_LMTE_INFRR_ALRME);
                    Tmp = Tmp.Replace("MED_PRSO_ADOTADA_FALHA", MED_PRSO_ADOTADA_FALHA);


                    // INSTRUMENTO DE TEMPERATURA --------------------------------------
                    var NUM_SERIE_TEMP = "0";
                    var MED_TMPTA_SPRR_ALARME = "0";
                    var MED_TMPTA_INFRR_ALRME = "0";
                    var MED_TMPTA_ADTTA_FALHA = "0";

                    Tmp = Tmp.Replace("NUM_SERIE_TEMP", NUM_SERIE_TEMP);
                    Tmp = Tmp.Replace("MED_TMPTA_SPRR_ALARME", MED_TMPTA_SPRR_ALARME);
                    Tmp = Tmp.Replace("MED_TMPTA_INFRR_ALRME", MED_TMPTA_INFRR_ALRME);
                    Tmp = Tmp.Replace("MED_TMPTA_ADTTA_FALHA", MED_TMPTA_ADTTA_FALHA);

                  

                    // PLACA DE ORIFICIO -------------------------------------------------
                    
                    // MED_DIAMETRO_REFERENCIA
                    var ORIFICIO  = Regex.Match(pdfTxt, @"\sOrifício:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("MED_DIAMETRO_REFERENCIA", ORIFICIO);
                                        
                    // MED_DMTRO_INTRO_TRCHO_MDCO
                    var TUBO = Regex.Match(pdfTxt, @"\sTubo:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("MED_DMTRO_INTRO_TRCHO_MDCO", TUBO);
                    
                    
                    // DIFERENCIAL DE PRESSAO PRINCIPAL ---------------------------------
                    var NUM_SERIE_DPP = "0";
                    var MED_PRSO_LIMITE_SPRR_ALRME_DPP = "0";
                    var MED_PRSO_LMTE_INFRR_ALRME_DPP = "0";
                    var MED_PRSO_ADOTADA_FALHA_DPP = "0";
                    var MED_CUTOFF_KPA = "0";

                    Tmp = Tmp.Replace("NUM_SERIE_DPP", NUM_SERIE_DPP);
                    Tmp = Tmp.Replace("MED_PRSO_LIMITE_SPRR_ALRME_DPP", MED_PRSO_LIMITE_SPRR_ALRME_DPP);
                    Tmp = Tmp.Replace("MED_PRSO_LMTE_INFRR_ALRME_DPP", MED_PRSO_LMTE_INFRR_ALRME_DPP);
                    Tmp = Tmp.Replace("MED_PRSO_ADOTADA_FALHA_DPP", MED_PRSO_ADOTADA_FALHA_DPP);
                    Tmp = Tmp.Replace("MED_CUTOFF_KPA", MED_CUTOFF_KPA);


                    // PRODUÇÃO -------------------------------------------------------

                    // Data e hora de abertura
                    var AberturaD = Regex.Match(pdfTxt, "Data e hora de abertura:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[1].Value;
                    var AberturaM = MonthToNumber(Regex.Match(pdfTxt, "Data e hora de abertura:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[2].Value);
                    var AberturaA = Regex.Match(pdfTxt, "Data e hora de abertura:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[3].Value;
                    Tmp = Tmp.Replace("PH_DHA_INICIO", AberturaD + "/" + AberturaM + "/" + AberturaA + " 00:00:00");
                    
                    // Data e hora de fechamento
                    var FechamentoD = Regex.Match(pdfTxt, "Data e hora de fechamento:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[1].Value;
                    var FechamentoM = MonthToNumber(Regex.Match(pdfTxt, "Data e hora de fechamento:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[2].Value);
                    var FechamentoA = Regex.Match(pdfTxt, "Data e hora de fechamento:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[3].Value;
                    Tmp = Tmp.Replace("PH_DHA_FIM", FechamentoD + "/" + FechamentoM + "/" + FechamentoA + " 00:00:00");                    
                    
                    // Diferencial de Pressão
                    var DBWA = Regex.Match(pdfTxt, @"\sDBWA:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_DBWA", DBWA);
                    
                    // Pressão Estática
                    var PWA = Regex.Match(pdfTxt, @"\sPWA:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_PWA", PWA);
                    
                    // Temperatura do Fluido
                    var TWA = Regex.Match(pdfTxt, @"\sTWA:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_TWA", TWA);

                    // Duração do Fluxo
                    var DUR_FLUXO = "1440,0000";
                    Tmp = Tmp.Replace("DURACAO_FLUXO_EFETIVO", DUR_FLUXO);

                    //MED_CORRIGIDO_MVMDO
                    var QB = Regex.Match(pdfTxt, @"\sTOT\s+QB:\s+=\s+GSV\s+\-\s+NSV:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("MED_CORRIGIDO_MVMDO", QB);


                    System.IO.File.WriteAllText(pdf + ".xml", Tmp);

                // _____________________________________________________________________________________________________________________________________________________________________________

                } else if (pdf.ToLower().Contains("qtr-emed03")) {
                    
                    Tmp = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.Peroa-EMED03.txt");

                    // DADOS BÁSICOS
                    
                    var NUM_SERIE_ELEMENTO_PRIMARIO = "0";
                    var COD_INSTALACAO = "0";
                    var COD_TAG_PONTO_MEDICAO = "0";
                                        
                    Tmp = Tmp.Replace("NUM_SERIE_ELEMENTO_PRIMARIO", NUM_SERIE_ELEMENTO_PRIMARIO);
                    Tmp = Tmp.Replace("COD_INSTALACAO", COD_INSTALACAO);
                    Tmp = Tmp.Replace("COD_TAG_PONTO_MEDICAO", COD_TAG_PONTO_MEDICAO);

                    
                    // CONFIGURAÇÕES DO CV --------------------------------------------

                    var NUM_SERIE_CV = "0";
                    var VERSAO_SOFTWARE = "0";
                    var NORMA_UTILIZADA_CALCULO = Regex.Match(pdfTxt, @"\sNormas:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    var DENSIDADE_RELATIVA = Regex.Match(pdfTxt, @"\s25\s+-\s+Densidade Relativa\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    
                    Tmp = Tmp.Replace("NUM_SERIE_CV", NUM_SERIE_CV);
                    Tmp = Tmp.Replace("VERSAO_SOFTWARE", VERSAO_SOFTWARE);
                    Tmp = Tmp.Replace("DENSIDADE_RELATIVA", DENSIDADE_RELATIVA);
                    Tmp = Tmp.Replace("NORMA_UTILIZADA_CALCULO", NORMA_UTILIZADA_CALCULO);
                    
                    // Data e Hora da Coleta (AGORA)
                    Tmp = Tmp.Replace("PH_DATA", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    
                    // Cromatografias
                    var METANO = Regex.Match(pdfTxt, @"\s1\s+-\s+Metano\s+-\s+C1\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var NITROGENIO = Regex.Match(pdfTxt, @"\s2\s+-\s+Nitrogênio\s+-\s+N2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var CO2 = Regex.Match(pdfTxt, @"\s3\s+-\s+Dióxido\s+de\s+Carbono\s+-\s+CO2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var ETANO = Regex.Match(pdfTxt, @"\s4\s+-\s+Etano\s+-\s+C2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var PROPANO = Regex.Match(pdfTxt, @"\s5\s+-\s+Propano\s+-\s+C3\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var AGUA = Regex.Match(pdfTxt, @"\s6\s+-\s+Água\s+-\s+H2O\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var H2S = Regex.Match(pdfTxt, @"\s7\s+-\s+Hidrogênio\s+Sulfídrico\s+-\s+H2S\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var HIDROGENIO = Regex.Match(pdfTxt, @"\s8\s+-\s+Hidrogênio\s+-\s+H2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var CO = Regex.Match(pdfTxt, @"\s9\s+-\s+Monóxido de Carbono\s+-\s+CO\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var OXIGENIO = Regex.Match(pdfTxt, @"\s10\s+-\s+Oxigênio\s+-\s+O2\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var I_BUTANO = Regex.Match(pdfTxt, @"\s11\s+-\s+i-Butano\s+-\s+iC4\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var N_BUTANO = Regex.Match(pdfTxt, @"\s12\s+-\s+n-Butano\s+-\s+nC4\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var I_PENTANO = Regex.Match(pdfTxt, @"\s13\s+-\s+i-Pentano\s+-\s+iC5\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var N_PENTANO = Regex.Match(pdfTxt, @"\s14\s+-\s+n-Pentano\s+-\s+nC5\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var HEXANO = Regex.Match(pdfTxt, @"\s15\s+-\s+n-Hexano\s+-\s+nC6\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var HEPTANO = Regex.Match(pdfTxt, @"\s16\s+-\s+n-Heptano\s+-\s+nC7\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var OCTANO = Regex.Match(pdfTxt, @"\s17\s+-\s+n-Octano\s+-\s+nC8\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var NONANO = Regex.Match(pdfTxt, @"\s18\s+-\s+n-Nonano\s+-\s+nC9\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var DECANO = Regex.Match(pdfTxt, @"\s19\s+-\s+n-Decano\s+-\s+nC10\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var HELIO = Regex.Match(pdfTxt, @"\s20\s+-\s+Hélio\s+-\s+He\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;
                    var ARGONIO = Regex.Match(pdfTxt, @"\s21\s+-\s+Argônio\s+-\s+Ar\s+([0-9\,]+)", RegexOptions.Multiline).Groups[1].Value;

                    Tmp = Tmp.Replace("CROMATOGRAFIA_METANO", METANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_NITROGENIO", NITROGENIO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_CO2", CO2);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_ETANO", ETANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_PROPANO", PROPANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_AGUA", AGUA);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_H2S", H2S);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_HIDROGENIO", HIDROGENIO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_CO", CO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_OXIGENIO", OXIGENIO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_I_BUTANO", I_BUTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_N_BUTANO", N_BUTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_I_PENTANO", I_PENTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_N_PENTANO", N_PENTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_HEXANO", HEXANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_HEPTANO", HEPTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_OCTANO", OCTANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_NONANO", NONANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_DECANO", DECANO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_HELIO", HELIO);
                    Tmp = Tmp.Replace("CROMATOGRAFIA_ARGONIO", ARGONIO);


                    // ELEMENTO PRIMÁRIO ---------------------------------------------

                    var ICE_LIMITE_SPRR_ALARME = "0";
                    var ICE_LIMITE_INFRR_ALARME = "0";
                    
                    Tmp = Tmp.Replace("ICE_LIMITE_SPRR_ALARME", ICE_LIMITE_SPRR_ALARME);
                    Tmp = Tmp.Replace("ICE_LIMITE_INFRR_ALARME", ICE_LIMITE_INFRR_ALARME);
                    

                    // INSTRUMENTO DE PRESSÃO --------------------------------------
                    var NUM_SERIE_PRESSAO = "0";
                    var MED_PRSO_LIMITE_SPRR_ALRME = "0";
                    var MED_PRSO_LMTE_INFRR_ALRME = "0";
                    var MED_PRSO_ADOTADA_FALHA = "0";

                    Tmp = Tmp.Replace("NUM_SERIE_PRESSAO", NUM_SERIE_PRESSAO);
                    Tmp = Tmp.Replace("MED_PRSO_LIMITE_SPRR_ALRME", MED_PRSO_LIMITE_SPRR_ALRME);
                    Tmp = Tmp.Replace("MED_PRSO_LMTE_INFRR_ALRME", MED_PRSO_LMTE_INFRR_ALRME);
                    Tmp = Tmp.Replace("MED_PRSO_ADOTADA_FALHA", MED_PRSO_ADOTADA_FALHA);


                    // INSTRUMENTO DE TEMPERATURA --------------------------------------
                    var NUM_SERIE_TEMP = "0";
                    var MED_TMPTA_SPRR_ALARME = "0";
                    var MED_TMPTA_INFRR_ALRME = "0";
                    var MED_TMPTA_ADTTA_FALHA = "0";

                    Tmp = Tmp.Replace("NUM_SERIE_TEMP", NUM_SERIE_TEMP);
                    Tmp = Tmp.Replace("MED_TMPTA_SPRR_ALARME", MED_TMPTA_SPRR_ALARME);
                    Tmp = Tmp.Replace("MED_TMPTA_INFRR_ALRME", MED_TMPTA_INFRR_ALRME);
                    Tmp = Tmp.Replace("MED_TMPTA_ADTTA_FALHA", MED_TMPTA_ADTTA_FALHA);

                  

                    // PLACA DE ORIFICIO -------------------------------------------------
                    
                    // MED_DIAMETRO_REFERENCIA
                    var ORIFICIO  = Regex.Match(pdfTxt, @"\sOrifício:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("MED_DIAMETRO_REFERENCIA", ORIFICIO);
                                        
                    // MED_DMTRO_INTRO_TRCHO_MDCO
                    var TUBO = Regex.Match(pdfTxt, @"\sTubo:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("MED_DMTRO_INTRO_TRCHO_MDCO", TUBO);
                    
                    
                    // DIFERENCIAL DE PRESSAO PRINCIPAL ---------------------------------
                    var NUM_SERIE_DPP = "0";
                    var MED_PRSO_LIMITE_SPRR_ALRME_DPP = "0";
                    var MED_PRSO_LMTE_INFRR_ALRME_DPP = "0";
                    var MED_PRSO_ADOTADA_FALHA_DPP = "0";
                    var MED_CUTOFF_KPA = "0";

                    Tmp = Tmp.Replace("NUM_SERIE_DPP", NUM_SERIE_DPP);
                    Tmp = Tmp.Replace("MED_PRSO_LIMITE_SPRR_ALRME_DPP", MED_PRSO_LIMITE_SPRR_ALRME_DPP);
                    Tmp = Tmp.Replace("MED_PRSO_LMTE_INFRR_ALRME_DPP", MED_PRSO_LMTE_INFRR_ALRME_DPP);
                    Tmp = Tmp.Replace("MED_PRSO_ADOTADA_FALHA_DPP", MED_PRSO_ADOTADA_FALHA_DPP);
                    Tmp = Tmp.Replace("MED_CUTOFF_KPA", MED_CUTOFF_KPA);


                    // PRODUÇÃO -------------------------------------------------------

                    // Data e hora de abertura
                    var AberturaD = Regex.Match(pdfTxt, "Data e hora de abertura:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[1].Value;
                    var AberturaM = MonthToNumber(Regex.Match(pdfTxt, "Data e hora de abertura:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[2].Value);
                    var AberturaA = Regex.Match(pdfTxt, "Data e hora de abertura:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[3].Value;
                    Tmp = Tmp.Replace("PH_DHA_INICIO", AberturaD + "/" + AberturaM + "/" + AberturaA + " 00:00:00");
                    
                    // Data e hora de fechamento
                    var FechamentoD = Regex.Match(pdfTxt, "Data e hora de fechamento:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[1].Value;
                    var FechamentoM = MonthToNumber(Regex.Match(pdfTxt, "Data e hora de fechamento:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[2].Value);
                    var FechamentoA = Regex.Match(pdfTxt, "Data e hora de fechamento:.*([0-9]{2})/([A-z]{3})/([0-9]{4})", RegexOptions.Multiline).Groups[3].Value;
                    Tmp = Tmp.Replace("PH_DHA_FIM", FechamentoD + "/" + FechamentoM + "/" + FechamentoA + " 00:00:00");                    
                    
                    // Diferencial de Pressão
                    var DBWA = Regex.Match(pdfTxt, @"\sDBWA:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_DBWA", DBWA);
                    
                    // Pressão Estática
                    var PWA = Regex.Match(pdfTxt, @"\sPWA:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_PWA", PWA);
                    
                    // Temperatura do Fluido
                    var TWA = Regex.Match(pdfTxt, @"\sTWA:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("PH_TWA", TWA);

                    // Duração do Fluxo
                    var DUR_FLUXO = "1440,0000";
                    Tmp = Tmp.Replace("DURACAO_FLUXO_EFETIVO", DUR_FLUXO);

                    //MED_CORRIGIDO_MVMDO
                    var QB = Regex.Match(pdfTxt, @"\sTOT\s+QB:\s+=\s+GSV\s+\-\s+NSV:\s+([0-9\,]+)", RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline).Groups[1].Value;
                    Tmp = Tmp.Replace("MED_CORRIGIDO_MVMDO", QB);


                    System.IO.File.WriteAllText(pdf + ".xml", Tmp);


                // _____________________________________________________________________________________________________________________________________________________________________________

                } else if (pdf.ToLower().Contains("audittrail")) {
                    Tmp = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.AlarmeFull.txt");

                    Regex regexObj = new Regex(@"(ID#)\s+(Data\s/\sHora)\s+(Vazão#)\s+(Tag do Bloco)\s+(Parâmetro)\s+(Encontrado)\s+(Deixado)\s+(Usuário:)", RegexOptions.Multiline);
                    var rGr = regexObj.Match(pdfTxt);

                    int idxId = rGr.Groups[1].Index;
                    int idxDataHora = rGr.Groups[2].Index;
                    int idxVazao = rGr.Groups[3].Index - idxDataHora;
                    int idxTagBloco = rGr.Groups[4].Index - idxDataHora;
                    int idxParametro = rGr.Groups[5].Index - idxDataHora;
                    int idxEncontrado = rGr.Groups[6].Index - idxDataHora;
                    int idxDeixado = rGr.Groups[7].Index - idxDataHora;
                    int idxUsuario = rGr.Groups[8].Index - idxDataHora;
                    idxDataHora = 0;

                    var SBA = new System.Text.StringBuilder();

                    Regex regexObjI = new Regex(@"\[.+\]\s[0-9]{2}/[A-z]{3}/[0-9]{2}\s[0-9]{2}:[0-9]{2}:[0-9]{2}.*", RegexOptions.Multiline);
                    Match matchResult = regexObjI.Match(pdfTxt);
                    while (matchResult.Success)
                    {
                        var Linha = matchResult.Value;

                        var sData = Linha.Substring(idxDataHora, 27).Trim();
                        var sOriginal = Linha.Substring(idxEncontrado, 16).Trim();
                        var sModificado = Linha.Substring(idxDeixado, 32).Trim();
                        var sTag = Linha.Substring(idxTagBloco, 15).Trim();
                        var sParametro = Linha.Substring(idxParametro, 22).Trim();


                        SBA.AppendLine(@"<EVENTOS><DSC_DADO_ALTERADO>" + sTag + " - " + sParametro + "</DSC_DADO_ALTERADO><DSC_CONTEUDO_ORIGINAL>" + sOriginal + "</DSC_CONTEUDO_ORIGINAL><DSC_CONTEUDO_ATUAL>" + sModificado + "</DSC_CONTEUDO_ATUAL><DHA_OCORRENCIA_EVENTO>" + DataShif(sData) + "</DHA_OCORRENCIA_EVENTO></EVENTOS>");
                        matchResult = matchResult.NextMatch();
                    }

                    Tmp = Tmp.Replace("PHALARMES", "");
                    Tmp = Tmp.Replace("PHEVENTOS", SBA.ToString());
                    Tmp = Tmp.Replace("PHCOMPVAZAO", "");
                    Tmp = Tmp.Replace("PHCODINSTALACAO", "");

                    System.IO.File.WriteAllText(pdf + ".xml", Tmp);



                } else if (pdf.ToLower().Contains("alarmes")) {
                    Tmp = Helper.ReadResource("Horizzon3REnergySysPDFtoXML.Templates.AlarmeFull.txt");

                    Regex regexObj = new Regex(@"(ID#)\s+(Data\s/\sHora)\s+(Vazão#)\s+(Tag do Bloco)\s+(Variável)\s+(Tipo de Alarme)\s+(Prioridade)\s(Valor)", RegexOptions.Multiline);
                    var rGr= regexObj.Match(pdfTxt);

                    int idxId = rGr.Groups[1].Index;
                    int idxDataHora = rGr.Groups[2].Index;
                    int idxVazao = rGr.Groups[3].Index - idxDataHora;
                    int idxTagBloco = rGr.Groups[4].Index - idxDataHora;
                    int idxVariavel = rGr.Groups[5].Index - idxDataHora;
                    int idxTipoAlarme = rGr.Groups[6].Index - idxDataHora;
                    int idxPrioridade = rGr.Groups[7].Index - idxDataHora;
                    int idxValor = rGr.Groups[8].Index - idxDataHora;
                    idxDataHora = 0;

                    var SBA = new System.Text.StringBuilder();

                    Regex regexObjI = new Regex(@"\[.+\]\s[0-9]{2}/[A-z]{3}/[0-9]{2}\s[0-9]{2}:[0-9]{2}:[0-9]{2}.*", RegexOptions.Multiline);
                    Match matchResult = regexObjI.Match(pdfTxt);
                    while (matchResult.Success) {
                        var Linha = matchResult.Value;

                        var sData = Linha.Substring(idxDataHora, 27).Trim();
                        var sTag = Linha.Substring(idxTagBloco, 30).Trim();
                        var sTipo = Linha.Substring(idxTipoAlarme, 29).Trim();
                        var sValor = Linha.Substring(idxValor).Trim();

                        SBA.AppendLine(@"<ALARMES><DSC_DADO_ALARMADO>" + sTag + " - " + sTipo + "</DSC_DADO_ALARMADO><DHA_ALARME>" + DataShif(sData) + "</DHA_ALARME><DSC_MEDIDA_ALARMADA>" + sValor + "</DSC_MEDIDA_ALARMADA></ALARMES>");
                        matchResult = matchResult.NextMatch();
                    }

                    Tmp = Tmp.Replace("PHALARMES", SBA.ToString());
                    Tmp = Tmp.Replace("PHEVENTOS", "");
                    Tmp = Tmp.Replace("PHCOMPVAZAO", "");
                    Tmp = Tmp.Replace("PHCODINSTALACAO", "");

                    System.IO.File.WriteAllText(pdf + ".xml", Tmp);
                } else {
                    System.Windows.Forms.MessageBox.Show("Não implementado o conversor para o arquivo: " + pdf + ".");
                }

                int p = 9;
            }
        }
        public static string DataShif(string val) {
            var rf1 = Regex.Match(val, @"\[.+\]\s([0-9]{2})/([A-z]{3})/([0-9]{2})\s([0-9]{2}):([0-9]{2}):([0-9]{2})", RegexOptions.Multiline);
            return "20" + rf1.Groups[3].Value + "-" + MonthToNumber(rf1.Groups[2].Value) + "-" + rf1.Groups[1].Value + " " + rf1.Groups[4].Value + ":" + rf1.Groups[5].Value + ":" + rf1.Groups[6].Value;
        }
        public static string MonthToNumber(string Val)
        {
            if (Val == "jan")
            {
                return "01";
            }
            if (Val == "fev")
            {
                return "02";
            }
            if (Val == "mar")
            {
                return "03";
            }
            if (Val == "abr")
            {
                return "04";
            }
            if (Val == "mai")
            {
                return "05";
            }
            if (Val == "jun")
            {
                return "06";
            }
            if (Val == "jul")
            {
                return "07";
            }
            if (Val == "ago")
            {
                return "08";
            }
            if (Val == "set")
            {
                return "09";
            }
            if (Val == "out")
            {
                return "10";
            }
            if (Val == "nov")
            {
                return "11";
            }
            if (Val == "dez")
            {
                return "12";
            }
            return "";
        }
        public static string MonthToNumberUS(string Val)
        {
            Val = Val.ToLower();
            if (Val == "jan")
            {
                return "01";
            }
            if (Val == "feb")
            {
                return "02";
            }
            if (Val == "mar")
            {
                return "03";
            }
            if (Val == "apr")
            {
                return "04";
            }
            if (Val == "may")
            {
                return "05";
            }
            if (Val == "jun")
            {
                return "06";
            }
            if (Val == "jul")
            {
                return "07";
            }
            if (Val == "aug")
            {
                return "08";
            }
            if (Val == "sep")
            {
                return "09";
            }
            if (Val == "oct")
            {
                return "10";
            }
            if (Val == "nov")
            {
                return "11";
            }
            if (Val == "dec")
            {
                return "12";
            }
            return "";
        }
    }
}
