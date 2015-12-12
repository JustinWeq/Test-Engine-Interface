using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Engine_Interface.Object
{
    //a simple class that contains methods and properts for the game object definition
    public class GameObject
    {

        //contains the type for each variable
        public enum TYPE
        {
            STRING,
            INTEGER,
            DOUBLE,
            FLOAT,
            SHORT,
            BYTE,
            CHAR,
            BOOL,
        }

        //defualt constructor creates a new instance of GameObject
        // with defualt parameters
        public GameObject()
        {
            //initalize lists
            m_bools = new Dictionary<string, byte>();
            m_bytes = new Dictionary<string, byte>();
            m_chars = new Dictionary<string, byte>();
            m_doubles = new Dictionary<string, byte>();
            m_floats = new Dictionary<string, byte>();
            m_integers = new Dictionary<string, byte>();
            m_longs = new Dictionary<string, byte>();
            m_shorts = new Dictionary<string, byte>();
            m_strings = new Dictionary<string, byte>();
            m_varTypes = new Dictionary<string, TYPE>();
        }
        
        //methods

        //addString--adds a new string to the dictionary of strings
        public void addString(string name)
        {
            //add new string to dictionary of string
            m_strings.Add(name,(byte)m_strings.Count);

            //add new typs to types
            m_varTypes.Add(name, TYPE.STRING);
        }

        public void editString(string name,string newValue)
        {

        }

        public bool containsData(string name)
        {
            return m_varTypes.ContainsKey(name);
        }


        //addInteger-- adds a new integer to the dictionary of integers
        //name- the name of the new string to add
        public void addInteger(string name)
        {
            //add new integer to the dictionary
            m_integers.Add(name, (byte)m_integers.Count);

            //add new typs to types
            m_varTypes.Add(name, TYPE.INTEGER);
        }


        //addDouble-- adds a new double the the dictionary of doubles
        //name- the name of the new double
        public void addDoubles(string name)
        {
            //add new double to the dictionary of doubles
            m_doubles.Add(name, (byte)m_doubles.Count);

            //add new typs to types
            m_varTypes.Add(name, TYPE.DOUBLE);
        }

        //addFloat-- adds a new float to the dictionary of floats
        //name- the name of the new float
        public void addFloat(string name)
        {
            //add the new float to the dictionary of floats
            m_floats.Add(name, (byte)m_floats.Count);

            //add new typs to types
            m_varTypes.Add(name, TYPE.DOUBLE);
        }

        //addLong-- adds a new long to the dictionary of longs
        //name- the name of the new long
        public void addLong(string name)
        {
            //add a new long to the dicionary of longs
            m_longs.Add(name, (byte)m_longs.Count);

            //add new typs to types
            m_varTypes.Add(name, TYPE.DOUBLE);
        }

        //addBool-- adds a new bool to the dictionary of bools
        //name- the name of the new bool to add
        public void addBool(string name)
        {
            //add a new bool to the dictionat of bools
            m_bools.Add(name, (byte)m_bools.Count);

            //add new typs to types
            m_varTypes.Add(name, TYPE.BOOL);
        }

        //addShort-- adds a new short to the list of shorts
        //name- the name of the new short
        public void addShort(string name)
        {
            //add the short to the name of shorts
            m_shorts.Add(name, (byte)m_shorts.Count);

            //add new typs to types
            m_varTypes.Add(name, TYPE.SHORT);
        }

        //addChar-- adds a new char to the dictionary of chars
        //name- the name of the new short
        public void addChar(string name)
        {
            //add the short to the dictionary of shorts
            m_chars.Add(name, (byte)m_chars.Count);

            //add new typs to types
            m_varTypes.Add(name, TYPE.CHAR);
        }

        //addByte-- adds a new byte to the dictionary of bytes
        //name- the name of the new byte
        public void addByte(string name)
        {
            //add the new byte to the list of bytes
            m_bytes.Add(name, (byte)m_bytes.Count);

            //add new typs to types
            m_varTypes.Add(name, TYPE.BYTE);
        }

        //getString-- returns the address of the passed in var name
        //name- the name of the variable
        public byte getString(string name)
        {
            return m_strings[name];
        }

        //getInteger-- returns the address of the passed in variables name
        //name- the name of the variable
        public byte getInteger(string name)
        {
            return m_integers[name];
        }

        //getDouble-- returns the address of the passed in variables name
        //name- the name of the variable
        public byte getDouble(string name)
        {
            return m_doubles[name];
        }

        //getFloat-- returns the address of the passed in variables name
        //name- the name of the variable
        public byte getFloat(string name)
        {
            return m_floats[name];
        }

        //getLong-- returns the address of the passed in variable
        //name- the name of the variable
        public byte getLong(string name)
        {
            return m_longs[name];
        }

        //getBool-- returns the address of the passed in variables name
        //name- the name of the variable
        public byte getBool(string name)
        {
            return m_bools[name];
        }

        //getShort-- returns the address of the passed in variables name
        //name- the name of the variable
        public byte getShort(string name)
        {
            return m_shorts[name];
        }

        //getChar-- returns the address of the passed in variables name
        //name- the name of the variable
        public byte getChar(string name)
        {
            return m_chars[name];
        }

        //getByte-- returns the address of the passed in variables name
        //name- the name of the variable
        public byte getByte(string name)
        {
            return m_bytes[name];
        }

        //getType-- returns the type of the variable
        //name- the name of the variable
        public TYPE getType(string name)
        {
            return m_varTypes[name];
        }

        //instance data
        private Dictionary<string, byte> m_strings;
        private Dictionary<string, byte> m_integers;
        private Dictionary<string, byte> m_doubles;
        private Dictionary<string, byte> m_floats;
        private Dictionary<string, byte> m_longs;
        private Dictionary<string, byte> m_bools;
        private Dictionary<string, byte> m_shorts;
        private Dictionary<string, byte> m_chars;
        private Dictionary<string, byte> m_bytes;
        private Dictionary<string,TYPE> m_varTypes;
    }
}
