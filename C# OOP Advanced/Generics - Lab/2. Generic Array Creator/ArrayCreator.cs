namespace _2.Generic_Array_Creator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            return new T[length];
        }
    }
}
