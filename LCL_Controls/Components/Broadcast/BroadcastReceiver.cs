using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landriesnidis.LCL_Controls.Components.Broadcast
{
    [DefaultEvent("OnBroadcast")]
    [DefaultProperty("Topics")]
    public partial class BroadcastReceiver : Component
    {
        public delegate void BroadcastReceiveEventHandler(object data, string topic);
        public event BroadcastReceiveEventHandler ReceiveBroadcast;

        [Browsable(true)]
        [Description("监听器订阅的Topic列表")]
        public List<string> Topics = new List<string>(); 

        public BroadcastReceiver()
        {
            InitializeComponent();
            BroadcastManager.AddReceiver(this);
        }

        public BroadcastReceiver(IContainer container) : this()
        {
            container.Add(this);
        }

        public BroadcastReceiver(List<string> topics) : this()
        {
            Topics = topics;
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
