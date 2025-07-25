using System.ComponentModel;
using Exiled.API.Interfaces;

namespace InfiniteAmmo
{
    public sealed class MiaoMiaolikeConfig : IConfig
    {
        [Description("是否开启此插件?")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
