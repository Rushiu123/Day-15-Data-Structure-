namespace Day_15_Data_Structure
{
    internal class MyMapNodeBase<K>
    {


        public void Remove(K key)       //Creating remove method
        {
            var linkedList = GetArrayPositionAndLinkedList(key);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }


        public void Remove (K key)       //Creating remove method
        {
            var linkedList = GetArrayPositionAndLinkedList(key);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                    //linkedList.Remove(item);
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
                //Console.WriteLine("Removed successfully with key " + foundItem.Key);
            }
        }
    }
}