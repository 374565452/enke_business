using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTUGateWay
{
    public class ValueEventArgs : EventArgs
    {
        public int Value { get; set; }
    }

    public delegate void ValueChangedEventHandler(object sender,ValueEventArgs e);

    public class DownloadDataWorker
    {
        public event ValueChangedEventHandler valueChanged;

        public void onValueChanged(ValueEventArgs e)
        {
            if (valueChanged != null)
            {
                valueChanged(this, e);
            }
        }
    }
}
