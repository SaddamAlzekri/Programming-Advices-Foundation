using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublisher
{
    public class NewArtice
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public NewArtice(string Title, string Content)
        {
            this.Title = Title;
            this.Content = Content;
        }
    }

    public class NewsPublisher
    {
        public event EventHandler<NewArtice> NewNewsPublished;

        public void PublishNews(string Title, string Content)
        {
            var Article = new NewArtice(Title, Content);
            OnNewNewsPublished(Article);
        }

        public virtual void OnNewNewsPublished(NewArtice Article)
        {
            if (NewNewsPublished != null)
            {
                NewNewsPublished.Invoke(this, Article);
            }
        }
    }

    public class NewsSubscriber
    {
        public string Name { get; set; }

        public NewsSubscriber(string Name)
        {
            this.Name = Name;
        }

        public void Subcribe(NewsPublisher Publisher)
        {
            Publisher.NewNewsPublished += HandleNewNews;
        }

        public void UnSubcribe(NewsPublisher Publisher)
        {
            Publisher.NewNewsPublished -= HandleNewNews;
        }

        public virtual void HandleNewNews(object sender, NewArtice Artice)
        {
            Console.WriteLine("\nName : " + Name);
            Console.WriteLine("Title : " + Artice.Title);
            Console.WriteLine("Content : " +  Artice.Content);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NewsPublisher Publisher = new NewsPublisher();

            NewsSubscriber Subscriber1 = new NewsSubscriber("Subscribe1");
            Subscriber1.Subcribe(Publisher);

            NewsSubscriber Subscriber2 = new NewsSubscriber("Subscribe2");
            Subscriber2.Subcribe(Publisher);


            Publisher.PublishNews("The Ware Of YEMEN", "The Ware Of YEMEN is Frightened. And it is not good.");
            Subscriber1.UnSubcribe(Publisher);
            Publisher.PublishNews("The Rain", "The is from My God. by water grow all types Of planets");
            Console.ReadKey();
        }
    }
}
