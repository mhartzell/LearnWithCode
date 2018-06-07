namespace PMasta.LearnWithCode.DataStructures
{
    internal class LinkedNode<T>
    {
        public LinkedNode(T value)
        {
            this.Value = value;
        }

        public LinkedNode<T> NextNode { get; set; }

        public LinkedNode<T> PreviousNode { get; set; }

        public T Value { get; set; }
    }
}
