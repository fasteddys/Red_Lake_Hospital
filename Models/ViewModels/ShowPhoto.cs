﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Red_Lake_Hospital_Redesign_Team6.Models.ViewModels
{
    public class ShowPhoto
    {
        //Conditionally render the page depending on if the admin is logged in.
        public bool isadmin { get; set; }
        public PhotoDto photo { get; set; }
        //information about the team the player plays for
        public DepartmentsDto departments { get; set; }
    }
}