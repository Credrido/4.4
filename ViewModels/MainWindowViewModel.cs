using System;
using System.Collections.Generic;

namespace _4._4.ViewModels;

public class MainWindowViewModel : ViewModelBase 
{
    public MainWindowViewModel()
    {
        string text1 = "Lorem ipsum dolor sit amet";
        string text2 = "Lorem ipsum dolor sit amet";
        string text3 = "Lorem ipsum dolor sit amet";
        string news1 = "Lorem ipsum dolor sit amet";
        string news2 = "Lorem ipsum dolor sit amet";
        string news3 = "Lorem ipsum dolor sit amet";
        BlogEntities =
        [
            new BlogEntity {Article = "Заголовок 1", Text = text1, Tags = ["Tag1, Tag2"], ImagePath="avalonia-logo.ico"},
            new BlogEntity {Article = "Заголовок 2", Text = text2, Tags= ["Tag3, Tag4"], ImagePath="avalonia-logo.ico"},
            new BlogEntity {Article = "Заголовок 3", Text = text3, Tags = ["Tag5, Tag6"], ImagePath="avalonia-logo.ico"}
        ];
        NewsEntities =
        [
            new NewsEntity { Text = news1, PublishDate = DateTime.Now.AddDays(-2)},
            new NewsEntity { Text = news2, PublishDate = DateTime.Now.AddDays(-7)},
            new NewsEntity { Text = news3, PublishDate = DateTime.Now}
        ];
    }
    public List<BlogEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }
}