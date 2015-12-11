using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Engine_Interface.Object;
namespace Test_Engine_Interface.Script
{
    //Script-- a static class that contains methods and propertys for
    // exporting scripts in a binary format

    public static class Script
    {
        private  enum Operator
        {
            EQUALS,
            PLUS,
            MINUS,
            MULTIPLY,
            DEVIDE,
            LESSTHEN,
            GREATERTHEN,
            NOT,
            ISEQUAL
        }

        private enum Type
        {
            SIZE,
            BYTE,
            STRING,
            LITERAL,
            CHAR,
            INT,
            FLOAT,
            DOUBLE,
            LONG,
            BOOL,
            SHORT,
            OPERATOR,
            IF,
            DO,
            WHILE,
            GLOBAL
           
        }

        private class ARG
        {
            public Type m_type;
            public object m_data;
        }


        //Write-- writes the passed in scipt out in in binary
        //script- the script to compile and write
        //fileout- the file to write out
        public static void Write(string script,string fileout,GameObject go)
        {
            //set up list of bytes to be written out
            List<byte> binlist = new List<byte>();
            //set up list of data to be written out to the script
            List<ARG> args = new List<ARG>();
            

            //break script into lines
            string[] lines = script.Split('\n');
            for(int i = 0;i < lines.Count();i++)
            {
                //read line
                string[] argss = lines[i].Split(' ');

                //add the number of args to the line
                ARG size = new ARG();
                size.m_type = Type.SIZE;
                size.m_data = argss.Count();
                //add size
                args.Add(size);

                //get the first
                switch (argss[0])
                {
                    case "do":
                        {
                           
                            //read next arg as literal
                            //write args
                            ARG  arg1 = new ARG(), arg2 = new ARG(),argt = new ARG();
                            arg1.m_data = null;
                            arg1.m_type = Type.DO;
                            arg2.m_type = Type.LITERAL;
                            argt.m_type = Type.INT;
                            argt.m_data = int.Parse(argss[0]);
                            arg2.m_data = argt;
                            args.Add(arg1);
                            args.Add(arg2);

                            //get how many lines there are
                            int count = 0;
                            bool flag = false;
                            while(!flag)
                            {
                                string[] nargss = lines[i + count].Split(' ');
                                if(nargss[0] == "end")
                                {
                                    flag = true;
                                }

                                count++;
                            }

                            //add the number of lines as a new argument to the end
                            ARG linecount = new ARG();
                            linecount.m_type = Type.SIZE;
                            linecount.m_data = count;

                            args.Add(linecount);
                            break;
                        }

                    case "while":
                        {
                            //data is a while loop


                            if (args.Count > 3)
                            {
                                //there is more then a single argument so get each one
                                bool op = false;
                                for (int index = 0; index < args.Count; index++)
                                {
                                    ARG arg1;
                                    if (op)
                                    {
                                        arg1 = getOperator(argss[index], go);
                                    }
                                    else
                                    {
                                        arg1 = getArg(argss[index], go);
                                    }

                                    args.Add(arg1);
                                }
                            }
                            else
                            {
                                //display a message box saying the was not enough arguments and return
                                MessageBox.Show("Not enough arguments for while loop on line " + i+ " in script " + script);
                                //return since there was an error parsing
                                return;
                            }

                            //get how many lines there are
                            int count = 0;
                            bool flag = false;
                            while (!flag)
                            {
                                string[] nargss = lines[i + count].Split(' ');
                                if (nargss[0] == "end")
                                {
                                    flag = true;
                                }

                                count++;
                            }

                            //add the number of lines as a new argument to the end
                            ARG linecount = new ARG();
                            linecount.m_type = Type.SIZE;
                            linecount.m_data = count;

                            args.Add(linecount);
                            break;
                        }

                    case "if":
                        {
                            //conditional statement
                            if (args.Count > 3)
                            {
                                //there is more then a single argument so get each one
                                bool op = false;
                                for (int index = 0; index < args.Count; index++)
                                {
                                    ARG arg1;
                                    if (op)
                                    {
                                        arg1 = getOperator(argss[index], go);
                                    }
                                    else
                                    {
                                        arg1 = getArg(argss[index], go);
                                    }

                                    args.Add(arg1);
                                }

                                //get how many lines there are
                                int count = 0;
                                bool flag = false;
                                while (!flag)
                                {
                                    string[] nargss = lines[i + count].Split(' ');
                                    if (nargss[0] == "end")
                                    {
                                        flag = true;
                                    }

                                    count++;
                                }

                                //add the number of lines as a new argument to the end
                                ARG linecount = new ARG();
                                linecount.m_type = Type.SIZE;
                                linecount.m_data = count;

                                args.Add(linecount);
                            }
                            else
                            {
                                //display a message box saying the was not enough arguments and return
                                MessageBox.Show("Not enough arguments for if statement on line " + i + " in script " + script);
                                //return since there was an error parsing
                                return;
                            }

                            break;
                        }

                    default:
                        {
                            //it was either a comment or a variable so write the script accordingly
                            if (argss[0][0] == '/' && argss[0][1] == '/')
                            {
                                //it was a comment so skip over this line
                                break;
                            }
                            else
                            {
                                //it must have been a variable so read in the variable and arguments
                                //there is more then a single argument so get each one
                                bool op = false;
                                for (int index = 0; index < args.Count; index++)
                                {
                                    ARG arg1;
                                    if (op)
                                    {
                                        arg1 = getOperator(argss[index], go);
                                    }
                                    else
                                    {
                                        arg1 = getArg(argss[index], go);
                                    }

                                    args.Add(arg1);
                                }
                            }

                            break;
                        }
                }

                
    

            }

            

        }

        private static void writeArguments(ARG[] args,string script,string fileout)
        {
            //prepare for binary writing
            BinaryWriter writer = new BinaryWriter(File.Open(fileout, FileMode.Create));

            //write each of the arguments depending on there type
            for(int i = 0;i < args.Count();i++)
            {
                switch(args[i].m_type)
                {
                    case Type.SIZE:
                        {
                            //data defines size, meaning the length of the block/line
                            writer.Write((byte)(Type.SIZE));
                            //now write the byte containing the size
                            writer.Write((byte)(args[i].m_data));

                            break;
                        }

                    case Type.BOOL:
                        {
                            //data defines a boolean(not literal)
                            writer.Write((byte)(Type.BOOL));
                            //write the address of the boolean
                            writer.Write((byte)args[i].m_data);
                            break;
                        }
                    case Type.BYTE:
                        {
                            //data defines a byte(not literal)
                            writer.Write((byte)(Type.BYTE));
                            //write the address of the byte
                            writer.Write((byte)args[i].m_data);
                            break;
                        }
                    case Type.CHAR:
                        {
                            //data defines a char(not literal)
                            writer.Write((byte)Type.CHAR);
                            //write the address of the char
                            writer.Write()
                        }
                }
            }

        }

        private static ARG getOperator(string arg,GameObject go)
        {
            ARG narg = new ARG();
            narg.m_type = Type.OPERATOR;
            narg.m_data = null;
            //check to see which operator it is
            switch (arg)
            {
                case "+":
                    {
                        //its the plus operator
                        narg.m_data = Operator.PLUS;
                        break;
                    }
                case "-":
                    {
                        //its the minus operator
                        narg.m_data = Operator.MINUS;
                        break;
                    }
                case "*":
                    {
                        //its the mutiply operator
                        narg.m_data = Operator.MULTIPLY;
                        break;
                    }
                case "/":
                    {
                        //its the division operator
                        narg.m_data = Operator.DEVIDE;
                        break;
                    }
                case "=":
                    {
                        //its the equals operator
                        narg.m_data = Operator.EQUALS;
                        break;
                    }
                case "<":
                    {
                        //its the less then operator
                        narg.m_data = Operator.LESSTHEN;
                        break;
                    }
                case ">":
                    {
                        //its the greater then operator
                        narg.m_data = Operator.GREATERTHEN;
                        break;
                    }
                case "==":
                    {
                        //its the is equal to operator
                        narg.m_data = Operator.ISEQUAL;
                        break;
                    }


            }

            //return the operator
            return narg;
        }

        private static ARG getArg(string arg,GameObject go)
        {
            ARG narg = new ARG();
            switch (go.getType(arg))
            {
                case GameObject.TYPE.BOOL:
                    {
                        narg.m_type = Type.BOOL;
                        narg.m_data = go.getBool(arg);
                        break;
                    }

                case GameObject.TYPE.BYTE:
                    {
                        narg.m_type = Type.BYTE;
                        narg.m_data = go.getByte(arg);
                        break;
                    }

                case GameObject.TYPE.CHAR:
                    {
                        narg.m_type = Type.CHAR;
                        narg.m_data = go.getChar(arg);
                        break;
                    }

                case GameObject.TYPE.DOUBLE:
                    {
                        narg.m_type = Type.DOUBLE;
                        narg.m_data = go.getDouble(arg);
                        break;
                    }

                case GameObject.TYPE.FLOAT:
                    {
                        narg.m_type = Type.FLOAT;
                        narg.m_data = go.getFloat(arg);
                        break;
                    }

                case GameObject.TYPE.INTEGER:
                    {
                        narg.m_type = Type.INT;
                        narg.m_data = go.getInteger(arg);
                        break;
                    }

                case GameObject.TYPE.SHORT:
                    {
                        narg.m_type = Type.SHORT;
                        narg.m_data = go.getShort(arg);
                        break;
                    }

                case GameObject.TYPE.STRING:
                    {
                        narg.m_type = Type.STRING;
                        narg.m_data = go.getString(arg);
                        break;
                    }
                default:
                    {
                        //there was no var so its literal
                        narg.m_type = Type.LITERAL;
                        ARG argt = new ARG();
                        float val;
                        //try to cast to a double and if it fails its a string
                        if (float.TryParse(arg, out val))
                        {
                            //its a value so set it as a literal float
                            argt.m_type = Type.FLOAT;
                            argt.m_data = val;
                        }
                        else
                        {
                            //its a string 
                            argt.m_type = Type.STRING;
                            argt.m_data = arg;
                        }
                        break;
                    }
            }

            //return new argument
            return narg;
        }
    }
}
