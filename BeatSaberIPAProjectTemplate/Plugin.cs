﻿using IPA;
using IPA.Config;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

namespace $safeprojectname$
{
    public class Plugin : IBeatSaberPlugin
    {
        internal static Ref<Config> config;
        internal static IConfigProvider configProvider;

        public void Init(IPALogger logger, [Config.Prefer("json")] IConfigProvider cfgProvider)
        {
            Logger.log = logger;
            configProvider = cfgProvider;

            config = cfgProvider.MakeLink<Config>((p, v) =>
            {
                if (v.Value == null || v.Value.RegenerateConfig)
                    p.Store(v.Value = new PluginConfig() { RegenerateConfig = false });
                config = v;
            });
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
