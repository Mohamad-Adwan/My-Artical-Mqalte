﻿using ArticlProject.Core;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace ArticlProject.CoreView
{
    public class AuthorPostView
    {
        [Required]
        [Display(Name = "المعرف")]
        public int Id { get; set; }
        
        [Display(Name = " معرف المستخدم")]

        public string UserId { get; set; }
        [Display(Name = "اسم المستخدم")]

        public string UserName { get; set; }

        
        [Display(Name = "الاسم الكامل")]
        public string FullName { get; set; }



        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الصنف")]
        [DataType(DataType.Text)]
        public string PostCategory { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "العنوان")]
        [DataType(DataType.Text)]

        public string PostTitle { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الوصف")]
        [DataType(DataType.MultilineText)]

        public string PostDescription { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الصورة")]
        [DataType(DataType.Upload)]

        public IFormFile PostImageUrl { get; set; }

        [Display(Name = "تاريخ الاضافة")]
        public DateTime AddedTime { get; set; }

        //Navigation Area
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int CatrgoryId { get; set; }
        public Category Category { get; set; }
    }
}
