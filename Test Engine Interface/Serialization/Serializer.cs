using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Test_Engine_Interface.Project;

namespace Test_Engine_Interface.Serialization
{ 
    [Serializable]
    public class Serializer
    {
        public Serializer()
        {

        }

        public void setObjects(string[] objects)
        {
            m_objects = new List<string>();
            m_objects.AddRange(objects);
        }

        public void setProject(GameProject project)
        {
            m_project = project;
        }

        public GameProject getProject()
        {
            return m_project;
        }

        public string[] getObjects()
        {
            return m_objects.ToArray();
        }

        public void serialize(string filePath)
        {
            BinaryFormatter formmatter = new BinaryFormatter();
            FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            Serializer ser = this;
            formmatter.Serialize(stream, ser);
        }

        public void Unserialize(string filePath)
        {
            BinaryFormatter formmatter = new BinaryFormatter();
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
            Serializer newSerializer = (Serializer)formmatter.Deserialize(stream);
            m_objects = newSerializer.m_objects;
            m_project = newSerializer.m_project;
        }


        //instance vars
        List<string> m_objects;
        GameProject m_project;
    }
}
