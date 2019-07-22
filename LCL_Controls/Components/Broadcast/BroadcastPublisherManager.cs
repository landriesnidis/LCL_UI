using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landriesnidis.LCL_Controls.Components.Broadcast
{
    public class BroadcastManager
    {
        private static BroadcastManager manager = null;

        static BroadcastManager()
        {
            manager = new BroadcastManager();
        }

        public static BroadcastManager Instance { get { return manager; } }

        public Collection<BroadcastReceiver> BroadcastReceivers { get; } = new Collection<BroadcastReceiver>();

        /// <summary>
        /// 添加接收器
        /// </summary>
        /// <param name="receiver"></param>
        public static void AddReceiver(BroadcastReceiver receiver)
        {
            manager.BroadcastReceivers.Add(receiver);
        }

        /// <summary>
        /// 移除接收器
        /// </summary>
        /// <param name="receiver"></param>
        public static void RemoveReceiver(BroadcastReceiver receiver)
        {
            manager.BroadcastReceivers.Remove(receiver);
        }

        /// <summary>
        /// 数据广播
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="tag"></param>
        public static void Broadcast(object obj, string tag)
        {
            foreach (BroadcastReceiver receiver in manager.BroadcastReceivers)
            {
                if (receiver != null)
                {
                    receiver.OnBroadcast(obj, tag);
                }
            }
        }
    }
}
