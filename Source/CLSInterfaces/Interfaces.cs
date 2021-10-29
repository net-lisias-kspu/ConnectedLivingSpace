/*
	This file is part of Ship Manifest /L Unleashed
		© 2021 Lisias T : http://lisias.net <support@lisias.net>
		© 2020 micha (mwerle)
		© 2015-2018 Papa_Joe
		© 2014-2015 codepoet

	Ship Manifest /L Unleashed is licensed as follows:

		* CC BY-NC-SA 4.0i : https://creativecommons.org/licenses/by-nc-sa/4.0/

	Ship Manifest /L Unleashed is distributed in the hope that
	it will be useful, but WITHOUT ANY WARRANTY; without even the implied
	warranty of	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

*/
using System;
using System.Collections.Generic;

namespace ConnectedLivingSpace
{
    public interface ICLSAddon
    {
        bool AllowUnrestrictedTransfers { get; set; }

        ICLSVessel Vessel { get; }
        ICLSVessel getCLSVessel(Vessel v);

        bool RequestAddConnection(Part part1, Part part2);
        List<bool> RequestAddConnections(List<Part> part1, List<Part> part2);
        bool RequestRemoveConnection(Part part1, Part part2);
        List<bool> RequestRemoveConnections(List<Part> part1, List<Part> part2);
    }

    public interface ICLSVessel
    {
        List<ICLSSpace> Spaces { get; }
        List<ICLSPart> Parts { get; }
        void Highlight(bool arg);
    }

    public interface ICLSSpace
    {
        List<ICLSPart> Parts {get;}
        int MaxCrew {get;}
        String Name {get;set;}
        ICLSVessel Vessel {get;}
        List<ICLSKerbal> Crew {get;}
        void Highlight(bool val);
    }

    public interface ICLSPart
    {
        ICLSSpace Space { get; }
        bool Docked { get; }
        List<ICLSKerbal> Crew { get; }
        Part Part { get; }
        void Highlight(bool val, bool force);
        bool Habitable { get; }
        bool Navigable { get; }
    }

    public interface IModuleDockingHatch
    {
        bool HatchOpen { get; set; }
        string HatchStatus { get; }
        bool IsDocked { get; }
        ModuleDockingNode ModDockNode { get; }
        BaseEventList HatchEvents { get; }
    }

    public interface ICLSKerbal
    {
        ICLSPart Part { get;}
        ProtoCrewMember Kerbal { get; }
    }
}
