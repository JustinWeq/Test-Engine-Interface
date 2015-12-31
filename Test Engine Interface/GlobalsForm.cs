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
                    case GameObject.TYPE.LONG:
                        {
                            //write long
                            types.Add("long");
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

        private void save_button_Click(object sender, EventArgs e)
        {
            //clear the old globals to make way for the new ones
            m_parent.getProject().clearGlobals();
            //save the form
            string[] lines = globals_textBox.Text.Split('\n');
            foreach (string line in lines)
            {
                //split the line into args
                string[] args = line.Split(' ');

                //reag the args
                switch(args[0])
                {
                    case "bool":
                        {
                            //add new bool
                            m_parent.getProject().addGlobal(args[1], GameObject.TYPE.BOOL);
                            break;

                        }

                    case "byte":
                        {
                            //add new byte
                            m_parent.getProject().addGlobal(args[1], GameObject.TYPE.BYTE);
                            break;
                        }
                    case "char":
                        {
                            //add new char
                            m_parent.getProject().addGlobal(args[1], GameObject.TYPE.CHAR);
                            break;
                        }
                    case "double":
                        {
                            //add new double
                            m_parent.getProject().addGlobal(args[1], GameObject.TYPE.DOUBLE);
                            break;
                        }
                    case "float":
                        {
                            //add new float
                            m_parent.getProject().addGlobal(args[1], GameObject.TYPE.FLOAT);
                            break;
                        }
                    case "int":
                        {
                            //add new integer
                            m_parent.getProject().addGlobal(args[1], GameObject.TYPE.INTEGER);
                            break;
                        }
                    case "short":
                        {
                            //add new short
                            m_parent.getProject().addGlobal(args[1], GameObject.TYPE.SHORT);
                            break;
                        }
                    case "string":
                        {
                            //add new string
                            m_parent.getProject().addGlobal(args[1], GameObject.TYPE.STRING);
                            break;
                        }
                    case "long":
                        {
                            //add new long
                            m_parent.getProject().addGlobal(args[1], GameObject.TYPE.LONG);
                            break;
                        }
                }
            }
            //all vars have been saved so close the form
            this.Close();
        }
    }
}
