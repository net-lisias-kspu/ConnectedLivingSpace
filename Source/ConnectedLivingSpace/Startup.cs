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
	warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

*/
using System;
using UnityEngine;

namespace ConnectedLivingSpace
{
  [KSPAddon(KSPAddon.Startup.Instantly, true)]
  internal class Startup : MonoBehaviour
  {
    private void Start()
    {
      Log.force("Version {0}", Version.Text);

      try
      {
        KSPe.Util.Installation.Check<Startup>();
      }
      catch (KSPe.Util.InstallmentException e)
      {
        Log.error(e.ToShortMessage());
        KSPe.Common.Dialogs.ShowStopperAlertBox.Show(e);
      }
    }
  }
}
