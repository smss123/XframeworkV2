using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.ControlX
{
    public class xControls
    {

        #region " DataGridView Style "
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Dgv">DataGridView Name</param>
        public static void GridStyle(DataGridView Dgv)
        {
            Dgv.Cursor = Cursors.Hand;
            Dgv.RowHeadersWidth = 70;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow R in Dgv.Rows)
            {
                R.HeaderCell.Value = (R.Index + 1).ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Dgv">DataGridView Name</param>
        public static void GridFullStyle(DataGridView Dgv)
        {
            Dgv.Cursor = Cursors.Hand;
            Dgv.ReadOnly = true;
            Dgv.AllowUserToAddRows = false;
            Dgv.GridColor = Color.Red;
            Dgv.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            Dgv.BackgroundColor = Color.Goldenrod;
            Dgv.DefaultCellStyle.SelectionBackColor = Color.Green;
            Dgv.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.AllowUserToResizeColumns = false;
            Dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            Dgv.RowHeadersWidth = 70;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow R in Dgv.Rows)
            {
                R.HeaderCell.Value = (R.Index + 1).ToString();
            }
        }
        #endregion

        public static void ClearTextControls(Form CurrentForm)
        {
            foreach (Control item in CurrentForm.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }

                if (item is RichTextBox)
                {
                    ((RichTextBox)item).Clear();
                }

                if (item is ComboBox)
                {
                    ((ComboBox)item).Text = null;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="TargetTextBox">TextBox Name </param>
        /// <param name="e">Insert e Only</param>
        public static void NumbersOnly(TextBox TargetTextBox, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && TargetTextBox.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

    }
}
