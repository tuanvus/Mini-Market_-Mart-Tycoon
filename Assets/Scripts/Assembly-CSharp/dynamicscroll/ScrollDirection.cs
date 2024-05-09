using System;

namespace dynamicscroll
{
	[Flags]
	public enum ScrollDirection
	{
		NONE = 1,
		LEFT = 2,
		RIGHT = 4,
		UP = 8,
		DOWN = 0x10
	}
}
