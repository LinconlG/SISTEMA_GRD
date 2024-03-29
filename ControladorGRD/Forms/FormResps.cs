﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControladorGRD.Entities;

namespace ControladorGRD.Forms
{
    public partial class FormResps : Form
    {

        string id;
        public FormResps(string id)
        {
            InitializeComponent();
            this.id = id;
            Exibir(id);
        }

        private void listResp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exibir(string id)
        {
            try
            {
                listResp.View = View.Details;
                listResp.GridLines = true;
                listResp.FullRowSelect = true;

                listResp.Columns.Add("Nome", 150, HorizontalAlignment.Left);
                listResp.Columns.Add("Data de recebimento", 130, HorizontalAlignment.Left);

                ConnectSQL.Connect();

                ConnectSQL.cmd.CommandText = $"SELECT nome, dataEntrega FROM recebimento WHERE grdId='{id}'";

                //ConnectSQL.//cmd.Prepare();
                SqlDataReader reader = ConnectSQL.cmd.ExecuteReader();
                string[] row = new string[2];
                while (reader.Read())
                {

                    row[0] = reader.GetString(0);

                    if (reader.IsDBNull(1) != true)
                    {
                        if (reader.GetString(1).Substring(0, 10) == "11/11/1111")
                        {
                            row[1] = "GRD não recebida";
                        }
                        else
                        {
                            row[1] = reader.GetString(1).Substring(0, 10);
                        }
                        
                    }
                    else
                    {
                        row[1] = "";
                    }


                    var linha = new ListViewItem(row);
                    listResp.Items.Add(linha);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                ConnectSQL.conexao.Close();
            }
        }
    }
}
