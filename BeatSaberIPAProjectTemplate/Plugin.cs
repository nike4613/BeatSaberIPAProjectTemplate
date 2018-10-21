using IPA;
using IPA.Config;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

namespace $safeprojectname$
{
    public class Plugin : IBeatSaberPlugin
    {
        public string Name => "$projectname$";

        public string Version => "0.0.1-alpha";

        public ModsaberModInfo ModInfo => null;

        internal static Config config;
        internal static IConfigProvider configProvider;

        public void Init(IPALogger logger, IConfigProvider cfgProvider)
        {
            Logger.log = logger;
            configProvider = cfgProvider;

            config = cfgProvider.Parse<Config>();
            if (config.RegenerateConfig)
                cfgProvider.Store(config = new Config() { RegenerateConfig = false });
        }

        public void OnApplicationStart()
        {
            Logger.log.Debug("OnApplicationStart");
        }

        public void OnApplicationQuit()
        {
            Logger.log.Debug("OnApplicationQuit");
        }

        public void OnFixedUpdate()
        {

        }

        public void OnUpdate()
        {

        }

        public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
        {

        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {

        }

        public void OnSceneUnloaded(Scene scene)
        {

        }
    }
}
