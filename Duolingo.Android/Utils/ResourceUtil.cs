using Android.Content;


namespace Duolingo.Droid.Utils
{
    class ResourceUtil
    {
        public static int GetDrawableIdByFileName(string fileName, Context context)
        {
            return context.Resources.GetIdentifier(fileName, "drawable", context.PackageName);
        }
    }
}