using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Engine_Interface.Project;
using Test_Engine_Interface.Object;
namespace Test_Engine_Interface
{
    public partial class TestEngineInterface : Form
    {
        //define vars
        GameProject project;

        public TestEngineInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up  project
            project = new GameProject();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit the form
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void project_treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //check to see which thing is selected and then open a menu accordingly
            if(e.Button == MouseButtons.Right)
            {
                
            }
        }

        private void objectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a new object and add it to the tree
            project.addObject(new Object.GameObject());
            project_treeView.Nodes.Add("New object");
        }

        private void project_treeView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.ToUpper(e.KeyChar)== (char)Keys.A)
            {
                TreeNode node;
                //delete the selected node
                if(( node = project_treeView.SelectedNode) != null) node.Remove();
               
                //delete it from the project as well
                //check to see which section is selected to delete it
            }
        }

        private void project_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        //updaeObject-- updates the passed in object, meant to be used by object editor windows
        public void updateObject(GameObject gameObject, int index)
        {

        }
    }
}
