using System;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace SumUpSDKBinding
{
	// The first step to creating a binding is to add your native framework ("MyLibrary.xcframework")
	// to the project.
	// Open your binding csproj and add a section like this
	// <ItemGroup>
	//   <NativeReference Include="MyLibrary.xcframework">
	//     <Kind>Framework</Kind>
	//     <Frameworks></Frameworks>
	//   </NativeReference>
	// </ItemGroup>
	//
	// Once you've added it, you will need to customize it for your specific library:
	//  - Change the Include to the correct path/name of your library
	//  - Change Kind to Static (.a) or Framework (.framework/.xcframework) based upon the library kind and extension.
	//    - Dynamic (.dylib) is a third option but rarely if ever valid, and only on macOS and Mac Catalyst
	//  - If your library depends on other frameworks, add them inside <Frameworks></Frameworks>
	// Example:
	// <NativeReference Include="libs\MyTestFramework.xcframework">
	//   <Kind>Framework</Kind>
	//   <Frameworks>CoreLocation ModelIO</Frameworks>
	// </NativeReference>
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, nint index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     NativeHandle Constructor (ElmoMuppet elmo);
	//
	// For more information, see https://aka.ms/ios-binding
	//

	[Static]
	partial interface Constants
	{
		// extern double SumUpSDKVersionNumber;
		[Field("SumUpSDKVersionNumber", "__Internal")]
		double SumUpSDKVersionNumber { get; }

		//// extern const unsigned char [] SumUpSDKVersionString;
		//[Field("SumUpSDKVersionString", "__Internal")]
		//char[] SumUpSDKVersionString { get; }

		// extern NSString *const _Nonnull SMPSumUpSDKErrorDomain;
		[Field("SMPSumUpSDKErrorDomain", "__Internal")]
		NSString SMPSumUpSDKErrorDomain { get; }

		// extern NSString *const _Nonnull SMPSumUpRegisterSDKErrorDomain;
		[Field("SMPSumUpRegisterSDKErrorDomain", "__Internal")]
		NSString SMPSumUpRegisterSDKErrorDomain { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeBGN;
		[Field("SMPCurrencyCodeBGN", "__Internal")]
		NSString SMPCurrencyCodeBGN { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeBRL;
		[Field("SMPCurrencyCodeBRL", "__Internal")]
		NSString SMPCurrencyCodeBRL { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeCHF;
		[Field("SMPCurrencyCodeCHF", "__Internal")]
		NSString SMPCurrencyCodeCHF { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeCLP;
		[Field("SMPCurrencyCodeCLP", "__Internal")]
		NSString SMPCurrencyCodeCLP { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeCOP;
		[Field("SMPCurrencyCodeCOP", "__Internal")]
		NSString SMPCurrencyCodeCOP { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeCZK;
		[Field("SMPCurrencyCodeCZK", "__Internal")]
		NSString SMPCurrencyCodeCZK { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeDKK;
		[Field("SMPCurrencyCodeDKK", "__Internal")]
		NSString SMPCurrencyCodeDKK { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeEUR;
		[Field("SMPCurrencyCodeEUR", "__Internal")]
		NSString SMPCurrencyCodeEUR { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeGBP;
		[Field("SMPCurrencyCodeGBP", "__Internal")]
		NSString SMPCurrencyCodeGBP { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeHUF;
		[Field("SMPCurrencyCodeHUF", "__Internal")]
		NSString SMPCurrencyCodeHUF { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeNOK;
		[Field("SMPCurrencyCodeNOK", "__Internal")]
		NSString SMPCurrencyCodeNOK { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodePLN;
		[Field("SMPCurrencyCodePLN", "__Internal")]
		NSString SMPCurrencyCodePLN { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeRON;
		[Field("SMPCurrencyCodeRON", "__Internal")]
		NSString SMPCurrencyCodeRON { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeSEK;
		[Field("SMPCurrencyCodeSEK", "__Internal")]
		NSString SMPCurrencyCodeSEK { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeUSD;
		[Field("SMPCurrencyCodeUSD", "__Internal")]
		NSString SMPCurrencyCodeUSD { get; }

		// extern NSString *const _Nonnull SMPCurrencyCodeHRK;
		[Field("SMPCurrencyCodeHRK", "__Internal")]
		NSString SMPCurrencyCodeHRK { get; }
	}

	// typedef void (^SMPCompletionBlock)(BOOL, NSError * _Nullable);
	delegate void SMPCompletionBlock(bool arg0, [NullAllowed] NSError arg1);

	// typedef void (^SMPCheckoutCompletionBlock)(SMPCheckoutResult * _Nullable, NSError * _Nullable);
	delegate void SMPCheckoutCompletionBlock([NullAllowed] SMPCheckoutResult arg0, [NullAllowed] NSError arg1);

	// @interface SMPMerchant : NSObject
	[BaseType(typeof(NSObject))]
	[Protocol]
	interface SMPMerchant
	{
		// @property (readonly, copy) NSString * _Nullable currencyCode;
		[NullAllowed, Export("currencyCode")]
		string CurrencyCode { get; }

		// @property (readonly, copy) NSString * _Nullable merchantCode;
		[NullAllowed, Export("merchantCode")]
		string MerchantCode { get; }
	}

	// @interface SMPSumUpSDK : NSObject
	[BaseType(typeof(NSObject))]
	[Protocol]
	interface SMPSumUpSDK
	{
		// @property (readonly, class) BOOL isLoggedIn;
		[Static]
		[Export("isLoggedIn")]
		bool IsLoggedIn { get; }

		// @property (readonly, class) SMPMerchant * _Nullable currentMerchant;
		[Static]
		[NullAllowed, Export("currentMerchant")]
		SMPMerchant CurrentMerchant { get; }

		// @property (readonly, class) BOOL checkoutInProgress;
		[Static]
		[Export("checkoutInProgress")]
		bool CheckoutInProgress { get; }

		// @property (readonly, class) NSString * _Nonnull bundleVersion;
		[Static]
		[Export("bundleVersion")]
		string BundleVersion { get; }

		// @property (readonly, class) NSString * _Nonnull bundleVersionShortString;
		[Static]
		[Export("bundleVersionShortString")]
		string BundleVersionShortString { get; }

		// +(BOOL)setupWithAPIKey:(NSString * _Nonnull)apiKey;
		[Static]
		[Export("setupWithAPIKey:")]
		bool SetupWithAPIKey(string apiKey);

		// +(void)presentLoginFromViewController:(UIViewController * _Nonnull)fromViewController animated:(BOOL)animated completionBlock:(SMPCompletionBlock _Nullable)block;
		[Static]
		[Export("presentLoginFromViewController:animated:completionBlock:")]
		void PresentLoginFromViewController(UIViewController fromViewController, bool animated, [NullAllowed] SMPCompletionBlock block);

		// +(void)loginWithToken:(NSString * _Nonnull)aToken completion:(SMPCompletionBlock _Nullable)block;
		[Static]
		[Export("loginWithToken:completion:")]
		void LoginWithToken(string aToken, [NullAllowed] SMPCompletionBlock block);

		// +(void)prepareForCheckout;
		[Static]
		[Export("prepareForCheckout")]
		void PrepareForCheckout();

		// +(void)checkoutWithRequest:(SMPCheckoutRequest * _Nonnull)request fromViewController:(UIViewController * _Nonnull)controller completion:(SMPCheckoutCompletionBlock _Nullable)block;
		[Static]
		[Export("checkoutWithRequest:fromViewController:completion:")]
		void CheckoutWithRequest(SMPCheckoutRequest request, UIViewController controller, [NullAllowed] SMPCheckoutCompletionBlock block);

		// +(void)presentCheckoutPreferencesFromViewController:(UIViewController * _Nonnull)fromViewController animated:(BOOL)animated completion:(SMPCompletionBlock _Nullable)block;
		[Static]
		[Export("presentCheckoutPreferencesFromViewController:animated:completion:")]
		void PresentCheckoutPreferencesFromViewController(UIViewController fromViewController, bool animated, [NullAllowed] SMPCompletionBlock block);

		// +(void)logoutWithCompletionBlock:(SMPCompletionBlock _Nullable)block;
		[Static]
		[Export("logoutWithCompletionBlock:")]
		void LogoutWithCompletionBlock([NullAllowed] SMPCompletionBlock block);

		// +(void)setUINotificationsForReaderStatusEnabled:(BOOL)enabled;
		[Static]
		[Export("setUINotificationsForReaderStatusEnabled:")]
		void SetUINotificationsForReaderStatusEnabled(bool enabled);

		// @property (readonly, class) BOOL isTipOnCardReaderAvailable;
		[Static]
		[Export("isTipOnCardReaderAvailable")]
		bool IsTipOnCardReaderAvailable { get; }

		// +(BOOL)testSDKIntegration;
		[Static]
		[Export("testSDKIntegration")]
		bool TestSDKIntegration { get; }

	}

	// @protocol SMPSumUpRegisterSDKDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SMPSumUpRegisterSDKDelegate
	{
		// @required -(void)registerDidConnect:(SMPRegisterSDKStatus * _Nonnull)deviceStatus;
		[Abstract]
		[Export("registerDidConnect:")]
		void RegisterDidConnect(SMPRegisterSDKStatus deviceStatus);

		// @required -(void)registerDidDisconnect;
		[Abstract]
		[Export("registerDidDisconnect")]
		void RegisterDidDisconnect();

		// @required -(void)registerStatusDidChange:(SMPRegisterSDKStatus * _Nullable)deviceStatus;
		[Abstract]
		[Export("registerStatusDidChange:")]
		void RegisterStatusDidChange([NullAllowed] SMPRegisterSDKStatus deviceStatus);

		// @required -(void)drawerDidOpen;
		[Abstract]
		[Export("drawerDidOpen")]
		void DrawerDidOpen();

		// @required -(void)drawerDidClose;
		[Abstract]
		[Export("drawerDidClose")]
		void DrawerDidClose();

		// @required -(void)printerStatusDidChange:(SMPRegisterSDKPrinterStatus * _Nullable)status;
		[Abstract]
		[Export("printerStatusDidChange:")]
		void PrinterStatusDidChange([NullAllowed] SMPRegisterSDKPrinterStatus status);
	}


	// @interface SMPSumUpRegisterSDK : NSObject
	[BaseType(typeof(NSObject))]
	[Protocol]
	[DisableDefaultCtor]
	interface SMPSumUpRegisterSDK
	{
		// @property (readonly, class) BOOL registerIsSupported;
		[Static]
		[Export("registerIsSupported")]
		bool RegisterIsSupported { get; }

		// @property (readonly, class) SMPSumUpRegisterSDK * _Nullable sharedInstance;
		[Static]
		[NullAllowed, Export("sharedInstance")]
		SMPSumUpRegisterSDK SharedInstance { get; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		SMPSumUpRegisterSDKDelegate Delegate { get; set; }

		// @property (weak) id<SMPSumUpRegisterSDKDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly) SMPRegisterSDKStatus * _Nullable deviceStatus;
		[NullAllowed, Export("deviceStatus")]
		SMPRegisterSDKStatus DeviceStatus { get; }

		// @property (readonly) SMPRegisterSDKPrinterStatus * _Nullable printerStatus;
		[NullAllowed, Export("printerStatus")]
		SMPRegisterSDKPrinterStatus PrinterStatus { get; }

		// @property (readonly) BOOL drawerIsOpen;
		[Export("drawerIsOpen")]
		bool DrawerIsOpen { get; }

		// -(void)startListeningForRegister;
		[Export("startListeningForRegister")]
		void StartListeningForRegister();

		// -(void)stopListeningForRegister;
		[Export("stopListeningForRegister")]
		void StopListeningForRegister();

		// -(void)printEscPos:(NSString * _Nonnull)escposString;
		[Export("printEscPos:")]
		void PrintEscPos(string escposString);

		// -(void)openDrawer;
		[Export("openDrawer")]
		void OpenDrawer();

		// -(void)startFirmwareUpdateWithCompletion:(SMPRegisterCompletionBlock _Nonnull)completion;
		[Export("startFirmwareUpdateWithCompletion:")]
		void StartFirmwareUpdateWithCompletion(SMPRegisterCompletionBlock completion);
	}

	// typedef void (^SMPRegisterCompletionBlock)(BOOL, NSError * _Nullable);
	delegate void SMPRegisterCompletionBlock(bool arg0, [NullAllowed] NSError arg1);

	// @interface SMPRegisterSDKStatus : NSObject
	[BaseType(typeof(NSObject))]
	[Protocol]
	interface SMPRegisterSDKStatus
	{
		// @property (readonly) BOOL isReaderConnected;
		[Export("isReaderConnected")]
		bool IsReaderConnected { get; }

		// @property (readonly) BOOL isCharging;
		[Export("isCharging")]
		bool IsCharging { get; }

		// @property (readonly) NSUInteger batteryLevel;
		[Export("batteryLevel")]
		nuint BatteryLevel { get; }

		// @property (readonly) BOOL isBatteryLow;
		[Export("isBatteryLow")]
		bool IsBatteryLow { get; }

		// @property (readonly) NSString * _Nullable serialNumber;
		[NullAllowed, Export("serialNumber")]
		string SerialNumber { get; }

		// @property (readonly) NSString * _Nullable firmwareVersion;
		[NullAllowed, Export("firmwareVersion")]
		string FirmwareVersion { get; }
	}

	// @interface SMPRegisterSDKPrinterStatus : NSObject
	[BaseType(typeof(NSObject))]
	[Protocol]
	interface SMPRegisterSDKPrinterStatus
	{
		// @property (readonly) BOOL isPrinterReady;
		[Export("isPrinterReady")]
		bool IsPrinterReady { get; }

		// @property (readonly) BOOL isPaperEmpty;
		[Export("isPaperEmpty")]
		bool IsPaperEmpty { get; }

		// @property (readonly) BOOL genericErrorDidOccur;
		[Export("genericErrorDidOccur")]
		bool GenericErrorDidOccur { get; }
	}


	// @interface SMPCheckoutResult : NSObject
	[BaseType(typeof(NSObject))]
	[Protocol]
	interface SMPCheckoutResult
	{
		// @property (readonly) BOOL success;
		[Export("success")]
		bool Success { get; }

		// @property (readonly) NSString * _Nullable transactionCode;
		[NullAllowed, Export("transactionCode")]
		string TransactionCode { get; }

		// @property (readonly) NSDictionary * _Nullable additionalInfo;
		[NullAllowed, Export("additionalInfo")]
		NSDictionary AdditionalInfo { get; }
	}

	// @interface SMPCheckoutRequest : NSObject
	[BaseType(typeof(NSObject))]
	[Protocol]
	interface SMPCheckoutRequest
	{
		// +(SMPCheckoutRequest * _Nonnull)requestWithTotal:(NSDecimalNumber * _Nonnull)totalAmount title:(NSString * _Nullable)title currencyCode:(NSString * _Nonnull)currencyCode paymentOptions:(SMPPaymentOptions)paymentOptions __attribute__((deprecated("Payment options will be ignored and default to .any. Options presented will be governed by merchant settings. Please use requestWithTotal:title:currencyCode: instead.")));
		[Static]
		[Export("requestWithTotal:title:currencyCode:paymentOptions:")]
		SMPCheckoutRequest RequestWithTotal(NSDecimalNumber totalAmount, [NullAllowed] string title, string currencyCode, SMPPaymentOptions paymentOptions);

		// +(SMPCheckoutRequest * _Nonnull)requestWithTotal:(NSDecimalNumber * _Nonnull)totalAmount title:(NSString * _Nullable)title currencyCode:(NSString * _Nonnull)currencyCode;
		[Static]
		[Export("requestWithTotal:title:currencyCode:")]
		SMPCheckoutRequest RequestWithTotal(NSDecimalNumber totalAmount, [NullAllowed] string title, string currencyCode);

		// @property (readonly, nonatomic) NSDecimalNumber * _Nullable totalAmount;
		[NullAllowed, Export("totalAmount")]
		NSDecimalNumber TotalAmount { get; }

		// @property (readonly, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export("title")]
		string Title { get; }

		// @property (readonly, nonatomic) NSString * _Nullable currencyCode;
		[NullAllowed, Export("currencyCode")]
		string CurrencyCode { get; }

		// @property (readonly, nonatomic) SMPPaymentOptions paymentOptions __attribute__((deprecated("Payment options will be ignored and default to .any")));
		[Export("paymentOptions")]
		SMPPaymentOptions PaymentOptions { get; }

		// @property (copy, nonatomic) NSString * _Nullable foreignTransactionID;
		[NullAllowed, Export("foreignTransactionID")]
		string ForeignTransactionID { get; set; }

		// @property (copy, nonatomic) NSDecimalNumber * _Nullable tipAmount;
		[NullAllowed, Export("tipAmount", ArgumentSemantic.Copy)]
		NSDecimalNumber TipAmount { get; set; }

		// @property (nonatomic) BOOL tipOnCardReaderIfAvailable;
		[Export("tipOnCardReaderIfAvailable")]
		bool TipOnCardReaderIfAvailable { get; set; }

		// @property (nonatomic) NSUInteger saleItemsCount;
		[Export("saleItemsCount")]
		nuint SaleItemsCount { get; set; }

		// @property (nonatomic) SMPSkipScreenOptions skipScreenOptions;
		[Export("skipScreenOptions", ArgumentSemantic.Assign)]
		SMPSkipScreenOptions SkipScreenOptions { get; set; }
	}
}
