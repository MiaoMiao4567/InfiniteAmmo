using Exiled.API.Features;
using InfiniteAmmo.Event.PlayerEvent;
using System;

namespace InfiniteAmmo
{
    public class Plugin : Plugin<MiaoMiaolikeConfig>
    {
        public override string Name { get; } = "InfiniteAmmo";
        public override string Author { get; } = "喵喵(QQ:108818013)";
        public override Version Version { get; } = new Version(1, 0, 2);
        public static Plugin Instance;
        public override void OnEnabled()
        {
            Instance = this;
            base.OnEnabled();
            Exiled.Events.Handlers.Player.ReloadingWeapon += Reloading.Reload;
            Exiled.Events.Handlers.Player.ChangingRole += ChangingRole.OnChangingRole;
            Exiled.Events.Handlers.Player.DroppingAmmo += DropAmmo.OnDropAmmo;
            Log.Info("InfiniteAmmo V1.0.0 | 已成功加载!");
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Exiled.Events.Handlers.Player.ReloadingWeapon -= Reloading.Reload;
            Exiled.Events.Handlers.Player.ChangingRole -= ChangingRole.OnChangingRole;
            Exiled.Events.Handlers.Player.DroppingAmmo -= DropAmmo.OnDropAmmo;
            Log.Info("InfiniteAmmo V1.0.0 | 已关闭!");
        }
    }
}