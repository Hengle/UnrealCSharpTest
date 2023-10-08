// Fill out your copyright notice in the Description page of Project Settings.


#include "TestCore/TestCoreBlueprintFunctionLibrary.h"

FString UTestCoreBlueprintFunctionLibrary::GetPlatform()
{
#if PLATFORM_WINDOWS
	return TEXT("Windows");
#elif PLATFORM_LINUX
	return TEXT("Linux");
#elif PLATFORM_MAC
	return TEXT("Mac");
#elif PLATFORM_ANDROID
	return TEXT("Android");
#elif PLATFORM_IOS
	return TEXT("IOS");
#endif
}

FString UTestCoreBlueprintFunctionLibrary::GetBuildConfiguration()
{
#if UE_BUILD_DEBUG
	return TEXT("Debug");
#elif UE_BUILD_DEVELOPMENT
	return TEXT("Development");
#elif UE_BUILD_TEST
	return TEXT("Test");
#elif UE_BUILD_SHIPPING
	return TEXT("Shipping");
#endif
}

void UTestCoreBlueprintFunctionLibrary::SaveStringToFile(FString FileName, const FString& String)
{
	const auto FileManager = &IFileManager::Get();

	FFileHelper::SaveStringToFile(String,
	                              *FPaths::Combine(FPaths::ProjectSavedDir(), FileName),
	                              FFileHelper::EEncodingOptions::ForceUTF8, FileManager,
	                              FILEWRITE_None);
}
