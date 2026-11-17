using System;
using System.Collections.Generic;

public class NewsArticle
{
    public string PublisherName { get; }
    public string Title { get; }
    public string Content { get; }


    public NewsArticle(string PublisherName ,string Title, string Content)
    {
        this.Title = Title;
        this.Content = Content;
        this.PublisherName = PublisherName;
    }
}
public class NewsPublisher
{
    public event EventHandler<NewsArticle> NewNewsPublished;

    public void PublishNews(string PublisherName, string Title, string Content)
    {
        var Article = new NewsArticle(PublisherName,Title, Content);

        OnNewNewsPublished(Article);
    }

    protected virtual void OnNewNewsPublished(NewsArticle Article)
    {
        NewNewsPublished?.Invoke(this, Article); // Tell any Describer  ?. == if Event not null
    }

}
public class NewsSubscriber
{
    public string Name { get; }

    public NewsSubscriber(string name)
    {
        Name = name;
    }

    public void Subscribe(NewsPublisher publisher)
    {
        publisher.NewNewsPublished += HandleNewNews;
    }


    public void UnSubscribe(NewsPublisher publisher)
    {
        publisher.NewNewsPublished -= HandleNewNews;
    }

    public void HandleNewNews(object sender, NewsArticle article)
    {
        Console.WriteLine($"{Name} received a new news article:");
        Console.WriteLine($"Publisher Name: {article.PublisherName}");
        Console.WriteLine($"Title: {article.Title}");
        Console.WriteLine($"Content: {article.Content}");
        Console.WriteLine();
    }
}
public class Program
{
    static void Main()
    {
        NewsPublisher publisher = new NewsPublisher();
        NewsSubscriber subscriber1 = new NewsSubscriber("Subscriber 1");
        subscriber1.Subscribe(publisher);
        NewsSubscriber subscriber2 = new NewsSubscriber("Subscriber 2");
        subscriber2.Subscribe(publisher);


        NewsPublisher Aloula = new NewsPublisher();
        NewsSubscriber Marocino = new NewsSubscriber("3alal l9adous");
        Marocino.Subscribe(Aloula);
        Marocino.Subscribe(publisher);

        publisher.PublishNews("Publisher" , "Breaking News", "A significant event just happened!");
        publisher.PublishNews("Publisher" ,"Tech Update", "New gadgets are hitting the market.");



        // Unsubscribe a subscriber (e.g., subscriber1) subscriber1 Unsubscribe publisher
        subscriber1.UnSubscribe(publisher);

        // this News Showed from subscriber2 Only
        publisher.PublishNews("Publisher", "Weather Forecast", "Expect sunny weather for the weekend.");

        // Unsubscribe another subscriber (e.g., subscriber2)
        subscriber2.UnSubscribe(publisher);
        Marocino.UnSubscribe(publisher);

        // This Publisher No One can See it , cause there is No Subcribers.
        publisher.PublishNews("Publisher", "Final Edition", "Last news update for today.");

        Aloula.PublishNews("Aloula1", "Duplicate News", "Nothing Happening!");


        Console.ReadLine();

    }
}
