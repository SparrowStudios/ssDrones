using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparrowStudios.Fivem.ssDrones.Models
{
    public class _DroneControl
    {
        public IList<int> Codes { get; set; }
        public string Text { get; set; }
    }

    public class DroneControl
    {
        public string Label { get; set; }
        public int KeyIndex { get; set; }
        
        public DroneControl(string label, int keyIndex)
        {
            Label = label;
            KeyIndex = keyIndex;
        }
    }
}
