using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class Save:Form1
    {
        public DataTable SaveFile(DataTable table,char delimiter)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                string path = sfd.FileName;
                TextWriter writer = new StreamWriter(path);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            writer.Write(table.Rows[i].ItemArray[j].ToString() + delimiter);
                            
                        }
                        writer.Write("\n");
                    }
                    writer.Close();
                    MessageBox.Show("Data Exported");
                    
                }
                return table;
            }
        }
    }
}
