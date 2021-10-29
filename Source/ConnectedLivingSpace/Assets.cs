/*
	This file is part of Connected Living Space /L Unleashed
		© 2021 Lisias T : http://lisias.net <support@lisias.net>
		© 2020 micha (mwerle)
		© 2015-2018 Papa_Joe
		© 2014-2015 codepoet

	Connected Living Space /L Unleashed is licensed as follows:

		* CC BY-NC-SA 4.0i : https://creativecommons.org/licenses/by-nc-sa/4.0/

	Connected Living Space /L Unleashed is distributed in the hope that
	it will be useful, but WITHOUT ANY WARRANTY; without even the implied
	warranty of	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

*/
using System;

using UTexture2D = UnityEngine.Texture2D;
using Asset = KSPe.IO.Asset<ConnectedLivingSpace.Startup>;
using IO = KSPe.IO.File<ConnectedLivingSpace.Startup>.Asset;

namespace ConnectedLivingSpace
{
  internal static class Assets
  {
		private const string assets = "assets";

    private static UTexture2D _cls_icon_off_128;
    internal static UTexture2D cls_icon_off_128 => _cls_icon_off_128 ?? (_cls_icon_off_128 = Asset.Texture2D.LoadFromFile(assets, "cls_icon_off_128"));

    private static UTexture2D _cls_icon_on_128;
    internal static UTexture2D cls_icon_on_128 => _cls_icon_on_128 ?? (_cls_icon_on_128 = Asset.Texture2D.LoadFromFile(assets, "cls_icon_on_128"));

    private static UTexture2D _cls_b_icon_on;
    internal static UTexture2D cls_b_icon_on => _cls_b_icon_on ?? (_cls_b_icon_on = Asset.Texture2D.LoadFromFile(assets, "cls_b_icon_on"));

    private static UTexture2D _cls_b_icon_off;
    internal static UTexture2D cls_b_icon_off => _cls_b_icon_off ?? (_cls_b_icon_off = Asset.Texture2D.LoadFromFile(assets, "cls_b_icon_off"));
  }
}
