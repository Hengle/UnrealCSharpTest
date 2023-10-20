// Fill out your copyright notice in the Description page of Project Settings.


#include "TestCore/TestCoreSubsystem.h"
#include "Kismet/KismetMathLibrary.h"
#include "Kismet/KismetStringLibrary.h"
#include "TestBase/TestBaseSubsystem.h"
#include "TestCore/TestCoreBlueprintFunctionLibrary.h"

void UTestCoreSubsystem::Test() const
{
	StartTest();

	ProcessTest();

	EndTest();
}

void UTestCoreSubsystem::StartTest() const
{
}

void UTestCoreSubsystem::ProcessTest() const
{
	auto TestSubsystemArray = GetWorld()->GetSubsystemArray<UTestBaseSubsystem>();

	for (const auto& TestSubsystem : TestSubsystemArray)
	{
		TestSubsystem->Test();
	}
}

void UTestCoreSubsystem::EndTest() const
{
	FString Value;

	Value.Append("What, bIsPassed\n");

	const auto Now = UKismetMathLibrary::Now();

	for (const auto& Result : TestResults)
	{
		Value.Append(Result.What).
		      Append(", ").
		      Append(UKismetStringLibrary::Conv_BoolToString(Result.bIsPassed)).
		      Append("\n");
	}

	const auto File = FString::Printf(TEXT("UnrealCSharp-%s-%s-%d-%d-%d-%d-%d-%d-%d.csv"),
	                                  *UTestCoreBlueprintFunctionLibrary::GetPlatform(),
	                                  *UTestCoreBlueprintFunctionLibrary::GetBuildConfiguration(),
	                                  Now.GetYear(),
	                                  Now.GetMonth(),
	                                  Now.GetDay(),
	                                  Now.GetHour(),
	                                  Now.GetMinute(),
	                                  Now.GetSecond(),
	                                  Now.GetMillisecond()
	);

	UTestCoreBlueprintFunctionLibrary::SaveStringToFile(File, Value);
}

void UTestCoreSubsystem::TestEqual(const FString& InWhat, const FText& InActual, const FText& InExpected)
{
	Test(InWhat, InActual.ToString() == InExpected.ToString());
}

void UTestCoreSubsystem::Test(const FString& InWhat, const bool bIsPassed)
{
	TestResults.Add(FTestResult{InWhat, bIsPassed});

	if (bIsPassed)
	{
		PassedIndex.Add(TestResults.Num() - 1);
	}
	else
	{
		NotPassedIndex.Add(TestResults.Num() - 1);
	}
}
