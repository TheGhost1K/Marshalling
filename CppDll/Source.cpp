#define Source _declspec(dllexport)

struct MyStruct 
{
	int a, b;
};

extern "C"
{
	Source int Add(int a, int b)
	{
		return a + b;
	}

	Source int Substract(int a, int b)
	{
		return a - b;
	}

	Source int StructAdd(MyStruct myStr)
	{
		return myStr.a + myStr.b;
	}

	Source int StructSubstract(MyStruct myStr)
	{
		return myStr.a - myStr.b;
	}
}