using System;
using Android.App;
using Android.Content.Res;

namespace TaikPizza.Utility
{
    public class ScreenUtils
    {
        public int Size;
        public String toastMsg;

        public ScreenUtils(Resources resources)
        { 
            var screenSize = resources.Configuration.ScreenLayout & ScreenLayout.SizeMask;

            switch (screenSize)
            {
                case ScreenLayout.SizeLarge:
                    toastMsg = "Large screen";
                    Size = 2;
                    break;
                case ScreenLayout.SizeNormal:
                    toastMsg = "Normal screen";
                    Size = 1;
                    break;
                case ScreenLayout.SizeSmall:
                    toastMsg = "Small screen";
                    Size = 1;
                    break;
                //default:
                //    toastMsg = "Screen size is neither large, normal or small";
                //    Size = 2;
            }
        }
    }
}