﻿namespace CodePulse.API.Models.Domain
{
    public class BlogPost
    {
        #region Properties
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Content {  get; set; }
        public string FeaturedImageUrl {  get; set; }
        public string UrlHandle {  get; set; }
        public DateTime PublishDate {  get; set; }
        public string Author {  get; set; }
        public bool IsVisible {  get; set; }
        #endregion
    }
}
