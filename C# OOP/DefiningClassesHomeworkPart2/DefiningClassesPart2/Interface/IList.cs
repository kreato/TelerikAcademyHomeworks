namespace DefiningClassesPart2.Interface
{
    public interface IList<T>
    {
        void Add(T element);
        T AccessElement(int index);
        void Remove(int index);
        void InsertAt(T element, int index);
        void Clear();
        string FindIndexOfElement(T value);
    }
}
