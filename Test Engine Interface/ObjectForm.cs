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

        public ObjectForm( GameObject gameObject,int index,TestEngineInterface parent)
        {
            InitializeComponent();
            //store gameObject
            m_gameObject = gameObject;
            //store index
            m_index = index;
            m_parent = parent;
        }

        private void ObjectForm_Load(object sender, EventArgs e)
        {
            //read in the data for the object
            //set up paralels array for names and data
            List<string> types = new List<string>();
            List<string> names = new List<string>();
            //get bytes
            foreach(string name in m_gameObject.getList("byte").Keys)
            {
                types.Add("byte");
                names.Add(name);
            }
            //get shorts
            foreach(string name in m_gameObject.getList("short").Keys)
            {
                types.Add("short");
                names.Add(name);
            }
            //get integers
            foreach(string name in m_gameObject.getList("int").Keys)
            {
                types.Add("int");
                names.Add(name);
            }
            //get longs
            foreach(string name in m_gameObject.getList("long").Keys)
            {
                types.Add("long");
                names.Add(name);
            }
            //get floats
            foreach(string name in m_gameObject.getList("float").Keys)
            {
                types.Add("float");
                names.Add(name);
            }
            //get doubles
            foreach(string name in m_gameObject.getList("double").Keys)
            {
                types.Add("float");
                names.Add(name);
            }
            //get bools
            foreach(string name in m_gameObject.getList("bool").Keys)
            {
                types.Add("bool");
                names.Add(name);
            }
            //get strings
            foreach(string name in m_gameObject.getList("string").Keys)
            {
                types.Add("string");
                names.Add(name);
            }
            //get chars
            foreach(string name in m_gameObject.getList("char").Keys)
            {
                types.Add("char");
                names.Add(name);
            }
            StringBuilder strBuilder = new StringBuilder();
            //now build the text
            for(int i = 0;i < names.Count;i++)
            {
                strBuilder.Append(types[i] + " " + names[i] + "\n");
            }

            //now set the text in the form
            in_rtxbox.Text = strBuilder.ToString();

            //set the name of the text box
            name_textBox.Text = m_gameObject.getName();



        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            GameObject newGameObject = new GameObject();
            string data;
            data = in_rtxbox.Text;
            //get the type of the object
            if(controller_radioButton.Checked)
            {
                //its a control so set the new objects type and add no extra data
                GameObject.ObjectType type = GameObject.ObjectType.CONTROL;
                newGameObject.setObjectType(type);
            }
            else
            if(radioButton2D.Checked)
            {
                GameObject.ObjectType type = GameObject.ObjectType.TWODIMENSIONAL;
                //set object to be two dimensional
                newGameObject.setObjectType(type);
                //add nesssary two dimensional data
                newGameObject.addFloat("x");
                newGameObject.addFloat("y");
                newGameObject.addFloat("direction");
                newGameObject.addFloat("speed");
                newGameObject.addFloat("image_angle");
                newGameObject.addFloat("height");
                newGameObject.addFloat("width");
                newGameObject.addFloat("red");
                newGameObject.addFloat("green");
                newGameObject.addFloat("blue");
                newGameObject.addFloat("alpha");
                newGameObject.addFloat("uv_add");
                newGameObject.addFloat("uv_multiply");
                newGameObject.addFloat("gravity_direction");
                newGameObject.addFloat("gravity_speed");
                newGameObject.addFloat("friction");
            }
            else
            if(radioButton3D.Checked)
            {
                GameObject.ObjectType type = GameObject.ObjectType.THREEDIMENSIONAL;
                newGameObject.setObjectType(type);
            }
            else
            {
                //its a control by defualt so set the new objects type and add no extra data
                GameObject.ObjectType type = GameObject.ObjectType.CONTROL;
                newGameObject.setObjectType(type);
            }
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
                            if (!newGameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                newGameObject.addInteger(args[1]);
                            }
                            break;
                        }
                    case "short":
                        {
                            //add new data to the object if it does not already exist
                            if (!newGameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                newGameObject.addShort(args[1]);
                            }
                            break;
                        }
                    case "double":
                        {
                            //add new data to the object if it does not already exist
                            if (!newGameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                newGameObject.addDoubles(args[1]);
                            }
                            break;
                        }
                    case "float":
                        {
                            //add new data if it does not already exist
                            if(!newGameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                newGameObject.addFloat(args[1]);
                            }
                            break;
                        }
                    case "byte":
                        {
                            //add new data if it does not already exist
                            if(!newGameObject.containsData(args[1]))
                            {
                                //it does nto exist so add it
                                newGameObject.addByte(args[1]);

                            }
                            break;
                        }
                    case "long":
                        {
                            //add new data to the object if it does not already exist
                            if(!newGameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                newGameObject.addLong(args[1]);
                            }
                            break;
                        }
                    case "string":
                        {
                            //add new data to the object if it does not already exist
                            if(!newGameObject.containsData(args[1]))
                            {
                                //it does not exist so add it
                                newGameObject.addString(args[1]);
                            }
                            break;
                        }
                    case "char":
                        {
                            //add new data to the object if it does not exist already
                            if(!newGameObject.containsData(args[1]))
                            {
                                //it does nto exist so add it
                                newGameObject.addChar(args[1]);
                            }
                            break;
                        }

                }
            }

            //set the name of the object
            newGameObject.setName(name_textBox.Text);
            //now get the type of the object selected so it can be constructed accordingly

            //done with object so edit it
            m_parent.updateObject(newGameObject, m_index);
            //dispose of this form
            this.Dispose();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
