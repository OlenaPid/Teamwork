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
    
    public partial class User
    {
        public User()
        {
            this.Article = new HashSet<Article>();
            this.ChoosedCategory = new HashSet<ChoosedCategory>();
            this.Order = new HashSet<Order>();
            this.Product = new HashSet<Product>();
            this.ProductToBuy = new HashSet<ProductToBuy>();
            this.ReservedProduct = new HashSet<ReservedProduct>();
            this.ShowedProduct = new HashSet<ShowedProduct>();
        }

        [HiddenInput(DisplayValue = false)]
        public int userID { get; set; }

        [HiddenInput(DisplayValue = false)]
        [DisplayName("������")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        public string password { get; set; }

        [DisplayName("������")]
        [Required(ErrorMessage = "������ ������")]
        public int userGroupID { get; set; }

        [DisplayName("����� ��������")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        public string companyName { get; set; }

        [DisplayName("�������� ������")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        public string juridicalAddress { get; set; }

        [DisplayName("������")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        public string address { get; set; }

        [DisplayName("����������� ����")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        public string contactPerson { get; set; }

        [DisplayName("������ � ����")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        public string post { get; set; }

        [DisplayName("����� ��������")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        public string phoneNumber { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "���� �� ���� ���� ������")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "���������� ������")]
        public string email { get; set; }

        [DisplayName("˳����� �� �������")]
        public bool merchantLicense { get; set; }

        [DisplayName("˳����� �� ������")]
        public bool tradeLicense { get; set; }

        [DisplayName("ϳ�����������")]
        public bool approved { get; set; }

        [HiddenInput(DisplayValue = false)]
        [DisplayName("������ ���������� ������")]
        public string passwordSalt { get; set; }
    
        public virtual ICollection<Article> Article { get; set; }
        public virtual ICollection<ChoosedCategory> ChoosedCategory { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductToBuy> ProductToBuy { get; set; }
        public virtual ICollection<ReservedProduct> ReservedProduct { get; set; }
        public virtual ICollection<ShowedProduct> ShowedProduct { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
