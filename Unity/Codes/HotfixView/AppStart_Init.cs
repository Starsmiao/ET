using UnityEngine;

namespace ET
{
    public class AppStart_Init : AEvent<EventType.AppStart>
    {
        protected override async ETTask Run(EventType.AppStart args)
        {
            Game.Scene.AddComponent<TimerComponent>();
            Game.Scene.AddComponent<CoroutineLockComponent>();

            Game.Scene.AddComponent<OpcodeTypeComponent>();
            Game.Scene.AddComponent<MessageDispatcherComponent>();
            Game.Scene.AddComponent<NetThreadComponent>();
            Game.Scene.AddComponent<SessionStreamDispatcher>();
            Game.Scene.AddComponent<ZoneSceneManagerComponent>();
            //Game.Scene.AddComponent<GlobalComponent>();
            //Game.Scene.AddComponent<AIDispatcherComponent>();

            Scene zoneScene = await SceneFactory.CreateZoneScene(1, "Game", Game.Scene);

            // 热更新流程
            await Game.EventSystem.Publish(new EventType.HotfixBegin() { ZoneScene = zoneScene }); // 加载热更新UI
            BundleDownloaderComponent bundleDownloaderComponent = Game.Scene.AddComponent<BundleDownloaderComponent>();
            {
                await bundleDownloaderComponent.StartUpdate();
                Log.Info("资源热更完成，进入大厅");
            }
            bundleDownloaderComponent.Dispose();
            await Game.EventSystem.Publish(new EventType.HotfixFinish() { ZoneScene = zoneScene }); // 移除热更新UI

            // 获取服务器地址
            if (UnityEngine.GameObject.Find("Global").GetComponent<libx.Updater>().DevelopmentMode)
            {
                Game.Scene.AddComponent<AdressComponent, bool>(true);
            }
            else
            {
                Game.Scene.AddComponent<AdressComponent, bool>(false);
            }

            // 加载配置
            Game.Scene.AddComponent<XAssetComponent>();
            Game.Scene.AddComponent<ConfigComponent>();
            await ConfigComponent.Instance.LoadAsync();
            XAssetComponent.Instance.UnLoadAssetBundle(ABPathUtilities.GetConfigPath("Config"));

            await Game.EventSystem.Publish(new EventType.AppStartInitFinish() { ZoneScene = zoneScene });
            await Game.EventSystem.Publish(new EventType.CreateUILogin() { ZoneScene = zoneScene });

            GameObject.Destroy(GameObject.Find("IL2CPP")); // 删除为了防止IL2CPP打包裁剪而挂载在Init场景下的物体
            GameObject.Destroy(GameObject.Find("Global").GetComponent<libx.Updater>()); // 移除XAsset的热更新脚本
            GameObject.Destroy(GameObject.Find("Global").GetComponent<libx.Downloader>()); // 移除XAsset的热更新脚本
        }
    }
}