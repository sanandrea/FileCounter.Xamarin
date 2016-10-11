using System;
using Foundation;


namespace FileCounter.Xamarin
{
	// @interface FileCounter : NSObject
	[BaseType(typeof(NSObject))]
	interface FileCounter
	{
		// +(void)lsof;
		[Static]
		[Export("lsof")]
		void Lsof();
	}
}
