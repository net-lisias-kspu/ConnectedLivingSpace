using System;

using UTexture2D = UnityEngine.Texture2D;
using Asset = KSPe.IO.Asset<ConnectedLivingSpace.Startup>;
using IO = KSPe.IO.File<ConnectedLivingSpace.Startup>.Asset;

namespace ConnectedLivingSpace
{
  internal static class Assets
  {
    private static UTexture2D _cls_icon_off_128;
    internal static UTexture2D cls_icon_off_128 => _cls_icon_off_128 ?? (_cls_icon_off_128 = Asset.Texture2D.LoadFromFile("assets", "cls_icon_off_128"));

    private static UTexture2D _cls_icon_on_128;
    internal static UTexture2D cls_icon_on_128 => _cls_icon_on_128 ?? (_cls_icon_on_128 = Asset.Texture2D.LoadFromFile("assets", "cls_icon_on_128"));

    internal static readonly String cls_b_icon_on = IO.Solve("assets", "cls_b_icon_on");
    internal static readonly string cls_b_icon_off = IO.Solve("assets", "cls_b_icon_off");
  }
}
