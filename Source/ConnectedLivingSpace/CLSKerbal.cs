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
namespace ConnectedLivingSpace
{
  public class CLSKerbal : ICLSKerbal
  {
    ProtoCrewMember kerbal;
    CLSPart part;

    public CLSKerbal(ProtoCrewMember k, CLSPart p)
    {
      kerbal = k;
      part = p;
    }

    // Allow a CLSKerbal to be cast into a ProtoCrewMember
    public static implicit operator ProtoCrewMember(CLSKerbal _k)
    {
      return _k.kerbal;
    }

    public ICLSPart Part
    {
      get
      {
        return part;
      }
    }

    public ProtoCrewMember Kerbal
    {
      get
      {
        return kerbal;
      }
    }

    internal void Clear()
    {
      kerbal = null;
      part = null;
    }
  }
}