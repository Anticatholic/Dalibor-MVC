using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dalibor_MVC.Models
{
    public class VzdelanieModel
    {
        public string ZakladnaSkola;
        public string StrednaSkola;
        public string PriemyselnaSkola;
        public KurzyModel ZoznamSkol;

        public VzdelanieModel()
        {
            ZoznamSkol = new KurzyModel();
        }
    }
}