# ConnectedLivingSpace :: Change Log

* 2020-1229: 2.0.0.6 (Micha) for KSP 1.11.0
	+ New: recompiled for KSP 1.11.0.
	+ New: additional part configurations:
		- bi-tri-quad stack couplers are now passable.
		- Inline cargo containers are passable.
	+ New: Restock Plus configuration (by Poodmund)
	+ Changed: Retargeted to DotNet 4.6.1.
	+ Changed: Enabled the StockFreedomAddon configurations by default.
	+ Changed: Enable Optional Passable Parts no longer requires restart.
	+ Fixed: removed default window position - off-screen for smaller displays.
	+ Fixed: GetInfo() no longer appends strings ad infinitum (thanks to todi)
* 2020-0614: 2.0.0.5 (Micha) for KSP 1.10.1
	+ Changed: Mk2 pod top hatch now passable (*evanrinehart*).
	+ Changed: 1.25m to 0.625m adapters now passable.
	+ Changed: StationScience Cyclotron and Spectrometer modules no longer passable (by mod author request).
	+ Fixed: Highlighting when hatches are opened or closed.
* 2020-0505: 2.0.0.4 (Micha) for KSP 1.9.1
	+ Added Chinese localization (thanks to *Li-Zongyao*)
	+ Added support for some modified Squad parts (thanks to *Kerbas-ad-astra*)
* 2020-0309: 2.0.0.3 (Micha) for KSP 1.9.1
	+ New: recompiled for KSP 1.9.1 and DotNet4.5
		- NOTE: This version is incompatible with versions of KSP before 1.8.
	+ Changed: new maintainer, *Micha*.
	+ New: Added german translation.
	+ Changed: reworked distribution scripts on Windows and repository layout (maintainers take note)
	+ Fixed: incorporate PR #105 from *taniwha* with many fixes and improvements.
* 2018-0613: 1.2.6.2 (Papa Joe) for KSP 1.4.5
	+ recompiled for 1.4.3
	+ incorporate PR #102 Add Italian translation.  Thanks to CRL42!
	+ incorporate PRs #101 from cake-pie make CLS 1.3.1 compatible. Thanks cake-pie!
	+ Updated KSP-AVC version file to reflect backwards compatibility to KSP 1.3.1
	+ fixed Git issue #99 inflatable airlock deploy/retract does not update clsvessel state.  Incorporate PR #100 from cake-pie.
	+ incorporate PR #98 from cake-pie correct updating cls state on crew movements Thanks cake-pie!
	+ fixed Git issue #96 localization of certain languages due to string order.
	+ Added surface attached is passable to structural tubes (Making History).
	+ Recoupler issue hatch status not changing when opening/closing hatches after recouple
* 2018-0410: 1.2.6.1 (Papa Joe) for KSP 1.4.2
	+ Made solution structural changes to ensure improved multi developer support and distribution.  Reorganized / cleaned up solution folders
	+ Added missing configs configs to CLSStockFreedomAddon.txt per PR97 by wookieegoldberg, Thanks wookie!
	+ this updates some renamed parts, and adds some Making history parts.
* 2018-0409: 1.2.6.0 (Papa Joe) for KSP 1.4.2
	+ Added configs for new Mk1-3 pod to base CLSStock.cfg
	+ Added configs for Making History Expansion
	+ Added configs to CLSStockFreedomAddon.txt per PR97 by wookieegoldberg, Thanks wookie!
	+ this updates some renamed parts, and adds some Making history parts.
* 2018-0318: 1.2.5.8 (Papa Joe) for KSP 1.4.1
	+ New: Recompiled for KSP 1.4.x
	+ Fixed: CLS ApplicationLauncher Button is blurry in KSP 1.4 update.  Updated textures to 128x128 px. Git issue #95.
	+ Added back in Recoupler support.  Previous PR#83 accidently removed it.  Merged PR#94.  Git issue #83.
* 2018-0130: 1.2.5.7 (Papa Joe) for KSP 1.3.1
	+ Changed:  Color for "No" response in information displays changed from Maroon to OrangeRed to improve readability (contrast)
	+ Fixed: Blizzy's Toolbar wrapper needs updating.  Git Issue #77
	+ Fixed: Vessel data is not updated when creating/modifying/deleting a vessel in the Vessel Editor.  Git Issue #85
	+ Fixed: Passable strings reversed. Git Issue #92. (thanks to @yalov!)
	+ Fixed: Hatch status reporting error in tweakable. Git Issue #93.
* 2018-0129: 1.2.5.6 (Papa Joe) for KSP 1.3.1
	+ Correct errors in config files for Mod version, and KSP version supported.
* 2018-0103: 1.2.5.5 (Papa Joe) for KSP 1.3.1
	+ 1.2.5.4 beta by linuxgurugamer, released under permission.
	+ 1.2.5.5 beta by linuxgurugamer, also released under permission.  for these 2 releases go to his git repository.
	+ release v1.2.5.5 (official) release date: 03 Jan 2018
		- New: PR from linuxgurugamer for an Updated CLSB9.cfg: Thanks to @Mine_Turtle:
		- linuxgurugamer has added CDP docking port(supposed to be used with s2 parts) to the
		- list and made s2 crew parts passable, when surface attached. Reason: there
		- is no inline s2 docking adapter, nor it is possible to attach stock
		- docking ports to s2 modules and have crew transfers with CLS.
	+ release v1.2.5.4 release date: 28 Oct 2017 (beta by linuxgurugamer)
		- New: Merged PR from @tyehle:	Make kibble storage passable. Fixes #87
		- New: Merged PR from @yalov: Localizations
		- New: Merged PR from @cake-pie: Refactor
		- New: Merged PR from @kerbas-ad-astra: Some new part configs
* 2017-0603: 1.2.5.3a (Papa Joe) for KSP 1.3.0
	+ Forgot a merge.  all other release notes are the same as last release
* 2017-0601: 1.2.5.2 (Papa Joe) for KSP 1.3.0
	+ New:  Added compatibility with Airlock Plus. (thanks to cakepie!)
* 2017-0529: 1.2.5.1 (Papa Joe) for KSP 1.3.0
	+ New: Added support for Recoupler.  Modders can now request to merge spaces on reconnect of parts.
		- Note to Modders:  This changes the CLSInterface.dll, so if you use this and want the new features please include the latest CLSInterface.dll with your mod.
	+ Misc:  Cleaned up text rendering to consistently use C# string interpolation.
* 2017-0528: 1.2.5.0 (Papa Joe) for KSP 1.3.0
	+ New: Refactored to support KSP 1.3
	+ New: Implemented Localization system.  Now it is possible to translate CLS into other languages. English included to start.
	+ New: Revised Crew and part display window for spaces.  now takes less real estate, and is more intuitive.
	+ New: Revised Space selection buttons to make it easier to tell which space is selected. Now buttons toggle to allow deselection of a space.
* 2017-0117: 1.2.4.2 (Papa Joe) for KSP 1.2.2
	+ New: Added a custom event to notify mods that the CLS vessel data has been refreshed.
	+ New: Added a some configs per GitHub issue and PR 79 Thanks Kerbas-ad-Astra!
* 2016-1231: 1.2.4.1 (Papa Joe) for KSP 1.2.2
	+ Fixed: Some parts were not merging spaces event when hatches were opened. Github Issue #75. Forum Post: http://forum.kerbalspaceprogram.com/index.php?/topic/109972-122-connected-living-space-v1240-30-dec-2016-customize-your-cls-parts/&do=findComment&comment=2906269
	+ Fixed: CLSDefaultPart.cfg was included in distribution.  There should only be a CLSDefaultPart.cfg.txt file.  Removed.  Github Issue #78.
* 2016-1230: 1.2.4.0 (Papa Joe) for KSP 1.2.2
	+ New:  Refactored to support KSP 1.2.2.
	+ New:  Completely refactored method used to Add hatches to vessels.  Now utilizes a module manager config, eliminating prefab manipulation in game.
	+ New:  Code refactored to improve performance and garbage collection.
	+ Fixed: Some parts containing ModuleDockingNode without a referenceNodeName would be rendered impassable in some nodes.
	+ Fixed: NRE generated during Vessel load. The addition of a female kerbal broke the CLS Module attachment code when a vessel is loaded at Flight.
		- (This was a old undetected bug, that may explain some parts not showing as passble)
	+ Fixed: Spammed Index out of range error during space changes while CLS Window is opened.
* 2016-0826: 1.2.3.0 (Papa Joe) for KSP 1.1.3
	+ New:  Added support for intercepting Parts selection list during stock Transfer target part selection.  A part not in the same space will be unselectable and is highlighted orange like full parts.
	+ New:  Added support for overriding the "Allow unrestricted Crew Transfers"in CLSInterfaces.dll setting via other Mods to prevent "competition" between mods when handling stock crew transfers.
	+ New:  Updated config for Docking Port Jr.  Squad now says that a kerbal can squeeze thru.
	+ New:  Refactored code to improve performance, recuce garbage collection, & use Explicit typing.
	+ Fixed: CLS windows now properly close when changing scenes.
	+ Fixed: In the Editor, part highlighting does not work correctly when adding new crewable parts.
* 2016-0724: 1.2.2.1 (Papa Joe) for KSP 1.1.3
	+ Fixed:  Stock Crew Transfer fails for "not in same space" even when the 2 parts are in the same space.
* 2016-0707: 1.2.2.0 (Papa Joe) for KSP 1.1.3
	+ New:  Refactored Stock Crew Transfer Handler to use new KSP 1.1.3 events to pre-empt the transfer if disallowd by CLS.
* 2016-0614: 1.2.1.5 (Papa Joe) for KSP 1.1.3
	+ Fixed:  Finally squashed NullRef exceptions when RemoteTech is installed.
	+ New:  Added Distribution folder to project for ease in locating binaries from Git.
	+ New:  Added folder check for PluginData to ensure proper config file creation when Mod is installed.
* 2016-0605: 1.2.1.4 (Papa Joe) for KSP 1.1.2
	+ Fixed:  NullRef exceptions when RemoteTech is installed.
	+ New:  Moved configuration file from GameData root folder to GameData\ConnectedLivingSpace\Plugins\PluginData folder to comply with KSP folder standards for mods.
* 2016-0528: 1.2.1.3 (Papa Joe) for KSP 1.1.2
	+ New:  Changed behavior of CLSClient.cs (API wrapper class) to prevent additional assembly scans when called. Ref Git Issue #72.
	+ New:  Added new configs for Taurus HCV.  Git Issue #71
	+ New:  Added config changes for KOSMOS SSPP  Git Issue #69
	+ New:  Refactoring for KSP 1.1.2 (WIP)
* 2016-0520: 1.2.1.2 (Papa Joe) for KSP 1.1.2
	+ Fixed:  WHen a Stock Crew transfer is overridden, the override message is not properly displayed.
	+ Fixed:  WHen a Stock Crew transfer is overridden, the original move message is not properly removed.
* 2016-0515: 1.2.1.1 (Papa Joe) for KSP 1.1.2
	+ Fixed:  Null reference errors.
	+ Fixed:  Window would not open
* 2016-0512: 1.2.1.0 (Papa Joe) for KSP 1.1.2
	+ New:  Updated mod for KSP 1.1.2 compatibility.
* 2016-0414: 1.2.0.9 (Papa Joe) for KSP 1.1 PRE-RELEASE
	+ New:  Updated mod for KSP 1.1 compatibility.
	+ New:  Corrected Stock Screen Messages so that they are properly removed when CLS overrides a Stock Crew Transfer.
	+ Fixed:  CLS would not display a window when the stock Icon was clicked.
	+ Fixed:  CLS should now only display 1 icon in Editor or flight.  Removed redundant icon call in Start, now that stock buttons now behave as intended.
* 2016-0322: 1.2.0.2 (Papa Joe) for KSP 1.0.5
	+ New:  Added Changes to configurations based on conversations in forums and a Pull Requests by Technologicat, khr15714n &  Kerbas-ad-astra.
	+ Fixed:  Correct build deploy automation to project (missing icons for blizzy).
	+ Fixed:  CLS tweakables incorrectly visible when custom passability is disabled.
* 2015-1203: 1.2.0.1 (Papa Joe) for KSP 1.0.5
	+ Add build deploy automation to project.
	+ Correct deploy error resulting in incorrect dll build being released.
* 2015-1120: 1.2.0.0 (Papa Joe) for KSP 1.0.2
	+ Added Editor-based tweakables to allow passability customization of a part during vessel construction. Off by default. (Original CLS behavior)
	+ Added option to enable / disable parts not originally passable.
	+ Expand and reformat parameter info in the RMB of the editor part description dialog.
	+ Added options window and moved options out of CLS window.
	+ Fixed bug with turning off Blizzy toolbar icon in Editor.
* 2015-0620: 1.1.3.1 (Papa Joe) for KSP 1.0.2
	+ Changed Unrestricted Crew Transfers option to be available when no vessel is loaded in VAB/SPH
	+ Fixed a bug in the Use Blizzy's Toolbar option to disable the option when Blizzy's Toolbar is not installed.
	+ Added Freedom Alt Stock MM config changes.
* 2015-0519: 1.1.3.0 (Papa Joe) for KSP 1.0.2
	+ Added trigger to overcome bug in KSP 1.0.2 that prevents stock toolbar icon from displaying.
	+ Added Blizzy Toolbar support with hot switching between stock and blizzy toolbars.
	+ Added support for KSP-AVC (if installed).
	+ Fixed a bug in OnVesselLoad to ensure only the active vessel is loaded into CLS.
* 2015-0206: 1.1.1.0 (Papa Joe) for KSP 0.90
	+ Changes to enable third party hatch control and made highlighting more co-operative.
* 2014-1225: 1.1.0.0 (Papa Joe) for KSP 0.90
	+ updated to be compatible with KSP 0.90
* 2015-0206: 1.1.1.0 (CodePoet) for KSP 0.90
	+ Changes to enable third party hatch control and made highlighting more co-operative.
* 2014-1225: 1.1.0.0 (CodePoet) for KSP 0.90
	+ updated to be compatible with KSP 0.90
* 2014-1027: 1.0.11.0 (CodePoet) for KSP 0.25
	+ Fixed a bug in the stock transfer code that meant it only worked for the first vessel.
* 2014-1023: 1.0.10.0 (CodePoet) for KSP 0.25
	+ Add CLS support to stock transfers
	+ Fixed a problem of unconfigured parts with crewspace not being considered passable
	+ Removed Near Future config which is now shipped with Near Future
* 2014-1011: 1.0.9.0 (CodePoet) for KSP 0.25
	+ built against KSP 0.25
	+ Added config for the new Mk spaceplane parts added to stock by porkjet.
	+ Added config for Near Future Spacecraft mod.
	+ Added config for Better Science mod
	+ Added config for Coffee Industries mod
	+ Added config for Hawkspeed Airstairs mod
	+ Added config for IXS mod
	+ Added config for KAX mod
	+ Added config for mk3 Nazari mod
	+ Added config for SH mod
	+ Added config for TT mod
* 2014-0731: 1.0.8.0 (CodePoet) for KSP 0.24.2
	+ Built against KSP 0.24.2
	+ Updated build process to use zip utilities installed on 64 bit OS
	+ Changed to use the stock toolbar, and removed the dependency on blizzy's toolbar.
	+ Improved the configuration documentation, and made it easier to find (in the mod root directory)
	+ Fixed issue with the descriptions of the parts in the VAB/SPH
* 2014-0627: 1.0.7.0 (CodePoet) for KSP 0.23.5
	+ Added support for the FASA parts pack
	+ removed the config for Porkworks habitat part pack as this will be shipped with the habitate pack in the future.
	+ Fixed bug whe
	+ re root part is deleted in the editor.
* 2014-0609: 1.0.6.0 (CodePoet) for KSP 0.23.5
	+ Added support for the Novapunch parts pack
	+ Fixed the bug of the hatch status not being saved and loaded properly.
	+ Cleaned up the error log a bit
	+ Made hatches openable and closable id two docking ports are attached rather than being docked.
	+ Made all hatches open in the VAB so the extend of spaces can be checked at designed time.
* 2014-0519: 1.0.5.0 (CodePoet) for KSP 0.23.5
	+ WHEN UPDATING TO THIS VERSION OF CONNCETED LIVING SPACE YOU WILL NEED TO UPDATE SHIP MANIFEST IF YOU ARE USING IT.
	+ Added interfaces to be used by other mods that use CLS functionality
	+ Added Support for Extra Planetary launchpads
	+ Added support for Station Parts Expansion
	+ Fixed config bugs where impassablenodes had been used without setting the passable option
	+ Changed standard 1.25m dockingports to be passabel when surface mounted
	+ Some changes to the UI
