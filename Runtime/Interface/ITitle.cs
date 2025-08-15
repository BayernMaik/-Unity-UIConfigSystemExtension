namespace UI
{
    public interface ITitle
    {
        public string Title { get; set; }
        public string GetTitle();
        public void SetTitle(string title);
    }
}