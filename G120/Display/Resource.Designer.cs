//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Display
{
    
    internal partial class Resource
    {
        private static System.Resources.ResourceManager manager;
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((Resource.manager == null))
                {
                    Resource.manager = new System.Resources.ResourceManager("Display.Resource", typeof(Resource).Assembly);
                }
                return Resource.manager;
            }
        }
        internal static System.Drawing.Bitmap GetBitmap(Resource.BitmapResources id)
        {
            return ((System.Drawing.Bitmap)(ResourceManager.GetObject(((short)(id)))));
        }
        internal static System.Drawing.Font GetFont(Resource.FontResources id)
        {
            return ((System.Drawing.Font)(ResourceManager.GetObject(((short)(id)))));
        }
        [System.SerializableAttribute()]
        internal enum FontResources : short
        {
            NinaB = 18060,
        }
        [System.SerializableAttribute()]
        internal enum BitmapResources : short
        {
            GHI_Electronics_Logo = 27467,
        }
    }
}
