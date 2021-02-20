# ConnectedLivingSpace :: Change Log

* 2015-1203: 1.2.0.1 (Papa Joe) for KSP 1.0.5
	+ release v1.2.0.1
		- Add build deploy automation to project.
		- Correct deploy error resulting in incorrect dll build being released.
* 2015-1120: 1.2.0.0 (Papa Joe) for KSP 1.0.2
	+ release v1.2.0.0
		- Added Editor-based tweakables to allow passability customization of a part during vessel construction. Off by default. (Original CLS behavior)
		- Added option to enable / disable parts not originally passable.
		- Expand and reformat parameter info in the RMB of the editor part description dialog.
		- Added options window and moved options out of CLS window.
		- Fixed bug with turning off Blizzy toolbar icon in Editor.
* 2015-0620: 1.1.3.1 (Papa Joe) for KSP 1.0.2
	+ release v1.1.3.1
		- Changed Unrestricted Crew Transfers option to be available when no vessel is loaded in VAB/SPH
		- Fixed a bug in the Use Blizzy's Toolbar option to disable the option when Blizzy's Toolbar is not installed.
		- Added Freedom Alt Stock MM config changes.
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
	+ release v1.0.11.0
		- Fixed a bug in the stock transfer code that meant it only worked for the first vessel.
* 2014-1023: 1.0.10.0 (CodePoet) for KSP 0.25
	+ release v1.0.10.0
		- Add CLS support to stock transfers
		- Fixed a problem of unconfigured parts with crewspace not being considered passable
		- Removed Near Future config which is now shipped with Near Future
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
	+ release v1.0.8.0
		- Built against KSP 0.24.2
		- Updated build process to use zip utilities installed on 64 bit OS
		- Changed to use the stock toolbar, and removed the dependency on blizzy's toolbar.
		- Improved the configuration documentation, and made it easier to find (in the mod root directory)
		- Fixed issue with the descriptions of the parts in the VAB/SPH
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
	+ CLS release v1.0.5.0
		- Added interfaces to be used by other mods that use CLS functionality
		- Added Support for Extra Planetary launchpads
		- Added support for Station Parts Expansion
		- Fixed config bugs where impassablenodes had been used without setting the passable option
		- Changed standard 1.25m dockingports to be passabel when surface mounted
		- Some changes to the UI
