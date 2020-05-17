﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WhiteMvvm.Bases;

namespace Signbook.Transitions
{
    public class NewsApi : BaseTransitional
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Img")]
        public string Img { get; set; }

        [JsonProperty("NewsFile")]
        public string NewsFile { get; set; }


        [JsonProperty("Date")]
        public string Date { get; set; }
        [JsonProperty("VideoUrl")]

        public string Url { get; set; }
        public override TRealmObject ToModel<TRealmObject>()
        {
            string DefaultImg = "https://storage.googleapis.com/signboo/news/newsimages/defimage.png";
            if (this.Img != null)
            {
                DefaultImg = this.Img;
            }
            var mainNews = new Models.News
            {
                Title = this.Title,
                Date = this.Date,
                Url = this.Url,
                Img = DefaultImg,
                NewsFile = this.NewsFile,
            };
            return mainNews as TRealmObject;
        }
    }

    public class LoginModule : BaseTransitional
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int DisabilityType { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int Status { get; set; }
        public string Email { get; set; }
    }

    
}