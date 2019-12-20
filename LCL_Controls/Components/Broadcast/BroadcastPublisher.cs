using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landriesnidis.LCL_Controls.Components.Broadcast
{
    public partial class BroadcastPublisher : Component
    {
        public BroadcastPublisher()
        {
            InitializeComponent();
        }

        public BroadcastPublisher(IContainer container) : this()
        {
            container.Add(this);
        }

        public void Publish(object data,string topic="")
        {
            BroadcastManager.Broadcast(data, topic);
        }
    }

    
}
