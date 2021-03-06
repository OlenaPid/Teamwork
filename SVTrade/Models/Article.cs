//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SVTrade.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        [HiddenInput(DisplayValue = false)]
        public int articleID { get; set; }

        [DisplayName("���������")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        public string title { get; set; }

        [DisplayName("User")]
        [Required(ErrorMessage = "������ �����������")]
        public int userID { get; set; }

        [DisplayName("��������")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        public string imageURL { get; set; }

        [DisplayName("����")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        [DataType(DataType.MultilineText)]
        public string description { get; set; }

        [DisplayName("����")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        [DataType(DataType.DateTime)]
        public System.DateTime date { get; set; }
    
        public virtual User User { get; set; }
    }
}
