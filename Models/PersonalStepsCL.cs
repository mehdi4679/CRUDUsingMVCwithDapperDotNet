using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDUsingMVC.Models
{
    public class ClPersonalSteps
    {
        private int? _PSID;
        public int? PSID
        {
            get { return _PSID; }
            set { _PSID = value; }
        }

        private int? _PrivatOrPublic;
        public int? PrivatOrPublic
        {
            get { return _PrivatOrPublic; }
            set { _PrivatOrPublic = value; }
        }

        private int? _PersonalID;
        public int? PersonalID
        {
            get { return _PersonalID; }
            set { _PersonalID = value; }
        }

        private int? _PageNumber;
        public int? PageNumber
        {
            get { return _PageNumber; }
            set { _PageNumber = value; }
        }

        private int? _StepID;
        public int? StepID
        {
            get { return _StepID; }
            set { _StepID = value; }
        }
        private int? _SatatusID;
        public int? SatatusID
        {
            get { return _SatatusID; }
            set { _SatatusID = value; }
        }
        private String _StatusComment;
        public String StatusComment
        {
            get { return _StatusComment; }
            set { _StatusComment = value; }
        }
        private DateTime _Regdate;
        public DateTime Regdate
        {
            get { return _Regdate; }
            set { _Regdate = value; }
        }

        public string _Timee;
        public string Timee
        {
            get { return _Timee; }
            set { _Timee = value; }
        }

        public string _IneteViewLocation;
        public string IneteViewLocation
        {
            get { return _IneteViewLocation; }
            set { _IneteViewLocation = value; }
        }

    }

    public class PersonalStepslist
    {
     public    List<ClPersonalSteps> Rows { get; set; }
    } 

}