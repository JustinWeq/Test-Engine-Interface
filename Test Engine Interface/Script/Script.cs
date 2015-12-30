using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Engine_Interface.Object;
using Test_Engine_Interface.Project;

namespace Test_Engine_Interface.JR_Script
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
            GLOBAL,
            OTHER,
            END
           
        }

        private class ARG
        {
            public Type m_type;
            public object m_data;
        }


        //Write-- writes the passed in scipt out in in binary
        //script- the script to compile and write
        //fileout- the file to write out
        public static void Write(string script,string fileout,GameObject go,GameObject goo,GameProject project)
        {
            //set up list of bytes to be written out
            List<byte> binlist = new List<byte>();
            //set up list of data to be written out to the script
            List<ARG> args = new List<ARG>();

            //break script into lines
            string[] lines = script.Split('\n');

            //read each line
            for(int i = 0;i < lines.Count(); i++)
            {
                //split args
                string[] largs = lines[i].Split(' ');
                switch(largs[0])
                {
                    case "if":
                        {
                            int section = 1;
                            //defines conditional statement
                            //check to see if there is special scope on it
                        }
                }
            }
            

        }

        private static ARG[] getScope(GameObject go,GameObject goo,GameProject project)
        {

        }

        private static void writeArguments(ARG[] args,string script,string fileout)
        {
            //prepare for binary writing
            BinaryWriter writer = new BinaryWriter(File.Open(fileout, FileMode.Create));

            //write the number of arguments
            writer.Write((long)args.Count());

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
                            writer.Write((byte)args[i].m_data);
                            break;
                        }
                    case Type.DO:
                        {
                            //data defines a do loop
                            writer.Write((byte)Type.DO);
                            //do not bother writing data since there is none
                            break;
                        }
                    case Type.DOUBLE:
                        {
                            //data defines a double
                            writer.Write((byte)Type.DOUBLE);
                            //write the address of the double;
                            writer.Write((byte)args[i].m_data);
                            break;
                        }
                    case Type.FLOAT:
                        {
                            //data defines a float(not literal)
                            writer.Write((byte)Type.FLOAT);
                            //write the address of the float
                            writer.Write((byte)args[i].m_data);
                            break;
                        }
                    case Type.GLOBAL:
                        {
                            //data defines a global
                            writer.Write((byte)Type.GLOBAL);
                            //dont bother writing the data since there is none
                            break;
                        }
                    case Type.IF:
                        {
                            //data deinfes an if statement
                            writer.Write((byte)Type.IF);
                            //dont bother writing the data since there is none
                            break;
                        }
                    case Type.INT:
                        {
                            //data deifnes an integer
                            writer.Write((byte)Type.INT);
                            //dont bother writing the data since there is none
                            break;
                        }
                    case Type.LITERAL:
                        {
                            //data defines a literal
                            writer.Write((byte)Type.LITERAL);
                            //get what is in it and then write it
                            ARG argt = (ARG)args[i].m_data;
                            //check to see if its a string and if it is write a string type and then the size of the string,
                            // note string must not be longer then 256
                            if(argt.m_type == Type.STRING)
                            {
                                string str = (string)argt.m_data;
                                writer.Write((byte)Type.STRING);
                                //write size of string
                                writer.Write((byte)str.Count());
                                writer.Write(str);
                            }
                            else
                            {
                                //it must have been a nother type
                                writer.Write((byte)argt.m_type);
                                writer.Write((float)argt.m_data);
                            }
                            break;
                        }
                    case Type.LONG:
                        {
                            //data defines a long
                            writer.Write((byte)Type.LONG);
                            //write the longs address
                            writer.Write((byte)args[i].m_data);
                            break;
                        }
                    case Type.OPERATOR:
                        {
                            //wrtie the operator and its type
                            writer.Write((byte)Type.OPERATOR);
                            writer.Write((byte)args[i].m_data);
                            break;
                        }
                    case Type.SHORT:
                        {
                            //data defines a short
                            writer.Write((byte)Type.SHORT);
                            //write its address
                            writer.Write((byte)args[i].m_data);
                            break;
                        }
                    case Type.STRING:
                        {
                            //data defines a string
                            writer.Write((byte)Type.STRING);
                            //write its address
                            writer.Write((byte)args[i].m_data);
                            break;
                        }
                    case Type.WHILE:
                        {
                            //data defines a while loop
                            writer.Write((byte)Type.WHILE);
                            //dont both writing anything else since the while loop does not contain anything else
                            break;
                        }
                    case Type.OTHER:
                        {
                            //data defines other scope
                            writer.Write((byte)Type.OTHER);
                            //dont bother writting anything else since there was nothing else
                            break;
                        }
                    case Type.END:
                        {
                            //data deifnes end of statement
                            writer.Write((byte)Type.OTHER);
                            //dont bother writing other data since there is nothing else
                            break;
                        }

                }
            }

            //close the writer
            writer.Close();

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
