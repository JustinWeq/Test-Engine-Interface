using System.Collections.Generic;
using Test_Engine_Interface.Object;
using Test_Engine_Interface.Level;
using Test_Engine_Interface.Sound;
using Test_Engine_Interface.JR_Script;
namespace Test_Engine_Interface.Project
{
    //GameProject-- a class that contains methods and propertys for a game
    class GameProject
    {
        //GameData-- The data for the game,such as defualt settings
        public struct GameData
        {
            public enum AA
            {
                //low- the lowest setting for AA
                LOW,
                //med- the medium setting for AA
                MED,
                //high- the high setting for AA
                HIGH,
                //ultra- the highest setting for AA
               ULTRA
            }

            public AA aa;
        }

        //GameFiles-- the structure that contans information for the related files of the game
        public struct GameFiles
        {
            //objects- a List that contains the various objects for the game project
            public List< GameObject> objects;
            //textures- a List that contains the various textures for the game project
            public List< string> textures;
            //scripts- a List that contains the various scripts for the game project
            public List<string> scripts;
            public List<GameLevel> levels;
            public List<string> models;
            public List<GameSound> sounds;
  
        }

        //ProjectSettings-- the settings for the project
        public struct ProjectSettings
        {
            //ReleaseType-- a enum that determine the release type
            public enum ReleaseType
            {
                //x86- 32 bit version
                x86,
                //x64- 64 bit version
                x64,
            }

            //ReleaseVersion-- the type of release version such as, debug or release
            public enum ReleaseVersion
            {
                //SAFE_DEBUG- program is in safe debug mode,
                // safe debug mode means exceptions will be automatically handled and you should see no
                // C++ runtime errors, game will be run from text scripts and will run slower then the release version, 
                // this is to enable debugging features such as break point
              SAFE_DEBUG,
              //UNSAFE_RELEASE- project is in unsafe release mode,
              // exceptions will not be handled and will lead to potentially application freezeing crashes,
              // the application will run much faster though, since it will not have to handle exceptions
                UNSAFE_RELEASE
                    //SAFE_RELEASE- the safe release version, scripts will be read from binary.
                    //This release version is safer then UNSAFE_RELEASE in that it catches exceptions for you
                    // slower becuase of exception handleing, UNSAFE_RELEASE should be used for the final release version,
                     //as it will run the fastest
                    ,SAFE_RELEASE
            }

            //
            public ReleaseType type;
            public ReleaseVersion version;
        }

        //instance vars
        private GameFiles m_files;
        private GameData m_data;
        private ProjectSettings m_settings;


        //default constructor-- creates a new instance of GameProject with defualt parameters
        public GameProject()
        {
            m_files = new GameFiles();
            m_data = new GameData();
            m_settings = new ProjectSettings();

            //set up game files
            m_files.levels = new List<GameLevel>();
            m_files.models = new List<string>();
            m_files.objects = new List<GameObject>();
            m_files.scripts = new List<string>();
            m_files.sounds = new List<GameSound>();
            m_files.textures = new List<string>();
        }

        public void setReleaseType(ProjectSettings.ReleaseType type)
        {
            m_settings.type = type;
        }

        public void setReleaseVersion(ProjectSettings.ReleaseVersion version)
        {
            m_settings.version = version;
        }

        public void setAA(GameData.AA aa)
        {
            m_data.aa = aa;
        }

        public void deleteObject(int index)
        {
            m_files.objects.RemoveAt(index);
        }

        public void addObject(GameObject gameObject)
        {
            m_files.objects.Add(gameObject);
        }

        public void updateObject(GameObject gameObject,int index)
        {
            m_files.objects[index] = gameObject;
        }

        public GameObject getObject(int index)
        {
            return m_files.objects[index];
        }


        public void deleteTexture(int index)
        {
            m_files.textures.RemoveAt(index);
        }

        public void addTexture(string textureAddress)
        {
            m_files.textures.Add(textureAddress);
        }

        public void deleteScript(int index)
        {
            m_files.scripts.RemoveAt(index);
        }

        public void addScript(string script)
        {
            m_files.scripts.Add(script);
        }

        public void deleteLevel(int index)
        {
            m_files.scripts.RemoveAt(index);
        }

        public void addLevel(GameLevel level)
        {
            m_files.levels.Add(level);
        }

        public void deleteModel(int index)
        {
            m_files.models.RemoveAt(index);
        }

        public void addModel(string modelAddress)
        {
            m_files.models.Add(modelAddress);
        }

        public void deleteSound(int index)
        {
            m_files.sounds.RemoveAt(index);
        }

        public void addSound(GameSound sound)
        {
            m_files.sounds.Add(sound);
        }

    }
}
