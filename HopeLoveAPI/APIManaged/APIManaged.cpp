// 这是主 DLL 文件。

#include "stdafx.h"

#include "APIManaged.h"

#include "../HopeLoveAPI/HopeLoveAPI.h"

namespace APIManaged
{
	void Func::InitializeBrain(String^ datadir)
	{
// 		if (datadir == nullptr)
// 		{
// 			HopeLove::InitializeBrain();
// 		}
// 		else
// 		{
// 			IntPtr pString = Marshal::StringToHGlobalAnsi(datadir);
// 
// 			char* pchString = static_cast<char*>(pString.ToPointer());
// 
// 			HopeLove::InitializeBrain(pchString);
// 		}

	}

	void Func::DisposeBrain()
	{
		HopeLove::DisposeBrain();
	}

	cli::array<String^>^ Func::WordSegment(String^ sentence)
	{
		IntPtr pString = Marshal::StringToHGlobalAnsi(sentence);

		char* pchString = static_cast<char*>(pString.ToPointer());

		try
		{
			std::vector<std::string> vec = HopeLove::WordSegment(pchString);

			array<String^>^ res = gcnew array<String^>(vec.size());

			for (unsigned int i = 0; i < vec.size(); ++i)
			{
				res[i] = gcnew String(vec[i].c_str());
			}

			return res;
		}
		catch (const std::exception&)
		{
			return nullptr;
			
		}
		
	}
}

