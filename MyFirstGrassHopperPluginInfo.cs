using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace MyFirstGrassHopperPlugin
{
    public class MyFirstGrassHopperPluginInfo : GH_AssemblyInfo
    {
        public override string Name => "MyFirstGrassHopperPlugin";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("5A905CD6-DF26-4036-BDB3-A9A7BC2EFE38");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}