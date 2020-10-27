using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAcademy.BikeShop.Host.Helpers
{
    public class BikeImageHelper
    {
        private static readonly string[] FileNames =
        {
            "cannondale_moterra_1_md_29_m.jpeg",
            "conway_ms_627.jpeg",
            "cannondale_slice_carbon_105.jpeg",
            "pinarello_nytro_ultegra_disc_h58.jpeg"
        };

        public static string GetRandomImage()
        {
            return FileNames[new Random().Next(0, FileNames.Length)];
        }
    }
}
