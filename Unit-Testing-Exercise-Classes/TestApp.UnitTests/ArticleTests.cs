using NUnit.Framework;

using System;


namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void Setup()
    {
        _article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        //Arrange

         string[] input = new string[]
        {
            "Article1 Content1 Autor1",
           "Article2 Content2 Autor2",
           "Article3 Content3 Author3"
        };


        // Act
        Article actual = _article.AddArticles(input);

        // Assert
        Assert.That(actual.ArticleList, Has.Count.EqualTo(3));
        Assert.That(actual.ArticleList[0].Title, Is.EqualTo("Article1"));
        Assert.That(actual.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(actual.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        _article.ArticleList.Add(new Article
        {
            Author = "Author1",
            Content = "Content1",
            Title = "Title2"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "Author2",
            Content = "Content2",
            Title = "Title3"
        });

        _article.ArticleList.Add(new Article
        {
            Author = "Author3",
            Content = "Content3",
            Title = "Title1"
        });
        string printCriteria = "title";
        string expected = $"Title1 - Content3: Author3" 
                             + Environment.NewLine +
                           "Title2 - Content1: Author1" 
                             + Environment.NewLine +
                           "Title3 - Content2: Author2";



        // Act
       string actual = _article.GetArticleList(_article, printCriteria);

        // Assert

        Assert.That(actual, Is.EqualTo(expected));

       
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        _article.ArticleList.Add(new Article
        {
            Author = "Author1",
            Content = "Content1",
            Title = "Title2"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "Author2",
            Content = "Content2",
            Title = "Title3"
        });

        _article.ArticleList.Add(new Article
        {
            Author = "Author3",
            Content = "Content3",
            Title = "Title1"
        });
        string printCriteria = "invalid";
       

        // Act
        string actual = _article.GetArticleList(_article, printCriteria);

        // Assert

        Assert.That(actual, Is.Empty);
    }
}
