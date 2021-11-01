namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack<T> // this is a generic type parameter
    {
        private readonly T[] _items;
        private int _currentIndex = -1;

        public SimpleStack() => _items = new T[10];

        public int Count => _currentIndex + 1;

        public void Push(T item) => _items[++_currentIndex] = item; // increments before statement

        public T Pop() => _items[_currentIndex--];
    }

}
