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
using UnityEngine;

namespace ConnectedLivingSpace
{
  public class CLSVesselModule : VesselModule
  {
    private bool dirty = true;

    private CLSVessel _clsVessel;
    internal CLSVessel CLSVessel
    {
      get
      {
        if (dirty) RebuildCLSVessel();
        return _clsVessel;
      }
    }

    public override Activation GetActivation()
    {
      return Activation.LoadedVessels;
    }

    public override void OnLoadVessel()
    {
      MarkDirty();
    }

    public override void OnUnloadVessel()
    {
      if (null != _clsVessel)
      {
        _clsVessel.Clear();
        _clsVessel = null;
      }

      // Recoupler support
      for (int i = CLSAddon.Instance.requestedConnections.Count - 1; i >= 0; i--)
      {
        CLSAddon.ConnectPair connectPair = CLSAddon.Instance.requestedConnections[i];
        if (connectPair.part1.vessel == this.vessel)
          CLSAddon.Instance.requestedConnections.Remove(connectPair);
      }
    }

    internal void MarkDirty()
    {
      dirty = true;
      CLSAddon.onCLSVesselChange.Fire(vessel);
    }

    private void RebuildCLSVessel()
    {
      dirty = false;

      if (null != _clsVessel)
      {
        _clsVessel.Clear();
        _clsVessel = null;
      }

      if (vessel.rootPart == null)
        return;
      
      try
      {
        // Build new vessel information
        _clsVessel = new CLSVessel();
        _clsVessel.Populate(vessel.rootPart);

        // Recoupler support
        for (int i = CLSAddon.Instance.requestedConnections.Count - 1; i >= 0; i--)
        {
          CLSAddon.ConnectPair connectPair = CLSAddon.Instance.requestedConnections[i];
          if (connectPair.part1.vessel != connectPair.part2.vessel)
            CLSAddon.Instance.requestedConnections.Remove(connectPair);
          _clsVessel.MergeSpaces(connectPair.part1, connectPair.part2);
        }

      }
      catch (Exception ex)
      {
        Log.error(ex, "CLS rebuild Vessel Error");
      }
    }

  }
}
