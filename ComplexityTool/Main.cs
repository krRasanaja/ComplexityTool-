using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComplexityTool.Size;

namespace ComplexityTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        SizeComplexity sComplex = new SizeComplexity();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            GlobalData.ExtendCount = 0;

            String code = txtCode.Text.ToString();
            String line;
            int scoreCs;
            int totalCs = 0;
            int totalExtendCount = 0;

            //Read line by line
            for (int i = 0; i < txtCode.Lines.Length; i++)
            {
                line = txtCode.Lines[i];

                //call method to calculate score
                scoreCs = sComplex.operatorsScore(line);

                //add to datagrid view
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = i + 1;
                dataGridView.Rows[i].Cells[1].Value = line;
                dataGridView.Rows[i].Cells[2].Value = scoreCs;
                if(GlobalData.isExtendedRow)
                {

                    dataGridView.Rows[i].Cells[9].Value = GlobalData.ExtendCount;
                    totalExtendCount = totalExtendCount + GlobalData.ExtendCount;
                }
                else
                {

                    dataGridView.Rows[i].Cells[9].Value = "0";
                }

                if (GlobalData.isInsideOfBrackets)
                {
                    dataGridView.Rows[i].Cells[9].Value = GlobalData.ExtendValueinsideBra;
                    totalExtendCount = totalExtendCount + GlobalData.ExtendValueinsideBra;
                    GlobalData.ExtendValueinsideBra = 0;
                    GlobalData.isInsideOfBrackets = false;
                }

                //calculate total score
                totalCs =  totalCs + scoreCs;
                //totalExtendCount = totalExtendCount + GlobalData.ExtendCount + GlobalData.ExtendValueinsideBra;
                GlobalData.isExtendedRow = false;
                GlobalData.ExtendCount = 0;
            }

            //display total score
            txtSizeScore.Text = totalCs.ToString();
            lblExtendCount.Text = totalExtendCount.ToString();
        }

        //Right click menu for richtextbox
        private void txtCode_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                MenuItem menuItem = new MenuItem("Cut");
                menuItem.Click += new EventHandler(CutAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Copy");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Paste");
                menuItem.Click += new EventHandler(PasteAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Select All");
                menuItem.Click += new EventHandler(SelectAll);
                contextMenu.MenuItems.Add(menuItem);
                txtCode.ContextMenu = contextMenu;
            }
        }

        void CutAction(object sender, EventArgs e)
        {
            txtCode.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            if(txtCode.SelectedText == "")
            {
                
                Clipboard.Clear();
            }
            else
            {
                Clipboard.SetText(txtCode.SelectedText);
            }
                   
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtCode.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }

        void SelectAll(object sender, EventArgs e)
        {
            txtCode.SelectAll();
            txtCode.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GlobalData.bracketsList.Clear();
            GlobalData.className = string.Empty;
            GlobalData.ExtendCount = 0;
            GlobalData.ExtendValueinsideBra = 0;
            GlobalData.isExtendedRow = false;
            GlobalData.isInsideOfBrackets = false;
            GlobalData.list.Clear();
            txtCode.Text = string.Empty;
            dataGridView.Rows.Clear();
        }
    }
}
