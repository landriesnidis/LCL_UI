using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landriesnidis.LCL_Controls.Components.Broadcast
{
    [DefaultEvent("OnBroadcast")]
    public partial class BroadcastReceiver : Component
    {
        public delegate void BroadcastReceiveEventHandler(object data, string tag);
        public event BroadcastReceiveEventHandler ReceiveBroadcast;

        public BroadcastReceiver()
        {
            InitializeComponent();
            BroadcastManager.AddReceiver(this);
        }

        public BroadcastReceiver(IContainer container) : this()
        {
            container.Add(this);
        }

        ~BroadcastReceiver()
        {
            BroadcastManager.RemoveReceiver(this);
        }

        public void OnBroadcast(object data, string tag)
        {
            ReceiveBroadcast?.Invoke(data, tag);
        }
    }
}
