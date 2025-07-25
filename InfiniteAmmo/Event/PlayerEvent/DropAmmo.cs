using System;
using Exiled.Events.EventArgs.Player;

namespace InfiniteAmmo.Event.PlayerEvent
{
    public class DropAmmo
    {
        public static void OnDropAmmo(DroppingAmmoEventArgs ev)
        {
            if (ev.Player != null)
            {
                ev.IsAllowed = false;
            }
        }
    }
}
