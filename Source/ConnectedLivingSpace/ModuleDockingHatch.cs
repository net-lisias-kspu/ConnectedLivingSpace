﻿using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace ConnectedLivingSpace
{
  // This module is added by a module Manager config to any part that also has a ModuleDockingNode. 
  // There is a one to one relationship between ModuleDockingHatch and ModuleDockingNode
  public class ModuleDockingHatch : PartModule, IModuleDockingHatch
  {
    [KSPField(isPersistant = true)]
    private bool hatchOpen;

    [KSPField]
    public string docNodeAttachmentNodeName = "top"; // Note, on some ModuleDockingNodes this does not exist, so we set the value to "none"

    [KSPField]
    public string docNodeTransformName = "dockingNode";

    [KSPField]
    public string hatchName;

    internal ModuleDockingNode modDockNode;

    // For localization.  These are the default (english) values...
    private static string _strOpen = "Open";
    private static string _strClosed = "Closed";
    private static string _strHatchStatus = "Hatch Status";
    private static string _strOpenHatch = "Open Hatch";
    private static string _strCloseHatch = "Close Hatch";
    private static string _strHasHatch = "Has Hatch";
    private static string _strHatchNode = "Hatch Node";
    private static string _strYes = $"<color={XKCDColors.HexFormat.Lime}>Yes</color>";
    //private readonly string _strNo = "<color=" + XKCDColors.HexFormat.Maroon + ">No</color>";

    public bool HatchOpen
    {
      get
      {
        return hatchOpen;
      }

      set
      {
        if (hatchOpen != value)
        {
          if (value) OpenHatch();
          else CloseHatch();
        }
        hatchStatus = value ? _strOpen : _strClosed;
      }
    }

    public string HatchStatus
    {
      get
      {
        return hatchStatus;
      }
    }

    public bool IsDocked
    {
      get
      {
        return isInDockedState() || isAttachedToDockingPort();
      }
    }

    public BaseEventList HatchEvents
    {
      get
      {
        return Events;
      }
    }

    public ModuleDockingNode ModDockNode
    {
      get
      {
        return modDockNode;
      }
    }

    [KSPField(isPersistant = false, guiActive = true, guiName = "Hatch status")]
    private string hatchStatus = "";

    private void SetEventStates()
    {
      if (isInDockedState() || isAttachedToDockingPort())
      {
        if (HatchOpen)
        {
          Events["CloseHatch"].active = true;
          Events["OpenHatch"].active = false;
        }
        else
        {
          Events["CloseHatch"].active = false;
          Events["OpenHatch"].active = true;
        }
      }
      else
      {
        Events["CloseHatch"].active = false;
        Events["OpenHatch"].active = false;
      }
    }

    [KSPEvent(active = true, guiActive = true, guiName = "Open Hatch")]
    private void OpenHatch()
    {
      hatchOpen = true;
      SetEventStates();

      if (vessel != null) GameEvents.onVesselWasModified.Fire(vessel);
    }

    [KSPEvent(active = true, guiActive = true, guiName = "Close Hatch")]
    private void CloseHatch()
    {
      hatchOpen = false;
      SetEventStates();

      if (vessel != null) GameEvents.onVesselWasModified.Fire(vessel);
    }

    private void SetLocalization()
    {
      //CacheClsLocalization();

      _strOpen = CLSAddon.Localize("#clsloc_033");
      _strClosed = CLSAddon.Localize("#clsloc_034");
      _strHatchStatus = CLSAddon.Localize("#clsloc_035");
      _strOpenHatch = CLSAddon.Localize("#clsloc_036");
      _strCloseHatch = CLSAddon.Localize("#clsloc_037");
      _strHasHatch = CLSAddon.Localize("#clsloc_038");
      _strHatchNode = CLSAddon.Localize("#clsloc_039");
      _strYes = $"<color={XKCDColors.HexFormat.Lime}>{CLSAddon.Localize("#clsloc_017")}</color>";
    }

    private void SetEventGuiNames()
    {
      string space = !string.IsNullOrEmpty(hatchName) ? " " : "";
      Fields["hatchStatus"].guiName = hatchName + space + _strHatchStatus;
      Events["OpenHatch"].guiName = _strOpenHatch + space + hatchName;
      Events["CloseHatch"].guiName = _strCloseHatch + space + hatchName;
    }

    private void FindDockingPort()
    {
      modDockNode = null;
      var ports = part.FindModulesImplementing<ModuleDockingNode> ();
      // search for the specified docking port
      for (int i = 0; i < ports.Count; i++)
      {
        if (ports[i].nodeTransformName == docNodeTransformName)
        {
          modDockNode = ports[i];
          break;
        }
      }
      // if not found, then just grab the first
      if (modDockNode == null && ports.Count > 0)
      {
        modDockNode = ports[0];
      }
    }

    // tries to work out if the docking port is docked based on the state
    private bool isInDockedState()
    {
      // First ensure that we know which ModuleDockingNode we are referring to.
      if (modDockNode != null)
      {
        if (modDockNode.state == "Docked (dockee)" || modDockNode.state == "Docked (docker)")
        {
          return true;
        }
      }
      else
      {
        // This is bad - it means there is a hatch that we can not match to a docking node. This should not happen. We will log an error but it will likely spam the log.
        Log.error("Docking port hatch can not find its ModuleDockingNode docNodeTransformName: {0} docNodeAttachmentNodeName: {1}", docNodeTransformName, docNodeAttachmentNodeName);
      }

      return false;
    }

    // tries to work out if the docking port is attached to another docking port (ie in the VAB) and therefore can be treated as if it is docked (for example by not requiring the hatch to be closed)
    private bool isAttachedToDockingPort()
    {
      // First - this is only possible if we have an reference attachmentNode
      if (string.IsNullOrEmpty(docNodeAttachmentNodeName)) return false;
      AttachNode thisNode = part.attachNodes.Find(x => x.id == docNodeAttachmentNodeName);
      if (null == thisNode) return false;
      Part attachedPart = thisNode.attachedPart;
      if (null == attachedPart) return false;
      // What is the attachNode in the attachedPart that links back to us?
      AttachNode reverseNode = attachedPart.FindAttachNodeByPart(part);
      if (null == reverseNode) return false;
      // Now the big question - is the attached part a docking node that is centred on the reverseNode?
      IEnumerator<ModuleDockingNode> eNodes = attachedPart.Modules.OfType<ModuleDockingNode>().GetEnumerator();
      while (eNodes.MoveNext())
      {
        if (eNodes.Current == null) continue;
        if (eNodes.Current.referenceNode.id == reverseNode.id)
        {
          // The part has a docking node that references the attachnode that connects back to our part - this is what we have been looking for!
          return true;
        }
      }
      eNodes.Dispose();
      return false;
    }

    // Method to provide extra infomation about the part on response to the RMB of the part gallery
    public override string GetInfo()
    {
      return $"{_strHasHatch}:  {_strYes}\n{_strHatchNode}:  <color={XKCDColors.HexFormat.Lime}>{docNodeAttachmentNodeName}</color>";
    }


    #region Event Handlers
    void onEditorShipModified (ShipConstruct ship)
    {
      // In the editor force the hatches open for attached docking ports so it is possible to see the living spaces at design time.
      if (isAttachedToDockingPort())
      {
        hatchOpen = true;
        hatchStatus = hatchOpen ? _strOpen : _strClosed;
      }
    }

    IEnumerator WaitAndCheckState()
    {
      yield return null;
      if (HatchOpen && !isInDockedState() && !isAttachedToDockingPort())
      {
        // We are not docked or attached to a docking port - close up the hatch if it is open!
        Log.info("Closing a hatch because its corresponding docking port is in state: {0}", modDockNode.state);
        hatchOpen = false;
      }
      SetEventStates();
      hatchStatus = hatchOpen ? _strOpen : _strClosed;
    }

    void onVesselWasModified (Vessel v)
    {
      if (v == vessel)
      {
        StartCoroutine (WaitAndCheckState());
      }
    }

    public override void OnAwake()
    {
      GameEvents.onEditorShipModified.Add (onEditorShipModified);
      GameEvents.onVesselWasModified.Add (onVesselWasModified);
    }

    public override void OnStart(PartModule.StartState state)
    {
      FindDockingPort();
      SetLocalization();
      SetEventGuiNames();
      if (HighLogic.LoadedSceneIsFlight) SetEventStates();
    }

    void OnDestroy()
    {
      GameEvents.onEditorShipModified.Remove (onEditorShipModified);
      GameEvents.onVesselWasModified.Remove (onVesselWasModified);
    }
    #endregion
  }
}
