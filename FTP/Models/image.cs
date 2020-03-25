﻿using System;
using System.Collections.Generic;
using FTP.Models;

namespace FTP.Models
{
    public class image
    {

        public readonly Student Student = new Student { StudentId = "200429757", FirstName = "Aditya", LastName = "Pidikiti" };


        public class Locations
        {
            public readonly static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            public readonly static string ExePath = Environment.CurrentDirectory;


            public readonly static string ContentPath = $"{ExePath}//..//..//..//Content";
            public readonly static string DataFolder = $"{ContentPath}//Data";
            public readonly static string imageFolder = $"{ContentPath}//Image";

            public const string InfoFile = "info.csv";
            public const string ImageFile = "myimage.jpg";


        }
        public class FTP
        {
            public const string UserName = @"bdat100119f\bdat1001";
            public const string Password = "bdat1001";

            public const string BaseUrl = "ftp://waws-prod-dm1-127.ftp.azurewebsites.windows.net/bdat1001-20914";


        }
    }
}