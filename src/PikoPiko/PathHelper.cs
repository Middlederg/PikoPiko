using System.Drawing;
using System.IO;

namespace PikoPiko
{
    public static class PathHelper
    {
        public static Image GetImage(this IPath path)
        {
            var file = Properties.Resources.ResourceManager.GetObject(path.ImagePath) as byte[];
            using (var ms = new MemoryStream(file))
            {
                return new Bitmap(ms);
            }
        }

        public static Icon GetIcon(this IPath path)
        {
            var file = Properties.Resources.ResourceManager.GetObject(path.ImagePath) as byte[];
            using (var ms = new MemoryStream(file))
            {
                return new Icon(ms);
            }
        }
    }
}
