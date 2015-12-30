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
using Test_Engine_Interface.Project;

namespace Test_Engine_Interface
{
    public partial class GlobalsForm : Form
    {
     //instance vars   
        private TestEngineInterface m_parent;
        public GlobalsForm(TestEngineInterface parent)
        {
            InitializeComponent();
            m_parent = parent;
            //set the text of the globals
            List<string> types = new List<string>();
            List<string> vars = new List<string>();

            Dictionary<string, GameProject.GameData.Data> data = m_parent.getProject().getGlobals();
            //get strings
            foreach (GameProject.GameData.Data d in data.Values)
            {
                //get type
                switch((GameObject.TYPE)d.data)
                {
                    case GameObject.TYPE.BOOL:
                        {
                            //write bool
                            types.Add("bool");
                            break;
                        }
                    case GameObject.TYPE.BYTE:
                        {
                            //write byte
                            types.Add("byte");
                            break;
                        }
                    case GameObject.TYPE.CHAR:
                        {
                            //write char
                            types.Add("char");
                            break;
                        }
                    case GameObject.TYPE.DOUBLE:
                        {
                            //write double
                            types.Add("double");
                            break;
                        }
                    case GameObject.TYPE.FLOAT:
                        {
                            //write float
                            types.Add("float");
                            break;
                        }
                    case GameObject.TYPE.INTEGER:
                        {
                            //write integer
                            types.Add("int");
                            break;
                        }
                    case GameObject.TYPE.SHORT:
                        {
                            //write short
                            types.Add("short");
                            break;
                        }
                    case GameObject.TYPE.STRING:
                        {
                            //write string
                            types.Add("string");
                            break;
                        }
                }
            }

            //now get names
            foreach (string name in data.Keys)
            {
                vars.Add(name);
            }

            //now set the proper text in the text box
            StringBuilder strBuild = new StringBuilder();
            for(int i = 0;i < types.Count;i++)
            {
                strBuild.Append(types[i]);
                strBuild.Append(" ");
                strBuild.Append(vars[i]);
                strBuild.Append("\n");
            }

            //finally set the text
            globals_textBox.Text = strBuild.ToString();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
