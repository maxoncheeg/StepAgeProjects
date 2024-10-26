﻿using System.Windows.Forms;

namespace LongDistanceService
{
    static class FormPlacer
    {
        public static void ToScreenCenter(Form form) =>
            form.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2 - form.Width / 2,
                                                     Screen.PrimaryScreen.Bounds.Height / 2 - form.Height / 2);
    }
}
