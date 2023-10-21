// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Reflection/TestCSharpFunctionActor.h"

// Sets default values
ATestCSharpFunctionActor::ATestCSharpFunctionActor():
	BoolValue(true),
	Int8Value(12),
	Int16Value(12),
	Int32Value(12),
	Int64Value(12),
	UInt8Value(12),
	UInt16Value(12),
	UInt32Value(12),
	UInt64Value(12),
	FloatValue(12.3f),
	DoubleValue(12.3),
	TestCoreSubsystem(nullptr)
{
	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void ATestCSharpFunctionActor::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ATestCSharpFunctionActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

void ATestCSharpFunctionActor::SetBoolValueFunction_Implementation(const bool InBoolValue)
{
	BoolValue = InBoolValue;
}

bool ATestCSharpFunctionActor::GetBoolValueFunction_Implementation() const
{
	return BoolValue;
}

void ATestCSharpFunctionActor::OutBoolValueFunction_Implementation(bool& OutBoolValue) const
{
	OutBoolValue = BoolValue;
}

void ATestCSharpFunctionActor::SetInt32ValueFunction_Implementation(const int32 InInt32Value)
{
	Int32Value = InInt32Value;
}

int32 ATestCSharpFunctionActor::GetInt32ValueFunction_Implementation() const
{
	return Int32Value;
}

void ATestCSharpFunctionActor::OutInt32ValueFunction_Implementation(int32& OutInt32Value) const
{
	OutInt32Value = Int32Value;
}

void ATestCSharpFunctionActor::SetInt64ValueFunction_Implementation(const int64 InInt64Value)
{
	Int64Value = InInt64Value;
}

int64 ATestCSharpFunctionActor::GetInt64ValueFunction_Implementation() const
{
	return Int64Value;
}

void ATestCSharpFunctionActor::OutInt64ValueFunction_Implementation(int64& OutInt64Value) const
{
	OutInt64Value = Int64Value;
}

void ATestCSharpFunctionActor::SetUInt8ValueFunction_Implementation(const uint8 InUInt8Value)
{
	UInt8Value = InUInt8Value;
}

uint8 ATestCSharpFunctionActor::GetUInt8ValueFunction_Implementation() const
{
	return UInt8Value;
}

void ATestCSharpFunctionActor::OutUInt8ValueFunction_Implementation(uint8& OutUInt8Value) const
{
	OutUInt8Value = UInt8Value;
}

void ATestCSharpFunctionActor::SetFloatValueFunction_Implementation(const float InFloatValue)
{
	FloatValue = InFloatValue;
}

float ATestCSharpFunctionActor::GetFloatValueFunction_Implementation() const
{
	return FloatValue;
}

void ATestCSharpFunctionActor::OutFloatValueFunction_Implementation(float& OutFloatValue) const
{
	OutFloatValue = FloatValue;
}

void ATestCSharpFunctionActor::SetDoubleValueFunction_Implementation(const double InDoubleValue)
{
	DoubleValue = InDoubleValue;
}

double ATestCSharpFunctionActor::GetDoubleValueFunction_Implementation() const
{
	return DoubleValue;
}

void ATestCSharpFunctionActor::OutDoubleValueFunction_Implementation(double& OutDoubleValue) const
{
	OutDoubleValue = DoubleValue;
}