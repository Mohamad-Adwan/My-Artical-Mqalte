﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArticlProject.Core
{
   public class Author
    {
        [Required]
        [Display(Name ="المعرف")]
        public int Id { get; set; }
        [Required]
        [Display(Name = " معرف المستخدم")]

        public string UserId { get; set; }
        [Required]
        [Display(Name = "اسم المستخدم")]

        public string UserName { get; set; }
        [Required]
        [Display(Name = "الاسم الكامل")]

        public string FullName { get; set; }
        [Display(Name = "الصورة")]

        public string ProfileImgaeUrl { get; set; }
        [Display(Name = "السيرة الذاتيه")]

        public string Bio { get; set; }
        [Display(Name = "فيسبوك")]

        public string FaceBook { get; set; }
        [Display(Name = "انستقرام")]

        public string Instgram { get; set; }
        [Display(Name = "تويتر")]

        public string Twitter { get; set; }

        //Navigation
        public virtual List<AuthorPost> AuthorPosts { get; set; }

    }
}
