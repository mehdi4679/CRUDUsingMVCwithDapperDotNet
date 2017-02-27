using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDUsingMVC.Models
{
    public class ClInterView
    {
        private int? _InterViewID;
        public int? InterViewID
        {
            get { return _InterViewID; }
            set { _InterViewID = value; }
        }

        private int? _StepID;
        public int? StepID
        {
            get { return _StepID; }
            set { _StepID = value; }
        }

        private string _InterViewDate;
        public string InterViewDate
        {
            get { return _InterViewDate; }
            set { _InterViewDate = value; }
        }



        private string _InterviewerPersonal;
        public string InterviewerPersonal
        {
            get { return _InterviewerPersonal; }
            set { _InterviewerPersonal = value; }
        }

        private String _Personality;
        public String Personality
        {
            get { return _Personality; }
            set { _Personality = value; }
        }
        private String _FavorateJobs;
        public String FavorateJobs
        {
            get { return _FavorateJobs; }
            set { _FavorateJobs = value; }
        }
        private String _PhisicalFeautures;
        public String PhisicalFeautures
        {
            get { return _PhisicalFeautures; }
            set { _PhisicalFeautures = value; }
        }
        private String _Dicipline;
        public String Dicipline
        {
            get { return _Dicipline; }
            set { _Dicipline = value; }
        }
        private String _comminicatinSkill;
        public String comminicatinSkill
        {
            get { return _comminicatinSkill; }
            set { _comminicatinSkill = value; }
        }
        private String _BodyLanguage;
        public String BodyLanguage
        {
            get { return _BodyLanguage; }
            set { _BodyLanguage = value; }
        }
        private String _rohiat;
        public String rohiat
        {
            get { return _rohiat; }
            set { _rohiat = value; }
        }
        private String _SujjestedJobs;
        public String SujjestedJobs
        {
            get { return _SujjestedJobs; }
            set { _SujjestedJobs = value; }
        }

        private String _PSID;
        public String PSID
        {
            get { return _PSID; }
            set { _PSID = value; }
        }

        private String _RequiredCource;
        public String RequiredCource
        {
            get { return _RequiredCource; }
            set { _RequiredCource = value; }
        }
        private String _Remark;
        public String Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
        private String _RemarkDocs;
        public String RemarkDocs
        {
            get { return _RemarkDocs; }
            set { _RemarkDocs = value; }
        }

    }

}