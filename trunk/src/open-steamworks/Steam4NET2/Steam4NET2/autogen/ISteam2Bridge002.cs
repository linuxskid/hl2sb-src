// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteam2Bridge002VTable
	{
		public IntPtr SetSteam2Ticket0;
		public IntPtr SetAccountName1;
		public IntPtr SetPassword2;
		public IntPtr SetAccountCreationTime3;
		public IntPtr CreateProcess4;
		public IntPtr GetConnectedUniverse5;
		public IntPtr GetIPCountry6;
		public IntPtr GetNumLicenses7;
		public IntPtr GetLicensePackageID8;
		public IntPtr GetLicenseTimeCreated9;
		public IntPtr GetLicenseTimeNextProcess10;
		public IntPtr GetLicenseMinuteLimit11;
		public IntPtr GetLicenseMinutesUsed12;
		public IntPtr GetLicensePaymentMethod13;
		public IntPtr GetLicenseFlags14;
		public IntPtr GetLicensePurchaseCountryCode15;
		public IntPtr SetOfflineMode16;
		public IntPtr GetCurrentSessionToken17;
		public IntPtr SetCellID18;
		public IntPtr SetSteam2FullASTicket19;
		public IntPtr BUpdateAppOwnershipTicket20;
		public IntPtr GetAppOwnershipTicketLength21;
		public IntPtr GetAppOwnershipTicketData22;
		public IntPtr GetAppDecryptionKey23;
		public IntPtr GetPlatformName24;
		private IntPtr DTorISteam2Bridge00225;
	};
	
	[InteropHelp.InterfaceVersion("STEAM2BRIDGE_INTERFACE_VERSION002")]
	public class ISteam2Bridge002 : InteropHelp.NativeWrapper<ISteam2Bridge002VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetSteam2TicketBI( IntPtr thisptr, Byte[] pubTicket, Int32 cubTicket );
		public void SetSteam2Ticket( Byte[] pubTicket ) 
		{
			this.GetFunction<NativeSetSteam2TicketBI>( this.Functions.SetSteam2Ticket0 )( this.ObjectAddress, pubTicket, (Int32) pubTicket.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAccountNameS( IntPtr thisptr, string szName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetAccountName( string szName ) 
		{
			return this.GetFunction<NativeSetAccountNameS>( this.Functions.SetAccountName1 )( this.ObjectAddress, szName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetPasswordS( IntPtr thisptr, string szPassword );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetPassword( string szPassword ) 
		{
			return this.GetFunction<NativeSetPasswordS>( this.Functions.SetPassword2 )( this.ObjectAddress, szPassword ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAccountCreationTimeU( IntPtr thisptr, UInt32 creationTime );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetAccountCreationTime( UInt32 creationTime ) 
		{
			return this.GetFunction<NativeSetAccountCreationTimeU>( this.Functions.SetAccountCreationTime3 )( this.ObjectAddress, creationTime ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeCreateProcessBUSSUBSU( IntPtr thisptr, Byte[] lpVACBlob, UInt32 cbVACBlob, string arg2, StringBuilder arg3, UInt32 arg4, Byte[] arg5, StringBuilder arg6, UInt32 arg7 );
		public Int32 CreateProcess( Byte[] lpVACBlob, string arg2, StringBuilder arg3, UInt32 arg4, Byte[] arg5, StringBuilder arg6, UInt32 arg7 ) 
		{
			return this.GetFunction<NativeCreateProcessBUSSUBSU>( this.Functions.CreateProcess4 )( this.ObjectAddress, lpVACBlob, (UInt32) lpVACBlob.Length, arg2, arg3, arg4, arg5, arg6, arg7 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUniverse NativeGetConnectedUniverse( IntPtr thisptr );
		public EUniverse GetConnectedUniverse(  ) 
		{
			return this.GetFunction<NativeGetConnectedUniverse>( this.Functions.GetConnectedUniverse5 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetIPCountry( IntPtr thisptr );
		public string GetIPCountry(  ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetIPCountry>( this.Functions.GetIPCountry6 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumLicenses( IntPtr thisptr );
		public UInt32 GetNumLicenses(  ) 
		{
			return this.GetFunction<NativeGetNumLicenses>( this.Functions.GetNumLicenses7 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicensePackageIDU( IntPtr thisptr, UInt32 licenseId );
		public UInt32 GetLicensePackageID( UInt32 licenseId ) 
		{
			return this.GetFunction<NativeGetLicensePackageIDU>( this.Functions.GetLicensePackageID8 )( this.ObjectAddress, licenseId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseTimeCreatedU( IntPtr thisptr, UInt32 licenseId );
		public UInt32 GetLicenseTimeCreated( UInt32 licenseId ) 
		{
			return this.GetFunction<NativeGetLicenseTimeCreatedU>( this.Functions.GetLicenseTimeCreated9 )( this.ObjectAddress, licenseId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseTimeNextProcessU( IntPtr thisptr, UInt32 licenseId );
		public UInt32 GetLicenseTimeNextProcess( UInt32 licenseId ) 
		{
			return this.GetFunction<NativeGetLicenseTimeNextProcessU>( this.Functions.GetLicenseTimeNextProcess10 )( this.ObjectAddress, licenseId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseMinuteLimitU( IntPtr thisptr, UInt32 licenseId );
		public UInt32 GetLicenseMinuteLimit( UInt32 licenseId ) 
		{
			return this.GetFunction<NativeGetLicenseMinuteLimitU>( this.Functions.GetLicenseMinuteLimit11 )( this.ObjectAddress, licenseId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseMinutesUsedU( IntPtr thisptr, UInt32 licenseId );
		public UInt32 GetLicenseMinutesUsed( UInt32 licenseId ) 
		{
			return this.GetFunction<NativeGetLicenseMinutesUsedU>( this.Functions.GetLicenseMinutesUsed12 )( this.ObjectAddress, licenseId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPaymentMethod NativeGetLicensePaymentMethodU( IntPtr thisptr, UInt32 licenseId );
		public EPaymentMethod GetLicensePaymentMethod( UInt32 licenseId ) 
		{
			return this.GetFunction<NativeGetLicensePaymentMethodU>( this.Functions.GetLicensePaymentMethod13 )( this.ObjectAddress, licenseId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELicenseFlags NativeGetLicenseFlagsU( IntPtr thisptr, UInt32 licenseId );
		public ELicenseFlags GetLicenseFlags( UInt32 licenseId ) 
		{
			return this.GetFunction<NativeGetLicenseFlagsU>( this.Functions.GetLicenseFlags14 )( this.ObjectAddress, licenseId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetLicensePurchaseCountryCodeU( IntPtr thisptr, UInt32 licenseId );
		public string GetLicensePurchaseCountryCode( UInt32 licenseId ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetLicensePurchaseCountryCodeU>( this.Functions.GetLicensePurchaseCountryCode15 )( this.ObjectAddress, licenseId ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetOfflineModeB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool offlineMode );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetOfflineMode( bool offlineMode ) 
		{
			return this.GetFunction<NativeSetOfflineModeB>( this.Functions.SetOfflineMode16 )( this.ObjectAddress, offlineMode ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetCurrentSessionToken( IntPtr thisptr, ref UInt64 retarg );
		public UInt64 GetCurrentSessionToken(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetCurrentSessionToken>( this.Functions.GetCurrentSessionToken17 )( this.ObjectAddress, ref ret ); return (UInt64)ret;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCellIDU( IntPtr thisptr, UInt32 cellId );
		public void SetCellID( UInt32 cellId ) 
		{
			this.GetFunction<NativeSetCellIDU>( this.Functions.SetCellID18 )( this.ObjectAddress, cellId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetSteam2FullASTicketBI( IntPtr thisptr, Byte[] pubTicket, Int32 cubTicket );
		public void SetSteam2FullASTicket( Byte[] pubTicket ) 
		{
			this.GetFunction<NativeSetSteam2FullASTicketBI>( this.Functions.SetSteam2FullASTicket19 )( this.ObjectAddress, pubTicket, (Int32) pubTicket.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBUpdateAppOwnershipTicketUB( IntPtr thisptr, UInt32 appId, [MarshalAs(UnmanagedType.I1)] bool arg1 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BUpdateAppOwnershipTicket( UInt32 appId, bool arg1 ) 
		{
			return this.GetFunction<NativeBUpdateAppOwnershipTicketUB>( this.Functions.BUpdateAppOwnershipTicket20 )( this.ObjectAddress, appId, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppOwnershipTicketLengthU( IntPtr thisptr, UInt32 appId );
		public UInt32 GetAppOwnershipTicketLength( UInt32 appId ) 
		{
			return this.GetFunction<NativeGetAppOwnershipTicketLengthU>( this.Functions.GetAppOwnershipTicketLength21 )( this.ObjectAddress, appId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppOwnershipTicketDataUBU( IntPtr thisptr, UInt32 appId, Byte[] lpTicketData, UInt32 cubTicketData );
		public UInt32 GetAppOwnershipTicketData( UInt32 appId, Byte[] lpTicketData ) 
		{
			return this.GetFunction<NativeGetAppOwnershipTicketDataUBU>( this.Functions.GetAppOwnershipTicketData22 )( this.ObjectAddress, appId, lpTicketData, (UInt32) lpTicketData.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAppDecryptionKeyUBU( IntPtr thisptr, UInt32 appId, Byte[] lpDecryptionKey, UInt32 cubDecryptionKey );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetAppDecryptionKey( UInt32 appId, Byte[] lpDecryptionKey ) 
		{
			return this.GetFunction<NativeGetAppDecryptionKeyUBU>( this.Functions.GetAppDecryptionKey23 )( this.ObjectAddress, appId, lpDecryptionKey, (UInt32) lpDecryptionKey.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate string NativeGetPlatformNameB( IntPtr thisptr, ref bool arg0 );
		public string GetPlatformName( ref bool arg0 ) 
		{
			return InteropHelp.DecodeANSIReturn( this.GetFunction<NativeGetPlatformNameB>( this.Functions.GetPlatformName24 )( this.ObjectAddress, ref arg0 ) ); 
		}
		
	};
}