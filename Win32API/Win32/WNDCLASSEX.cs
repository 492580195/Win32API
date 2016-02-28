using System;

namespace Win32
{
	public struct WNDCLASSEX
	{
		public int cbSize;

		public int style;

		public int lpfnWndProc;

		public int cbClsExtra;

		public int cbWndExtra;

		public IntPtr hInstance;

		public IntPtr hIcon;

		public IntPtr hCursor;

		public IntPtr hbrBackground;

		public string lpszMenuName;

		public string lpszClassName;

		public IntPtr hIconSm;
	}
}
