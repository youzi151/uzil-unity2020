// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2021 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX)
	#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks {
	public static class SteamRemotePlay {
		/// <summary>
		/// <para> Get the number of currently connected Steam Remote Play sessions</para>
		/// </summary>
		public static uint GetSessionCount() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_GetSessionCount(CSteamAPIContext.GetSteamRemotePlay());
		}

		/// <summary>
		/// <para> Get the currently connected Steam Remote Play session ID at the specified index. Returns zero if index is out of bounds.</para>
		/// </summary>
		public static RemotePlaySessionID_t GetSessionID(int iSessionIndex) {
			InteropHelp.TestIfAvailableClient();
			return (RemotePlaySessionID_t)NativeMethods.ISteamRemotePlay_GetSessionID(CSteamAPIContext.GetSteamRemotePlay(), iSessionIndex);
		}

		/// <summary>
		/// <para> Get the SteamID of the connected user</para>
		/// </summary>
		public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID) {
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamRemotePlay_GetSessionSteamID(CSteamAPIContext.GetSteamRemotePlay(), unSessionID);
		}

		/// <summary>
		/// <para> Get the name of the session client device</para>
		/// <para> This returns NULL if the sessionID is not valid</para>
		/// </summary>
		public static string GetSessionClientName(RemotePlaySessionID_t unSessionID) {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamRemotePlay_GetSessionClientName(CSteamAPIContext.GetSteamRemotePlay(), unSessionID));
		}

		/// <summary>
		/// <para> Get the form factor of the session client device</para>
		/// </summary>
		public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_GetSessionClientFormFactor(CSteamAPIContext.GetSteamRemotePlay(), unSessionID);
		}

		/// <summary>
		/// <para> Get the resolution, in pixels, of the session client device</para>
		/// <para> This is set to 0x0 if the resolution is not available</para>
		/// </summary>
		public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_BGetSessionClientResolution(CSteamAPIContext.GetSteamRemotePlay(), unSessionID, out pnResolutionX, out pnResolutionY);
		}

		/// <summary>
		/// <para> Invite a friend to Remote Play Together</para>
		/// <para> This returns false if the invite can't be sent</para>
		/// </summary>
		public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemotePlay_BSendRemotePlayTogetherInvite(CSteamAPIContext.GetSteamRemotePlay(), steamIDFriend);
		}
	}
}

#endif // !DISABLESTEAMWORKS
