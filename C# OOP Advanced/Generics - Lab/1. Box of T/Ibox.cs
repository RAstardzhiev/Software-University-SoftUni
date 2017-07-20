namespace _1.Box_of_T
{
    public interface Ibox<T>
    {
        int Count { get; }

        void Add(T element);

        T Remove();
    }
}
