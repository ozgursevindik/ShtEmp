using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTryCatch
{
    public class OzgurException: Exception
    {
        public List<OzgurException> AltHatalar { get; set; }

        public OzgurException()
        {
            AltHatalar = new List<OzgurException>();

        }
    }
}
