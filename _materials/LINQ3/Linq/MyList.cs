namespace Linq
{
    class MyList<T>
    {
        private T[] myArray;

        public MyList()
        {
            myArray = new T[0];
        }

        public void Add(T item)
        {
            var newArray = new T[myArray.Length + 1];

            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }

            newArray[myArray.Length] = item;
            myArray = newArray;
        }

        void RemoveLast()
        {
            // ...
        }

        private int Count
        {
            get { return myArray.Length; }
        }
    }
}