﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Red_Lake_Hospital_Redesign_Team6.Models.ViewModels
{
    public class ShowEcard
    {
        public bool isadmin { get; set; }
        public EcardsDto ecard { get; set; }
        //information about the team the player plays for
        public DepartmentsDto departments { get; set; }
    }
}