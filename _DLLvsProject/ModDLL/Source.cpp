#define EXPORT_API __declspec(dllexport)

//real dll
#include <random>
#include <time.h>

// Link following functions C-style (required for plugins)
extern "C"
{
	//get data of creation
}