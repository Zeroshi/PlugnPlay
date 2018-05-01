using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace x_Platform.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();
			LoadApplication (new x_Platform.App ());

			return base.FinishedLaunching (app, options);
		}
	}
//	public class MachMemoryHelper
  //      {

            // task_info.h
    //        struct task_basic_info
      //      {
        //        public /* integer_t */ int suspend_count;
          //      public /* vm_size_t */ int virtual_size;
            //    public /* vm_size_t */ int resident_size;
 //               public /* time_value_t */ long user_time;
   //             public /* time_value_t */ long system_time;
     //           public /* policy_t */ int policy;
       //     }

         //   [System.Runtime.InteropServices.DllImport("/usr/lib/libSystem.dylib")]
           // extern static /* kern_return_t */ int task_info(
             //   /* task_name_t -> mach_port_t */ IntPtr target_task,
               /// /* task_flavor_t -> natural_t */ int flavor,
 //               /* task_info_t -> integer_t* */ ref task_basic_info task_info_out,
   //             /* mach_msg_type_number_t* -> natural_t* */ ref int task_info_outCnt);

//            const int KERN_SUCCESS = 0;
  //          const int TASK_BASIC_INFO = 4;

    //        static IntPtr self;
  //          static task_basic_info tbi = new task_basic_info();
//            static int size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(task_basic_info));

//            static MachMemoryHelper()
            //{
          //      var handle = ObjCRuntime.Dlfcn.dlopen("/usr/lib/libSystem.dylib", 0);
        //        self = ObjCRuntime.Dlfcn.GetIntPtr(handle, "mach_task_self_");
      //          ObjCRuntime.Dlfcn.dlclose(handle);
    //        }

  //          static public int GetResidentSize()
//            {
         //       var err = task_info(self, TASK_BASIC_INFO, ref tbi, ref size);
       //         return (err == KERN_SUCCESS) ? tbi.resident_size : -1;
     //       }
   //     }

       // [Export("getMemoryUsageBackdoor")]
       // public string GetMemoryUsageBackdoor()
     //   {
          //  var managed = GC.GetTotalMemory(true) / 1000000;
        //    var unmanaged = MachMemoryHelper.GetResidentSize() / 1000000;

      //      return $"{managed},{unmanaged}";
    //    }

    }
}
