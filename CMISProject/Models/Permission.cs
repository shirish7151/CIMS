﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace CMISProject.Models
{
    public class Permission
    {
        [Required]
        [ScaffoldColumn(false)]
        public int PermissionId { get; set; }

        public string Perm { get; set; }
    }
}