using Exiled.Events.EventArgs.Player;

namespace InfiniteAmmo.Event.PlayerEvent
{
    public class Reloading
    {
        public static void Reload(ReloadingWeaponEventArgs e)
        {
            if (e.Player == null) return;
            if (e.Firearm.Type == ItemType.ParticleDisruptor) return;
            e.Player.SetAmmo(e.Firearm.AmmoType, (ushort)((e.Firearm.MaxMagazineAmmo - e.Firearm.MagazineAmmo) + 1));
        }
    }
}
