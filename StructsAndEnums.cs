using System;
using ObjCRuntime;
using System.Runtime.InteropServices;
namespace SumUpSDKBinding
{
	[Native]
	public enum SMPSumUpSDKError : long//nint
	{
		General = 0,
		ActivationNeeded = 1,
		AccountGeneral = 20,
		AccountNotLoggedIn = 21,
		AccountIsLoggedIn = 22,
		CheckoutGeneral = 50,
		CheckoutInProgress = 51,
		CheckoutCurrencyCodeMismatch = 52,
		DuplicateForeignID = 53,
		InvalidAccessToken = 54,
		InvalidAmountDecimals = 55
	}

	[Native]
	public enum SMPSumUpRegisterSDKError : long//nint
	{
		General = 0,
		NotConnected = 10,
		FirmwareUpdateInProgress = 20,
		Timeout = 30,
		TimeoutFirmwareUpdate = 31
	}

	static class CFunctions
	{
		// extern int NS_OPTIONS (int NSUInteger, int SMPSkipScreenOptions);
		[DllImport("__Internal")]
		static extern int NS_OPTIONS(int NSUInteger, int SMPSkipScreenOptions);

		// extern int NS_SWIFT_NAME ();
		[DllImport("__Internal")]
		static extern int NS_SWIFT_NAME();
	}

	[Native]
	public enum SMPSkipScreenOptions : long//nuint
	{
		None = 0,
		Success = 1 << 0,
		Failed = 1 << 1
	}

	[Native]
	public enum SMPPaymentOptions : long//nuint
	{
		Any = 0,
		CardReader = 1 << 0,
		MobilePayment = 1 << 1
	}
}
