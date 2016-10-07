using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_15_I_N
{
    class Conexao
    {
        static FbConnection fbCnn;
        static FbCommandBuilder fbCmm = new FbCommandBuilder();

        public static FbConnection FbCnn{
            get { return fbCnn; }
        }

        public static FbCommandBuilder FbCmm{
            get { return fbCmm; }
        }

        public static Boolean Active (Boolean bActive){
            if (bActive){
                string _conn;
                _conn = "User=SYSDBA;Password=masterkey;"
                                 + @"Database=C:\Fatec\Ads\LES_16_I_N\Dados.fdb;"
                                 + "DataSource=localhost;Port=3050;"
                                 + "Dialect=3;Charset=WIN1252;Role=;"
                                 + "Connection lifetime=0;"
                                 + "Connection timeout=15;"
                                 + "Pooling=True;Packet"
                                 + " Size=16384;Server Type=0";
                fbCnn = new FbConnection(_conn);
                try{
                fbCnn.Open();
                return true;
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else {
                fbCnn.Close();
                return false;
            }
        }
    }
}
