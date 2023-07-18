﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина поля не менее 5 символов")]
        public string name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длина поля не менее 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина поля не менее 5 символов")]
        public string addres { get; set; }

        [Display(Name = "Введите номер телефона")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина поля не менее 5 символов")]
        public string phone { get; set; }

        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина поля не менее 5 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
