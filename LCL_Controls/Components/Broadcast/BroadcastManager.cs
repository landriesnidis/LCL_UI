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
        /// <param name="topic"></param>
        public static void Broadcast(object obj, string topic)
        {
            foreach (BroadcastReceiver receiver in manager.BroadcastReceivers)
            {
                if (receiver != null)
                {
                    // 没有设置Topic集合或Topic再集合中被注册了 则执行广播接收器的事件 
                    // 如果Topic的注册集合为空 则所有消息都会被广播到（兼容上一个无topic的版本）
                    if (receiver.Topics==null || receiver.Topics.Count==0 || receiver.Topics.Contains(topic))
                    {
                        receiver.OnBroadcast(obj, topic);
                    }
                }
            }
        }
    }
}
