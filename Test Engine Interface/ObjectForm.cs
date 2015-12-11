using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Engine_Interface.Object;
namespace Test_Engine_Interface
{
    public partial class ObjectForm : Form
    {
        //instance vars
        GameObject m_gameObject;
        TestEngineInterface m_parent;
        int m_index;

        public ObjectForm(GameObject gameObject,int index,TestEngineInterface parent)
        {
            InitializeComponent();
            //store gameObject
            m_gameObject = gameObject;
            //stroe index
            m_index = index;
            m_parent = parent;
        }

        private void ObjectForm_Load(object sender, EventArgs e)
        {

        }


        
    }
}
