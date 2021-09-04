﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlixGoWebUI.Models.Entity
{
   
    public class BaseEntity
    {
       
        public int Id { get; set; }
        public DateTime? CreatedDate  { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? DeletedDate  { get; set; }    
        public int? DeletedByUserId   { get; set; }
    }
}
