## Xamarin Forms iOS binding --> Maui iOS binding

## Update to newer sumup release  

1) Download the new SDK from here:

  https://github.com/sumup/sumup-ios-sdk

2) On the mac, install Objective Sharpie.  See here:

   https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie

3) Run Objective Sharpie.  The commands will be something like:

      SumUp providing new version of lib for iOS xcframework
	  so need to run command for every file in headers folder 
	    SumUpSDK.framework/Headers/
		SMPCheckoutResult.h
		SMPCheckoutRequest.h
		SMPCurrencyCodes.h
		etc


     sharpie bind -output Binding  -sdk iphoneos16.2 SumUpSDK.framework/Headers/SumUpSDK.h -scope SumUpSDK.framework/Headers/ -n SumUpSDKBinding -c -F /Users/danilkurkin/SumUp/SumUpSDK.xcframework/ios-arm64_armv7/SumUpSDK.framework

  

4) Compare the generated .cs files with the existing ones in SumUpSDK.framework, and merge any required changes.  There will be
   many [Verify] attributes which need to be removed - these indicate where Objective Sharpie may have generated incorrect code.

5) Remove the SumUpSDK, PPHR_BLE, native references from the SumUpSDKBinding project, delete
   any leftover files in the folder and add the new versions of the frameworks from <path-to-sdk>/frameworks and
   <path-to-sdk>/RSDK/Release.

6) Make sure proj file has tags like in example

<Project Sdk="Microsoft.NET.Sdk">
      <PropertyGroup>
        <TargetFramework>net8.0-ios</TargetFramework>
        <Nullable>enable</Nullable>
        <ImplicitUsings>true</ImplicitUsings>
        <IsBindingProject>true</IsBindingProject>
    </PropertyGroup>

    <ItemGroup>
        <ObjcBindingApiDefinition Include="ApiDefinition.cs"/>
        <ObjcBindingCoreSource Include="StructsAndEnums.cs"/>
    </ItemGroup>
    <ItemGroup>
    <NativeReference Include="SumUpSDK.xcframework">
         <Kind>Framework</Kind>
         <Frameworks>Foundation</Frameworks>
         <ForceLoad>True</ForceLoad>
         <SmartLink>False</SmartLink>
	</NativeReference>
	</ItemGroup>
</Project> 

