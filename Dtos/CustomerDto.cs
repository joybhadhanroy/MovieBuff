﻿using MovieBuff.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieBuff.Dtos
{
    public class CustomerDto
    {
        // fluent api for annotation
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}