﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace Concat_Addin
{
    public static class Ionito
    {

        public static void GetIonito(Excel.Range firstRange, Excel.Range secondRange, out object[,] ionito )
        {

            object[,] ret= new object[3, 3];

            ionito = ret;


        }


    }
}