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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Test_Engine_Interface.Serialization;

namespace Test_Engine_Interface
{
    [Serializable]
    public partial class TestEngineInterface : Form
    {
        //define vars
        GameProject project;
        string m_filePath = null;
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

            //open object editor
            ObjectForm of = new ObjectForm(project.getObject(project_treeView.SelectedNode.Index),
                project_treeView.SelectedNode.Index,this);
            
            of.Visible = true;
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
                project.deleteObject(node.Index);
                //check to see which section is selected to delete it
            }
        }

        private void project_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        //updaeObject-- updates the passed in object, meant to be used by object editor windows
        public void updateObject(GameObject gameObject, int index)
        {
            project.updateObject(gameObject,index);
            //now update the tree
            project_treeView.Nodes[index].Text = gameObject.getName();
        }

        public void serialize()
        {
            if(m_filePath == null)
            {
                //open file chooser dialog to save the project
                SaveFileDialog save = new SaveFileDialog();
                DialogResult result = save.ShowDialog();
                //store the choosen file path if on was accepted
                if(result == DialogResult.OK)
                {
                    //stroe the file path and continue
                    m_filePath = save.FileName;

                }
                else
                {
                    //dont do anything and return
                    return;
                }
            }

            Serializer serializer = new Serializer();
            List<string> objects = new List<string>();
            for (int i = 0; i < project_treeView.Nodes.Count; i++)
            {
                objects.Add(project_treeView.Nodes[i].Text);
            }
            serializer.setObjects(objects.ToArray());
            serializer.setProject(project);
            //serialize
            serializer.serialize(m_filePath + ".tprj");

            
        }

        public void serializeAs()
        {
            string filepath;
            //open file chooser dialog to save the project
            SaveFileDialog save = new SaveFileDialog();
            DialogResult result = save.ShowDialog();
            //store the choosen file path if on was accepted
            if (result == DialogResult.OK)
            {
                //stroe the file path and continue
                filepath = save.FileName;

            }
            else
            {
                //dont do anything and return
                return;
            }

            Serializer serializer = new Serializer();
            List<string> objects = new List<string>();
            for(int i = 0;i < project_treeView.Nodes.Count;i++)
            {
                objects.Add(project_treeView.Nodes[i].Text);
            }
            serializer.setObjects(objects.ToArray());
            serializer.setProject(project);
            //serialize
            serializer.serialize(filepath + ".tprj");
        }

        public void open()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to load?(any unsaved progress will be lost)", "Confirmation", MessageBoxButtons.OKCancel);
            if(result == DialogResult.Cancel)
            {
                return;
            }
            //open the file dialog
            string filepath;
            OpenFileDialog open = new OpenFileDialog();
            result = open.ShowDialog();
            if(result == DialogResult.OK)
            {
                Serializer serializer = new Serializer();
                serializer.Unserialize(open.FileName);
                copy(serializer);
            }
        
        }

        public void copy(Serializer serializer)
        {
            //copy info from on to another
            this.project = serializer.getProject();
            //now copy each of the objects into the list of nodes
            foreach(string str in serializer.getObjects())
            {
                project_treeView.Nodes.Add(new TreeNode(str));
            }
            //data is now copied
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open
            open();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //save 
            serialize();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serializeAs();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to start a new project?(any unsaved progress will be lost)", "Confirmation", MessageBoxButtons.OKCancel);
            if(result == DialogResult.Cancel)
            {
                return;
            }

            //clear the form
            project_treeView.Nodes.Clear();
            project = new GameProject();
        }

        public GameProject getProject()
        {
            return project;
        }
    }
}
