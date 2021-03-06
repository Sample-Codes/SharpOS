//
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//	Bruce Markham <illuminus86@gmail.com>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

namespace SharpOS.Kernel.Tests.CS
{
	public class UInt32
	{

		public static int CMPToString ()
		{
			uint nbr = 1000;

			string str = nbr.ToString ();

			if (str != "1000")
				return 0;

			return 1;
		}

		public static int CMPToString2 ()
		{
			uint nbr = 0;

			string str = nbr.ToString ();

			if (str != "0")
				return 0;

			return 1;
		}
	}
}
