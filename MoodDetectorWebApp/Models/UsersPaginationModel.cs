﻿using Model.Entity;
using System.Collections.Generic;

namespace MoodDetectorWebApp.Models
{
    public class UsersPaginationModel
    {
        public int? UsersCount { get; set; }
        public int UsersPerPage { get; set; } = 10;
        public int CurrentPage { get; set; } = 1;
        public List<UserListItem> UserListItems { get; set; }
        public bool NextPage => CurrentPage * UsersPerPage < UsersCount;
        public bool PreviousPage => CurrentPage != 1;
    }
}
