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

        private void accept_button_Click(object sender, EventArgs e)
        {
            string data;
            data = in_rtxbox.Text;
            //split data into lines
            string[] lines = data.Split('\n');
            //parse the arguments in the object text box and add them to the object
            foreach (string line in lines)
            {
                //split the line into arguments
                string[] args = line.Split(' ');
                //go trough the list and see if its an argument
                switch(args[0])
                {
                    case "int":
                        {
                            //add new data to the object if it does not already exist
                            if (!m_gameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                m_gameObject.addInteger(args[1]);
                            }
                            break;
                        }
                    case "short":
                        {
                            //add new data to the object if it does not already exist
                            if (!m_gameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                m_gameObject.addShort(args[1]);
                            }
                            break;
                        }
                    case "double":
                        {
                            //add new data to the object if it does not already exist
                            if (!m_gameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                m_gameObject.addDoubles(args[1]);
                            }
                            break;
                        }
                    case "float":
                        {
                            //add new data if it does not already exist
                            if(!m_gameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                m_gameObject.addFloat(args[1]);
                            }
                            break;
                        }
                    case "byte":
                        {
                            //add new data if it does not already exist
                            if(!m_gameObject.containsData(args[1]))
                            {
                                //it does nto exist so add it
                                m_gameObject.addByte(args[1]);

                            }
                            break;
                        }
                    case "long":
                        {
                            //add new data to the object if it does not already exist
                            if(!m_gameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                m_gameObject.addLong(args[1]);
                            }
                            break;
                        }
                    case "string":
                        {
                            //add new data to the object if it does not already exist
                            if(!m_gameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                m_gameObject.addString(args[1]);
                            }
                            break;
                        }
                    case "char":
                        {
                            //add new data to the object if it does not exist already
                            if(!m_gameObject.containsData(args[1]))
                            {
                                //it does nto exist so add it
                                m_gameObject.addChar(args[1]);
                            }
                            break;
                        }

                }
            }
            //done with object so edit it
            //dispose of this form
            this.Dispose();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
