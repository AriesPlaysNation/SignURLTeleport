using Rocket.API;

namespace SignURLTeleport
{

    public class ConfigurationSignURLTeleport : IRocketPluginConfiguration
    {

        public int MaxDistance;
        public string DefaultDesc;

        public void LoadDefaults()
        {
            DefaultDesc = "Open the URL to visit the webpage!";
            MaxDistance = 5;

        }

    }

}

