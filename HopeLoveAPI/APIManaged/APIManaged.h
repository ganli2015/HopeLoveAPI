// APIManaged.h

#pragma once

using namespace System;

using namespace System::Runtime::InteropServices;

namespace APIManaged {

	public ref class Func
	{
	public:

		static void InitializeBrain(String^ datadir);

		static void  DisposeBrain();

		static array<String^>^ WordSegment(String^ sentence);
	};

}
