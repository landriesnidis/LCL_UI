using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Landriesnidis.LCL_Controls.Utils
{
    public class AeList<T> : List<T>
    {
        public delegate void ItemAddedEventHandler(AeList<T> list, ListItemsChangedEventArgs<T> e);
        public delegate void ItemRemovedEventHandler(AeList<T> list, ListItemsChangedEventArgs<T> e);
        public delegate void ItemInsertedEventHandler(AeList<T> list, ListItemsChangedEventArgs<T> e);
        public delegate void ItemsClearedEventHandler(AeList<T> list, EventArgs e);

        public event ItemAddedEventHandler ItemAddedEvent;
        public event ItemRemovedEventHandler ItemRemovedEvent;
        public event ItemInsertedEventHandler ItemInsertedEvent;
        public event ItemsClearedEventHandler ItemsClearedEvent;

        public new void Add(T item)
        {
            int index = Count;
            base.Add(item);
            ItemAddedEvent?.Invoke(this, new ListItemsChangedEventArgs<T>(item, index));
        }

        public new void AddRange(IEnumerable<T> collection)
        {
            int index = Count;
            base.AddRange(collection);
            foreach (T item in collection)
            {
                ItemAddedEvent?.Invoke(this, new ListItemsChangedEventArgs<T>(item, index++));
            }
        }

        public new void Clear()
        {
            base.Clear();
            ItemsClearedEvent?.Invoke(this, new EventArgs());
        }

        public new bool Remove(T item)
        {
            bool b = base.Remove(item);
            if (b)
            {
                ItemRemovedEvent?.Invoke(this, new ListItemsChangedEventArgs<T>(item, -1));
            }
            return b;
        }

        public new void RemoveAt(int index)
        {
            T item = this[index];
            base.RemoveAt(index);
            ItemRemovedEvent?.Invoke(this, new ListItemsChangedEventArgs<T>(item, index));
        }

        public new void Insert(int index, T item)
        {
            base.Insert(index, item);
            ItemInsertedEvent?.Invoke(this, new ListItemsChangedEventArgs<T>(item, index));
        }

        public new void InsertRange(int index, IEnumerable<T> collection)
        {
            base.InsertRange(index, collection);
            foreach (T item in collection)
            {
                ItemInsertedEvent?.Invoke(this, new ListItemsChangedEventArgs<T>(item, index++));
            }
        }
    }

    public class ListItemsChangedEventArgs<T> : EventArgs
    {
        public T Item { get; set; }
        public int Position { get; set; }

        public ListItemsChangedEventArgs(T item, int position)
        {
            Item = item;
            Position = position;
        }
    }
}
