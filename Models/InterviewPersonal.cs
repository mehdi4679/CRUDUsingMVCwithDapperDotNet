using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDUsingMVC.Models
{
    public class ClInterViewPersonal
    {
        private int? _InterViewPersonal;
        public int? InterViewPersonal
        {
            get { return _InterViewPersonal; }
            set { _InterViewPersonal = value; }
        }
        private int? _InterViewID;
        public int? InterViewID
        {
            get { return _InterViewID; }
            set { _InterViewID = value; }
        }
        private int? _PSID;
        public int? PSID
        {
            get { return _PSID; }
            set { _PSID = value; }
        }

        private int? _forPersonalId;
        public int? forPersonalId
        {
            get { return _forPersonalId; }
            set { _forPersonalId = value; }
        }


        private int? _PersonalID;
        public int? PersonalID
        {
            get { return _PersonalID; }
            set { _PersonalID = value; }
        }

    }

}