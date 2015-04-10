namespace SchoolClasses
{
    public interface IComment
    {
        string GetComments { get; }

        void AddComment(string input);
    }
}
