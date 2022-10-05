

namespace OOPCompositionStringBuilder.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        //Crindo o vinculo a composição e já garantir que sera iniciada
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        //não podera passar o argumento para muitos no construtor boas praticas
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //QUando temos uma composição tem muitos é comum colocar as operações adicionar e remover
        public void AddComment (Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment (Comment comment)
        {
            Comments.Remove(comment);
        }
    }
}
